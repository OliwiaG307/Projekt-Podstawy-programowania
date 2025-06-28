using System;
using System.Collections.Generic

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            static List<string> tasks = new List<string>();     // lista opisów zadań
            static List<bool> completed = new List<bool>();     // równoległa lista statusów (false = nieukończone, true = ukończone)

            static void Main(string[] args)
            {
                bool exit = false;
                while (!exit)
                {
                    // Wyświetlenie menu
                    Console.WriteLine("==== MENU ====");
                    Console.WriteLine("1. Dodaj nowe zadanie");
                    Console.WriteLine("2. Wyświetl listę zadań");
                    Console.WriteLine("3. Oznacz zadanie jako ukończone");
                    Console.WriteLine("4. Usuń zadanie");
                    Console.WriteLine("5. Zakończ program");
                    Console.WriteLine("Wybierz opcję (1-5):");

                    string choice = Console.ReadLine();
                    Console.WriteLine(); // pusta linia dla czytelności

                    switch (choice)
                    {
                        case "1":
                            AddTask();
                            break;
                        case "2":
                            ListTasks();
                            break;
                        case "3":
                            CompleteTask();
                            break;
                        case "4":
                            RemoveTask();
                            break;
                        case "5":
                            Console.WriteLine("Koniec działania programu.");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Nieprawidłowy wybór, spróbuj ponownie.");
                            break;

                    }
                }
            }

            static void AddTask()
            {
                // TODO: implementacja dodawania zadania
                Console.Write("Podaj opis nowego zadania: ");
                string newTask Console.ReadLine();
                if (string.IsNullOrwhiteSpace(newTask))
                {
                    Console.WriteLine("Opis zadania nie może być pusty. Przerwano dodawanie.");
                    return;
                }
                tasks.Add(newTask);
                completed.Add(false);
                Console.WriteLine($"Dodano zadanie: {newTask}");
            }


            static void ListTasks()
            {
                // TODO: implementacja wyświetlania zadań
                
                if (tasks.Count == 0)
                {
                    Console.WriteLine("Lista zadań jest pusta.");
                }
                else
                {
                    Console.WriteLine("Lista zdań:");
                    for (int i = 0; i < tasks.Count; int++)
                    {
                        string status = completed[i] ? "[X]" : "[ ]";
                        Console.WriteLine($"{i + 1}. {status} {tasks[i]}");
                    }
                }
            
            }

            static void CompleteTask()
            {
                // TODO: implementacja oznaczania ukończenia zadania
                if (tasks.Count == 0)
                {
                    Console.WriteLine("Brak zadań na liście. Nie ma czego oznaczać jako ukończone.");
                    return;
                }

                // Wyświetlamy listę zadań, aby użytkownik widział numerację
                Console.WriteLine("Które zadanie oznaczyć jako ukończone? Wybierz numer:");
                for (int i = 0; i < tasks.Count; i++)
                {
                    string status = completed[i] ? "[X]" : "[ ]";
                    Console.WriteLine($"{i + 1}. {status} {tasks[i]}");
                }
                // Pobieramy numer od użytkownika
                Console.Write("Numer zadania: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int taskNumber))
                {
                    Console.WriteLine("Wprowadzono nieprawidłowy numer.");
                    return;
                }

                // Konwertujemy numer (1-based) na indeks (0-based)
                int index = taskNumber - 1;
                if (index < 0 || index >= tasks.Count)
                {
                    Console.WriteLine("Zadanie o podanym numerze nie istnieje.");
                    return;
                }

                if (completed[index])
                {
                    Console.WriteLine($"Zadanie \"{tasks[index]}\" było już oznaczone jako ukończone.");
                }
                else
                {
                    completed[index] = true;
                    Console.WriteLine($"Zadanie \"{tasks[index]}\" oznaczono jako ukończone!");
                }
            }


        }

        static void RemoveTask()
            {
                // TODO: implementacja usuwania zadania
                Console.WriteLine("[Usuwanie zadania - funkcja w trakcie implementacji]");
            }

        }
    }

