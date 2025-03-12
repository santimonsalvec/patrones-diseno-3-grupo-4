using System;

namespace PrototypePatternOne
{
    class Program
    {
        static void Main()
        {
            Hero archer1 = new HeroArcher("Legolas", "Elf", 100, 10, "Beginner");
            PrintHero(archer1);
            PrintArcherAbility(archer1);
            Console.WriteLine("-----------");

            Hero archer2 = archer1.Clone();
            PrintHero(archer2);
            PrintArcherAbility(archer2);
            Console.WriteLine("-----------");

            Hero infantry1 = new HeroInfantry("Aragorn", "Human", 200, 20, "Knight");
            PrintHero(infantry1);
            PrintInfantryAbility(infantry1);
            Console.WriteLine("-----------");

            Hero magician1 = new HeroMagician("Mystery", "Marcian", 250, 10, "Dark");
            magician1.Name = "Zeuss";
            magician1.Appearance = "Human";
            PrintHero(magician1);
            PrintMagicianAbility(magician1);
            Console.WriteLine("-----------");
        }

        static void PrintHero(Hero hero)
        {
            Console.WriteLine($"Name: {hero.Name}");
            Console.WriteLine($"Appearance: {hero.Appearance}");
            Console.WriteLine($"Experience: {hero.Experience}");
            Console.WriteLine($"Level: {hero.Level}");
        }

        static void PrintArcherAbility(Hero hero)
        {
            if (hero is HeroArcher heroArcher)
            {
                Console.WriteLine($"Attack: {heroArcher.GetAbility().Attack}");
                Console.WriteLine($"Defense: {heroArcher.GetAbility().Defense}");
                Console.WriteLine($"Velocity: {heroArcher.GetAbility().Velocity}");
                Console.WriteLine($"Range: {((AbilityArcher)heroArcher.GetAbility()).Range}");
            }
        }

        static void PrintInfantryAbility(Hero hero)
        {
            if (hero is HeroInfantry heroInfantry)
            {
                Console.WriteLine($"Attack: {heroInfantry.GetAbility().Attack}");
                Console.WriteLine($"Defense: {heroInfantry.GetAbility().Defense}");
                Console.WriteLine($"Velocity: {heroInfantry.GetAbility().Velocity}");
                Console.WriteLine($"Hardness: {((AbilityInfantry)heroInfantry.GetAbility()).Hardness}");
            }
        }

        static void PrintMagicianAbility(Hero hero)
        {
            if (hero is HeroMagician heroMagician)
            {
                Console.WriteLine($"Attack: {heroMagician.GetAbility().Attack}");
                Console.WriteLine($"Defense: {heroMagician.GetAbility().Defense}");
                Console.WriteLine($"Velocity: {heroMagician.GetAbility().Velocity}");
                Console.WriteLine($"Invisibility: {((AbilityMagician)heroMagician.GetAbility()).Invisibility}");
            }
        }
    }
}