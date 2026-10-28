using System;
using System.Collections.Generic;

// Estudo Dirigido - TAD Fila Flexível (AED 2026/2) - ESQUELETO
// Complete os trechos marcados com TODO. Não altere a Main das Partes 1 e 3.

public class Celula 
{
    public int elemento;
    public Celula prox;

    public Celula() : this(0) { }

    public Celula(int elemento)
    {
        // TODO (Parte 1): guardar o elemento e iniciar prox como null
        throw new NotImplementedException();
    }
}

public class Fila
{
    private Celula primeiro, ultimo;   // primeiro é o nó cabeça

    public Fila()
    {
        // TODO (Parte 1): criar o nó cabeça e fazer ultimo apontar para ele
        throw new NotImplementedException();
    }

    public bool isVazia() { throw new NotImplementedException(); }   // TODO (Parte 1)

    public int tamanho() { throw new NotImplementedException(); }    // TODO (Parte 1)

    public void inserir(int x) { throw new NotImplementedException(); }   // TODO (Parte 1)

    public int remover()   // TODO (Parte 1): lançar Exception("Erro: fila vazia") se vazia
    {
        throw new NotImplementedException();
    }

    public void mostrar()  // TODO (Parte 1): imprimir no formato [3, 5, 7]
    {
        throw new NotImplementedException();
    }

    // ---------- Parte 3 ----------
    public bool pesquisar(int x) { throw new NotImplementedException(); }   // TODO
    public int maior()   { throw new NotImplementedException(); }           // TODO (exceção se vazia)
    public int somar()   { throw new NotImplementedException(); }           // TODO
    public void inverter() { throw new NotImplementedException(); }         // TODO (use Stack<int>)

    // ---------- Desafio opcional ----------
    public int removerUltimo() { throw new NotImplementedException(); }     // TODO
}

// ---------- Parte 5 ----------
public class FilaSemUltimo
{
    private Celula primeiro = new Celula();
    public long passos = 0;   // quantas células o inserir visitou

    public void inserir(int x)
    {
        // TODO (Parte 5): percorrer até a última célula (contando em passos) e encadear a nova
        throw new NotImplementedException();
    }
}

public class Program
{
    static void Tentar(Action a)
    {
        try { a(); } catch (Exception e) { Console.WriteLine(e.Message); }
    }

    public static void Main(string[] args)
    {
        // ---- Parte 1 ----
        Fila f = new Fila();
        Console.WriteLine(f.isVazia());
        f.inserir(3); f.inserir(5); f.inserir(7);
        f.mostrar();
        Console.WriteLine(f.remover());
        f.mostrar();
        Console.WriteLine(f.tamanho());
        f.inserir(10);
        f.mostrar();
        f.remover(); f.remover(); f.remover();
        Console.WriteLine(f.isVazia());
        Tentar(() => f.remover());
        f.inserir(1);
        f.mostrar();

        // ---- Parte 3 ----
        Fila g = new Fila();
        foreach (int x in new[] { 5, 10, 15, 20, 25 }) g.inserir(x);
        Console.WriteLine(g.pesquisar(15));
        Console.WriteLine(g.pesquisar(7));
        Console.WriteLine(g.maior());
        Console.WriteLine(g.somar());
        g.inverter();
        g.mostrar();
        g.inserir(1);
        g.mostrar();

        // ---- Desafio (descomente ao chegar aqui) ----
        // Console.WriteLine(g.removerUltimo());
        // Console.WriteLine(g.removerUltimo());
        // g.mostrar();

        // ---- Parte 5 ----
        foreach (int n in new[] { 1000, 2000 })
        {
            FilaSemUltimo s = new FilaSemUltimo();
            for (int k = 0; k < n; k++) s.inserir(k);
            Console.WriteLine($"n = {n}: passos = {s.passos}");
        }
    }
}
