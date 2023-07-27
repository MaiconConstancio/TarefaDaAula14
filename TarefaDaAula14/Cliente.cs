using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaDaAula14
{
    internal class Cliente
    {
        //atributos
        string nome;
        string email;
        string senha;
        public ContaBancaria contaBancaria;

        //Métodos


        public Cliente(string nome, string email, string senha, double saldo, bool cartaoCredito, bool cartaoDebito)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.contaBancaria = new ContaBancaria(saldo, cartaoCredito, cartaoDebito);
        }

        public void mostra()
        {
            Console.WriteLine($"Cliente {nome}\nEmail: {email}\nSenha: {senha}\nCom o saldo: {contaBancaria.saldo}\nStatus do credito: {contaBancaria.cartaoCredito}\nStatus do debito: {contaBancaria.cartaoDebito}\n\n");
        }

    }
}
