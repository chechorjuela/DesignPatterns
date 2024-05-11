using Builder.Characters.Models;

namespace Builder.Characters.Builder
{
    public class MageBuilder : CharacterBuilderBase
    {
        public override Character Build()
        {
            _character.Class = "Mago";
            _character.Abilities = new List<string> { "Magia elemental", "Curación" };
            return _character;
        }
    }

}
