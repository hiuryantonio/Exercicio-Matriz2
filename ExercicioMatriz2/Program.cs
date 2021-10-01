using System;

namespace ExercicioMatriz2
{
    class Program
    {
        private static object mat;

        static void Main(string[] args)
        {
            string[] linha = Console.ReadLine().Split(' ');
            int m = int.Parse(linha[0]);
            int n = int.Parse(linha[1]);

            int[,] tapete = new int[m, n];

            for(int i = 0; i < m; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for(int j = 0; j < n; j++) {
                    tapete[i, j] = int.Parse(valores[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for(int i = 0; i < m; i++) {
                for(int j = 0; j < n; j++) {
                    if(tapete[i, j] == x) {
                        Console.WriteLine("Posição " + i + ", " + j + "  );
                        if
                            (j > 0) 
                        {
                            Console.WriteLine("Esquerda: " + tapete[i, j - 1]);
                        }
                        if(i > 0) 
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if(j < n - 1) 
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if(i < m - 1) 
                        {
                            Console.WriteLine("Down: " + tapete[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
