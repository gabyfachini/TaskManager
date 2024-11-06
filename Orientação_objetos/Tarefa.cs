using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientação_objetos
{
    public abstract class Tarefa //abstrata porque não pode ser instanciada
    {
        public Tarefa(string descricao) {
            Descricao = descricao;
            Concluida = false;
            DataDeCriacao = DateTime.Now;
        } //Construtor, é um método que toda classe tem para iniciar a classe
        //Tudo propriedade
        public string Descricao { get; set; } //buscar e modificar o valor de algo
        public bool Concluida { get; set; } //Atríbuto específico da classe
        public DateTime DataDeCriacao { get; set; }
        public abstract void Executar(); // Método, o void é o retorno
        public void MarcarComoConcluida()
        {
            Concluida = true;
        }
        public override string ToString() //public virtual string? ToString (); Sempre será o padrão
        {
            return $"[{(Concluida ? "X" : " ")}] {Descricao} (Criada em: {DataDeCriacao})";
        }

    }
    public class TarefaSimples : Tarefa //Classe mãe e Classe filha
    {
        public TarefaSimples(string descricao) : base(descricao)
        {

        }
        public override void Executar() //quero sobreescrever algum método
        {
            Console.WriteLine($"Executando Tarefa Simples: {Descricao}");
            MarcarComoConcluida();
        }
    }
    public class TarefaComPrazo : Tarefa 
    {
        public TarefaComPrazo(string descricao,DateTime prazo) : base (descricao)
        {
            Prazo = prazo;
        }
        public DateTime Prazo { get; set; }
        public override void Executar() //Polimorfismo, dizendo que um método pode existir de diversas maneiras
        {
            Console.WriteLine($"Executando Tarefa com prazo: {Descricao} em {Prazo}");
            MarcarComoConcluida();
        }
        public override string ToString() //public virtual string? ToString (); Sempre será o padrão
        {
            return base.ToString()+$" com Prazo: {Prazo}";
        }
    }
}
