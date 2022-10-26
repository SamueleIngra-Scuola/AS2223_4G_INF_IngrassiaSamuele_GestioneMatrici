using AS2223_4G_INF_IngrassiaSamuele_GestioneMatrici;
using System;

const int MIN_VALUE_MAT = -100;
const int MAX_VALUE_MAT = 75;

Console.WriteLine("Request #1\n");

Console.Write("Inserisci la dimensione del lato della matrice: ");
int matSize = Int32.Parse(Console.ReadLine());

MatrixManager GM = new MatrixManager(matSize);

GM.FillMatrix(MIN_VALUE_MAT, MAX_VALUE_MAT);
Console.WriteLine("Matrice Riempita!");

Console.WriteLine("\nRequest #2\n");

GM.PrintMatrix();

Console.WriteLine("\nRequest #3\n");

Console.Write("Inserisci il valore da ricercare: ");
int searchedValue = Int32.Parse(Console.ReadLine());
Console.WriteLine($"Sono state trovate {GM.NumberCounter(searchedValue)} celle contenenti il numero {searchedValue}!");

Console.WriteLine("\nRequest #4\n");

GM.PrintMatrixFrame();

Console.WriteLine("\nRequest #5\n");

GM.PrintMatrix();
GM.InvertFirstLastColumn();
Console.WriteLine("\nColonne Invertite!\n");
GM.PrintMatrix();

Console.WriteLine("\nRequest #6");

int min = 0, max = 0;
double average;

average = GM.CalcMinMaxAverage(ref min, ref max);

Console.WriteLine($"Valore Massimo: {max} | Valore Minimo: {min} | Media: {average}");




