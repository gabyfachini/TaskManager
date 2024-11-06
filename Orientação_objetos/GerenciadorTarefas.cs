using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientação_objetos
{
    internal class GerenciadorTarefas
    {
        private List<Tarefa> tarefas = new List<Tarefa>(); //armazena diversos valores de mesmo tipo
        public List<Tarefa> Tarefas => tarefas;

        public void AdicionarTarefa(Tarefa tarefa)
        {
            tarefas.Add(tarefa);
            Console.WriteLine("Tarefa adicionada com sucesso!");
        }
        public void ListarTarefas(string tipo)
        {
            if (!tarefas.Any())
            {
                Console.WriteLine("Não há tarefas listadas!");
                return;
            }
            foreach (var tarefa in tarefas)
            {
                if (tipo == "1" && tarefa is TarefaSimples)
                {
                    Console.WriteLine(tarefa);
                }
                else if (tipo == "2" && tarefa is TarefaComPrazo)
                {
                    Console.WriteLine(tarefa);
                }
                else if (tipo == "3")
                {
                    // Para listar ambas as tarefas, não há necessidade de filtro
                    Console.WriteLine(tarefa);
                }
            }
        }
            public void ConcluirTarefas(int indice)
            {
                if (indice >= 0 && indice < tarefas.Count)
                {
                    tarefas[indice].Executar();
                    Console.WriteLine("Tarefa Concluída!");
                } else
                {
                    Console.WriteLine("Índice inválido!");
                }
            }
        }
    } //comentario
