using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1135_2._0
{
    public abstract class CreatureClass
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Armor { get; set; }
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public int Speed { get; set; }
        public List<CreatureAction> Actions { get; set; } = new List<CreatureAction>();

        internal void TakeDamage(int damage)
        {
            int one_attack_damage = CurrentHP + Armor;
            CurrentHP = one_attack_damage - damage;
           
        }

        public void PrintAction()
        {
            foreach (CreatureAction action in Actions)
            {
                var action1 = action.Title;
                Console.WriteLine(action1);
            }
        }
    }
}
