namespace CCSA{
    public class CCSAclass
    {
        public void Attend()
        {

        }
        static void Main()
        {
            Human[] humans = new Human[10];

            for(int i = 0; i < humans.Length; i++)
            {
                if (i < 4)
                {
                    Console.WriteLine("\nWelcome Facilitator!");
                    Console.Write("\nWhat is your name: ");
                    string Name=Console.ReadLine();

                    Console.Write("\nAre you a frontend or backend Facilitator: ");
                    string cohort=Console.ReadLine();

                    if (cohort.ToLower() == "frontend") { new Program(programmes.frontend,"Monday"); new Program(programmes.frontend, "Wednesday"); }

                    else if (cohort.ToLower() == "backend") { new Program(programmes.backend, "Monday"); new Program(programmes.backend, "Wednesday"); }
                }

                else if (i > 4)
                {
                    Console.WriteLine("\nWelcome Student!");
                    Console.Write("\nWhat is your name: ");
                    string Name = Console.ReadLine();

                    Console.Write("\nAre you a frontend or backend cohort: ");
                    string cohort = Console.ReadLine();

                    if (cohort.ToLower() == "frontend") { new Program(programmes.frontend, "Monday"); new Program(programmes.frontend, "Wednesday"); }

                    else if (cohort.ToLower() == "backend") { new Program(programmes.backend, "Monday"); new Program(programmes.backend, "Wednesday"); }
                }
            }

        }
    }
}