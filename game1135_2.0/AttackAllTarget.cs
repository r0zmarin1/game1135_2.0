using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1135_2._0
{
    public abstract class AttackAllTarget : CreatureAction
    { }
        public class MultiAttackTarget : AttackAllTarget
        {
            public MultiAttackTarget()
            {
                Title = "1) Aтака по группе";
            }

            Random random = new Random();

            public override void Run(Creature actor, Room room)
            {
                List<Creature> Targets = new List<Creature>();
                if (actor is Player)
                {
                    foreach (var enemy in room.Enemies)
                    {
                        Targets.Add(enemy);
                        Console.WriteLine($"враг {enemy.Stats.Name}, здоровье  - {enemy.Stats.CurrentHP}, броня  - {enemy.Stats.Armor}");
                        int rnd = random.Next(1, 15);
                        int damage = rnd + (actor.Stats.Damage/2);
                        enemy.TakeDamage(damage);
                        Console.WriteLine($"Альтушка {actor.Stats.Name} БЬЕТ {enemy.Stats.Name} С СИЛОЙ {damage}");
                    }
                }
                else
                {
                    Targets.Add(room.Player);
                    int rnd = random.Next(1, 15);
                    int damage = rnd + (actor.Stats.Damage / 2);
                    room.Player.TakeDamage(damage);
                    Console.WriteLine($"Враг {actor.Stats.Name} БЬЕТ С СИЛОЙ {damage}");
                }
            }
        }
    }

