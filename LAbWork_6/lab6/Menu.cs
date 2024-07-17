using System;

namespace lab6
{ 
        internal class Menu
        {
            private string labNumber;
            private string taskNumber;
            private string variantNumber;
            private string taskDescription;
            private string studentName;
            private string studentGroup;

            public Menu(string labNumber, string taskNumber, string variantNumber, string taskDescription, string studentName, string studentGroup)
            {
                this.labNumber = labNumber;
                this.taskNumber = taskNumber;
                this.variantNumber = variantNumber;
                this.taskDescription = taskDescription;
                this.studentName = studentName;
                this.studentGroup = studentGroup;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Лабораторная работа №{labNumber}");
                Console.WriteLine($"Задание №{taskNumber}");
                Console.WriteLine($"Вариант №{variantNumber}");
                Console.WriteLine($"Описание: {taskDescription}");
                Console.WriteLine($"Выполнил студент: {studentName}");
                Console.WriteLine($"Группа: {studentGroup}");
            }

            public static void MainMenu()
            {
                Console.WriteLine("\nГлавное меню:");
                Console.WriteLine("1. Выбрать бананы");
                Console.WriteLine("2. Выбрать манго");
                Console.WriteLine("3. Выбрать апельсины");
                Console.WriteLine("4. Показать информацию о бананах");
                Console.WriteLine("5. Показать информацию о манго");
                Console.WriteLine("6. Показать информацию об апельсинах");
                Console.WriteLine("7. Продемонстрировать вызов конструктора родительского класса при наследовании (на примере бананов)");
                Console.WriteLine("8. Выход");
            }
        }
    }
