namespace Program
{
    class Character
    {
        public string CharacterClass;
        public string CharacterName;

        public Character(string charClass, string characterName)
        {
            this.CharacterClass = charClass;
            this.CharacterName = characterName;
        }

        public void print()
        {
            Console.WriteLine("Character class: " + CharacterClass + "\nCharacter name: " + CharacterName);
        }
    }
}