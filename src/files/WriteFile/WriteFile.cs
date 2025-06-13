namespace HelloWorld{
    public class WriteFile: Character{

        public void WriteFileMethod(){
            string filePath = "Members.txt";
            if (File.Exists(filePath))
            {

                Input();
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine("Id: " + Id);
                    sw.WriteLine("Name: " + Name);
                    sw.WriteLine("Exp: " + Exp);
                    sw.WriteLine("Level: " + Level);
                    sw.WriteLine("Health: " + MaxHealth);
                    sw.WriteLine("Mana: " + Mana);
                    sw.WriteLine("Power: " + Power);
                    sw.WriteLine("Defense: " + Defense);
                    sw.WriteLine("Speed: " + Speed);
                    sw.WriteLine("Skills: " + string.Join(", ", Skills ?? new List<string>()));
                    sw.WriteLine("Item: " + Item);
                    sw.WriteLine();
                }
                Console.WriteLine("Data written to file successfully.");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
    }
}