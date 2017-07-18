using System;
using System.Collections.Generic;

namespace forest_animals
{
    public class Forest
    {
        public string Name { get; set; }

        public string Location { get; set; }

        List<Animals> Animals { get; set; } = new List<Animals>();

        public Forest(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public void AddAnimal(Animals newAnimal)
        {
            Animals.Add(newAnimal);
        }

        public void ListAnimals()
        {
            foreach (var animal in Animals)
            {
                Console.WriteLine($"{animal.Name} of {Name} in {Location} has fur of {animal.Fur} and {animal.LegAmount} many legs! ");
            }
        }



    }
}