using System;

class Duck
{
    public virtual void quack()
    {
        Console.WriteLine("Quack!");
    }

    public virtual void swim()
    {
        Console.WriteLine("Estou nadando!");
    }

    public virtual void display()
    {
        Console.WriteLine("Eu sou um pato.");
    }
}

using System;

class RedHeadDuck : Duck
{
    public override void display()
    {
        Console.WriteLine("Sou um pato Vermelho.");
    }
}

using System;

class MallardDuck : Duck
{
    public override void display()
    {
        Console.WriteLine("Eu sou um pato mau.");
    }
}

using System;

class Program
{
    static void Main()
    {
        RedHeadDuck patoVermelho = new RedHeadDuck();
        MallardDuck patoMau = new MallardDuck();

        Console.WriteLine("=== Pato Vermelho ===");

        patoVermelho.quack();
        patoVermelho.swim();
        patoVermelho.display();

        Console.WriteLine();

        Console.WriteLine("=== Pato Mau ===");

        patoMau.quack();
        patoMau.swim();
        patoMau.display();
    }
}

using System;

class Questao8
{
    public static double CalcularMedia(double nota1, double nota2, double nota3)
    {
        return (nota1 + nota2 + nota3) / 3;
    }

    public static void Rodar()
    {
        Console.Write("Digite a nota 1: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        double nota3 = double.Parse(Console.ReadLine());

        double media = CalcularMedia(nota1, nota2, nota3);

        Console.WriteLine($"Média: {media:F2}");

        if (media >= 6.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else
        {
            Console.WriteLine("Aluno reprovado.");
        }
    }
}

public static int ContarPares(int[] vetor)
{
    int quantidade = 0;

    for (int i = 0; i < vetor.Length; i++)
    {
        if (vetor[i] % 2 == 0)
        {
            quantidade++;
        }
    }

    return quantidade;
}

using System;

class Questao9
{
    public static int ContarPares(int[] vetor)
    {
        int quantidade = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] % 2 == 0)
            {
                quantidade++;
            }
        }

        return quantidade;
    }

    public static void Rodar()
    {
        int[] vetor = new int[10];

        // Preenchendo o vetor
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        // Chamando a função
        int quantidadePares = ContarPares(vetor);

        // Exibindo o resultado
        Console.WriteLine($"Quantidade de números pares: {quantidadePares}");
    }
}


public static int ProcurarNumero(int[] vetor, int numero)
{
    if (numero <= 0)
    {
        Console.WriteLine("O número precisa ser natural e positivo.");
        return -1;
    }

    for (int i = 0; i < vetor.Length; i++)
    {
        if (vetor[i] == numero)
        {
            return i;
        }
    }

    return -1;
}

using System;

class Questao10
{
    public static int ProcurarNumero(int[] vetor, int numero)
    {
        if (numero <= 0)
        {
            Console.WriteLine("O número precisa ser natural e positivo.");
            return -1;
        }

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == numero)
            {
                return i;
            }
        }

        return -1;
    }

    public static void Rodar()
    {
        int[] vetor = new int[10];

        // Preenchendo o vetor
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Digite o número que deseja procurar: ");
        int numero = int.Parse(Console.ReadLine());

        int posicao = ProcurarNumero(vetor, numero);

        if (numero > 0)
        {
            if (posicao != -1)
            {
                Console.WriteLine($"Número encontrado na posição {posicao}.");
            }
            else
            {
                Console.WriteLine("Número não encontrado no vetor.");
            }
        }
    }
}
