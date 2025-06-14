# Task Manager - Object-Oriented Programming Example in C#

This repository contains a simple console project that demonstrates the use of **Object-Oriented Programming (OOP)** concepts in **C#**. 

The project simulates a **Task Manager**, where you can add tasks, list them, execute them, and manage their status (completed or pending).

---

## 📚 Project Description

The purpose of this project is to serve as a practical study of the **fundamental principles of OOP**, including:

- ✅ **Encapsulation**
- ✅ **Inheritance**
- ✅ **Polymorphism**
- ✅ **Abstraction**

The project applies these principles through task management, allowing you to create both simple tasks and tasks with deadlines.

---

## 🚀 Features

- ✔️ **Add Simple Tasks**  
  Create basic tasks without deadlines.

- ✔️ **Add Deadline Tasks**  
  Create tasks with a specified deadline.

- ✔️ **List Tasks**  
  View tasks filtered by type (simple, deadline, or all).

- ✔️ **Execute Tasks**  
  Simulate task execution and mark tasks as completed.

- ✔️ **View Task Status**  
  Easily check whether tasks are pending or completed.

- ✔️ **Interactive Console Menu**  
  The system runs in a loop with a simple menu to interact with tasks.

---

## 🏗️ Project Structure

/TaskManager
│
├── Program.cs → Console menu and user interaction
├── TaskManager.cs → Manages task list (add, list, execute)
│
├── Tasks/
│ ├── Task.cs → Abstract class (base task)
│ ├── SimpleTask.cs → Inherits from Task (basic task)
│ └── DeadlineTask.cs → Inherits from Task (task with deadline)
│
└── README.md → Documentation

---

## 🧠 Learning Goals

This project aims to help you:

- Understand how to implement abstract classes and inheritance in C#.
- Apply polymorphism through method overriding.
- Work with encapsulated data and controlled class behaviors.
- Create structured and reusable code using OOP best practices.

---
# 🛠️ Technologies Used

- **Language:** C#
- **Framework:** .NET 8
- **IDE:** Visual Studio or Visual Studio Code
- **Project Type:** Console Application

---

## 💻 How to Run

```bash
1. Clone the repository:

git clone https://github.com/gabyfachini/TaskManager.git

2. Open the project in Visual Studio or Visual Studio Code.

3.  dependencies (if needed) and build the project.

4. Run the application.
   A menu will appear in the terminal, allowing you to:
      Add tasks
      List tasks
      Execute tasks
      Exit the program

