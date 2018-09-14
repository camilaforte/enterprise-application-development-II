using Fiap.Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Execicio.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar  ContaCorrente e ContaPoupanca 
            var cc = new ContaCorrente()
            {
                Agencia = 1,
                Numero = 2,
                Saldo = 10,
                Tipo = Model.TipoConta.Comum,
                DataAbertura = DateTime.Now
            };

            var cp = new ContaPoupança(0.06m)
            {
                Agencia = 1,
                Numero = 2,
                Saldo = 1000,
                Taxa = 2,
                DataAbertura = new DateTime(2018,1,1)
            };

            try
            {
                cc.Retirar(100);
                Console.WriteLine(cc.Saldo);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
}
