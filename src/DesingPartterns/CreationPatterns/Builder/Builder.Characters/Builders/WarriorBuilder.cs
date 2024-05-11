using Builder.Characters.Models;

namespace Builder.Characters.Builder
{
    public class WarriorBuilder : CharacterBuilderBase
    {
        public override Character Build()
        {
            _character.Name = "Sergio";
            _character.Class = "Guerrero";
            _character.Abilities = new List<string> { "Ataque cuerpo a cuerpo", "Resistencia" };
            return _character;
        }
    }

}
