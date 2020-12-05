using System;
using System.Collections.Generic;
using Try;

namespace App_C3_core
{
    class Program
    {
        static int i;
        static string ler;
        static List<Produto> prod = new List<Produto>();
        static List<Cliente> cli = new List<Cliente>();
        public static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World!");
             int codigo = int.Parse(Console.ReadLine());
             int nome = int.Parse(Console.ReadLine());
             int total = (int)codigo + nome;
             int[] eu = new int[total];
             List<int> lista = new List<int>();

             Console.WriteLine($"{nome} dias atrás eu comprei {codigo} maçãs por {total}");
             for (i = 0; i < 10; i++)
             {
                 lista.Add(nome);
                 nome++;
             }
             i = 0;
             Console.WriteLine($"{string.Join(';', lista.ToArray())}");
             while (i < lista.Count)
             {
                 if (lista.ToArray()[i] % 2 == 0)
                 {
                     lista.RemoveAt(i);
                     i--;
                 }
                 i++;

             };
             Console.WriteLine($"{string.Join(';', lista.ToArray())}");*/



            // Objeto
            List<Objeto> lisObj = new List<Objeto>();
            fillListProd();
            fillListCli();
            cadastroCli();

            int menun, j;
            do
            {
                menun = menu();
                switch (menun)
                {
                    case 1:
                        consultarCli();
                        break;

                    case 2:
                        printListProd();
                        break;

                    case 3:
                        printListCli();
                        break;

                    case 4:
                        montarCarrinho();
                        break;

                    case 0:
                        Console.WriteLine("Você saiu!");
                        break;

                    default:
                        Console.WriteLine("Número Incorreto");
                        break;
                }
            } while (menun != 0);

            /*try
            {
                Any any = new Any(101);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("xxxxxxxxxxx");
            }*/
            static void fillListProd()
            {
                ler = ReadFile.lerArquivoProd();
                var linha = ler.Split("/");
                for (i = 0; i < linha.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(linha[i]))
                    {
                        var inserir = linha[i].Split(";");
                        Produto produto = new Produto()
                        {
                            Nome = inserir[0],
                            Preco = float.Parse(inserir[1]),
                            Cod = int.Parse(inserir[2]),
                            Qnt = int.Parse(inserir[3]),
                            Desc = inserir[4]
                        };
                        prod.Add(produto);

                    }

                }
            }

            static void fillListCli()
            {
                ler = ReadFile.lerArquivoCli();
                var linha = ler.Split("/");
                for (i = 0; i < linha.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(linha[i]))
                    {
                        var inserir = linha[i].Split(";");
                        Cliente cliente = new Cliente()
                        {
                            Nome = inserir[0],
                            Cpf = int.Parse(inserir[1]),
                            Idade = int.Parse(inserir[2]),
                            Email = inserir[3]
                        };
                        cli.Add(cliente);
                    }
                }
            }

            static void printListProd()
            {
                for (i = 0; i < prod.Count; i++)
                {
                    Console.WriteLine(prod.ToArray()[i].toString());
                }
            }

            static void printListCli()
            {
                for (i = 0; i < cli.Count; i++)
                {
                    Console.WriteLine(cli.ToArray()[i].toString());
                }
            }

            static bool consultarCli()
            {
                bool achou = false;
                Console.WriteLine("Digite o nome ou CPF a buscar: ");
                var consulta = Console.ReadLine();

                for (i = 0; i < cli.Count; i++)
                {
                    if (consulta == cli.ToArray()[i].Nome || int.Parse(consulta) == cli.ToArray()[i].Cpf)
                    {
                        Console.WriteLine(cli.ToArray()[i].toString());
                        achou = true;
                    }
                }
                return achou;
            }
            static void cadastroCli()
            {
                int opc;
                bool achou = false;
                do
                {
                    Console.WriteLine(" 1 - Consultar Cadastro\n 2 - Relizar Cadastro\n 3 - Sair\n");
                    opc = int.Parse(Console.ReadLine());

                    switch (opc)
                    {
                        case 2:
                            Console.WriteLine("\nInsira o seu nome: ");
                            string nome = Console.ReadLine();

                            Console.WriteLine("\nInsira o seu CPD: ");
                            int cpf = int.Parse(Console.ReadLine());

                            Console.WriteLine("\nInsira o sua Idade: ");
                            int idade = int.Parse(Console.ReadLine());

                            Console.WriteLine("\nInsira o seu e-mail: ");
                            string email = Console.ReadLine();

                            ReadFile.inserirEmFile(nome, cpf, idade, email);

                            adicionarObjetoCli(nome, cpf, idade, email);
                            break;

                        case 3:
                            FailFast();
                            break;

                        case 1:
                            achou = consultarCli();
                            break;

                        default:
                            Console.WriteLine("\nCódigo incorreto!");
                            break;
                    }
                } while (!achou);

            }

            static void montarCarrinho()
            {
                List<int> carrinho = new List<int>();
                bool achou;
                int opc;                
                do
                {
                    achou = false;
                    Console.WriteLine(" Digite o código do produto que deseja buscar: ");
                    var cod = int.Parse(Console.ReadLine());
                    for(i = 0; i < prod.Count; i++)
                    {
                        if (cod == prod.ToArray()[i].Cod)
                        {
                            carrinho.Add(cod);
                            achou = true;
                            break;
                        }
                        i++;
                    }
                    if (!achou)
                    {
                        Console.WriteLine("\nProduto não encontrado na llista!");
                    }
                    Console.WriteLine(" Adicionar mais um item?\n 1 - Sim\n 2 - Não");
                    opc = int.Parse(Console.ReadLine());

                } while (opc != 2);
                comprarProduto(carrinho);
            }
            static void comprarProduto(List<int> Carrinho)
            {
                float total = 0;
                Console.WriteLine(" \nItens do carrinho:\n ");
                for(i = 0; i<Carrinho.Count; i++)
                {
                    if(Carrinho.ToArray()[i] == prod.ToArray()[i].Cod)
                    {
                        Console.WriteLine(prod.ToArray()[i].toString() + "\n");
                        total = total + prod.ToArray()[i].Preco;
                    }
                }

                Console.WriteLine("Deseja continuar a compra?\n 1 - Sim\n 2 0 Não");
                int opc = int.Parse(Console.ReadLine());

                if(opc == 1)
                {
                    Console.WriteLine($"\nTotal a pagar: R${total}");
                }
            }

        }
        static int menu()
        {
            Console.WriteLine(" 1 - Consultar Cliente\n 2 - Printar Produtos\n 3 - Printar Clientes\n 4 - Realizar Compra\n 0 - Sair");
            int opc = int.Parse(Console.ReadLine());
            return opc;
        }


        static void adicionarObjetoCli(string Nome, int Cpf, int Idade, string Email)
        {
            Cliente cliente = new Cliente()
            {
                Nome = Nome,
                Cpf = Cpf,
                Idade = Idade,
                Email = Email
            };
            cli.Add(cliente);
        }

        public static void FailFast()
        {
            string causeOfFailure = "End of program!";
            Environment.FailFast(causeOfFailure);
        }
    }
}
