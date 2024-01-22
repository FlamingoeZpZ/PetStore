using ThePetStore;

PetStore myStore = new PetStore("Gabe's Shop");

myStore.AddNewAnimal(new Cat("John"));
myStore.AddNewAnimal(new Cat("Sarah"));
myStore.AddNewAnimal(new Cat("Tiger"));

myStore.CheckPetStore();

MainMenu();


void MainMenu()
{
    Console.Clear();
    bool inStore = true;
    while (inStore)
    {
        Console.WriteLine($"Welcome to: {myStore.GetName()}  What would you like to do: \nBUY a pet, SELL a pet, EXIT the store");
        string? input = Console.ReadLine()?.ToUpper();
        
        switch (input)
        {
            case "BUY":
                Console.Clear();
                myStore.CheckPetStore();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("What pet would you like to purchase: ");
                Console.ForegroundColor = ConsoleColor.White;
                
                string? petName = Console.ReadLine();
                Pet? myPet = myStore.RemoveAnimal(petName!);
                if (myPet == null)
                {
                    Console.WriteLine("This pet does not exist!");
                    break;
                }
                myPet.Speak();
                myPet.SpeakOverride();
                break;
            case "SELL":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter the information for the pet you'd like to sell");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            case "EXIT":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Come back soon!");
                Console.ForegroundColor = ConsoleColor.White;
                inStore = false;
                break;
            default:
                break;
        }
        Console.WriteLine("Press anything to continue");
        Console.ReadKey(true);
        Console.Clear();
    }
}

void PetStore()
{
    
}

void RemovePet()
{
    
}
