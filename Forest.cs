using System;
using System.Collections.Generic;
using forest_animals.Animals;

namespace forest_animals
{
    public class Forest
    {
        public string Name { get; set; }

        public string Location { get; set; }

        List<Animal> Animals { get; set; } = new List<Animal>();

        public Forest(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public void AddAnimal(Animal newAnimal)
        {
            Animals.Add(newAnimal);
        }

        public void ListAnimals()
        {
            foreach (var animal in Animals)
            {
                if (animal is IFurryAnimal) {
                    Console.WriteLine($"{animal.Name} of {Name} in {Location} "+
                                      $"{((IFurryAnimal)animal).TypeOfFur}!");                
                }
                else {
                    Console.WriteLine($"{animal.Name} of {Name} in {Location}!");
                }

                var walkingAnimal = animal as IWalkingAnimal;
                if (walkingAnimal != null)
                {
                    walkingAnimal.Walk(7);
                }

            }
        }



    }
}