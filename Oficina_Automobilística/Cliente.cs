using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Oficina_Automobilística
{
    internal class Cliente
    {
       public static Dictionary<string, string> Clientes = new Dictionary<string, string>
        {
            {"José Carlos","81984766559" },
            {"Maria Fernanda", "819464654654" }
        };
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Cliente(string nome,string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public void addClientes()
        {
            Console.WriteLine("Digite o seu nome");
            string nome= Console.ReadLine()!;
            Console.WriteLine("Digite o seu numero");
            string telefone=Console.ReadLine()!;
            Clientes.Add(nome,telefone);
            Console.WriteLine("Cliente cadastrado com sucesso");
        }
        public void RemCliente()
        {
            Console.WriteLine("Lista de Cliente\n");
            foreach (var cli in Clientes)
            {
                Console.WriteLine($"Cliente: {cli.Key}, telefone: {cli.Value}");
            }
            string escolha = Console.ReadLine()!;
            Clientes.Remove(escolha);
        }
        public void ExibirClientes()
        {
            Console.WriteLine("Lista de Cliente\n");
            foreach (var cli in Clientes)
            {
                Console.WriteLine($"Cliente: {cli.Key}, telefone: {cli.Value}");
            }
        }
    }
}
