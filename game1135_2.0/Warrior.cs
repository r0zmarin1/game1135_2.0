using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1135_2._0
{
    public class Warrior : CreatureClass
    {
        public Warrior()
        {
            LightAttackTarget lightAttackTarget = new LightAttackTarget();
            Actions.Add(lightAttackTarget);
            MultiAttackTarget multiAttackTarget = new MultiAttackTarget();
            Actions.Add(multiAttackTarget);

            CurrentHP = 30;
            MaxHP = 30;
            Damage = 4;
            Armor = 5;
        }
    }
}
