using _02.Execicio.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class ContaPoupança : Conta, IContaInvestimento
    {
        //propriedade
        public decimal Taxa { get; set; }
        
        //construtor Construtor: deve receber um valor decimal e atribuir esse valor ao field
        public ContaPoupança(decimal rendimento)
        {
            _rendimento = Rendimento;
        }

        public ContaPoupança()
        {
        }

        //campos/field preciso criar um metodo com get e set
        //readonly apenas leitura, logo nao tem set
        private readonly decimal _rendimento;

         public decimal Rendimento
        {
            get { return _rendimento; }
            // set { } porque é apenas leitura
        }


        //métodos
        public decimal CalculaRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if (Saldo < valor + Taxa)
            {
                throw new Exception("Saldo insuficiente");
            }

            Saldo -= valor + Taxa;
        }
    }
}
