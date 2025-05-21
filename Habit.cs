using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Projekt_AWzorek_167366
{
    class Habit
    {
        private string name { get; set; }
        private string description { get; set; }
        private bool isDone { get; set; }
        private DateTime startDate { get; set; }
        public Habit(string name, string description, int frequency, bool isDone)
        {
            this.name = name;
            this.description = description;
            this.isDone = false;
            this.startDate = new DateTime();
        }

    }
}
