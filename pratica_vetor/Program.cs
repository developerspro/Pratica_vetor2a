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
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string opcao = "a";
            while (opcao.ToLower() != "q")
            {

            Console.WriteLine("1. Cadastrar clientes\n" +
                "2. Mostrar fila\n" +
                "3. Adicionar Cliente com Prioridade\n" +
                "4. Atender cliente\nDigite  a Letra 'q' para sair.");

        opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    cliente.inserirCliente();
                    break;
                case "2":
                    cliente.listarCliente();
                    break;
                case "3":
                    cliente.incluirPrioritario();
                    break;
                case "4":
                        cliente.AtenderCliente();
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
            }
        }
    }
}
    