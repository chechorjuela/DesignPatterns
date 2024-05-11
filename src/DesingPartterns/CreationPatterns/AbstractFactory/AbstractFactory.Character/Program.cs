// See https://aka.ms/new-console-template for more information
using AbstractFactorty.Characters.Characters;
using AbstractFactorty.Characters.Factories;
using AbstractFactorty.Characters.Weapons;

// Crear fábrica de personajes y armas para la versión de escritorio
ICharacterFactory desktopFactory = new DesktopFactory();
ICharacter desktopCharacter = desktopFactory.CreateCharacter();
IWeapon desktopWeapon = desktopFactory.CreateWeapon();

// Usar personaje y arma de la versión de escritorio
desktopCharacter.Attack(desktopWeapon);
desktopCharacter.Defend();

// Crear fábrica de personajes y armas para la versión en línea
ICharacterFactory onlineFactory = new OnlineFactory();
ICharacter onlineCharacter = onlineFactory.CreateCharacter();
IWeapon onlineWeapon = onlineFactory.CreateWeapon();

// Usar personaje y arma de la versión en línea
onlineCharacter.Attack(onlineWeapon);
onlineCharacter.Defend();