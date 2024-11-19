using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1135_2._0
{
    public class Mage : CreatureClass
    {
        public Mage() 
        {
            LightAttackTarget lightAttackTarget = new LightAttackTarget();
            Actions.Add(lightAttackTarget);
            MultiAttackTarget multiAttackTarget = new MultiAttackTarget();
            Actions.Add(multiAttackTarget);

            CurrentHP = 0;
            MaxHP = 0;
            Damage = 0;
            Armor = 0;
        }
    }
}
