using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace App_C3_core
{
    public class ReadFile
    {
       public static string lerArquivoProd()
        {
            return File.ReadAllText("Produto.txt");
        } 

        public static string lerArquivoCli()
        {
            return File.ReadAllText("Cliente.txt");
        }

        public static void inserirEmFile(string nome, int cpf, int idade, string email)
        {
            string ler = $"{nome};{cpf};{idade};{email}/";
            //File.WriteAllText("Cliente.txt", ler);
            File.AppendAllText("Cliente.txt", ler);
        }
    }
}
