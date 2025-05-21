using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Projekt_AWzorek_167366
{
    class HabitList
    {
        private List<Habit> habits;
        public HabitList()
        {
            habits = new List<Habit>();
        }

        public void ReadFromFile(string filePath)
        {
            // Read from file and deserialize to List<Habit>
            string json = File.ReadAllText(filePath);
            habits = JsonSerializer.Deserialize<List<Habit>>(json);
        }

        public void WriteToFile(string filePath)
        {
            // Serialize List<Habit> to JSON and write to file
            string json = JsonSerializer.Serialize(habits);
            File.WriteAllText(filePath, json);
        }
    }
}
