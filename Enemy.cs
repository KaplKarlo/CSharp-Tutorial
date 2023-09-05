namespace Program
{
    interface Enemy
    {
        public string name { get; }
        public int health { get; set; }
        public int damage { get; }

        public bool calculateDamage(int userDamage);
    }

    class Ogre : Enemy
    {
        public  string name { get; } = "Ogre";
        public  int health { get; set; } = 110;
        public  int damage { get; } = 20;

        public bool calculateDamage(int userDamage){
            return true;
        }
    }

    class OgreMage : Enemy
    {
        public  string name { get; } = "Ogre";
        public  int health { get; set; } = 110;
        public  int damage { get; } = 20;
        int magicResistance = 5;

        public  bool calculateDamage(int userDamage)
        {
            int currentHealth = health - (userDamage - magicResistance);

            if (currentHealth > 0)
            {
                health = currentHealth;
                Console.WriteLine("You did " + userDamage + " damage. Current enemy health: " + this.health);
                return false;
            }
            if (currentHealth <= 0)
            {
                Console.WriteLine("You are victorious!");
                return true;
            }
            return false;
        }
    }
}