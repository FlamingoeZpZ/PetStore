namespace ThePetStore;

public class Dog : Pet
{
    public Dog(string name) : base(name)
    {
        
    }

    public override void Speak()
    {
        Console.WriteLine("And Barks happily");
    }
}