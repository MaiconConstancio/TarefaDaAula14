using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaDaAula14
{
    internal class ContaBancaria
    {
        public double saldo;
        public bool cartaoCredito = true;
        public bool cartaoDebito;

        public ContaBancaria(double saldo, bool cartaoCredito, bool cartaoDebito)
        {
            this.saldo = saldo;
            this.cartaoCredito = cartaoCredito;
            this.cartaoDebito = cartaoDebito;
        }

        

    }
}
