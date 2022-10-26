using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
        public void FillMatrix(int minValue, int maxValue)
        {
            Random random = new System.Random();
            for (int i = 0; i < matSize; i++)
                for(int j = 0; j < matSize; j++)
                {
                    mat[i, j] = random.Next(minValue, maxValue);
                }
        }

        /// <summary>
        /// Prints the matrix
        /// </summary>
        public void PrintMatrix()
        {
            for (int i = 0; i < matSize; i++)
            {
                for (int j = 0; j < matSize; j++)
                {
                    Console.Write($"{mat[i, j]}\t");
                }
                Console.Write("\n");
            }
        }

        /// <summary>
        /// Prints the matrix's frame
        /// </summary>
        public void PrintMatrixFrame()
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
        }
        
        /// <summary>
        /// Inverts the first and last columns
        /// </summary>
        public void InvertFirstLastColumn()
        {
            for (int i = 0; i < matSize; i++)
            {
                int temp = mat[i, 0];
                mat[i, 0] = mat[i, matSize - 1];
                mat[i, matSize - 1] = temp;
            }
        }
        
        /// <summary>
        /// Searches for a number inside the matrix and counts how many times it is found
        /// </summary>
        /// <param name="searchedNumber"></param>
        /// <returns></returns>
        public int NumberCounter(int searchedNumber)
        {
            int nCounter = 0;

            for (int i = 0; i < matSize; i++)
                for (int j = 0; j < matSize; j++)
                {
                    if (searchedNumber == mat[i, j])
                        nCounter++;
                }

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

            average = sum / nValues;

            return average;
        }

        /// <summary>
        /// Returns the value of a cell of the matrix
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public double GetValue(int row, int column)
        {
            return mat[row, column];
        }
    }
}