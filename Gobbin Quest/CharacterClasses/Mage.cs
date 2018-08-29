using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gobbin_Quest.CharacterClasses
{
    public class Mage : Entity
    {
        public Mage()  
            :base()
        {

        }

        public Mage(string name, EntityGender gender)
            : base()
        {

        }

        public Mage(string name, EntityGender gender, int strength, int defense, int dexterity, int magic, int willpower, int health)
            :base()
        {
            Name = name;
            Gender = gender;
            strength = 5;
            defense = 5;
            dexterity = 10;
            magic = 15;
            willpower = 15;
            health = 10;
        }

    }
}
