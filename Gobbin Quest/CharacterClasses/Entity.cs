using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gobbin_Quest.CharacterClasses
{

    public enum EntityGender { Gobbo, Gobbina, Gobblyn }

    public abstract class Entity
    {
        #region Fields Region
        protected string name;
        protected EntityGender gender;
        protected int strength, defense, dexterity, magic, willpower, health;
        protected int strengthMod, defenseMod, dexterityMod, magicMod, willpowerMod, healthMod;

        #endregion


        #region Properties Region
        public string Name 
            {
                get { return name; }
                set { name = value; }
            }
        public EntityGender Gender
        {
            get { return gender; }
            protected set { gender = value; }
        }
        public int Strength
        {
            get { return strength + strengthMod; }
            protected set { strength = value; }
        }
        public int Defense
        {
            get { return defense + defenseMod; }
            protected set { defense = value; }
        }
        public int Dexterity
        {
            get { return dexterity + dexterityMod; }
            protected set { dexterity = value; }
        }
        public int Magic
        {
            get { return magic + magicMod; }
            protected set { magic = value; }
        }
        public int Willpower
        {
            get { return willpower + willpowerMod; }
            protected set { willpower = value; }
        }
        public int Health
        {
            get { return health + healthMod; }
            protected set { health = value; }
        }
        
        #endregion


        #region Constructor Region
        public Entity()
        {
            //Initial values
            Name = "";
            Strength = 0;
            Defense = 0;
            Dexterity = 0;
            Magic = 0;
            Willpower = 0;
            Health = 0;

        }
        #endregion


        #region Methods Region

        #endregion
    }
}
