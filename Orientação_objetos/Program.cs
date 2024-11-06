//Começar por colocar as classes do sistema
using Orientação_objetos;

GerenciadorTarefas gerenciador = new GerenciadorTarefas();

while(true) {
    Console.WriteLine();
    Console.WriteLine("1. Adicionar Tarefa Simples");
    Console.WriteLine("2. Adicionar Tarefa Prazo");
    Console.WriteLine("3. Listar Tarefas");
    Console.WriteLine("4. Executar Tarefa");
    Console.WriteLine("5. Sair");
    string opcao = Console.ReadLine();
    int indice = 0;

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite a descrição da tarefa: ");
            string descricao1 = Console.ReadLine();
            gerenciador.AdicionarTarefa(new TarefaSimples(descricao1));
            Console.ReadKey(); //Continua a execução do sistema quando digitar qualquer tecla
            Console.Clear();
            break;

        case "2":
            Console.WriteLine("Digite a descrição da tarefa: ");
            string descricao2 = Console.ReadLine();
            DateTime prazo = DateTime.Now;
            gerenciador.AdicionarTarefa(new TarefaComPrazo(descricao2,prazo));
            Console.ReadKey(); //Continua a execução do sistema quando digitar qualquer tecla
            Console.Clear();
            break;
        case "3": 
            Console.WriteLine("LISTA DE TAREFAS");
            // Opção de visualizar tarefas
            Console.WriteLine("Digite qual Tarefa deseja visualizar:");
            Console.WriteLine("1. Tarefa Simples");
            Console.WriteLine("2. Tarefa com Prazo");
            Console.WriteLine("3. As duas Opções");
            Console.WriteLine("4. Voltar ao menu inicial");
            string tipo;

            while (true)
            {
                    tipo = Console.ReadLine();

                switch (tipo)
                {
                    case "1":
                        gerenciador.ListarTarefas("1");
                        Console.Write("Digite novamente: ");
                        continue; // Continua pedindo a opção
                    case "2":
                        gerenciador.ListarTarefas("2");
                        Console.Write("Digite novamente: ");
                        continue; // Continua pedindo a opção
                    case "3":
                        gerenciador.ListarTarefas("3");
                        Console.Write("Digite novamente: ");
                        continue; // Continua pedindo a opção
                    case "4":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.Write("Digite novamente: ");
                        continue; // Continua pedindo a opção
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            break;
        case "4":     
            // Aqui, vamos concluir apenas as tarefas que existem
            for (int i = 0; i < gerenciador.Tarefas.Count; i++) // Deve ser i < indice para não exceder o número de tarefas
            {
                gerenciador.ConcluirTarefas(i);
            }
            Console.WriteLine();
            Console.WriteLine("Status das tarefas:");
            gerenciador.ListarTarefas("3"); // Supondo que este método lista as tarefas
            Console.ReadKey();
            Console.Clear();
            break;
        case "5":
            Console.WriteLine("O programa está prestes a ser encerrado.");
            return; // Finaliza o método Main, encerrando o programa
        default:
            Console.WriteLine("Opção inválida!");
            continue; // Continua pedindo a opção
    }
} 