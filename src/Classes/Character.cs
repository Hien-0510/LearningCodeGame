namespace HelloWorld{
    public class Character: CharacterCons, ICharacter
    {
        public void Input(){
            
            Console.WriteLine("Enter your name:");
            Name = Console.ReadLine();
        }
    }
}