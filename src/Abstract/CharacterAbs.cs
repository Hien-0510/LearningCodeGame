using System.Data.Common;

namespace HelloWorld{
    public class CharacterAbs : Character
    {
        public void Player()
        {
            Console.Write("Enter your name:");
            Input();
        }
        
        public void Enemy()
        {
            Console.Write("Enter your enemy name:");
            Input();
        }
    }
}