namespace Flyweight{

    public class Paragraph : Ichar {

        private List<Ichar> _characters;
        private int _location;

        public Paragraph(List<Ichar> characters, int location)
        {
            _characters = characters;
            _location = location;
        }

        public void Draw(string FontFamily, int charfontSize)
        {
            Console.WriteLine($"Drawing para at loc {_location}");

            foreach(var character in _characters){
                character.Draw(FontFamily,charfontSize);
            }
        }
    }
}