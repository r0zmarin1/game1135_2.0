using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1135_2._0
{
    public abstract class AttackOneTarget: CreatureAction
    {
    }

    public class LightAttackTarget : AttackOneTarget
    {
        public LightAttackTarget()
        {
            Title = "0) Легкая атака";
        }

        Random random = new Random();
       
        public override void Run(Creature actor, Room room)
        {
            
            if (actor is Player)
            {
                foreach(var enemy in room.Enemies)
                {
                    Console.WriteLine($"враг {enemy.Stats.Name}, здоровье  - {enemy.Stats.CurrentHP}, броня  - {enemy.Stats.Armor}");
                    int rnd = random.Next(1, 10);
                    int damage = rnd + actor.Stats.Damage;
                    enemy.TakeDamage(damage);
                    Console.WriteLine($"Игрок {actor.Stats.Name} БЬЕТ {enemy.Stats.Name} С СИЛОЙ {damage}");
                }
            }
            else
            {
                int rnd = random.Next(1, 10);
                int damage = rnd + actor.Stats.Damage;
                room.Player.TakeDamage(damage);
                Console.WriteLine($"Враг {actor.Stats.Name} БЬЕТ С СИЛОЙ {damage}");
            }         
        }
    }
}
