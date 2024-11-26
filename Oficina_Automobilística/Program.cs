using Oficina_Automobilística;
Servicos s = new Servicos(); Mecanicos m = new Mecanicos(); Orcamento o= new Orcamento();
Cliente c=new Cliente("João Paulo","2646465456"); Veiculos v=new Veiculos();
void Inicio() {
    Console.WriteLine("Bem vindo(a) a Oficiona do Zezim\n");
    Console.WriteLine("Escolha alguma das opçoes a seguir");
    Console.WriteLine("1-tudo relacionado a Serviços");
    Console.WriteLine("2-tudo relacionado a clientes");
    Console.WriteLine("3-tudo relacionado a mecanico");
    Console.WriteLine("4-tudo relacionado a carro");
    Console.WriteLine("5-Fazer Orçamento");
    Console.WriteLine("0- para sair");
    int Escolha = int.Parse(Console.ReadLine()!);
    switch (Escolha)
    {
        case 1:Console.Clear();
            Console.WriteLine("1-Ver lista de Serviços");
            Console.WriteLine("2-Adicionar Serviço");
            Console.WriteLine("3-Remover Serviço");
            Console.WriteLine("4-para voltar para o menu");
            int escolha1 = int.Parse(Console.ReadLine()!);
            switch(escolha1){
                case 1:
                    Console.Clear();
                    s.ExibirServico();
                    VoltarInicio();
                    break;
                case 2:
                    Console.Clear();
                    s.AddServico();
                    VoltarInicio();
                    break;
                case 3:
                    Console.Clear();
                    s.RemServiço();
                    VoltarInicio();
                    break;
                case 4: Console.Clear();
                    VoltarInicio();
                    break;

            }
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("1-Lista de clientes");
            Console.WriteLine("2-Adicionar clientes");
            Console.WriteLine("3-Remover cliente");
            Console.WriteLine("4-para voltar para o menu");
            int escolha2 = int.Parse(Console.ReadLine()!);
            switch (escolha2)
            {
                case 1:
                    Console.Clear();
                    c.ExibirClientes();
                    VoltarInicio();
                    break;
                case 2:
                    Console.Clear();
                    c.addClientes();
                    VoltarInicio();
                    break;
                case 3:
                    Console.Clear();
                    c.RemCliente();
                    VoltarInicio();
                    break;
                case 4: Console.Clear();
                    VoltarInicio();
                    break;
            }
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("1-Exibir mecanico");
            Console.WriteLine("2-Adicionar mecanico");
            Console.WriteLine("3-Remover mecanico");
            Console.WriteLine("4- Ativar mecanico");
            Console.WriteLine("5-voltar ao menu");
            int escolha3 = int.Parse(Console.ReadLine()!);
            switch (escolha3)
            {
                case 1:
                    Console.Clear();
                    m.ExibirMecanico();
                    VoltarInicio();
                    break;
                case 2:
                    Console.Clear();
                    m.AddMecanico();
                    VoltarInicio();
                    break;
                case 3:
                    Console.Clear();
                    m.RemMecanico();
                    VoltarInicio();
                    break;
                case 4:
                    Console.Clear();
                    m.AtivarMecanico();
                    VoltarInicio();
                    break;
                case 5: Console.Clear();
                    VoltarInicio();
                    break;
            }
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("1-Exibir carro");
            Console.WriteLine("2-Adicionar carro");
            Console.WriteLine("3-Remover carro");
            Console.WriteLine("4-Voltar ao menu");
            int escolha4 = int.Parse(Console.ReadLine()!);
            switch (escolha4)
            {
                case 1:
                    Console.Clear();
                    v.ExibirCarro();
                    VoltarInicio();
                    break;
                case 2:
                    Console.Clear();
                    v.AddCarro();
                    VoltarInicio();
                    break;
                case 3:
                    Console.Clear();
                    v.RemVeiculo();
                    VoltarInicio();
                    break;
                case 4:
                    Console.Clear();
                    VoltarInicio();
                    break;
            }
            break;
         case 5: Console.Clear();
                o.ExibirOracamento();
            VoltarInicio(); 
            break;
        case 0:
            Console.Clear();
            Console.WriteLine("xau xau");
            break;
        default:
            Console.Clear();
            Console.WriteLine("Opçao invalida");
            VoltarInicio();
            break;
    }
}
void VoltarInicio()
{
    Thread.Sleep(200);
    Console.WriteLine("Digite qualquer tecla para voltar ao inicio");
    Console.ReadKey();
    Console.Clear();
    Inicio();
}
Inicio();
