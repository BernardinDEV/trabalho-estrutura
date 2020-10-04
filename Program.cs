using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Lista circular = new Lista();
            string w = Console.ReadLine();

            do
            {
               
                Console.Write("\nLista telefonica \n");
                Console.Write("selecione uma opçao \n");
                Console.Write("1->Adicionar um contato\n");
                Console.Write("2->Remover um contato\n");
                Console.Write("3->Atualizar um contato\n");
                Console.Write("4->Encontar contato\n");
                Console.Write("5->Mostar a lista\n");
                Console.Write("6->Salvar a lista em Arquivo\n");
                Console.Write("7->Ordenar agenda Por nome\n");
                Console.Write("8->Ordernar agenda por Email\n");
                Console.Write("9->Navegar Pela agenda\n");
                string v = Console.ReadLine();
                switch (v)

                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Digite as seguintes informaçoes\n");
                        Console.WriteLine("Nome:"); string nome = Console.ReadLine();
                        Console.WriteLine("\nEmail:"); string email = Console.ReadLine();
                        Console.WriteLine("\nNumero:"); string numero = Console.ReadLine();
                        circular.addList(nome, email, numero);
                        break;
                    case "2":
                        Console.WriteLine("Digite as seguintes informaçoes\n");
                        Console.WriteLine("Qual contato deseja remover :"); string achar2 = Console.ReadLine();
                        circular.removeList(achar2);

                        break;
                    case "3":
                        Console.WriteLine("Digite as seguintes informaçoes\n");
                        Console.WriteLine("Qual contato deseja atualizar :"); string achar1 = Console.ReadLine();
                        Console.WriteLine("atualize o contato");
                        Console.WriteLine("Nome:"); string nome1 = Console.ReadLine();
                        Console.WriteLine("\nEmail:"); string email1 = Console.ReadLine();
                        Console.WriteLine("\nNumero:"); string numero1 = Console.ReadLine();
                        circular.update(nome1, email1, numero1, achar1);

                        break;
                    case "4":
                        Console.WriteLine("digite as seguintes informaçoes\n");
                        Console.WriteLine("Nome:"); string achar = Console.ReadLine();
                        circular.encontar(achar);
                        break;
                    case "5":
                        Console.WriteLine("Sua Lista");
                        circular.printList();
                        break;
                    case "6":
                        circular.salvarEmAqruivo();
                        break;
                    case "7":
                        circular.ordenarNome();
                        break;
                    case "8":
                        circular.ordenarEmail();
                        break;
                    case "9":
                        var t = "0";
                        do
                        {
                            Console.WriteLine("\nNavegar 'n' Sair 's':\n"); string navegar = Console.ReadLine();

                            switch (navegar)
                            {
                                case "n":
                                    circular.navegaçao();
                                    break;
                                case "s":
                                    t = "1";
                                    break;
                            }
                        } while (t == "0");
                        break;
                    case "Exit":
                        w = "Exit";
                        break;
                }
                

            } while (w != "Exit");



        }
    }
}
