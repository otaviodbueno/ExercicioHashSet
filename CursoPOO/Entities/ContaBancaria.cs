using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOO.Entities
{
    class ContaBancaria
    {
        public int NumeroDaConta { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public double Saque { get; set; }
        public int LimiteDeSaque { get; set; }

        public ContaBancaria() { }

        public ContaBancaria(int numeroDaConta, string nome, double saldo, int limiteDeSaque, double saque)
        {
            if(saldo == 0 || limiteDeSaque < saque)
            {
                throw new DomainException("O saldo da conta é zero ou o limite de saque é maior que saque desejado!");
            }


            NumeroDaConta = numeroDaConta;
            Nome = nome;
            Saldo = saldo;
            LimiteDeSaque = limiteDeSaque;
            Saque = saque;
        }


        public double RealizarSaque(double saque)
        {
            Saldo -= saque;
            return Saldo;
        }

        public double Deposito(double deposito)
        {
            Saldo += deposito;
            return Saldo;
        }
    }
}
