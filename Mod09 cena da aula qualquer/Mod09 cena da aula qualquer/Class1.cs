using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_cena_da_aula_qualquer
{
    public class Class1
    {
       /* public Class1(int numero)
        {
            this.Numero = numero;
        }
        public Class1(int Numero , double Limite)
        {
            this.Numero = Numero;
            this.Limite = Limite;
        }*/
        private double Saldo { get; set; }

        public double Limite { get; private set; }
        public double Numero { get; set; }
        
        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }
        public bool Tirar(double valor)
        {
            double SaldoDisponivel = this.ConsultaSaldo();
           if (valor > SaldoDisponivel )
           {
                Console.WriteLine("Saldo negativo");
                return false;
           }
            this.Saldo -= valor;
            return true;
        }
        public void AddLimite(double valor)
        {
            this.Limite = valor;
        }
        public double ConsultaSaldo()
        {
            return this.Saldo + this.Limite;    
        }
    }
}
