public static class teste2
{
    public static void Executar()
    {
        Console.WriteLine("Tamanho vetor: ");
        int tamanho = int.Parse(Console.ReadLine());

        int[] vetor = new int[tamanho];

        

        for (int i = 0; i < tamanho; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Chave: ");
        int chave = int.Parse(Console.ReadLine());

        int indice = posicao(vetor, chave, 0);

        Console.WriteLine(indice);
    }

    public static int posicao(int[] vetor, int chave, int i)
    {
        int resultado;

        if (i >= vetor.Length)
        {
            resultado = -1;
        }
        else if (vetor[i] == chave)
        {
            resultado = i;
        }
        else
        {
            resultado = posicao(vetor, chave, i + 1);
        }

        return resultado;
    }
}

using System;
public class Program {
    public static void Main() {
        
        int n = int.Parse(Console.ReadLine());

        int fatorial = fat(n);

        Console.WriteLine("FATORIAL = " + fatorial);

    }

    public static int fat(int n){
        int resultado;

        if(n <= 1)
        {
            resultado = 1;
        }
        else
        {
            resultado = n * fat(n - 1);
        }

        return resultado;
    }
}

using System;
public class Program {
    public static void Main() {

        int tamanho = int.Parse(Console.ReadLine());

        int[] vetor = new int[tamanho];

        string[] valores = Console.ReadLine().Split();

        for (int i = 0; i < tamanho; i++)
        {
            vetor[i] = int.Parse(valores[i]);
        }

        int chave = int.Parse(Console.ReadLine());

        int indice = posicao(vetor, chave, 0);

        Console.WriteLine(indice);
       
    }

    public static int posicao(int[] vetor, int chave, int i)
    {
        int resultado;

        if (i >= vetor.Length)
        {
            resultado = -1;
        }
        else if (vetor[i] == chave)
        {
            resultado = i;
        }
        else
        {
            resultado = posicao(vetor, chave, i + 1);
        }

        return resultado;
    }
}
