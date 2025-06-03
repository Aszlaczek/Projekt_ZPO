using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Projekt_AWzorek_167366
{
    class HabitList
    {
        private List<Habit> habits;
        public HabitList()
        {
            habits = new List<Habit>();
        }

        public void ReadFromFile()
        {
            try
            {
                if (File.Exists("habits.json"))
                {
                    string json = File.ReadAllText("habits.json");
                    var loaded = JsonSerializer.Deserialize<List<Habit>>(json);
                    habits = loaded ?? new List<Habit>();
                }
                else
                {
                    habits = new List<Habit>();
                }
            }
            catch
            {
                habits = new List<Habit>();
            }
        }

        public void WriteToFile()
        {
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
            WriteToFile();
        }

        public void RemoveHabit(Habit habit)
        {
            if (habit == null || !habits.Contains(habit))
            {
                throw new ArgumentException("Habit not found in the list.");
            }
            habits.Remove(habit);
            WriteToFile();
        }

        public List<Habit> GetHabits()
        {
            return habits;
        }
    }
}