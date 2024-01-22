namespace ThePetStore;

public class PetStore
{

    private List<Pet> storePets = new List<Pet>();
    private string Name;

    public PetStore(string storeName)
    {
        Name = storeName;
        storePets.Add(new Cat("Jeff"));
        storePets.Add(new Dog("Tim"));
    }

    public void CheckPetStore()
    {
        Console.WriteLine("--------- ACTIVE PETS ---------");
        int dogCount = 0;
        int catCount = 0;
        foreach (Pet p in storePets)
        {
            string str = "";
            if (p is Dog)
            {
                dogCount += 1;
                str = "DOG - ";
            }

            else if (p is Cat)
            {
                catCount += 1;
                str = "CAT - ";
            }
            
            Console.WriteLine(str + p.GetName());
        }
        Console.WriteLine($"TOTAL PETS (DOGS: {dogCount}), (CATS({catCount})");
    }

    public void AddNewAnimal(Pet animal)
    {
        storePets.Add(animal);
    }

    public Pet? RemoveAnimal(string id)
    {
        id = id.ToLower();
        for (int i = 0; i < storePets.Count; i++)
        {
            Pet pet = storePets[i];
            if (id.Equals(pet.GetName().ToLower()))
            {
                return RemoveAnimal(i);
            }
        }
        return null;
    }

    public Pet? RemoveAnimal(int id)
    {
        if (id >= storePets.Count) return null;
        Pet p = storePets[id];
        storePets.RemoveAt(id);
        return p;
    }

    public string GetName()
    {
        return Name;
    }

}