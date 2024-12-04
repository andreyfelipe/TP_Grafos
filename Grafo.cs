using System;
using System.Collections.Generic;

class Grafo
{
    private Dictionary<string, List<string>> adjacencia;

    public Grafo()
    {
        adjacencia = new Dictionary<string, List<string>>();
    }

    // Adiciona um vértice ao grafo
    public void AdicionarVertice(string vertice)
    {
        if (!adjacencia.ContainsKey(vertice))
        {
            adjacencia[vertice] = new List<string>();
            Console.WriteLine($"Vértice '{vertice}' adicionado.");
        }
        else
        {
            Console.WriteLine($"Vértice '{vertice}' já existe.");
        }
    }

    // Adiciona uma aresta entre dois vértices
    public void AdicionarAresta(string origem, string destino)
    {
        if (!adjacencia.ContainsKey(origem))
        {
            Console.WriteLine($"O vértice '{origem}' não existe.");
            return;
        }

        if (!adjacencia.ContainsKey(destino))
        {
            Console.WriteLine($"O vértice '{destino}' não existe.");
            return;
        }

        adjacencia[origem].Add(destino);
        adjacencia[destino].Add(origem); // Para grafo não direcionado
        Console.WriteLine($"Aresta adicionada entre '{origem}' e '{destino}'.");
    }

    // Exibe o grafo
    public void ExibirGrafo()
    {
        Console.WriteLine("\nRepresentação do Grafo:");
        foreach (var vertice in adjacencia)
        {
            Console.Write($"{vertice.Key}: ");
            foreach (var vizinho in vertice.Value)
            {
                Console.Write($"{vizinho} ");
            }
            Console.WriteLine();
        }
    }
}