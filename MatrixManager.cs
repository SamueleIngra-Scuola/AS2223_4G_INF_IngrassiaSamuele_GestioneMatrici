using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_IngrassiaSamuele_GestioneMatrici
{
    /// <summary>
    /// Gestore di una matrice quadrata
    /// </summary>
    public class GestoreMatrice
    {
        // definizione e istanziazione matrice in base alle dimensioni indicate dall'utente
        int[,] mat;

        // dimensione della matrice
        int matSize;

        /// <summary>
        /// Istanzia una matrice quadra di dimensione lato
        /// </summary>
        /// <param name="lato"></param>
        public GestoreMatrice(int lato)
        {
            this.matSize = lato;
            mat = new int[lato, lato];
        }

        /// <summary>
        /// Istanzia e carica la matrice con la matrice passata come parametro
        /// </summary>
        /// <param name="mat"></param>
        public GestoreMatrice(int[,] mat)
        {
            this.mat = mat;
        }

        /// <summary>
        /// Carica la matrice con valori casuali fra minValue e MaxValue
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        public void CaricaMatrice(int minValue, int maxValue)
        {
            Random random = new System.Random();
            for (int i = 0; i < matSize; i++)
                for (int j = 0; j < matSize; j++)
                {
                    mat[i, j] = random.Next(minValue, maxValue);
                }
        }

        /// <summary>
        /// Stampa la matrice nella console opportunamente formattata
        /// </summary>
        public void StampaMatrice()
        {
            for (int i = 0; i < matSize; i++)
            {
                for (int j = 0; j < matSize; j++)
                {
                    Console.Write($"{mat[i, j]}\t");
                }
                Console.Write("\n");
            }

            Console.Write("\n");
        }

        /// <summary>
        /// Stampa la cornice della matrice da [0,0] per righe distinte in senso antiorario
        /// </summary>
        public void StampaCornice()
        {
            int i;

            for (i = 0; i < matSize; i++) //Left Column
                Console.Write($"{mat[i, 0]}\t");
            Console.Write("\n");
            for (i = 1; i < matSize; i++) //Bottom Row
                Console.Write($"{mat[matSize - 1, i]}\t");
            Console.Write("\n");
            for (i = matSize - 2; i >= 0; i--) //Right Column
                Console.Write($"{mat[i, matSize - 1]}\t");
            Console.Write("\n");
            for (i = matSize - 2; i > 0; i--) //Top Row
                Console.Write($"{mat[0, i]} \t");
            Console.Write("\n");
            Console.Write("\n");
        }

        /// <summary>
        /// Inverte i valori della prima colonna della matrice con l'ultima
        /// </summary>
        /// <returns></returns>
        public void InvertiPrimaUltimaColonna()
        {
            for (int i = 0; i < matSize; i++)
            {
                int temp = mat[i, 0];
                mat[i, 0] = mat[i, matSize - 1];
                mat[i, matSize - 1] = temp;
            }
        }

        /// <summary>
        /// Cerca il valore passato nella matrice e restituisce il numero di occorrenze
        /// </summary>
        /// <param name="valoreDaCercare"></param>
        /// <returns></returns>
        public int ContaValore(int valoreDaCercare)
        {
            int nValori = 0;

            for (int i = 0; i < matSize; i++)
                for (int j = 0; j < matSize; j++)
                {
                    if (valoreDaCercare == mat[i, j])
                        nValori++;
                }

            return nValori;
        }

        /// <summary>
        /// Calcola il valore minimo, massimo e medio (ritornato) dei valori inseriti nella matrice
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public double CalcolaMinMaxMedio(ref int min, ref int max)
        {
            double medio = 0;
            double sum = 0;
            int nValues = matSize * matSize;

            min = mat[0, 0];
            max = mat[0, 0];

            for (int i = 0; i < matSize; i++)
                for (int j = 0; j < matSize; j++)
                {
                    if (mat[i, j] < min)
                        min = mat[i, j];
                    if (mat[i, j] > max)
                        max = mat[i, j];

                    sum += mat[i, j];
                }

            medio = sum / nValues;

            return medio;
        }

        /// <summary>
        /// Ritorna il valore della matrice in una cella
        /// </summary>
        /// <param name="riga"></param>
        /// <param name="colonna"></param>
        /// <returns></returns>
        public int GetValue(int riga, int colonna)
        {
            return mat[riga, colonna];
        }

    }
}
