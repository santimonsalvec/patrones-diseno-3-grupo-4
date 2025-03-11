namespace PrototypePatternOne
{
    public abstract class Hero
    {
        private string name;
        private string appearance;
        private int experience;
        private int level;

        public Hero(string name, string appearance, int experience, int level)
        {
            this.name = name;
            this.appearance = appearance;
            this.experience = experience;
            this.level = level;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Appearance
        {
            get => appearance;
            set => appearance = value;
        }
        public int Experience => experience;
        public int Level => level;

        public abstract Hero Clone();
        public abstract Ability GetAbility();
    }

    public class HeroArcher : Hero
    {
        private string arcType;
        private AbilityArcher ability;

        public HeroArcher(string name, string appearance, int experience, int level, string type) 
            : base(name, appearance, experience, level)
        {
            this.arcType = type;
            this.ability = new AbilityArcher(1, 2, 3, 4);
        }

        public string ArcType => arcType;
        public AbilityArcher Ability => ability;

        public override Hero Clone()
        {
            return new HeroArcher(Name, Appearance, Experience, Level, ArcType);
        }

        public override Ability GetAbility()
        {
            return Ability;
        }
    }

    public class HeroInfantry : Hero
    {
        private string infantryType;
        private AbilityInfantry ability;

        public HeroInfantry(string name, string appearance, int experience, int level, string type) 
            : base(name, appearance, experience, level)
        {
            this.infantryType = type;
            this.ability = new AbilityInfantry(5, 6, 7, 8);
        }

        public string InfantryType => infantryType;
        public AbilityInfantry Ability => ability;

        public override Hero Clone()
        {
            return new HeroInfantry(Name, Appearance, Experience, Level, InfantryType);
        }

        public override Ability GetAbility()
        {
            return Ability;
        }
    }

    public class HeroMagician : Hero
    {
        private string magicianType;
        private AbilityMagician ability;

        public HeroMagician(string name, string appearance, int experience, int level, string type) 
            : base(name, appearance, experience, level)
        {
            this.magicianType = type;
            this.ability = new AbilityMagician(8, 9, 10, 11);
        }

        public string MagicianType => magicianType;
        public AbilityMagician Ability => ability;

        public override Hero Clone()
        {
            return new HeroMagician(Name, Appearance, Experience, Level, MagicianType);
        }

        public override Ability GetAbility()
        {
            return Ability;
        }
    }
}