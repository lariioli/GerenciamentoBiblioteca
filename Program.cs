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

            