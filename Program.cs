using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09Produtos
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> produtos = new List<string>();
            produtos.Add("pepsi");
            produtos.Add("fanta");

            Console.WriteLine("Bem-vindo ao Conradito Store");

            while (true)
            {
                Console.WriteLine("Digite 1 para cadastrar ou 2 para listar");
                string resposta = Console.ReadLine();

                if (resposta == "1")
                {
                    Console.WriteLine("Digite o nome do produto");
                    //produtos.Add(Console.ReadLine();
                    string produto = Console.ReadLine();
                    produto = produto.ToLower();
                    //ToLower transforma as letras em minusculo
                    

                    if (produtos.Contains(produto))
                    {
                        Console.WriteLine("Esse produto já está na lista...");
                    }

                    else
                    {
                        produtos.Add(produto);
                        Console.WriteLine("Produto adicionado!");
                    }


                }
                else
                {
                    string texto = "";
                    int contador = 0;
                    
                    while (contador < produtos.Count)
                    {
                        string nome = produtos[contador];
                        string primeira_letra = nome.Substring(0, 1).ToUpper();
                        string resto = nome.Substring(1, nome.Length -1);
                        string nome_tratado = primeira_letra + resto;

                       


                        texto += nome_tratado + ", ";
                        // pepsi, fanta, nome,
                        contador++;
                    }

                    texto= texto.Substring(0, texto.Length -2);
                    // texto.Length conta os caracteres da palavra
                   





                    Console.WriteLine(texto);



                }
            }
                       
            

        }
    }
}
