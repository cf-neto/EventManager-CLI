using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEventos.Models
{
    public class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public static string FilePath = "Events.csv";
        public Event(string name,  DateTime date, string address)
        {
            Name = name;
            Date = date;
            Address = address;
        }

    }
}
