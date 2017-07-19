namespace forest_animals.Animals
{
    public class Seal : Animal, IFurryAnimal
    {
        public int NumberOfFlippers => 4;
        public string TypeOfFur => "Waterproof";

        public Seal(string name)
        {
            Name = name;
        }
    }
}