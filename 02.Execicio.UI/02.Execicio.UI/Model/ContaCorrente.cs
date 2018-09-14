using _02.Execicio.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    //sealed porque nao pode ser herdada, como se fosse o final
    sealed class ContaCorrente : Conta
    {

        //propriedades
        public TipoConta Tipo { get; set; }

        //metodos herdados
        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if(Tipo == TipoConta.Comum && Saldo < valor)
            {
                throw new Exception("Saldo insuficiente!");
            }
            Saldo -= valor;
        }
    }
}
