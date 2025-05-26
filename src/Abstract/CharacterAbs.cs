using System.Data.Common;

namespace HelloWorld{
    public class CharacterAbs : CharacterCons
    {
        public virtual void Input()
        {
            Console.Write("Enter your name:");
            Name = Console.ReadLine();
        }

        public void GainExp(int num)
        {
            Exp += num;
            while (Exp >= ExpToNextLevel())
            {
                Exp -= ExpToNextLevel();
                LevelUp();
            }
        }
        private void LevelUp()
        {
            Level++;
            Console.WriteLine($"Chúc mừng! {Name} đã lên cấp {Level}.");
        }

        private int ExpToNextLevel()
        {
            // Ví dụ: Cần 100 * cấp độ hiện tại để lên cấp tiếp theo
            return 100 * Level;
        }
    }
}