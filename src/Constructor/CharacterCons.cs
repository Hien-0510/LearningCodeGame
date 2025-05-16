namespace HelloWorld{
    public class CharacterCons: CharacterGetSet{
        public CharacterCons(){}
        public CharacterCons(string id, string name, int exp, int level, int health, int mana, int power, int defense, int speed)
        {
            Id = id;
            Name = name;
            Defense = defense;
            if (Exp >= 0 && Level >=0 && Health >=0 && Mana >=0 && Speed >=0){
                Exp = exp;
                Level = level;
                Health = health;
                Mana = mana;
                Speed = speed;
            }
            else
            {
                Console.WriteLine("Invalid values. Please enter non-negative values.");
            }
        }
    }
}