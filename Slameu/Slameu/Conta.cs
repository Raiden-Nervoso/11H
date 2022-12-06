using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slameu
{
    internal class Conta
    {
        
        public Conta(int numero, double limite)
        {
            this.Numero = numero;
            this.Limite = limite;
        }
        private double Saldo { get; set; }
        public double Limite { get; private set; }
        public int Numero { get; private set; }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
        public bool Saca(double valor)
        {
            double SaldoDisponivel = this.ConsultaSaldoDisponivel();
            

            if(valor > SaldoDisponivel)
            {
                Console.WriteLine("Saque e saldo indisponivel");
                return false;
            }
            this.Saldo -= valor;
            return true;
        }
        public void AdicionarLimite(double valor)
        {
            this.Limite = valor;
        }

        public double ConsultaSaldoDisponivel()
        {
            return this.Saldo + this.Limite;
        }
    }
}
