using Builder.Characters.Builder;
using Builder.Characters.Models;

namespace Builder.Characters
{
    public class CharacterCreator
    {
        private ICharacterBuilder _builder;

        public CharacterCreator(ICharacterBuilder builder)
        {
            _builder = builder;
        }

        public Character CreateCharacter()
        {
            _builder.SetName("Nuevo Personaje");
            _builder.SetRace("Humano"); // Por defecto
            return _builder.Build();
        }
    }
}