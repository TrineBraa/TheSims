using System.Runtime.CompilerServices;
using TheSims;

FamilyMode Family = new FamilyMode();
BuildMode Build = new BuildMode();
PlayMode Play = new PlayMode();
bool Housebuilt = false;
bool FamilyMade = false;

Main();

void Main()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("\tWelcome to the Sims");
        Console.WriteLine("\nOptions:");
        Console.WriteLine("\n\t1. Family Mode");
        Console.WriteLine("\t2. Build Mode");
        Console.WriteLine("\t3. Play Mode");
        Console.WriteLine("\t4. Close");
        Console.WriteLine();
        MainMenu();

    }
}


void MainMenu()
{
    Console.WriteLine("What would you like to do?");
    var MainOption = Console.ReadLine();
    switch (MainOption)
    {
        case "1":
            Family.CreateFamily(); //Se om det er mulig å komme tilbake hit etter at det er laget en familie og en har forlatt denne kategorien.
            FamilyMade = true;
            break;
        case "2":
            Build.BuildMenu();
            Housebuilt = true;
            break;
        case "3":
            Play.PlayMenu(Housebuilt, FamilyMade);
            break;
        case "4":
            Console.WriteLine("Closing down!");
            Thread.Sleep((2000));
            Environment.Exit(404);
            break;
        default:
            Console.WriteLine("\n\tPlease choose a valid option!");
            Thread.Sleep(2000);
            Console.Clear();
            break;
    }
}



