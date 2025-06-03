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
            this.ReadFromFile();
        }

        public void ReadFromFile()
        {
            // Read from file and deserialize to List<Habit>
            try
            {
            string json = File.ReadAllText("habits.json");
            habits = JsonSerializer.Deserialize<List<Habit>>(json);
            }
            catch
            {
                habits = new List<Habit>();
            }
        }

        public void WriteToFile()
        {
            // Serialize List<Habit> to JSON and write to file
            try
            {
            string json = JsonSerializer.Serialize(habits);
            File.WriteAllText("habits.json", json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }

        public void AddHabit(Habit habit)
        {
            habits.Add(habit);
        }

        public void RemoveHabit(Habit habit)
        {
            if(habit == null || !habits.Contains(habit))
            {
                throw new ArgumentException("Habit not found in the list.");
            }
            habits.Remove(habit);
        }
        public List<Habit> GetHabits()
        {
            return habits;
        }
    }
}
