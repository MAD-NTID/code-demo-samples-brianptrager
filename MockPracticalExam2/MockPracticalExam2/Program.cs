using System;

namespace MockPracticalExam2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

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
                }
            }
        }
    }
}
