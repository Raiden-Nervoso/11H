using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_de_estudo1
{
    internal class Program
    {
        enum Minakaze { perfeito, muito_bom, bom, mid, bosta, mud };
        
        static void Main(string[] args)
        {
            //Variaveis:
            //Int 10,  40
            //Float 10,3 , 40,6
            //Bool true or false (?)
            //String  "" (texto normal)
            //Char  'E' (apenas uma letra)
            int data_Nascimento = 31 / 1;
            string cor_favorita = "Roxo";
            float velocidadeF1 = 294.48f;
            bool data_NascimentoVerdadeira = true;

            //var bodaVariavel = "BODAAA";
            //Console.Write(bodaVariavel);
            //Console.Write("Teste");
            //Console.ReadLine();

            Console.WriteLine(data_Nascimento);
            Console.WriteLine(cor_favorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(data_NascimentoVerdadeira);

            velocidadeF1 = 348.41f;
            cor_favorita = "Vermelho";
            Console.WriteLine(cor_favorita);
            

            dynamic joe = "Bruh";
            Console.WriteLine(joe);

            joe = 23415667;
            Console.WriteLine(joe);

            const float PI = 3.1416f;
            Console.WriteLine(PI);

            string nome = "";
            Console.Write("Escreve o teu nome bro: ");
            nome = Console.ReadLine();
            Console.WriteLine("O teu nome é:");
            Console.WriteLine(nome);

            int numeroFds = 40 + 69;
            Console.WriteLine(numeroFds);
            int numeroMult = 10;
            Console.WriteLine(numeroFds * numeroMult);
            //6 / 2 => 3 //int
            //5 / 2 => 2.5//decimal / float
            float numeroDiv = 5f / 2; 

            Console.WriteLine(numeroDiv);
            int numeroFudido = 0;
            Console.WriteLine("O Numero é: ");
            numeroFudido = int.Parse(Console.ReadLine());


            
            if (numeroFudido == 10)
            {
                Console.WriteLine("TRUE");
            
            }
            else if (numeroFudido > 5 && numeroFudido < 10) 
            {
                Console.WriteLine("Epa o numero está entre 5 e 10 bro bem fixe");
            
            }
            else if (numeroFudido < 5 || numeroFudido >10)
            {
                Console.WriteLine("Eia este n ta no meio de 5 e 10 dx");
            }
            // && significa AND e o || significa OR

            Console.WriteLine("de 0 a sla quanto lol o quanto fixolas es?");
            int barilada = int.Parse(Console.ReadLine());

            if (barilada >= 0 && barilada <= 11)
            {
                Console.WriteLine("Fixolas nao fixolas");
            }
            else if (barilada >= 12 && barilada <= 18)
            {
                Console.WriteLine("Eia Fixolas FIXOLAS");
            }
            else if (barilada >= 18)
            {
                Console.WriteLine("EPA SUPER BARIL mas n quero saber aha");
            }

            string[] jogos = new string[5] {
                "OW2","Minecraft","Roblox","GTA","Valorant"
            };
            Console.WriteLine(jogos[0]);
            for (int i = jogos.GetLowerBound(0); i <= jogos.GetUpperBound(0); i++)
                Console.WriteLine("   [{0,2}]: {1}", i, jogos[i]);

            Console.WriteLine("Escreve o numero oh padeiro:");
            int primata = int.Parse(Console.ReadLine());
            MostrarMens(primata);
            Console.ReadLine();

            Console.WriteLine("A cor é vermelho ou amarelo?");
            string cor69 =Console.ReadLine();
            switch (cor69){
                case "vermelho":
                    Console.WriteLine("A cor é vermelho");
                    break;
                case "amarelo":
                    Console.WriteLine("A cor é amarelo");
                    break;
                
            }
            Rank();
            Console.WriteLine("Escreva o numero de vezes que este vai spamar algo xD");
            
            SPAMAR();
            string[] slameu = { "cona", "pila", "cu", "pachacha", "FODASSE" };
            foreach(string slamen in slameu)
            {
                Console.WriteLine(slamen);
            }
            Console.ReadLine();
            Console.WriteLine("Escreva o numero de vezes que quer escrever algo no for xD");

            
            string[] checheche = { "UMA", "DUAS", "TRES", "QUATRO", "CINCO" };
            Console.WriteLine("Escreva agora lol");
            int contador2 = int.Parse(Console.ReadLine());
            for (contador2 = 0; contador2 < checheche.Length; contador2--)
            {
                
                Console.WriteLine(contador2);
                Console.WriteLine(checheche[contador2]);
            }

            Console.WriteLine("!!!!Enter para fechar o programa!!!!");
            Console.ReadLine();
            
        }

        static void Rank()
        {
            Console.WriteLine("0-Perfeito, 1-MuitoBom, 2-Bom, 3-Mid, 4-Mud");
            int index = int.Parse(Console.ReadLine());
            Minakaze opcao = (Minakaze)index;
            Console.WriteLine(opcao);
        }
        static int MostrarMens(int primata)
        {
            int numeroNovo = primata * primata;
            Console.WriteLine("o numero elevado a 2 é");
            Console.WriteLine(numeroNovo);
            return numeroNovo;

        }
        static void SPAMAR()
        {
            int contador = int.Parse(Console.ReadLine());
            while (contador > 0)
            {
                Console.WriteLine("SPEMAARRRRRRR");
                contador = (contador - 1);
            }
        }
        //MUITO IMPORTANTE!!!!!!!!!!!!!!!!!!!!!!!!!!
        //for (int i = strings.GetLowerBound(0); i <= strings.GetUpperBound(0); i
        //Console.WriteLine("   [{0,2}]: {1}", i, strings[i]);
        //isto mostra os objetos de um array e é um ciclo!!!!!

    }
}
