using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Oficina_Automobilística
{
    internal class Orcamento
    {
        Dictionary<string,double> Orcamen = new Dictionary<string,double>();
        
        public void ExibirOracamento()
        {
            
            foreach (var i in Servicos.ListaServicos)
            {
                Console.WriteLine($"Serviço: {i.Key}, Valor:{i.Value}");
            }
            while (true)
            {
                
                Console.WriteLine("Digite sua escolha ou digite ok para parar");
                string escolha = Console.ReadLine()!;
                if (escolha=="ok")
                {
                    break;
                }
                if (Servicos.ListaServicos.ContainsKey(escolha))
                {
                    Orcamen.Add(escolha, Servicos.ListaServicos[escolha]);
                    Console.WriteLine($"Serviço {escolha} adicionado no orçamento");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Serviço nao disponivel\n");
                    ExibirOracamento();
                }
                Console.Clear();
                foreach (var i in Servicos.ListaServicos)
                {
                    Console.WriteLine($"Serviço: {i.Key}, Valor:{i.Value}");
                }
                double total = 0;
                foreach (var i in Orcamen)
                {
                    Console.WriteLine("\nLista do Orçamento\n");
                    Console.WriteLine($"Serviço: {i.Key}, Valor: {i.Value:c}");
                    total += i.Value;
                }
                Console.WriteLine($"Total: {total}");
            }
           
        }
    }
}
