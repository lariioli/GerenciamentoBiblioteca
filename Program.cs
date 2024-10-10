using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Livro> catalogo = new List<Livro>();

    static void Main(string[] args)
    {
        CarregarCatalogo();

        while (true)
        {
             Console.Clear();
             Console.WriteLine("\nMenu Biblioteca:");
             Console.WriteLine("1. Cadastrar livro");
             Console.WriteLine("2. Ver catálogo");
             Console.WriteLine("3. Emprestar livro");
             Console.WriteLine("4. Devolver livro");
             Console.WriteLine("5. Sair e salvar");
             
             string opcao = Console.ReadLine();

             if (opcao == "1") CadastrarLivro();
             else if (opcao == "2") VerCatalogo();
             else if (opcao == "3") EmprestarLivro();
             else if (opcao == "4") DevolverLivro();
             else if (opcao == "5") 
              {
                SalvarCatalogo();
                break;
            }
            else Console.WriteLine("Opção inválida.");
        }
    }
      static void CadastrarLivro()
    {
        Console.Write("Título: ");
        string titulo = Console.ReadLine();
        Console.Write("Autor: ");
        string autor = Console.ReadLine();
        Console.Write("Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine());

        catalogo.Add(new Livro(titulo, autor, quantidade));
        Console.WriteLine("Livro cadastrado!");
         }

    static void VerCatalogo()
    {
        Console.WriteLine("\nCatálogo de Livros:");
        foreach (var livro in catalogo)
        {
            Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}, Quantidade: {livro.Quantidade}");
        }
    }
     static void EmprestarLivro()
    {
        Console.Write("Título do livro: ");
        string titulo = Console.ReadLine();
        Livro livro = catalogo.Find(l => l.Titulo.ToLower() == titulo.ToLower());

        if (livro != null && livro.Quantidade > 0)
         {
            livro.Quantidade--;
            Console.WriteLine($"Você emprestou '{livro.Titulo}'.");
        }
        else
        {
            Console.WriteLine("Livro indisponível.");
        }
    }
     static void DevolverLivro()
    {
        Console.Write("Título do livro: ");
        string titulo = Console.ReadLine();
        Livro livro = catalogo.Find(l => l.Titulo.ToLower() == titulo.ToLower());

        if (livro != null)
         {
            livro.Quantidade++;
            Console.WriteLine($"Você devolveu '{livro.Titulo}'.");
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }
    static void SalvarCatalogo()
    {
        using (StreamWriter writer = new StreamWriter("catalogo.txt"))
        {
            foreach (var livro in catalogo)
            {
                writer.WriteLine($"{livro.Titulo};{livro.Autor};{livro.Quantidade}");
            }
        }
        Console.WriteLine("Catálogo salvo.");
    }
     static void CarregarCatalogo()
    {
        if (File.Exists("catalogo.txt"))
        {
            string[] linhas = File.ReadAllLines("catalogo.txt");
            foreach (var linha in linhas)
            {
                string[] dados = linha.Split(';');
                catalogo.Add(new Livro(dados[0], dados[1], int.Parse(dados[2])));
            }
            Console.WriteLine("Catálogo carregado.");
        }
        else
        {
  
            