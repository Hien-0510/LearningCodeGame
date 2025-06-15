namespace HelloWorld{
    public class ICharacter: CharacterAbs
    {
        string filePath = "Members.txt";
        private static readonly char[] separator = new[] { '\n', '\r' };

        public void Player() { }
        public void Enemy() { }

        public  void Attack()
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string readText =  reader.ReadToEnd();
                while (Id != null)
                {
                    string [] parts = readText.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    Console.WriteLine(parts[0]); // Assuming the first line contains the character's ID
                    break;  // Break after reading the first line for simplicity
                }
            }
        }
    }
}