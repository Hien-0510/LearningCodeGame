namespace HelloWorld{
    public class ReadFile{
        public void ReadFileMethod(){
            string filePath = "Members.txt";

            if (File.Exists(filePath))
            {
                Console.WriteLine("File exists. Reading file...");
                string content = File.ReadAllText(filePath);
                Console.WriteLine("-----------------------------");
                Console.WriteLine("File content:");
                Console.WriteLine("");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
    }
}