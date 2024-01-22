namespace ThePetStore;

public abstract class Pet
{
    private string Name;
    public Pet(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return Name;
    }

    public abstract void Speak();

    public virtual void SpeakOverride()
    {
        Console.WriteLine(Name +  ", Says hello");
    }



}


