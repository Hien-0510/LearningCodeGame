namespace HelloWorld
{
    public class DeleteFile
    {
        public void DeleteFileMethod()
        {
            string filePath = "Members.txt";
            if (File.Exists(filePath))
            {
                Console.WriteLine("File exists. Deleting file...");
                File.Delete(filePath);
                Console.WriteLine("File deleted successfully.");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
    }
}