namespace Program
{
    class MainMenu
    {

        private string charClass;
        public string CharacterClass()
        {
            bool running = true;
            do
            {
                //Izbornik
                Console.WriteLine("1.Warior");
                Console.WriteLine("2.Mage");
                Console.WriteLine("\nUpišite broj klase lika koju želite odabrati: ");

                //Korisnik bira klasu
                string key = Console.ReadLine();
                int choice = key == "" ? 0 : int.Parse(key);

                //Ako izbor nije 1 ili 2,prekini rad aplikacije
                if (choice == 1)
                {
                    Console.WriteLine("\nOdabrali ste klasu: Warior");
                    charClass = "Warior";
                    running = false;
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\nOdabrali ste klasu: Mage");
                    charClass = "Mage";
                    running = false;
                }
                else
                {
                    Console.WriteLine("Nedozvoljeni unos! \nProbajte Ponovo.");
                }
            } while (running);

            return charClass;
        }

        public string CharacterName()
        {
            string name;
            bool running = true;
            do
            {
                //Ako je izvor u redu,pitaj igrača za ime lika
                Console.WriteLine("\n**************************************");
                Console.WriteLine("\nUpišite ime vašeg lika: ");
                name = Console.ReadLine();
                //Ako nema unosa prekini rad aplikacije 

                if (name == null || name == "")
                {
                    Console.WriteLine("Greška!\nNiste unijeli ime lika. \nPokušajte ponovo");
                }
                else
                {
                    running = false;
                }
            } while (running);

            return name;
        }
    }

}