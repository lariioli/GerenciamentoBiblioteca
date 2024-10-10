using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Livro> catalogo = new List<Livro>();
    {
        static void Main(string[] args)
        {
            CarregarCatalago();
            while(true)
            {
             Console.Clear();
             Console.WriteLine("n/Menu Biblioteca:");
             Console.WriteLine("1. Cadastrar livro");
             Console.WriteLine("2. Ver catálogo");
             Console.WriteLine("3. Emprestar livro");
             Console.WriteLine("4. Devolver livro");
             Console.WriteLine("5. Sair e salvar");


            }
        }


    }
}