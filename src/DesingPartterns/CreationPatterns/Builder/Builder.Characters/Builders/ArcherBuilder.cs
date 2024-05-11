using Builder.Characters.Models;

namespace Builder.Characters.Builder
{
    public class ArcherBuilder : CharacterBuilderBase
    {
        public override Character Build()
        {
            _character.Class = "Arquero";
            _character.Abilities = new List<string> { "Tiro con arco", "Sigilo" };
            return _character;
        }
    }
}