using System.Text.Json.Nodes;

namespace HelloWorld{
    public class Character
    {
        string filePath = "Members.json";
        private static readonly char[] separator = new[] { '\n', '\r' };
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public int Exp { get; set; }
        public int Level { get; set; } = 1;
        public int MaxHealth { get; set; } = 100;
        public int Mana { get; set; } = 100;
        public int Power { get { return Level * 2; } }
        public int Defense { get; set; } = Random.Shared.Next(1, 10);
        public int Speed { get; set; } = Random.Shared.Next(1, 10);
        public List<string> Skills { get; set; } = new List<string>() { "Basic Attack" };
        public List<string> UnlockedSkills { get; set; } = new List<string>() {"Speead Attack", "Dig", "Cut"};
        public string Item { get; set; }
        public Character() { }
        public Character(string id, string name, int exp, int level, int maxhealth, int mana, int defense, int speed, List<string> skills)
        {
            Id = id;
            Name = name;
            Defense = defense;
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
            Skills = skills;
        }
        public void Input()
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

        public void Unlocked()
        {
            if (Level >= 10 && UnlockedSkills.Count >= 1 && !Skills.Contains(UnlockedSkills[0]))
            {
                Skills.Add(UnlockedSkills[0]);
                Console.WriteLine($"Đã mở khóa kỹ năng: {UnlockedSkills[0]}");
            }
            if (Level >= 20 && UnlockedSkills.Count >= 2 && !Skills.Contains(UnlockedSkills[1]))
            {
                Skills.Add(UnlockedSkills[1]);
                Console.WriteLine($"Đã mở khóa kỹ năng: {UnlockedSkills[1]}");
            }
            if (Level >= 30 && UnlockedSkills.Count >= 3 && !Skills.Contains(UnlockedSkills[2]))
            {
                Skills.Add(UnlockedSkills[2]);
                Console.WriteLine($"Đã mở khóa kỹ năng: {UnlockedSkills[2]}");
            }
        }
        public void Attack()
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string readText = reader.ReadToEnd();
                while (Id != null)
                {
                    var getId = JsonValue.Parse(readText);
                    Console.WriteLine("Your ID is: " + getId["Id"]);
                    break;
                }
            }
        }
    }
}