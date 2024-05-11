// See https://aka.ms/new-console-template for more information
using FactoryMethod.WarriorPlayer.Entities;
using FactoryMethod.WarriorPlayer.Factory;

Console.WriteLine("Enter the type of character (Warrior, Mage, Archer):");
string typeCharacter = Console.ReadLine();
try
{
    ICharacter character = CharacterFactory.CreateEbook(typeCharacter);
    character.Atack();
    character.Defend();
    character.Walk();
}
catch (Exception exp)
{
    Console.WriteLine(exp.Message);
}
Console.WriteLine("Press any key to exit app...");
Console.ReadKey();