namespace Flyweight{

    public class charFactory {
        private readonly Dictionary<char, Ichar> _chars = new();
        public Ichar? GetChar(char charIdentifier){
            if (_chars.ContainsKey(charIdentifier)){
                Console.WriteLine($"Reusing {charIdentifier}");
                return _chars[charIdentifier];
            }

            Console.WriteLine($"Constructing {charIdentifier}");

            switch (charIdentifier){
                case 'a' :
                    _chars[charIdentifier] = new CharA();
                    return _chars[charIdentifier];

                case 'b' :
                    _chars[charIdentifier] = new CharB();
                    return _chars[charIdentifier];
            }
            return null;
        }

        public Ichar CreatePara(List<Ichar> chars, int location){
            return new Flyweight.Paragraph(chars, location);
        }
    } 
}