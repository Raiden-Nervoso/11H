using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herançalol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            animal animal = new animal();
            pessoa pessoa = new pessoa();

            Console.WriteLine("A classe pessoa vai enviar uma mensagem: ");
            pessoa.falar();
            Console.WriteLine("");

            Console.WriteLine("E agora a classe pessoa também vai enviar outra mensagem, para o qual a classe animal também tem: ");
            pessoa.comer();
            Console.WriteLine("");

            Console.WriteLine("E agora a class animal vai enviar uma mensagem a dizer COMIDA");
            animal.comer();
            Console.WriteLine("");

            Console.WriteLine("Assim, a class animal tem a propriedade comer e a classe pessoa vai herdar essa propriedade e usa-la.");
            Console.WriteLine("Enter para fechar o programa");
            Console.ReadLine();
        }
    }
}
