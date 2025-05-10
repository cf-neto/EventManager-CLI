using System;
using System.Collections.Generic;

using ProjetoEventos.Services;

namespace ProjetoEventos
{
    class Program
    {
        public static void Main()
        {
            var eventService = new EventService();


            while (true)
            {

                Console.Clear();  // Clear terminal

                Menu();

                Console.Write("Choose an option: ");

                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("\nEvent Name cannot be empty.\n");
                    continue;

                }

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        eventService.AddEvent();
                        break;

                    case "2":
                        Console.Clear();
                        Console.Write("\nWrite the name of event: ");
                        string name = Console.ReadLine();

                        if (string.IsNullOrEmpty(name))
                        {
                            Console.WriteLine("\nEvent Name cannot be empty.\n");
                            continue;
                        }

                        eventService.RemoveEvent(name);
                        break;

                    case "3":
                        Console.Clear();

                        eventService.ReadEvents();

                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }
            }
        }

        
        static void Menu()
        {
            Console.WriteLine("\n=-=-= Menu =-=-=");
            Console.WriteLine("1. Add Event");
            Console.WriteLine("2. Remove Event");
            Console.WriteLine("3. Read File");
            Console.WriteLine("4. Exit");
            Console.WriteLine("= = =  ==  = = =\n");
        }
    }
}