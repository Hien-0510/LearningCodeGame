// See https://aka.ms/new-console-template for more information

using System.Data.Common;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {

            bool temp = true;
            int choice;
            do
            {
                Console.WriteLine("Welcome to the file management program!");
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Create a file");
                Console.WriteLine("2. Enter information");
                Console.WriteLine("3. Read a file");
                Console.WriteLine("4. Delete a file");
                Console.WriteLine("5. Exit");
                Console.WriteLine("--------------------------------------------------");
                Console.Write("Enter your choice (1-5): ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------");
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Creating a file...");
                        CreateFile createFile = new CreateFile();
                        createFile.CreateFileMethod();
                        break;
                    case 2:
                        Console.WriteLine("Entering information...");
                        WriteFile writeFile = new WriteFile();
                        writeFile.WriteFileMethod();
                        break;
                    case 3:
                        Console.WriteLine("Reading a file...");
                        ReadFile readFile = new ReadFile();
                        readFile.ReadFileMethod();
                        break;
                    case 4:
                        Console.WriteLine("Deleting a file...");
                        DeleteFile deleteFile = new DeleteFile();
                        deleteFile.DeleteFileMethod();
                        break;
                    case 5:
                        Console.WriteLine("Exiting the program...");
                        temp = false;
                        break;
                    case 6:
                        ICharacter Ic = new ICharacter();
                        Ic.Attack();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (temp);
        }
    }
}