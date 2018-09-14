using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    //classe abstrata
    //nao pode ser instanciada
    //pode conter metodos abstratos (sem implementação)
    abstract class Conta
    {
        //propriedades getters and setters
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public DateTime DataAbertura { get; set; }
        public decimal Saldo { get; set; }

        public abstract void Depositar(decimal valor);
        public abstract void Retirar(decimal valor);
    }
}
