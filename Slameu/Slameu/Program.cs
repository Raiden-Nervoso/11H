using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Slameu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo POO");

            //criando instancia conta
            Conta conta = new Conta(123, 300);

            //a conta começa com 300 euros e estes 300 não são usados

            conta.Deposita(1500);
            conta.Deposita(2500);
            conta.Deposita(4500);

            

            bool saca = conta.Saca(7000);

            if(saca)
            {
                double saldo = conta.ConsultaSaldoDisponivel();

                Console.WriteLine("O seu saldo é: " + saldo);
                Console.WriteLine("O seu saldo limite é: " + conta.Limite);
                Console.WriteLine("O numero da sua conta é: " + conta.Numero);
            }
        }
    }
}
