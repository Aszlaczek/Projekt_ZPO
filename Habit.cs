using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Projekt_AWzorek_167366
{

    abstract class AbsHabit
    {
        public string name { get; set; }
        public bool isDone { get; set; }

    }
    class Habit : AbsHabit, IDescription
    {
        private DateTime startDate { get; set; }
        public string Description { get => Description; set => Description = value; }

        public Habit(string name)
        {
            this.name = name;
            this.isDone = false;
            this.startDate = new DateTime();
        }

        public void SetStartDate(DateTime date)
        {
            this.startDate = date;
        }

        public void ToggleDone()
        {
            this.isDone = !this.isDone;
        }

    }
}
