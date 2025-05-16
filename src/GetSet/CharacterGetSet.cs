using System.Diagnostics.Tracing;

namespace HelloWorld{
    public class CharacterGetSet{
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public int Exp { get; set; }
        public int Level { get; set; } = 1;
        public int Health { get; set; } = 100;
        public int Mana { get; set; } = 100;
        public int Power { get { return Level * 2; } }
        public int Defense { get; set; } = Random.Shared.Next(1, 10);
        public int Speed { get; set; } = Random.Shared.Next(1, 10);
    }
}