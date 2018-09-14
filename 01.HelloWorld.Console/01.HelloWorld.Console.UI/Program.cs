using _01.HelloWorld.Console.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloWorld.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar um carro
            Carro c = new Carro(2010, 2.0);
            //set
            c.Ano = 2010;
            c.ArCondicionado = true;
            //get
            System.Console.WriteLine(c.Ano);
            System.Console.WriteLine(c.ArCondicionado);

            //instanciar uma lancha
            Lancha l = new Lancha(2019, 140)
            {
                BoiaSalvaVida = true,
                Ano = 2000
            };

        }
    }
}
