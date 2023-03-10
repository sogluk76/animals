using CSharpAnimal.Models.Animals;
namespace CSharpAnimal.Models.Animals
{
    class Bird : Animal, IPilotage, IFly
    {
        public Bird()
        {
            name = "Bird";
        }

        public Bird(string name, string type, int ID)
        {
            this.name = name;
            this.Type = type;
            this.Id = ID;
        }
        public override void Moove()
        {
            Console.WriteLine($"{name} moove");
        }

        public void Fly()
        {
            Console.WriteLine($"{name} fly");
        }

        public new void Sleep()
        {
            Console.WriteLine($"{name} sleep");
        }
    }
}