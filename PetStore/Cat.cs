namespace ThePetStore;

public class Cat : Pet
{
    public Cat(string name) : base(name)
    {
        
    }

    public void Jump()
    {
        Console.WriteLine("Jump");
    }

    public override void Speak()
    {
        Console.WriteLine("And Meows happily");
    }

    public override void SpeakOverride()
    {
        base.SpeakOverride();
        Console.WriteLine("And Barks happily");
    }
}