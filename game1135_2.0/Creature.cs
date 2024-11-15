using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1135_2._0
{
    public abstract class Creature
    {
        public CreatureClass Stats { get; set; }

        public bool IsDead { get; set; }

        public void TakeDamage(int damage)
        {
            Stats.TakeDamage(damage);
            if (Stats.CurrentHP <= 0)
            {
                Death();
            }
        }
        private void Death()
        {
            IsDead = true;
            Console.WriteLine("вы умерли");
        }
    }
}
