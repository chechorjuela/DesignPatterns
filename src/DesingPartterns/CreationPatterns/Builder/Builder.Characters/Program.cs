// See https://aka.ms/new-console-template for more information
// Crear un constructor de guerrero
using Builder.Characters;
using Builder.Characters.Builder;

var warriorBuilder = new WarriorBuilder();
// Crear un creador de personajes con el constructor de guerrero
var characterCreator = new CharacterCreator(warriorBuilder);
// Crear un guerrero
var warrior = characterCreator.CreateCharacter();
warrior.Display();

Console.WriteLine();

// Crear un constructor de mago
var mageBuilder = new MageBuilder();
// Cambiar el constructor del creador de personajes al de mago
characterCreator = new CharacterCreator(mageBuilder);
// Crear un mago
var mage = characterCreator.CreateCharacter();
mage.Display();

Console.WriteLine();

// Crear un constructor de arquero
var archerBuilder = new ArcherBuilder();
// Cambiar el constructor del creador de personajes al de arquero
characterCreator = new CharacterCreator(archerBuilder);
// Crear un arquero
var archer = characterCreator.CreateCharacter();
archer.Display();