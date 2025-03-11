namespace PrototypePatternOne
{
    public class Ability
    {
        private int attack;
        private int defense;
        private int velocity;

        public Ability(int attack, int defense, int velocity)
        {
            this.attack = attack;
            this.defense = defense;
            this.velocity = velocity;
        }

        public int Attack => attack;
        public int Defense => defense;
        public int Velocity => velocity;
    }

    public class AbilityArcher : Ability
    {
        private int range;

        public AbilityArcher(int attack, int defense, int velocity, int range) 
            : base(attack, defense, velocity)
        {
            this.range = range;
        }

        public int Range => range;
    }

    public class AbilityInfantry : Ability
    {
        private int hardness;

        public AbilityInfantry(int attack, int defense, int velocity, int hardness) 
            : base(attack, defense, velocity)
        {
            this.hardness = hardness;
        }

        public int Hardness => hardness;
    }

    public class AbilityMagician : Ability
    {
        private int invisibility;

        public AbilityMagician(int attack, int defense, int velocity, int invisibility) 
            : base(attack, defense, velocity)
        {
            this.invisibility = invisibility;
        }

        public int Invisibility => invisibility;
    }
}