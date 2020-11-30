namespace MJ_AlgorytmSortowania_16
{
	partial class AnalizatorAlgorytmów
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.mj_cmb_AlgorytmySort = new System.Windows.Forms.ComboBox();
			this.mj_tb_MaksRozmTab = new System.Windows.Forms.TextBox();
			this.mj_tb_DolnaGranica = new System.Windows.Forms.TextBox();
			this.mj_tb_GornaGranica = new System.Windows.Forms.TextBox();
			this.mj_tb_MinProb = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.mj_lbl3 = new System.Windows.Forms.Label();
			this.mj_lbl2 = new System.Windows.Forms.Label();
			this.mj_lbl1 = new System.Windows.Forms.Label();
			this.mj_btn_GrafiPrez = new System.Windows.Forms.Button();
			this.mj_btn_Reset = new System.Windows.Forms.Button();
			this.mj_btn_demo = new System.Windows.Forms.Button();
			this.mj_btn_AkceptDanych = new System.Windows.Forms.Button();
			this.mj_btn_WizualTablPoSort = new System.Windows.Forms.Button();
			this.mj_btn_TabPrez = new System.Windows.Forms.Button();
			this.mj_menu = new System.Windows.Forms.MenuStrip();
			this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kolorLiniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kolorTłaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.styllLiniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mj_dgvTabelaWynikow = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mj_dgvElementyTablicy = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mj_erp = new System.Windows.Forms.ErrorProvider(this.components);
			this.mj_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.mj_menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mj_dgvTabelaWynikow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mj_dgvElementyTablicy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mj_erp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mj_chart)).BeginInit();
			this.SuspendLayout();
			// 
			// mj_cmb_AlgorytmySort
			// 
			this.mj_cmb_AlgorytmySort.FormattingEnabled = true;
			this.mj_cmb_AlgorytmySort.Items.AddRange(new object[] {
            "SelectSort"});
			this.mj_cmb_AlgorytmySort.Location = new System.Drawing.Point(12, 66);
			this.mj_cmb_AlgorytmySort.Name = "mj_cmb_AlgorytmySort";
			this.mj_cmb_AlgorytmySort.Size = new System.Drawing.Size(121, 21);
			this.mj_cmb_AlgorytmySort.TabIndex = 32;
			this.mj_cmb_AlgorytmySort.Text = "Wybierz Algorytm";
			// 
			// mj_tb_MaksRozmTab
			// 
			this.mj_tb_MaksRozmTab.Location = new System.Drawing.Point(10, 213);
			this.mj_tb_MaksRozmTab.Name = "mj_tb_MaksRozmTab";
			this.mj_tb_MaksRozmTab.Size = new System.Drawing.Size(100, 20);
			this.mj_tb_MaksRozmTab.TabIndex = 31;
			// 
			// mj_tb_DolnaGranica
			// 
			this.mj_tb_DolnaGranica.Location = new System.Drawing.Point(10, 279);
			this.mj_tb_DolnaGranica.Name = "mj_tb_DolnaGranica";
			this.mj_tb_DolnaGranica.Size = new System.Drawing.Size(100, 20);
			this.mj_tb_DolnaGranica.TabIndex = 30;
			// 
			// mj_tb_GornaGranica
			// 
			this.mj_tb_GornaGranica.Location = new System.Drawing.Point(12, 364);
			this.mj_tb_GornaGranica.Name = "mj_tb_GornaGranica";
			this.mj_tb_GornaGranica.Size = new System.Drawing.Size(100, 20);
			this.mj_tb_GornaGranica.TabIndex = 29;
			// 
			// mj_tb_MinProb
			// 
			this.mj_tb_MinProb.Location = new System.Drawing.Point(12, 150);
			this.mj_tb_MinProb.Name = "mj_tb_MinProb";
			this.mj_tb_MinProb.Size = new System.Drawing.Size(100, 20);
			this.mj_tb_MinProb.TabIndex = 28;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 315);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(173, 26);
			this.label1.TabIndex = 27;
			this.label1.Text = "Górna granica wartości elementów \r\nsortowanych tablic";
			// 
			// mj_lbl3
			// 
			this.mj_lbl3.AutoSize = true;
			this.mj_lbl3.Location = new System.Drawing.Point(9, 250);
			this.mj_lbl3.Name = "mj_lbl3";
			this.mj_lbl3.Size = new System.Drawing.Size(149, 26);
			this.mj_lbl3.TabIndex = 26;
			this.mj_lbl3.Text = "Dolna granica wartości \r\nelementów sortowanych tablic";
			// 
			// mj_lbl2
			// 
			this.mj_lbl2.AutoSize = true;
			this.mj_lbl2.Location = new System.Drawing.Point(11, 184);
			this.mj_lbl2.Name = "mj_lbl2";
			this.mj_lbl2.Size = new System.Drawing.Size(101, 26);
			this.mj_lbl2.TabIndex = 25;
			this.mj_lbl2.Text = "Maksymalny rozmiar\r\nsortowanych tablic";
			// 
			// mj_lbl1
			// 
			this.mj_lbl1.AutoSize = true;
			this.mj_lbl1.Location = new System.Drawing.Point(9, 108);
			this.mj_lbl1.Name = "mj_lbl1";
			this.mj_lbl1.Size = new System.Drawing.Size(224, 39);
			this.mj_lbl1.TabIndex = 24;
			this.mj_lbl1.Text = "Minimalna próba badawcza (liczba powtórzeń \r\nsortowania tablicy o tych samych \r\nr" +
    "ozmiarach, ale róźnej zawartości)";
			// 
			// mj_btn_GrafiPrez
			// 
			this.mj_btn_GrafiPrez.Enabled = false;
			this.mj_btn_GrafiPrez.Location = new System.Drawing.Point(1886, 162);
			this.mj_btn_GrafiPrez.Name = "mj_btn_GrafiPrez";
			this.mj_btn_GrafiPrez.Size = new System.Drawing.Size(91, 48);
			this.mj_btn_GrafiPrez.TabIndex = 22;
			this.mj_btn_GrafiPrez.Text = "Graficzna prezentacja";
			this.mj_btn_GrafiPrez.UseVisualStyleBackColor = true;
			this.mj_btn_GrafiPrez.Click += new System.EventHandler(this.mj_btn_GrafiPrez_Click);
			// 
			// mj_btn_Reset
			// 
			this.mj_btn_Reset.Enabled = false;
			this.mj_btn_Reset.Location = new System.Drawing.Point(1886, 216);
			this.mj_btn_Reset.Name = "mj_btn_Reset";
			this.mj_btn_Reset.Size = new System.Drawing.Size(91, 48);
			this.mj_btn_Reset.TabIndex = 21;
			this.mj_btn_Reset.Text = "Resetuj (ustawienia standardowe)";
			this.mj_btn_Reset.UseVisualStyleBackColor = true;
			// 
			// mj_btn_demo
			// 
			this.mj_btn_demo.Enabled = false;
			this.mj_btn_demo.Location = new System.Drawing.Point(1886, 270);
			this.mj_btn_demo.Name = "mj_btn_demo";
			this.mj_btn_demo.Size = new System.Drawing.Size(91, 48);
			this.mj_btn_demo.TabIndex = 20;
			this.mj_btn_demo.Text = "DEMO (symulacja działania)";
			this.mj_btn_demo.UseVisualStyleBackColor = true;
			// 
			// mj_btn_AkceptDanych
			// 
			this.mj_btn_AkceptDanych.Location = new System.Drawing.Point(10, 403);
			this.mj_btn_AkceptDanych.Name = "mj_btn_AkceptDanych";
			this.mj_btn_AkceptDanych.Size = new System.Drawing.Size(91, 48);
			this.mj_btn_AkceptDanych.TabIndex = 19;
			this.mj_btn_AkceptDanych.Text = "Akceptacja danych dla badania algorytmu";
			this.mj_btn_AkceptDanych.UseVisualStyleBackColor = true;
			this.mj_btn_AkceptDanych.Click += new System.EventHandler(this.mj_btn_AkceptDanych_Click);
			// 
			// mj_btn_WizualTablPoSort
			// 
			this.mj_btn_WizualTablPoSort.Location = new System.Drawing.Point(10, 457);
			this.mj_btn_WizualTablPoSort.Name = "mj_btn_WizualTablPoSort";
			this.mj_btn_WizualTablPoSort.Size = new System.Drawing.Size(91, 48);
			this.mj_btn_WizualTablPoSort.TabIndex = 18;
			this.mj_btn_WizualTablPoSort.Text = "Wizualizacja tablicy po sortowaniu";
			this.mj_btn_WizualTablPoSort.UseVisualStyleBackColor = true;
			this.mj_btn_WizualTablPoSort.Click += new System.EventHandler(this.mj_btn_WizualTablPoSort_Click);
			// 
			// mj_btn_TabPrez
			// 
			this.mj_btn_TabPrez.Enabled = false;
			this.mj_btn_TabPrez.Location = new System.Drawing.Point(1886, 108);
			this.mj_btn_TabPrez.Name = "mj_btn_TabPrez";
			this.mj_btn_TabPrez.Size = new System.Drawing.Size(91, 48);
			this.mj_btn_TabPrez.TabIndex = 17;
			this.mj_btn_TabPrez.Text = "Tabelaryczna prezentacja złożoności";
			this.mj_btn_TabPrez.UseVisualStyleBackColor = true;
			this.mj_btn_TabPrez.Click += new System.EventHandler(this.mj_btn_TabPrez_Click);
			// 
			// mj_menu
			// 
			this.mj_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcjeToolStripMenuItem});
			this.mj_menu.Location = new System.Drawing.Point(0, 0);
			this.mj_menu.Name = "mj_menu";
			this.mj_menu.Size = new System.Drawing.Size(1989, 24);
			this.mj_menu.TabIndex = 23;
			this.mj_menu.Text = "menuStrip1";
			// 
			// opcjeToolStripMenuItem
			// 
			this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kolorLiniiToolStripMenuItem,
            this.kolorTłaToolStripMenuItem,
            this.styllLiniiToolStripMenuItem});
			this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
			this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.opcjeToolStripMenuItem.Text = "Opcje";
			// 
			// kolorLiniiToolStripMenuItem
			// 
			this.kolorLiniiToolStripMenuItem.Name = "kolorLiniiToolStripMenuItem";
			this.kolorLiniiToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.kolorLiniiToolStripMenuItem.Text = "Kolor linii";
			// 
			// kolorTłaToolStripMenuItem
			// 
			this.kolorTłaToolStripMenuItem.Name = "kolorTłaToolStripMenuItem";
			this.kolorTłaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.kolorTłaToolStripMenuItem.Text = "Kolor tła";
			// 
			// styllLiniiToolStripMenuItem
			// 
			this.styllLiniiToolStripMenuItem.Name = "styllLiniiToolStripMenuItem";
			this.styllLiniiToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.styllLiniiToolStripMenuItem.Text = "Styll linii";
			// 
			// mj_dgvTabelaWynikow
			// 
			this.mj_dgvTabelaWynikow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.mj_dgvTabelaWynikow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.mj_dgvTabelaWynikow.Location = new System.Drawing.Point(945, 150);
			this.mj_dgvTabelaWynikow.Name = "mj_dgvTabelaWynikow";
			this.mj_dgvTabelaWynikow.Size = new System.Drawing.Size(506, 455);
			this.mj_dgvTabelaWynikow.TabIndex = 34;
			this.mj_dgvTabelaWynikow.Visible = false;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Rozmiar Sortowanej tabeli";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Koszt czasowy z pomiaru";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Analityczny koszt czasowy (na podstawie wzoru)";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Koszt pamięciowy";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// mj_dgvElementyTablicy
			// 
			this.mj_dgvElementyTablicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.mj_dgvElementyTablicy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
			this.mj_dgvElementyTablicy.Location = new System.Drawing.Point(433, 150);
			this.mj_dgvElementyTablicy.Name = "mj_dgvElementyTablicy";
			this.mj_dgvElementyTablicy.Size = new System.Drawing.Size(506, 456);
			this.mj_dgvElementyTablicy.TabIndex = 33;
			this.mj_dgvElementyTablicy.Visible = false;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Rozmiar";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Elementy";
			this.Column2.Name = "Column2";
			// 
			// mj_erp
			// 
			this.mj_erp.ContainerControl = this;
			// 
			// mj_chart
			// 
			chartArea1.Name = "ChartArea1";
			this.mj_chart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.mj_chart.Legends.Add(legend1);
			this.mj_chart.Location = new System.Drawing.Point(465, 162);
			this.mj_chart.Name = "mj_chart";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.mj_chart.Series.Add(series1);
			this.mj_chart.Size = new System.Drawing.Size(922, 610);
			this.mj_chart.TabIndex = 35;
			this.mj_chart.Visible = false;
			// 
			// AnalizatorAlgorytmów
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1989, 954);
			this.Controls.Add(this.mj_chart);
			this.Controls.Add(this.mj_dgvTabelaWynikow);
			this.Controls.Add(this.mj_dgvElementyTablicy);
			this.Controls.Add(this.mj_cmb_AlgorytmySort);
			this.Controls.Add(this.mj_tb_MaksRozmTab);
			this.Controls.Add(this.mj_tb_DolnaGranica);
			this.Controls.Add(this.mj_tb_GornaGranica);
			this.Controls.Add(this.mj_tb_MinProb);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.mj_lbl3);
			this.Controls.Add(this.mj_lbl2);
			this.Controls.Add(this.mj_lbl1);
			this.Controls.Add(this.mj_btn_GrafiPrez);
			this.Controls.Add(this.mj_btn_Reset);
			this.Controls.Add(this.mj_btn_demo);
			this.Controls.Add(this.mj_btn_AkceptDanych);
			this.Controls.Add(this.mj_btn_WizualTablPoSort);
			this.Controls.Add(this.mj_btn_TabPrez);
			this.Controls.Add(this.mj_menu);
			this.Name = "AnalizatorAlgorytmów";
			this.Text = "Analizator Algorytmów";
			this.Load += new System.EventHandler(this.AnalizatorAlgorytmów_Load);
			this.mj_menu.ResumeLayout(false);
			this.mj_menu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.mj_dgvTabelaWynikow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mj_dgvElementyTablicy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mj_erp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mj_chart)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox mj_cmb_AlgorytmySort;
		private System.Windows.Forms.TextBox mj_tb_MaksRozmTab;
		private System.Windows.Forms.TextBox mj_tb_DolnaGranica;
		private System.Windows.Forms.TextBox mj_tb_GornaGranica;
		private System.Windows.Forms.TextBox mj_tb_MinProb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label mj_lbl3;
		private System.Windows.Forms.Label mj_lbl2;
		private System.Windows.Forms.Label mj_lbl1;
		private System.Windows.Forms.Button mj_btn_GrafiPrez;
		private System.Windows.Forms.Button mj_btn_Reset;
		private System.Windows.Forms.Button mj_btn_demo;
		private System.Windows.Forms.Button mj_btn_AkceptDanych;
		private System.Windows.Forms.Button mj_btn_WizualTablPoSort;
		private System.Windows.Forms.Button mj_btn_TabPrez;
		private System.Windows.Forms.MenuStrip mj_menu;
		private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kolorLiniiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kolorTłaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem styllLiniiToolStripMenuItem;
		private System.Windows.Forms.DataGridView mj_dgvTabelaWynikow;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridView mj_dgvElementyTablicy;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.ErrorProvider mj_erp;
		private System.Windows.Forms.DataVisualization.Charting.Chart mj_chart;
	}
}

