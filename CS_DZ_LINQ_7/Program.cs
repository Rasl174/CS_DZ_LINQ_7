using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_LINQ_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Soldier> soldiers1 = new List<Soldier> { new Soldier("Балабанов", "Олег"), new Soldier("Алексеев", "Антон"), 
                new Soldier("Егоров", "Егор"), new Soldier("Бритых", "Игорь")};

            List<Soldier> soldiers2 = new List<Soldier> { new Soldier("Игнатьев", "Роман"), new Soldier("Мытых", "Артем"), 
                new Soldier("Калашников", "Калаш"), new Soldier("Летчиков", "Валентин")};

            var filteredSoldiers = soldiers1.Where(soldier => soldier.LastName.StartsWith("Б"));
            soldiers2 = filteredSoldiers.Union(soldiers2).ToList();
            soldiers1 = soldiers1.Except(filteredSoldiers).ToList();

            Console.WriteLine("Новый список отряда 2: ");

            foreach (var soldier in soldiers2)
            {
                Console.WriteLine(soldier.LastName + " " + soldier.Name);
            }
        }
    }

    class Soldier
    {
        public string LastName { get; private set; }

        public string Name { get; private set; }

        public Soldier(string lastName, string name)
        {
            LastName = lastName;
            Name = name;
        }
    }
}
