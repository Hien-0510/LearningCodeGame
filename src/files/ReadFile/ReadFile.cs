namespace HelloWorld{
    public class ReadFile{
        public void ReadFileMethod(){
            string filePath = "Members.txt";

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
    }
}