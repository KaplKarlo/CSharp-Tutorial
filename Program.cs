// See https://aka.ms/new-console-template for more information

namespace Program
{
    class Aplication
    {
        static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            string charClass = menu.CharacterClass();
            string name = menu.CharacterName();

            Character player = new Character(charClass, name);
            player.print();

            BattleManager battle = new BattleManager();
            battle.startBattle(player);
        }
    }
}