using CSharpAnimal.Models.Animals;
namespace CSharpAnimal.Models.Animals
{
    class Eagle : Animal, IPilotage, IFly
    {
        public Eagle()
        {
            name = "Dragon";
        }

        public Eagle(string name, string type, int ID)
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