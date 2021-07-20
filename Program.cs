using System;
using System.Collections.Generic;

namespace logica
{
    class Program
    {
        static List<string> ListaNomes = new List<string>();
        private static string pessoa;

         static string escolha;
        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine($@" 
                
            | --------------------------------------------|
            | -------------PAINEL DE CONTROLE ----------- |
            | 1 - Cadastrar Nome                          |
            | 2 - Listar Nome                             | 
            |                                             |
            | 3 - Finalizar Programa                      |
            | --------------------------------------------| ");
        

                escolha = (Console.ReadLine());

                switch (escolha)
                {
                    case "1":

                        Console.WriteLine("Digite seu nome!");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Digite sua idade!");
                        int idade = int.Parse(Console.ReadLine());

                        if (idade >= 16)
                        {
                            CadastraNome(nome);

                        }
                        else
                        {
                            Console.WriteLine($"Você está acompanhado dos seus pais");
                            string acompanhante = Console.ReadLine().ToLower();
                            if (acompanhante == "s")
                            {
                                CadastraNome(nome);
                            }
                            else if (acompanhante == "n" && idade < 15)
                            {
                                Console.WriteLine($"Sua entrada não foi liberada!!!! Por favor volte ano que vem com seu resp onsavél legal. ");

                            }
                            else if (acompanhante == "n")
                            {
                                Console.WriteLine("Sua entrada não foi liberada, volte ano que vem.");
                            }
                        }

                        break;
                    case "2":
                        MonstrarNome();
                        break;
                    case "3":
                        Console.WriteLine("Você está saindo do nosso sistema.");
                        break;
                    default:
                        Console.WriteLine($"Opção invalida por favor digite um dos números acima.");

                        break;
                }



            } while (escolha != "3");
        }

        static void MonstrarNome()
        {

            foreach (var CadaItem in ListaNomes)
            {
                Console.WriteLine($"Nome: {CadaItem}");
            }
        }

        static void CadastraNome(string nome)
        {

            Console.WriteLine($"Sua entrada está autorizada!");
            ListaNomes.Add(nome);
        }
    }
}