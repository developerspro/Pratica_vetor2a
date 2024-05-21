using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratica_vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente = new Cliente();
            string opcao = "a";
            while (opcao.ToLower() != "q")
            {
                Console.Clear();
                Console.WriteLine("1. Cadastrar clientes\n" +
                "2. Mostrar fila\n" +
                "3. Adicionar Cliente com Prioridade\n" +
                "4. Atender cliente\nDigite  a Letra 'q' para sair.");

                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        cliente.inserirCliente();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        cliente.listarCliente();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        cliente.incluirPrioritario();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        cliente.AtenderCliente();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida");
                        break;
                }
            }
        }
    }
}
