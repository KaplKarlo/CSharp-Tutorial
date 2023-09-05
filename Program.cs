// See https://aka.ms/new-console-template for more information

using System.Threading.Tasks.Dataflow;

namespace Program
{
    class Aplication : Util
    {
        static void Main(string[] args)
        {
            IFizicka fizicka = new FizickeOsobe();
            IOsoba pravna = new PravneOsobe();

            //Util.ispis(pravna);
            //Console.WriteLine("");
            //Util.ispis(fizicka);
            Console.WriteLine("");
            ispisOsobe(fizicka);

            /*
            MainMenu menu = new MainMenu();
            string charClass = menu.CharacterClass();
            string name = menu.CharacterName();

            Character player = new Character(charClass, name);
            player.print();

            BattleManager battle = new BattleManager();
            battle.startBattle(player);

            */
        }


    }
    class Util
    {
        protected static void ispis(IOsoba osoba)
        {
            Console.WriteLine(osoba.adresa);
            Console.WriteLine(osoba.grad);
            Console.WriteLine(osoba.telefon);
        }

        protected static void ispisOsobe(IFizicka osoba)
        {
            Console.WriteLine(osoba.ime);
            Console.WriteLine(osoba.prezime);
        }

    }
}