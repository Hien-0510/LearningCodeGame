using System.Data.Common;

namespace HelloWorld{
    public class CharacterAbs: Character{
        public void Output(){
            Console.WriteLine(Id + Name + Level + Health + Power + Defense + Speed + Mana);
        }
    }
}