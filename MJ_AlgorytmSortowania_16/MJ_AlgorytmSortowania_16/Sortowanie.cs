using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJ_AlgorytmSortowania_16
{
	class Sortowanie
	{




		public int SelecSort(ref double[] T, int k)
		{


			double KopiaElementuDoWymiany;
			int LicznikOD = 0; // Licznik operacji dominujacych 

			for (int i = 0; i < T.Length - 1; i++)
			{
				k = 1;

				for (int j = i + 1; j < T.Length; j++)
				{
					LicznikOD++;
					if (T[k] > T[j])
					{
						k = j;
					}

				}//for2
				KopiaElementuDoWymiany = T[i];
				T[i] = T[k];
				T[k] = KopiaElementuDoWymiany;

			}//for1

			return LicznikOD;
		} // SelecSort

		///////////HeapSort///////////



		public int HeapSort(ref double[] T, int k)
		{
		int LicznikOD = 0; // Licznik operacji dominujacych 
		return LicznikOD;
		}

		///////////CountingSort///////////

		public int CountingSort(ref double[] T, int k)
		{
		int LicznikOD = 0; // Licznik operacji dominujacych 
		return LicznikOD;
		}

		//////////////////////
	}
}
