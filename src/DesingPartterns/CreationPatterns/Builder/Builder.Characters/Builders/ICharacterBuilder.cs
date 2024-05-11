using Builder.Characters.Models;

namespace Builder.Characters.Builder
{
    public interface ICharacterBuilder
    {
        void SetName(string name);
        void SetRace(string race);
        void SetClass(string className);
        void SetAbilities(List<string> abilities);
        Character Build();
    }
}