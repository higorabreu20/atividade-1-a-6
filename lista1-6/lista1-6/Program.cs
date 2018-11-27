using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1_6
{
 
        
     class Program
        {

            //Questao conta poupança
            public class Cliente
            {
                private int saldo;
                private int conta;
                private int totalCobrancas;
                private int totalCredito;
                private int limiteCredito;

                public Cliente(int saldo, int conta, int cobrancas, int credito, int limite)
                {
                    this.saldo = saldo;
                    this.conta = conta;
                    this.totalCobrancas = cobrancas;
                    this.totalCredito = credito;
                    this.limiteCredito = limite;
                }
                public int CalcularNovoSaldo()
                {
                    return this.saldo + this.totalCobrancas - this.totalCredito;
                }

                public void AtualizarSaldo()
                {
                    this.saldo = CalcularNovoSaldo();
                }

                public bool UltrapassouLimite()
                {
                    return this.saldo > this.limiteCredito;
                }
            }
            static void Main(string[] args)
            {

            //Questão 1 

           
            //Questão 2
            Console.WriteLine("Digite o saldo atual ");
                int saldo = int.Parse(Console.ReadLine());

                Cliente c = new Cliente(saldo, 2, 300, 400, 2000);
                Console.WriteLine("O seu novo saldo é ");
                Console.WriteLine(c.CalcularNovoSaldo());

                c.AtualizarSaldo();
                Console.ReadKey();
                if (c.UltrapassouLimite())
                {
                    Console.WriteLine("Limite de Credito Excedido.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Ainda há crédito disponivel.");
                    Console.ReadKey();
                }

                // Fim da Questão 2 



                //Questão 3 
                Console.WriteLine("\n");
                int a = 0;
                Console.WriteLine("Digite um Numero");
                a = Convert.ToInt32(Console.ReadLine());
                if (a % 2 == 0)
                {
                    Console.WriteLine("O numero " + a + " é par");
                }
                else
                {
                    Console.WriteLine("O numero " + a + " é impar");

                }

                Console.ReadKey();

            //Fim da Questão 

                //Questão 4
                Console.WriteLine("\n");
                int n1, n2, n3;

                Console.Write("Informe um lado para o Triângulo:");
                n1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe um segundo lado para o Triângulo:");
                n2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe um terceiro lado para o Triângulo:");
                n3 = Convert.ToInt32(Console.ReadLine());


                if (n1 == n2 && n1 == n3 && n2 == n3)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }

                else if (n1 != n2 && n1 != n3 && n2 != n3)
                {
                    Console.WriteLine("TRIANGULO ESCALENO");
                }

                else
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }

                Console.ReadKey();
            //Fim da Questão 4 

                //Questão 5

                char letra;
                bool vogal = false;

                string[] vogais = new string[] { "a", "e", "i", "o", "u" };

                Console.Write("Informe uma letra: ");
                char.TryParse(Console.ReadLine(), out letra);

                for (int i = 0; i < vogais.Length; i++)
                {
                    if (vogais[i] == letra.ToString())
                    {
                        vogal = true;
                    }
                }
                if (vogal)
                {
                    Console.WriteLine("VOGAL.");
                }
                else
                {
                    Console.WriteLine("CONSOANTE.");
                }
                //Fim da Questão 5 

                //Questão 6 
                Console.WriteLine("\n");
                int n = 0, cont = 0;
                Console.WriteLine("Informe um número");
                n = Convert.ToInt32(Console.ReadLine());
                for (int i = n; i > 0; i--)
                {
                    if (n % i == 0)
                    {
                        cont++;
                    }
                }
                if (cont == 2)
                {
                    Console.WriteLine("O numero " + n + " é primo");
                }
                else
                {
                    Console.WriteLine("O numero " + n + " não é primo");
                }
                Console.ReadKey();

            } // Fim da Questão 6 
        }
    }

