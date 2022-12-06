using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_cena_da_aula_qualquer
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Class1 conta3 = new Class1();

            conta3.AddLimite(1500);

            conta3.Depositar(1500);
            conta3.Depositar(2500);
            conta3.Depositar(4500);

            int decisao = 0;
            Console.WriteLine("O seu saldo neste momento é de: " + conta3.ConsultaSaldo());
            Console.WriteLine("O limite é de: " + conta3.Limite);
            Console.WriteLine("Pretende retirar quanto dinheiro? ");
            decisao = int.Parse(Console.ReadLine());

            bool tira = conta3.Tirar(decisao);

            if(tira)
            {
            double saldo = conta3.ConsultaSaldo();
                Console.WriteLine("O seu saldo é: " + saldo);
                Console.WriteLine("O seu limite é: " + conta3.Limite);
                
                Console.ReadLine();
            }
            
        }
    }
}
