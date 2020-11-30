using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MJ_AlgorytmSortowania_16
{
	public partial class AnalizatorAlgorytmów : Form
	{
		const int Margines = 20;
		//deklaracje zmiennych domyślnych

		int PróbaBadawcza = 100;
		int MaxRozmiarTabl = 50;

		double DolnaGranicaWart = 20.0;
		double GornaGranicaWart = 300000.0;

		//deklaracja tablic

		double[] Tablica; // tablica do sortowania

		float[] WynikiZpomiaru;
		float[] WynikiAnalityczne;
		int[] TablicaLOD; // LOD Licznik Operacje Dominujące


		public AnalizatorAlgorytmów()
		{
			InitializeComponent();
		}

		private void AnalizatorAlgorytmów_Load(object sender, EventArgs e)
		{
			InitializeComponent();

			this.Left = Screen.PrimaryScreen.Bounds.Left + Margines;
			this.Top = Screen.PrimaryScreen.Bounds.Top + Margines;

			this.Width = (int)(Screen.PrimaryScreen.Bounds.Width * 0.75F);
			this.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.8F);
			this.StartPosition = FormStartPosition.Manual;

			this.AutoScroll = true;

			mj_tb_MinProb.Text = PróbaBadawcza.ToString();
			mj_tb_MaksRozmTab.Text = MaxRozmiarTabl.ToString();
			mj_tb_DolnaGranica.Text = DolnaGranicaWart.ToString();
			mj_tb_GornaGranica.Text = GornaGranicaWart.ToString();

			//mj_cmb_AlgorytmySort.SelectedIndex = 0;
		}

		private void mj_btn_AkceptDanych_Click(object sender, EventArgs e)
		{
			// utwworzenie egzemplarza tablic
			Tablica = new double[MaxRozmiarTabl];
			WynikiZpomiaru = new float[MaxRozmiarTabl];
			WynikiAnalityczne = new float[MaxRozmiarTabl];
			TablicaLOD = new int[PróbaBadawcza];

			//aktywacja zablokowanych przycisków

			mj_btn_TabPrez.Enabled = true;
			mj_btn_GrafiPrez.Enabled = true;
			mj_btn_Reset.Enabled = true;

			//dezaktywacja przycisku akceptuj

			mj_btn_AkceptDanych.Enabled = false;
		}

		private void mj_btn_WizualTablPoSort_Click(object sender, EventArgs e)
		{
			// deklaracje lokalne 

			int LicznikOD; // OD : Operacje Dpminujące 
			float SumaOD, ŚredniaOD;
			Random Rnd = new Random();

			Sortowanie AlgorytmSortowania = new Sortowanie();

			// powtarzenie eksperymentu dla każdego rozmiaru sortowanej tablicy 
			for (int l = 0; l < MaxRozmiarTabl; l++)
			{
				// powtarzanie eksperymentu z sortowania i zliczeanie LOD
				for (int k = 0; k < PróbaBadawcza; k++)
				{
					//wylosowanie wartosci elementów tablicy
					for (int i = 0; i < MaxRozmiarTabl; i++)
					{
						Tablica[i] = Rnd.NextDouble() * (GornaGranicaWart - DolnaGranicaWart) - DolnaGranicaWart;
					}//for-i

					// wywołane wybranej metody sortowania 
					switch (mj_cmb_AlgorytmySort.SelectedIndex)
					{
						case 0:
							LicznikOD = AlgorytmSortowania.SelecSort(ref Tablica, l);
							break;
						// inny case dla innego algorytmu 
						default:

							mj_erp.SetError(mj_btn_TabPrez, "UWAGA: jeszcze pracuje nad tym algorytmem");

							return;// przerwanie obłsugi
					}//do switch1

					// "zapamiętanie" licznika operacji dominujacych dla k-tego badania

					TablicaLOD[k] = LicznikOD;

				}//do for-k (int k = 0; k < PróbaBadawcza; k ++)

				//zsumowanie wykonanych Operacji Dominujacych dla wszytkich powtórzeń 
				SumaOD = 0.0F;
				for (int j = 0; j < PróbaBadawcza; j++)
				{
					SumaOD = SumaOD + TablicaLOD[j];
					// obliczenie średniej arytmetycznej 
					ŚredniaOD = SumaOD / PróbaBadawcza;
					// zapisanie średniej liczby wykonanych operacji dominujących w tablicy WynikZPomiaru

					WynikiZpomiaru[l] = ŚredniaOD;
				}

				switch (mj_cmb_AlgorytmySort.SelectedIndex)
				{
					case 0:
						WynikiAnalityczne[l] = (l * (l - 1)) / 2;
						break;
					// inne case 
					default:
						mj_erp.SetError(mj_btn_TabPrez, "UWAGA: jeszcze pracuje nad tym algorytmem");
						return; // przerwanie dalszej obsługi 
				}

			} //do  for-l (int l = 0; l < MaxRozmiarTabl; l++)

			/*wizualizacja tab wyników analizy złożonosci obliczeniowawej wybranego algorytmu */

			mj_dgvElementyTablicy.Location = new Point(400, 250);
			mj_dgvElementyTablicy.Width = (int)(this.Width * 0.55F);
			mj_dgvElementyTablicy.Height = (int)(this.Height * 0.5F);

			// wypisanie wynikow badadnia eksperymentalnego do kontrolki DataGridView
			for (int i = 0; i < MaxRozmiarTabl; i++)
			{
				mj_dgvElementyTablicy.Rows.Add();
				// wypisanie wynikow.
				mj_dgvElementyTablicy.Rows[i].Cells[0].Value = i;
				mj_dgvElementyTablicy.Rows[i].Cells[1].Value = String.Format("{0, 8:F3}", Tablica[i]);


				//ustawienie koloru tła dla zwięrzenia czytelnosci wyników
				if (i % 2 == 0)
				{
					mj_dgvElementyTablicy.Rows[i].Cells[0].Style.BackColor = Color.LightGray;
					mj_dgvElementyTablicy.Rows[i].Cells[1].Style.BackColor = Color.LightGray;


				}
				else
				{
					mj_dgvElementyTablicy.Rows[i].Cells[0].Style.BackColor = Color.White;
					mj_dgvElementyTablicy.Rows[i].Cells[1].Style.BackColor = Color.White;


				}
				//wycentrowanie zapisów w kolumnach 
				mj_dgvElementyTablicy.Rows[i].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
				mj_dgvElementyTablicy.Rows[i].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

			}// do pętli for(int i = 0; i < MaxRozmiarTabl; i++)

			mj_dgvElementyTablicy.Visible = true;

			mj_btn_WizualTablPoSort.Enabled = true;

			mj_btn_TabPrez.Enabled = false;

		}

		private void mj_btn_TabPrez_Click(object sender, EventArgs e)
		{
			// deklaracje lokalne 

			int LicznikOD; // OD : Operacje Dpminujące 
			float SumaOD, ŚredniaOD;
			Random Rnd = new Random();

			Sortowanie AlgorytmSortowania = new Sortowanie();

			// powtarzenie eksperymentu dla każdego rozmiaru sortowanej tablicy 
			for (int l = 0; l < MaxRozmiarTabl; l++)
			{
				// powtarzanie eksperymentu z sortowania i zliczeanie LOD
				for (int k = 0; k < PróbaBadawcza; k++)
				{
					//wylosowanie wartosci elementów tablicy
					for (int i = 0; i < MaxRozmiarTabl; i++)
					{
						Tablica[i] = Rnd.NextDouble() * (GornaGranicaWart - DolnaGranicaWart) - DolnaGranicaWart;
					}//for-i

					// wywołane wybranej metody sortowania 
					switch (mj_cmb_AlgorytmySort.SelectedIndex)
					{
						case 0:
							LicznikOD = AlgorytmSortowania.SelecSort(ref Tablica, l);
							break;
						// inny case dla innego algorytmu 
						default:

							mj_erp.SetError(mj_btn_TabPrez, "UWAGA: jeszcze pracuje nad tym algorytmem");

							return;// przerwanie obłsugi
					}//do switch1

					// "zapamiętanie" licznika operacji dominujacych dla k-tego badania

					TablicaLOD[k] = LicznikOD;

				}//do for-k (int k = 0; k < PróbaBadawcza; k ++)

				//zsumowanie wykonanych Operacji Dominujacych dla wszytkich powtórzeń 
				SumaOD = 0.0F;
				for (int j = 0; j < PróbaBadawcza; j++)
				{
					SumaOD = SumaOD + TablicaLOD[j];
					// obliczenie średniej arytmetycznej 
					ŚredniaOD = SumaOD / PróbaBadawcza;
					// zapisanie średniej liczby wykonanych operacji dominujących w tablicy WynikZPomiaru

					WynikiZpomiaru[l] = ŚredniaOD;
				}

				switch (mj_cmb_AlgorytmySort.SelectedIndex)
				{
					case 0:
						WynikiAnalityczne[l] = (l * (l - 1)) / 2;
						break;
					// inne case 
					default:
						mj_erp.SetError(mj_btn_TabPrez, "UWAGA: jeszcze pracuje nad tym algorytmem");
						return; // przerwanie dalszej obsługi 
				}

			} //do  for-l (int l = 0; l < MaxRozmiarTabl; l++)

			/*wizualizacja tab wyników analizy złożonosci obliczeniowawej wybranego algorytmu */

			mj_dgvTabelaWynikow.Location = new Point(400, 250);
			mj_dgvTabelaWynikow.Width = (int)(this.Width * 0.55F);
			mj_dgvTabelaWynikow.Height = (int)(this.Height * 0.5F);

			// wypisanie wynikow badadnia eksperymentalnego do kontrolki DataGridView
			for (int i = 0; i < MaxRozmiarTabl; i++)
			{
				mj_dgvTabelaWynikow.Rows.Add();
				// wypisanie wynikow.
				mj_dgvTabelaWynikow.Rows[i].Cells[0].Value = i;
				mj_dgvTabelaWynikow.Rows[i].Cells[1].Value = String.Format("{0:F2}", WynikiZpomiaru[i]);
				mj_dgvTabelaWynikow.Rows[i].Cells[2].Value = String.Format("{0:F2}", WynikiAnalityczne[i]);
				// koszt pamięciowy
				mj_dgvTabelaWynikow.Rows[i].Cells[3].Value = i;

				//ustawienie koloru tła dla zwięrzenia czytelnosci wyników
				if (i % 2 == 0)
				{
					mj_dgvTabelaWynikow.Rows[i].Cells[0].Style.BackColor = Color.LightGray;
					mj_dgvTabelaWynikow.Rows[i].Cells[1].Style.BackColor = Color.LightGray;
					mj_dgvTabelaWynikow.Rows[i].Cells[2].Style.BackColor = Color.LightGray;
					mj_dgvTabelaWynikow.Rows[i].Cells[3].Style.BackColor = Color.LightGray;

				}
				else
				{
					mj_dgvTabelaWynikow.Rows[i].Cells[0].Style.BackColor = Color.White;
					mj_dgvTabelaWynikow.Rows[i].Cells[1].Style.BackColor = Color.White;
					mj_dgvTabelaWynikow.Rows[i].Cells[2].Style.BackColor = Color.White;
					mj_dgvTabelaWynikow.Rows[i].Cells[3].Style.BackColor = Color.White;

				}
				//wycentrowanie zapisów w kolumnach 
				mj_dgvTabelaWynikow.Rows[i].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
				mj_dgvTabelaWynikow.Rows[i].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
				mj_dgvTabelaWynikow.Rows[i].Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
				mj_dgvTabelaWynikow.Rows[i].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
			}// do pętli for(int i = 0; i < MaxRozmiarTabl; i++)

			mj_dgvTabelaWynikow.Visible = true;

			mj_btn_WizualTablPoSort.Enabled = true;

			mj_btn_TabPrez.Enabled = false;
		}

		private void mj_btn_GrafiPrez_Click(object sender, EventArgs e)
		{
			mj_dgvTabelaWynikow.Visible = false;
			mj_dgvElementyTablicy.Visible = false;

			// odsłonięcie kontrolki chart

			mj_chart.Visible = true;

			mj_chart.Titles.Add("Algorytm" + mj_cmb_AlgorytmySort.SelectedItem);

			// zwymiarowanie

			mj_chart.Location = new Point(200, 140);
			mj_chart.Width = (int)(this.Width * 0.55);
			mj_chart.Height = (int)(this.Height * 0.55);
			mj_chart.BackColor = Color.Black; // ustawić na wybór !!!
			mj_chart.Legends["Legend1"].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;

			// wektor pomocniczy
			int[] RozmiarTabeli = new int[MaxRozmiarTabl];
			for (int i = 0; i < MaxRozmiarTabl; i++)
			{
				RozmiarTabeli[i] = i;

				// wykreslenie pomiaru
				mj_chart.Series[0].Name = "Koszt czasowy z pomiaru";

				//ustalenie atrybutów dla kreślonego wykresu funkcji, której dane reprezetuje seria[0]

				mj_chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
				mj_chart.Series[0].Color = Color.Black;
				mj_chart.Series[0].BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
				mj_chart.Series[0].BorderWidth = 1;
				mj_chart.Series[0].Points.DataBindY(RozmiarTabeli, WynikiZpomiaru);
			}

		}
	}
}
