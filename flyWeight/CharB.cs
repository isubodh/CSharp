namespace Flyweight
{
    public class CharB : Ichar {
        private char _actualChar = 'b';
        private string _fontFamily = string.Empty;
        private int _fontSize;

        public void Draw(string FontFamily, int charfontSize){
            _fontFamily = FontFamily;
            _fontSize = charfontSize;

            Console.WriteLine($"Drawing character {_actualChar} in {_fontFamily} with size {_fontSize}");
        }
    }
}
