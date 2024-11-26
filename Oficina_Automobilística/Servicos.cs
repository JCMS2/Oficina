using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina_Automobilística
{   
    internal class Servicos
    {
        public static Dictionary<string, double> ListaServicos = new Dictionary<string, double>
        {
            {"Manutençao",119.99} ,{"Troca de pastilha",84.98 }
        };

        public void AddServico()
        {
            Console.WriteLine("Qual serviço vc que colocar ?");
            string servico=Console.ReadLine()!;
            Console.WriteLine("Agora digite o valor");
            double valor = double.Parse(Console.ReadLine()!);
            ListaServicos.Add(servico,valor);
            Console.WriteLine($"Serviço {servico} adicionado com sucesso");

        }
        public void RemServiço()
        {
            Console.WriteLine("Lista de serviços\n");
            foreach(var ser in ListaServicos)
            {
                Console.WriteLine($"Serviços: {ser.Key}, valor: {ser.Value}");
            }
            Console.WriteLine("Digite qual serviço vc quer remover");
            string escolha = Console.ReadLine()!;
            ListaServicos.Remove(escolha);
        }
        public  void ExibirServico()
        {
            Console.WriteLine("Lista de Serviços\n");
            foreach (var Ser in ListaServicos)
            {
                Console.WriteLine($"Serviço: {Ser.Key}, Valor: {Ser.Value}");
                
            }
        }
    }
}
