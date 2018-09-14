using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloWorld.Console.UI.Model
{
    //classe abstrata NAO pode ser instanciada
    //PODE conter metodos absratos, sem implementação
    abstract class Veiculo
    {
        private double _potencia; //privado inicializa com underline
        
        //Gets e Sets
        public int Ano { get; set; } //nao preciso declarar o atributo, somente get e set


        public double Potencia
        {
            get { return _potencia; }
            set
            {
                if (value >= 0)
                {
                    _potencia = value;
                }
            }
        }

        //mesmo get e set de cima
        public double Potenciaa { get; set; }

        //construtor com parametro
        public Veiculo(int ano, double potencia)
        {
            Ano = ano;                  //metodo set por isso ta maiusculo
            Potencia = potencia;        //metodo set por isso ta maiusculo
        }
    
        //metodo normal
        public virtual void Acelerar()
        {
            System.Console.WriteLine("Veiculo acelerando!");
        }

        //metodo abstrato, nao tem implementação, mas seus filhos PRECISAM implementar
        public abstract void Desligar();


    }
}
