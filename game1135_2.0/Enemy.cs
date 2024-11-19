using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1135_2._0
{
    public class Enemy : Creature
    {
        Random random = new Random();
        
        public Enemy() 
        {
            
           var wm =  random.Next(1,2);
            if (wm == 1)
            {
                Warrior warrior = new Warrior();
                Stats = warrior;
                Stats.Name = "Роскомнадзор";
            }
            else
            {
                Mage mage = new Mage();
                Stats = mage;
                Stats.Name = "Скуф";
            }
        }
        
        public override void RunAction(Room room)
        {
            if (IsDead = true)
                return;
            var i = random.Next(1,Stats.Actions.Count);
            Stats.Actions[i].Run(this, room);
        }
    }
}
