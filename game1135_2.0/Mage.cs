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

            CurrentHP = 25;
            MaxHP = 25;
            Damage = 3;
            Armor = 3;
        }
    }
}
