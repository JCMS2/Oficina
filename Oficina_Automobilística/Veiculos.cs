using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Oficina_Automobilística
{
    internal class Veiculos
    {
        
        List<string>CarrosList = new List<string>()
        {
            "BMW","Ferrari"
        };

        public void ExibirCarro()
        {
            Console.WriteLine("Lista de carros");
            foreach (var item in CarrosList)
            {
                Console.WriteLine($"Carro:{item}");
            }
            
        }
        public void AddCarro()
        {

            Console.WriteLine("Qual o modelo do carro que vc quer colocar?");
            string modelo= Console.ReadLine()!;
            Console.WriteLine("Lista de clientes");
            foreach (var i in Cliente.Clientes)
            {
                Console.WriteLine($"Clientes: {i.Key}");
            }
            Console.WriteLine("Qual o nome do cliente?");
            string nomecliente = Console.ReadLine()!;
            if (!Cliente.Clientes.ContainsKey(nomecliente))
            {
                Console.WriteLine("Cliente nao cadastrado");
                return;
            }
            foreach (var i in Mecanicos.Mecanico)
            {
                Console.WriteLine($"Mecanico: {i.Key}, Disponivel: {(i.Value? "Sim":"Não")}");
            }
            Console.WriteLine("Digite qual mecanico quer que faça o serviço");
            string nomemecanico= Console.ReadLine()!;


            if (Cliente.Clientes.ContainsKey(nomecliente) && Mecanicos.Mecanico.ContainsKey(nomemecanico) && Mecanicos.Mecanico[nomemecanico]==true)
            {
                Mecanicos.Mecanico[nomemecanico]=false;
                CarrosList.Add(modelo);
                Console.WriteLine($"Carro: {modelo}, esta com o mecanico: {nomemecanico}");
            }
            else
            {
                Console.WriteLine("mecanico esta ocupado porfavor verificar se o mecanico esta disponivel");
            }
        }
        public void RemVeiculo()
        {
            foreach (var i in CarrosList)
            {
                Console.WriteLine($"Carro: {i}");
            }
            Console.WriteLine("Digite qual carro vc quer remover");
            string escolha = Console.ReadLine()!;
            CarrosList.Remove(escolha);
        }
    }
}


