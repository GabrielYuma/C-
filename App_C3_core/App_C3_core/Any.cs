using System;
using System.Collections.Generic;
using System.Text;

namespace Try
{
    public class Any
    {
        int idade;
        public Any(int pedro)
        {
            idade = pedro;
            IsDed();
        }
        public void IsDed() {
            if (this.idade > 100)
            {
                throw new Exception("Morreu, coitado!");
            }
            Console.WriteLine(this.idade);
        }
    }
}
