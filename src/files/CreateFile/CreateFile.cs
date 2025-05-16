namespace HelloWorld{
    public class CreateFile{
        public void CreateFileMethod(){
            string filePath = "Members.txt";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File does not exist. Creating file...");
                File.Create(filePath).Close();
                Console.WriteLine("File created successfully.");
            }
            else
            {
                Console.WriteLine("File already exists.");
            }
        }
    }
}