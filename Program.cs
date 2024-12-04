using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Grafo grafo = new Grafo();

        // Adiciona vértices
        grafo.AdicionarVertice("A");
        grafo.AdicionarVertice("B");
        grafo.AdicionarVertice("C");
        grafo.AdicionarVertice("D");

        // Adiciona arestas
        grafo.AdicionarAresta("A", "B");
        grafo.AdicionarAresta("A", "C");
        grafo.AdicionarAresta("B", "D");
        grafo.AdicionarAresta("C", "D");

        // Exibe o grafo
        grafo.ExibirGrafo();
    }
}

