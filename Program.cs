using System;

namespace forest_animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest lachia = new Forest("Poplar City", "East");
            Forest redwood = new Forest("Big Red Trees", "West");

            var squirrel = new Animals {
                Fur = "gray",
                LegAmount = 2,
                Name = "Squirrel"
            };
            var bear = new Animals {
                Fur = "blue",
                LegAmount = 4,
                Name = "Blue Bear"
            };
            var raccoon = new Animals {
                Fur = "black",
                LegAmount = 4,
                Name = "Raccoon"
            };
            var bobcat = new Animals {
                Fur = "brown",
                LegAmount = 4,
                Name = "Bobcat"
            };
            var seal = new Animals {
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
