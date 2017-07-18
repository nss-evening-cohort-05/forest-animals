using System;

namespace ForestAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest lachia = new Forest("Poplar City", "East");
            Forest redwood = new Forest("Big Red Trees", "West");

            var squirrel = new Animal {
                Fur = "gray",
                LegAmount = 2,
                Name = "Squirrel"
            };
            var bear = new Animal {
                Fur = "blue",
                LegAmount = 4,
                Name = "Blue Bear"
            };
            var raccoon = new Animal {
                Fur = "black",
                LegAmount = 4,
                Name = "Raccoon"
            };
            var bobcat = new Animal {
                Fur = "brown",
                LegAmount = 4,
                Name = "Bobcat"
            };
            var seal = new Animal {
                Fur = "white",
                LegAmount = 0,
                Name = "Seal"
            };

            lachia.AddAnimal(raccoon);
            lachia.AddAnimal(bobcat);
            lachia.AddAnimal(bear);
            redwood.AddAnimal(squirrel);
            redwood.AddAnimal(seal);

            lachia.ListAnimals();
            redwood.ListAnimals();
        }
    }
}
