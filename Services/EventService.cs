using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using ProjetoEventos.Models;

namespace ProjetoEventos.Services
{
    public class EventService
    {
        private List<Event> events = new List<Event>();

        public void AddEvent()
        {
            // Get event Name
            Console.Write("\nEvent Name: ");
            string name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.Write("Event Name cannot be empty. Please enter a valid name: ");
                name = Console.ReadLine();
            }

            // Get event Date
            DateTime date = DateTime.MinValue;
            bool validDate = false;
            while (!validDate)
            {
                Console.Write("\nEvent Date (MM-dd-yyyy): ");
                string dateInput = Console.ReadLine();

                if (DateTime.TryParseExact(dateInput, "MM-dd-yyyy", null, System.Globalization.DateTimeStyles.None, out date))
                {
                    validDate = true;
                }

                else
                {
                    Console.WriteLine("Invalid Date!");
                }
            }

            // Get event address
            Console.Write("\nEvent Address: ");
            string address = Console.ReadLine();
            while (string.IsNullOrEmpty(address))
            {
                Console.Write("Event Address cannot be empty. Please enter a valid address: ");
                address = Console.ReadLine();
            }


            // Create a new Event
            Event newEvent = new Event(name, date, address);
            events.Add(newEvent);
            Console.WriteLine("\n- Event added successfully\n\n");

            // Fail First
            if (!File.Exists(Event.FilePath))
            {
                using (StreamWriter sw = new StreamWriter(Event.FilePath))
                {
                    sw.WriteLine("Name,Date,Address");
                }
            }

            using (StreamWriter sw = new StreamWriter(Event.FilePath, append: true))
            {
                sw.WriteLine($"{newEvent.Name},{newEvent.Date:MM-dd-yyyy},{newEvent.Address}");
            }

        }

        public void RemoveEvent(string name)
        {
            Event eventToRemove = events.FirstOrDefault(e => e.Name == name);

            if (eventToRemove == null)
            {
                Console.WriteLine("- Event not found");
                return;
            }

            events.Remove(eventToRemove);
            Console.WriteLine("- Event removed successfully");


            using (StreamWriter sw = new StreamWriter(Event.FilePath, false))
            {
                sw.WriteLine("Name,Date,Address");
                foreach (var e in events)
                {
                    sw.WriteLine($"{e.Name},{e.Date:MM-dd-yyyy},{e.Address}");
                }
            }
        }

        public void ReadEvents()
        {

            if (!File.Exists(Event.FilePath))
            {
                Console.WriteLine("-> File not found.");
                return;
            }
            // Console.WriteLine("Reading file...");
            events.Clear();

            using (StreamReader sr = new StreamReader(Event.FilePath))
            {
                string line;
                bool isFirstLine = true;

                while ((line = sr.ReadLine()) != null)
                {
                    if (isFirstLine)
                    {
                        isFirstLine = false;
                        continue;
                    }

                    var parts = line.Split(',');

                    if (parts.Length == 3)
                    {
                        string name = parts[0];
                        DateTime date = DateTime.ParseExact(parts[1], "MM-dd-yyyy", null);
                        string address = parts[2];

                        Event e = new Event(name, date, address);
                        events.Add(e);
                    }
                }
            }

            Console.WriteLine("\n== Events ==\n");

            for (int i = 0; i < events.Count(); i++)
            {
                Console.WriteLine($"{i+1} | {events[i].Name}, {events[i].Date:MM-dd-yyyy}, {events[i].Address}");
            }


            Console.WriteLine("\n\n");
        }
    }
}
