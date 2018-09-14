using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloWorld.Console.UI.Model
{
    class Carro: Veiculo
    {
        //propriedades
        public int Portas { get; set; }
        public bool ArCondicionado { get; set; }

        //tipo de veiculo enum
        public TipoCarro Tipo { get; set; }

        //construtor, uso :base no lugar de super 
        public Carro(int ano, double potencia) : base (ano, potencia)
        {
            
        }

        //sobrescrever metodo (override)
        public override void Desligar()
        {
            System.Console.WriteLine("Virar a chave!");
        }

    }


}
