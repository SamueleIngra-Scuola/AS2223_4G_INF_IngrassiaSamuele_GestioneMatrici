using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AS2223_4G_INF_IngrassiaSamuele_GestioneMatrici
{
    public class MatrixManager
    {
        int[,] mat;
        int matSize;

        /// <summary>
        /// Builder with matSize
        /// </summary>
        /// <param name="matSize"></param>
        public MatrixManager(int matSize)
        {
            this.matSize = matSize;
            mat = new int[matSize, matSize];
        }

        /// <summary>
        /// Builder with entire matrix
        /// </summary>
        /// <param name="mat"></param>
        public MatrixManager(int[,] mat)
        {
            this.mat = mat;
        }

        /// <summary>
        /// Loads values in the matrix
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        public void LoadMatrix(int minValue, int maxValue)
        {

        }

        /// <summary>
        /// Prints the matrix
        /// </summary>
        public void PrintMatrix()
        {

        }

        /// <summary>
        /// Prints the matrix's frame
        /// </summary>
        public void PrintMatrixFrame()
        {

        }
        
        /// <summary>
        /// Inverts the first and last columns
        /// </summary>
        public void InvertFirstLastColumn()
        {

        }
        
        /// <summary>
        /// Searches for a number inside the matrix and counts how many times it is found
        /// </summary>
        /// <param name="searchedNumber"></param>
        /// <returns></returns>
        public int NumberCounter(int searchedNumber)
        {
            int nCounter = 0;

            return nCounter;
        }

        /// <summary>
        /// Calculates the minimum, the maximum and the average values in the matrix
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public double CalcMinMaxAverage(ref int min, ref int max)
        {
            double average = 0;

            return average;
        }
    }
}
