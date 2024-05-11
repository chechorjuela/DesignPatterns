using Builder.Characters.Models;

namespace Builder.Characters.Builder
{
    public abstract class CharacterBuilderBase : ICharacterBuilder
    {
        protected Character _character = new Character();
        public virtual Character Build()
        {
            return _character;
        }
        public void SetAbilities(List<string> abilities)
        {
            _character.Abilities = abilities;
        }
        public void SetClass(string className)
        {
            _character.Class = className;
        }
        public void SetName(string name)
        {
            _character.Name = name;
        }
        public void SetRace(string race)
        {
            _character.Race = race;
        }
    }
}