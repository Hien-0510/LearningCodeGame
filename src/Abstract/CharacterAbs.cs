using System.Data.Common;

namespace HelloWorld{
    public class CharacterAbs
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public int Exp { get; set; }
        public int Level { get; set; } = 1;
        public int MaxHealth { get; set; } = 100;
        public int Mana { get; set; } = 100;
        public int Power { get { return Level * 2; } }
        public int Defense { get; set; } = Random.Shared.Next(1, 10);
        public int Speed { get; set; } = Random.Shared.Next(1, 10);
        public List<string> Skills { get; private set; } = new List<string>() { "Basic Attack" };
        public List<string> UnlockedSkills => Skills.Take(Level).ToList();
        public string Item { get; set; }
        public CharacterAbs() { }
        public CharacterAbs(string id, string name, int exp, int level, int maxhealth, int mana, int defense, int speed, List<string> skills)
        {
            Id = id;
            Name = name;
            Defense = defense;
            if (skills != null && 0 < skills.Count && skills.Count < 5)
            {
                Skills = new List<string>(skills);
            }
            else
            {
                Skills = new List<string>();
            }
            if (Exp >= 0 && Level >= 0 && MaxHealth >= 0 && Mana >= 0 && Speed >= 0)
            {
                Exp = exp;
                Level = level;
                MaxHealth = maxhealth;
                Mana = mana;
                Speed = speed;
            }
            else
            {
                Console.WriteLine("Invalid values. Please enter non-negative values.");
            }
        }
        public virtual void Input()
        {
            Console.Write("Enter your name:");
            Name = Console.ReadLine();
        }

        public bool IsAlive()
        {
            return MaxHealth > 0;
        }

        public void LevelUp()
        {
            Level++;
            if (Level <= 10)
            {
                MaxHealth += 5;
                Defense += Random.Shared.Next(1, 3);
                Speed += Random.Shared.Next(1, 3);
            }
            if (Level <= 20)
            {
                MaxHealth += 10;
            }
        }
    }
}