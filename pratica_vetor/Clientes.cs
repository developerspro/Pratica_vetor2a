using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratica_vetor
{
    class Cliente
    {

        public Cliente[] cli;
        public string nome;
        public int idade;
        public string cpf;
        public string rg;
        public bool prioridade;
        public int quantidadeFila = 0;
        public int prioridades = 0;




        public Cliente(string nome = "", int idade = 0, string cpf = "", string rg = "", bool prioridade = false)
        {
            cli = new Cliente[10];
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
            this.rg = rg;
            this.prioridade = prioridade;
        }


        public void inserirCliente()

        {
            if (quantidadeFila < 10)
            {
                Console.WriteLine("Digite o seu nome:");
                nome = Console.ReadLine();
                Console.WriteLine("Digite a sua idade:");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o seu CPF");
                cpf = Console.ReadLine();
                Console.WriteLine("Digite o seu RG");
                rg = Console.ReadLine();
                Cliente cliente = new Cliente(nome, idade, cpf, rg);
                cli[quantidadeFila] = cliente;
                quantidadeFila++;
                Console.WriteLine("\nCliente cadastrado com sucesso!\n" +
                                  "\n\t\t\t\t\t\tAperte qualquer tecla para voltar\n");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Fila Cheia:");
            }

        }
        public void listarCliente()
        {
            if (quantidadeFila > 0)
            {
                for (int i = 0; i < cli.Length; i++)
                {
                    if (cli[i] != null)
                    {
                        Console.WriteLine($"\nCliente {i + 1}");
                        Console.WriteLine($"Nome:{cli[i].nome}");
                        Console.WriteLine($"Idade:{cli[i].idade}");
                        Console.WriteLine($"CPF:{cli[i].cpf}");
                        Console.WriteLine($"RG:{cli[i].rg}");
                        Console.WriteLine($"Prioridade:{cli[i].prioridade}\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("Fila Vazia");
            }
            Console.ReadKey();
        }
        public void incluirPrioritario()
        {
            if (quantidadeFila < 10)
            {
                Console.WriteLine("Digite o seu nome:");
                nome = Console.ReadLine();
                Console.WriteLine("Digite a sua idade:");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o seu CPF");
                cpf = Console.ReadLine();
                Console.WriteLine("Digite o seu RG");
                rg = Console.ReadLine();
                Cliente clientePrioritario = new Cliente(nome, idade, cpf, rg, true);

                for (int i = quantidadeFila - 1; i >= prioridades; i--)
                {
                    cli[i + 1] = cli[i];
                }
                cli[prioridades] = clientePrioritario;
                prioridades++;
                quantidadeFila++;
            }
            Console.WriteLine("\nCliente com prioridade cadastrado com sucesso!\n" +
                              "\n\t\t\t\t\tAperte qualquer tecla para voltar\n" +
                              "\t\t\t\t\t\t\tou\n" +
                              "\t\t\t\t\t\tAperte 'q' para sair\n");
            Console.ReadKey();
        }

        public void AtenderCliente()
        {
            Cliente clienteAtendido = cli[0];

            if (quantidadeFila > 0)
            {
                for (int i = 1; i < quantidadeFila; i++)
                {
                    cli[i - 1] = cli[i];
                }
                cli[quantidadeFila - 1] = null;
                quantidadeFila--;

                Console.WriteLine($"O Cliente {clienteAtendido.nome} foi atendido com sucesso");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Não ha Clientes para serem atendidos");
                Console.ReadKey();
            }
        }
    }
}
