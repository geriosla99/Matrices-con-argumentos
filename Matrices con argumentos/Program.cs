using System;

namespace Matrices_con_argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Matriz = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //invocamos el método
            ImprimirMatriz(Matriz);

            //matriz multi
            double[,] matriz2D ={   {1, 2 },
                                    {3,4 }  };
            ImprimirMatrizMultidimencional(matriz2D);
        }

        static void ImprimirMatriz(int[] matrizPa)
        {
            int i;
            for (i = 0; i < matrizPa.Length; i++)
            {
                Console.WriteLine(matrizPa[i]);
            }
        }

        static void ImprimirMatrizMultidimencional(double[,] matriz2DPa)
        {
            int i;
            int j;
            for (i = 0; i < matriz2DPa.GetLength(0); i++)
            {
                Console.WriteLine("fila {0}", i);
                for (j = 0; j < matriz2DPa.GetLength(0); j++)
                {
                    Console.WriteLine(matriz2DPa[i,j]);
                }
            }
        }

    }
}
