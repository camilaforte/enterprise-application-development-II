using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloWorld.Console.UI.Model
{
    class Lancha:Veiculo, IAquatico
    {
        //propriedade
        public bool BoiaSalvaVida { get; set; }


        public Lancha(int ano, double potencia): base (ano, potencia)
        {

        }

        //preciso implementar o metodo desligar abstrato da classe pai
        public override void Desligar()
        {
            System.Console.WriteLine("Desligando a lancha");
        }

        //polimorfismo vou sobrescrever um metodo ja implementado na classe pai
        //logo preciso ir na classe pai e habilitar o virtual
        public override void Acelerar()
        {
            System.Console.WriteLine("Empurrar a manete!");
        }

        public void Flutuar()
        {
            System.Console.WriteLine("Flutuando");

        }
    }

}
