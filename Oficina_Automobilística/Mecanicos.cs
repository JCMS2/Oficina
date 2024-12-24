using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Oficina_Automobilística
{
    internal class Mecanicos
    {
        public static Dictionary<string, bool> Mecanico = new Dictionary<string, bool>
        {
            { "Seu Zé da roda",true }, {"Tucano",true }

        };

        public void AddMecanico()
        {
            bool disponivel;
            Console.WriteLine("Digite o seu nome");
            string nome= Console.ReadLine()!;
            Console.WriteLine("voce esta disponivel?");
            string escolha = Console.ReadLine()!;
            if (escolha=="sim")
            {
                disponivel = true;
            }else if (escolha=="nao" || escolha=="não")
            {
                disponivel= false;
            }
            else
            {
                Console.WriteLine("Nao disponivel");
                disponivel = false;
            }
            
            Mecanico.Add(nome, disponivel);
            Console.WriteLine("Lista atualizada");
        }
        public void ExibirMecanico()
        {
            Console.WriteLine("Lista de mecanicos:");
            foreach (var mec in Mecanico)
            {
                Console.WriteLine($"Mecanico: {mec.Key}, Disponivel : {(mec.Value? "Sim": "Não")}");
            }
        }
        public void RemMecanico()
        {
            Console.WriteLine("Lista de mecanicos\n");
            foreach (var mec in Mecanico)
            {
                Console.WriteLine($"Mecanico: {mec.Key}, Disponivel {(mec.Value? "Sim": "Não")}");
            }
            Console.WriteLine("Digite o mecanico que quer remover: ");
            string escolha = Console.ReadLine()!;
            Mecanico.Remove(escolha);
            Console.WriteLine("Lista Atualizada");
        }
        public void AtribuirTrabalho()
        {
            Console.WriteLine("Lista de mecanicos: \n");
            foreach (var me in Mecanico)
            {
                Console.WriteLine($"Mecanico:{me.Key}, Disponivel:{(me.Value? "Sim":"Não")}");
            }
            Console.WriteLine("Digite o nome do mecanico que quer que comece a trabalhar");
            string escolha = Console.ReadLine()!;
            if (Mecanico.ContainsKey(escolha) && Mecanico[escolha] ==true)
            {
                Mecanico[escolha] = false;
                foreach (var e in Mecanico)
                {
                    Console.WriteLine($"Mecanico: {e.Key}, Disponivel: {(e.Value? "Sim":"Não")}");
                }
                
            }
            else
            {
                Console.WriteLine("esse mecanico nao existe ou ja esta trabalhando");
            }
        }
        public void AtivarMecanico()
        {
            foreach (var i in Mecanico)
            {
                Console.WriteLine($"Mecanico: {i.Key}, Disponivel: {(i.Value? "Sim": "Não")}");
            }
            Console.WriteLine("Diga qual mecanico voltando ao trabalho");
            string escolha= Console.ReadLine()!;
            if (Mecanico.ContainsKey(escolha))
            {
                
                if (Mecanico[escolha])
                {
                    Console.WriteLine("O mecanico ja esta ativo nao é possivel ser ativado novamente");
                }
                else
                {
                    Mecanico[escolha]=true;
                    Console.WriteLine($"O mecanico {escolha}, esta ativo");
                }
            }
            else
            {
                Console.WriteLine("esse mecanico nao existe");
            }
            
        }
    }
}
