using System;

namespace MAD4UFOS
{
    class Program
    {
        static Alien[] aliens = new Alien[0];

        enum AlienTypes 
        { 
            Cockroach,
            Crickets,
            Octo
        }
        static void Main(string[] args)
        {
            int choice;
            string alienSpecies;

            DisplayHeading();

            while (true)
            {
                choice = GetMainMenuChoice();

                switch (choice)
                {
                    case 1:
                        EnterASighting();
                        break;
                    case 2:
                        DisplayAllSightings();
                        break;
                    case 3:
                        FilterBySpecies();
                        break;
                    case 4:
                        DisplayRecordCount();
                        break;
                    case 5:
                        ExitProgram();
                        break;
                }//end switch
            }//end outer loop 
        }//end Main

        public static void EnterASighting()
        {
            DateTime dt;
            bool flag = false;
            //Ask for Species
            Console.Write("Enter the species for this sighting: ");

            string species = Console.ReadLine();
            foreach (string at in Enum.GetNames(typeof(AlienTypes)))
            {
                if (at == species)
                {
                    flag = true;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Species not identified or complete, data not saved.");
                return;
            }

            Console.Write("Enter the date of the sighting (mm/dd/yyyy): ");
            if(!(DateTime.TryParse(Console.ReadLine(), out dt)))
            {
                Console.WriteLine("==> You must enter a valid date in mm/dd/yyyy format");
                return;
            }

            Console.Write("Enter the location (state) where the sighting occurred: ");
            string location = Console.ReadLine();

            if (location == "")
            {
                Console.WriteLine("==> You must enter a location (state)");
                return;
            }

            Array.Resize(ref aliens, aliens.Length + 1);
            aliens[aliens.Length - 1] = new Alien(species, dt, location);
        }

        public static void DisplayAllSightings()
        {
            Console.WriteLine($"Species              Date Location");
            Console.WriteLine($"------------ ------------ ------------");

            foreach(Alien a in aliens)
            {
                Console.WriteLine(a);
            }
        }

        public static void FilterBySpecies()
        {
            int speciesCount = 0;
            Console.Write("Enter the species name to list: ");
            string species = Console.ReadLine();

            foreach (Alien a in aliens)
            {
                if(species == a.Name)
                {
                    Console.WriteLine(a);
                    speciesCount++;
                }   
            }
            Console.WriteLine($"{speciesCount} sightings reported for species: {species}");
        }

        public static void DisplayRecordCount()
        {
            Console.WriteLine($"There are {aliens.Length} sightings on file");
        }

        public static void DisplayHeading()
        {
            Console.Clear();
            Console.WriteLine("MAD4UFOS Data Collection System");
            Console.WriteLine($"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToShortTimeString()}");
        }

        public static int GetMainMenuChoice()
        {
            while (true)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("---------");
                Console.WriteLine("1. Enter a sighting\n2. Display all sightings\n3. Display sightings filtered by species"
                    + "\n4. Display record count\n5. Exit");
                Console.Write("Enter your selection (1-5):");

                if (int.TryParse(Console.ReadLine(), out int selection))
                {
                    return selection;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid selection -- please enter 1-5\n");
                    Console.ResetColor();
                }

            }
        }
    
        public static void ExitProgram()
        {
            Environment.Exit(0);
        }
    }
}
