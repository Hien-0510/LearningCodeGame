namespace HelloWorld{
    public class CreateFile{
        public void CreateFileMethod(){
            string filePath = "Members.json";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File does not exist. Creating file...");
                File.Create(filePath).Close();
                Console.WriteLine("File created successfully.");
            }
            else
            {
                Console.WriteLine("File already exists.");
                Console.WriteLine("Do you want to overwrite it? (yes/no)");
                string response = Console.ReadLine();
                if (response?.ToLower() == "yes")
                {
                    File.Create(filePath).Close();
                    Console.WriteLine("File overwritten successfully.");
                }
                else
                {
                    Console.WriteLine("File not overwritten.");
                }
            }
        }
    }
}