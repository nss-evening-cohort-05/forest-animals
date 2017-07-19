using System;
using forest_animals.Animals;

namespace forest_animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest lachia = new Forest("Poplar City", "East");
            Forest redwood = new Forest("Big Red Trees", "West");

            var squirrel = new Squirrel ("Squirrel","Patchy") {TailLength = 17};
            var bear = new Bear("Yogi","Blue") { TailLength = 1, PicnicBasketAmount=2 };
            var seal = new Seal ("Sammy");

            lachia.AddAnimal(bear);
            redwood.AddAnimal(squirrel);
            redwood.AddAnimal(seal);
            redwood.AddAnimal(new Animal {Name="Steve"});

            lachia.ListAnimals();
            redwood.ListAnimals();
        }
    }
}
