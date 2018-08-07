﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    public abstract class Conta
    {

        public int Agencia { get; set; }
        public int Numero { get; set; }
        public DateTime DataAbertura { get; set; }
        public double Saldo { get; set; }

        public abstract void Depositar(double valor);
        public abstract void Retirar(double valor);

    }

}
