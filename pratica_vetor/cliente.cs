using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratica_vetor
{
    class cliente
    {
     
        public cliente[]cli =  new cliente[10];
        public string nome;
        public int idade;
        public string cpf;
        public string rg;
        public bool prioridade;

        public void cadastrarCliente()
        {
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade:");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu CPF");
            cpf = Console.ReadLine();
            Console.WriteLine("Digite o seu RG");
            rg = Console.ReadLine();

        }

        public cliente(string nome, int idade, string cpf, string rg, bool prioridade = false)
        {

            this.nome = nome;
            this.cpf = cpf;
            this.rg = rg;
            this.prioridade = prioridade;
        }

        public cliente()
        {
        }

        public void inserirCliente()
        {

        }
        public void listarCliente()
        {

        }
        public void incluirPrioritario()
        {

        }
    }
}
