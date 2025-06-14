# Task Manager - Exemplo de Programação Orientada a Objetos em C#

Este repositório contém um projeto de console simples que demonstra o uso dos conceitos de **Programação Orientada a Objetos (POO)** em **C#**.

O projeto simula um **Gerenciador de Tarefas**, onde você pode adicionar tarefas, listá-las, executá-las e gerenciar seus status (concluída ou pendente).

---

## 📚 Descrição do Projeto

O objetivo deste projeto é servir como um estudo prático dos **princípios fundamentais da POO**, incluindo:

- ✅ **Encapsulamento**
- ✅ **Herança**
- ✅ **Polimorfismo**
- ✅ **Abstração**

O projeto aplica esses princípios por meio do gerenciamento de tarefas, permitindo a criação de tarefas simples e tarefas com prazo.

---

## 🚀 Funcionalidades

- ✔️ **Adicionar Tarefas Simples**  
  Crie tarefas básicas, sem prazo definido.

- ✔️ **Adicionar Tarefas com Prazo**  
  Crie tarefas que possuem um prazo específico.

- ✔️ **Listar Tarefas**  
  Visualize tarefas filtradas por tipo (simples, com prazo ou todas).

- ✔️ **Executar Tarefas**  
  Simula a execução das tarefas e as marca como concluídas.

- ✔️ **Verificar Status das Tarefas**  
  Veja facilmente se as tarefas estão pendentes ou concluídas.

- ✔️ **Menu Interativo no Console**  
  O sistema roda em loop com um menu simples para interação com as tarefas.

---

## 🏗️ Estrutura do Projeto

/TaskManager  
│  
├── Program.cs → Menu do console e interação com o usuário  
├── TaskManager.cs → Gerencia a lista de tarefas (adicionar, listar, executar)  
│  
├── Tasks/  
│ ├── Task.cs → Classe abstrata (tarefa base)  
│ ├── SimpleTask.cs → Herda de Task (tarefa simples)  
│ └── DeadlineTask.cs → Herda de Task (tarefa com prazo)  
│  
└── README.md → Documentação  

---

## 🧠 Objetivos de Aprendizado

Este projeto tem como objetivo te ajudar a:

- Entender como implementar classes abstratas e herança em C#.
- Aplicar polimorfismo através da sobrescrita de métodos.
- Trabalhar com dados encapsulados e comportamentos controlados nas classes.
- Criar código estruturado e reutilizável, seguindo as boas práticas da POO.

---

# 🛠️ Tecnologias Utilizadas

- **Linguagem:** C#  
- **Framework:** .NET 8  
- **IDE:** Visual Studio ou Visual Studio Code  
- **Tipo de Projeto:** Aplicação de Console  

---

## 💻 Como Executar

1. **Clone este repositório:**

```bash
git clone https://github.com/gabyfachini/TaskManager.git

2. Abra o projeto no Visual Studio ou Visual Studio Code.

3. Restaure as dependências (se necessário) e compile o projeto.

4. Execute a aplicação.
    Um menu aparecerá no terminal, permitindo que você:
        Adicione tarefas
        Liste tarefas
        Execute tarefas
        Encerre o programa