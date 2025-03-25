/* ******************************************************************* 
Colegio Técnico Antônio Teixeira Fernandes (Univap) 
Curso Técnico em Informática - Data de Entrega: 25/03/2025 
Autores do Projeto: Heitor Pinheiro de Souza
                    Davi Dancuart Cavalcante
Turma: 2°I
Atividade Proposta em aula 
Observação:  
projetopvb1bi.cs 
************************************************************/
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa Fábrica de brinquedos");
            while (true)
            {
                Console.WriteLine("Digite o tipo de brinquedo (carrinho ou boneca, digite em letra minúscula):");
                string tipo = Console.ReadLine();
                if (tipo == "carrinho" || tipo == "Carrinho")
                {
                    Console.WriteLine("Digite um número para o cálculo do fatorial:");
                    int num = int.Parse(Console.ReadLine());
                    while (num <= 0)
                    {
                        Console.WriteLine("Erro, digite um número acima de 0");
                        num = int.Parse(Console.ReadLine());
                    }
                    int result = 1;
                    for (int i = 2; i <= num; i++)
                    {
                        result *= i;
                    }
                    Console.WriteLine("O número de rodas necessárias para o carrinho é: " + result);
                }
                else if (tipo == "boneca" || tipo == "Boneca")
                {
                    Console.WriteLine("Digite o número para fatoração:");
                    int num = int.Parse(Console.ReadLine());
                    while (num <= 0)
                    {
                        Console.WriteLine("Erro, digite um número acima de 0");
                        num = int.Parse(Console.ReadLine());
                    }
                    string resultadoFatores = "Os fatores primos são: ";
                    int div = 2;
                    bool primeiro = true;
                    while (num > 1)
                    {
                        if (num % div == 0)
                        {
                            if (!primeiro)
                            {
                                resultadoFatores += ", ";
                            }
                            resultadoFatores += div;
                            num /= div;
                            primeiro = false;
                        }
                        else
                        {
                            div++;
                        }
                    }
                    Console.WriteLine(resultadoFatores);
                }
                else
                {
                    Console.WriteLine("Erro, não existe essa opção. Digite novamente.");
                    continue;
                }
                string sn;
                do
                {
                    Console.Write("Deseja continuar? (s/n): ");
                    sn = Console.ReadLine();
                    if (sn != "s" && sn != "S" && sn != "n" && sn != "N")
                    {
                        Console.WriteLine("Erro, opção inválida. Digite 's' ou 'n'.");
                    }
                } while (sn != "s" && sn != "S" && sn != "n" && sn != "N");
                if (sn == "n" || sn == "N")
                {
                    break;
                }
            }
        }
    }
}