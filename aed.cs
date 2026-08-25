using System;

class Program
{
    static void Main()
    {
        int[,] M = new int[10, 10];

        int somaTotal = 0;

        
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (i == j)
                {
                    M[i, j] = 1;
                }
                else if (i < j)
                {
                    M[i, j] = i + j;
                }
                else
                {
                    M[i, j] = -1;
                }

                somaTotal += M[i, j];
            }
        }

       
        Console.WriteLine("Matriz:");

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(M[i, j] + "\t");
            }

            Console.WriteLine();
        }

        
        Console.WriteLine("\nRelatório:");

        for (int j = 0; j < 10; j++)
        {
            int somaColuna = 0;

            for (int i = 0; i < 10; i++)
            {
                somaColuna += M[i, j];
            }

            Console.WriteLine($"Soma da coluna {j + 1} = {somaColuna}");
        }

        
        Console.WriteLine($"Soma dos elementos da matriz = {somaTotal}");
    }
}
