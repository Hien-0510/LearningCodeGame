namespace HelloWorld{
    public class ICharacter: CharacterAbs
    {
        string filePath = "Members.txt";
        public void Player() { }
        public void Enemy() { }

        public async void Attack()
        {
            using (StringReader reader = new StringReader(filePath))
            {
                string readText = await reader.ReadToEndAsync();
                while (readText.Length > 0)
                {
                    // Assuming the file contains character data in a specific format
                    // Here we just read the first character for demonstration
                    var c = readText[1];
                    Console.WriteLine(c);
                    // Break after reading the first character for simplicity
                    break;
                }
            }
        }
    }
}