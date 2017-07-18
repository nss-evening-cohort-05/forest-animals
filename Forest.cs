using System;
using System.Collections.Generic;

namespace ForestAnimals
{
    public class Forest
    {
        public string Name { get; set; }

        public string Location { get; set; }

        List<Animal> Animal { get; set; } = new List<Animal>();

        public Forest(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public void AddAnimal(Animal newAnimal)
        {
            Animal.Add(newAnimal);
        }

        public void ListAnimals()
        {
            foreach (var animal in Animal)
            {
                Console.WriteLine($"{animal.Name} of {Name} in {Location} has fur of {animal.Fur} and {animal.LegAmount} many legs! ");
            }
        }



    }
}