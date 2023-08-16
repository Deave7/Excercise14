namespace Excercise14
{
    internal class Program
    {
        
        class PersonRegistry
        {
            string name;
            long socialSecurity;

            public PersonRegistry(string name, long socialSecurity)
            {
                this.name = name;
                this.socialSecurity = socialSecurity;
            }

            public string Name //public metod från klassen för att ändra värdet på PersonRegistry.name
            {
                get 
                { 
                    return name; 
                }
                set 
                { 
                    name = value; 
                }
            }

            public long SocialSecurity //samma som ovan fast för socialSecurity fast skrivet på färre rader 
            {
                get { return socialSecurity; }
                set { socialSecurity = value; }
            }


        }
        
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("This registry will let you add new people or search for ones already in the system\n");

            List<PersonRegistry> registry = new List<PersonRegistry>();


            //Lite personer i listan för testsyfte 
            registry.Add(new PersonRegistry("John Doe", 111122331234));
            registry.Add(new PersonRegistry("Janne Doe", 21122331234));
            registry.Add(new PersonRegistry("Johan Doe", 311122331234));
            registry.Add(new PersonRegistry("Johanna Doe", 411122331234));
            registry.Add(new PersonRegistry("Johnatan Doe", 511122331234));
            registry.Add(new PersonRegistry("Jakob Doe", 611122331234));
            registry.Add(new PersonRegistry("Jolin Doe", 711122331234));
            registry.Add(new PersonRegistry("Josefine Doe", 811122331234));

            

            while (true)
            {
                Console.WriteLine("Please choose a option from the menu: ");
                Console.WriteLine("[A]dd person");
                Console.WriteLine("[S]earch for person");
                Console.WriteLine("[Q]uit");
                string choice = Console.ReadLine();

                switch (choice.ToUpper())
                {
                    case "A":
                        Console.WriteLine("Please input a name: ");
                        string inputName = Console.ReadLine();
                        Console.WriteLine("Please input a swedish social security number (YYYYMMDDXXXX)");
                        long inputSocialSecurity = Convert.ToInt64(Console.ReadLine());

                        registry.Add(new PersonRegistry(inputName, inputSocialSecurity));

                        break;

                    case "S":
                        
                        Console.WriteLine("Do you want to search for a person using their [N]ame or their [S]ocial security number?");
                        string searchChoice = Console.ReadLine();

                        if (searchChoice.ToUpper() == "N")
                        {
                            Console.WriteLine("Please enter the name of the person you want to search for: ");
                            string searchPerson = Console.ReadLine();

                            for (int i = 0; i < registry.Count; i++)
                            {
                                if (registry[i].Name == searchPerson)
                                {
                                    Console.WriteLine($"Your person was found at index: {i} and their social security number is is: {registry[i].SocialSecurity} ");
                                }
                            }
                        }
                        else if (searchChoice.ToUpper() == "S")
                        {
                            Console.WriteLine("Please enter the social security number of the person you want to search for: ");
                            long searchPerson = Convert.ToInt64(Console.ReadLine());

                            for (int i = 0; i < registry.Count; i++)
                            {
                                if (registry[i].SocialSecurity == searchPerson)
                                {
                                    Console.WriteLine($"Your person was found at index: {i} and their name is is: {registry[i].Name} ");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Your input was incorrect, try again.");
                        }

                        break;

                    case "Q":
                        Console.WriteLine("The program is shutting down, until next time!");
                        return;

                    default:
                        Console.WriteLine("Please input something from the menu");
                        break;
                }
            }
        }
    }
}