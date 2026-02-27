namespace LLD.structural_design_patterns.Flyweight
{
    public class CharacterFactory
    {
        private readonly Dictionary<string, ICharacter> _characters
            = new Dictionary<string, ICharacter>();

        public ICharacter GetCharacter(char symbol, string font, int size, string color)
        {
            string key = $"{symbol}-{font}-{size}-{color}";

            if (!_characters.ContainsKey(key))
            {
                _characters[key] = new CharacterFlyweight(symbol, font, size, color);
            }

            return _characters[key];
        }
    }
}
