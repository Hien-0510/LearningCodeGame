namespace HelloWorld{
    public class Character : CharacterCons, ICharacter
    {
        public void Input()
        {
            Console.Write("Enter your name:");
            Name = Console.ReadLine();
        }
    }
}