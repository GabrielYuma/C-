using System;
using System.Collections.Generic;
using Try;

namespace App_C3_core
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Hello World!");
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
            Console.WriteLine($"{string.Join(';', lista.ToArray())}");



            // Objeto
            List<Objeto> lisObj = new List<Objeto>();
            int menun, j;
            do
            {
                menun = menu();
                switch (menun)
                {
                    case 1:
                       
                        Console.WriteLine("Insira Nome, Idade e Salário, respectivamente: ");
                        Objeto objeto = new Objeto() {
                            Nome = Console.ReadLine(),
                            Idade = int.Parse(Console.ReadLine()),
                            Sal = int.Parse(Console.ReadLine())
                        };
                        /* Outra forma:
                         objeto.Nome = Console.ReadLine();
                         objeto.Idade = int.Parse(Console.ReadLine());
                         objeto.Sal = float.Parse(Console.ReadLine());
                        */
                        lisObj.Add(objeto);
                        break;

                    case 2:
                        for (j = 0; j < lisObj.Count; j++)
                        {
                            Console.WriteLine($"{lisObj.ToArray()[j].toString()}");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Você saiu!");
                        break;

                    default:
                        Console.WriteLine("Número Incorreto");
                        break;
                }
            } while (menun != 0);

            try
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
            }


        }
        static int menu()
        {
            Console.WriteLine("1 - Inserir dados\n 2 - Printar Objeto\n 0 - Sair");
            int opc = int.Parse(Console.ReadLine());
            return opc;
        }


    }




}
