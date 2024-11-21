using System;
using System.Collections.Generic;
using System.Drawing;
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
            
           var wm =  random.Next(1,3);
            if (wm == 1)
            {
                Warrior warrior = new Warrior();
                Stats = warrior;
                Stats.Name = "Роскомнадзор";
                color = ConsoleColor.Red;
            }
            else
            {
                Mage mage = new Mage();
                Stats = mage;
                Stats.Name = "Скуф";
                color= ConsoleColor.Magenta;
            }
        }
        
        public override void RunAction(Room room)
        {
            if (IsDead == true)
                return;
            Console.ForegroundColor = color;
            var i = random.Next(1,Stats.Actions.Count);
            Stats.Actions[i].Run(this, room);
        }
    }
}
