using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Randstad_Backend_com_DOTNET.models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome e {Nome}, e tenho {Idade} anos");
        }
    }
}