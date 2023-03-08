class Program
{
    static void Main(string[] args)
    {
        //Animal myAnimal = new Animal("Roucoups");
        //myAnimal.Move();
        //myAnimal.Sleep();

        //Animal anotherAnimal = new Animal();
        //anotherAnimal.Name = "Groudon";
        //anotherAnimal.Move();
        //anotherAnimal.Sleep();

        Dragon myDragon = new Dragon("Dragon");
        myDragon.Move();
        myDragon.Sleep();

        Griffin myGriffin = new Griffin("Griffin");
        myGriffin.Move();
        myGriffin.Sleep();
    }
}