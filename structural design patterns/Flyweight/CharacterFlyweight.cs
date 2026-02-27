namespace LLD.structural_design_patterns.Flyweight
{
    public class CharacterFlyweight : ICharacter
    {
        private readonly char _symbol;
        private readonly string _font;
        private readonly int _size;
        private readonly string _color;

        public CharacterFlyweight(char symbol, string font, int size, string color)
        {
            _symbol = symbol;
            _font = font;
            _size = size;
            _color = color;
        }

        public void Display(int position)
        {
            Console.WriteLine(
                $"Character: {_symbol}, Font: {_font}, Size: {_size}, Color: {_color}, Position: {position}");
        }
    }
}
