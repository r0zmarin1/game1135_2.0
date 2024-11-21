using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1135_2._0
{
    public class Player : Creature
    {
        public Player()
        {
            Console.WriteLine("А кто ты сегодня?");
            Console.WriteLine("1) жоская воинственная альтушка");
            Console.WriteLine("2) альтушка с магической палочкой");
            color = ConsoleColor.Green;
            again:
            var answer = Console.ReadLine();
            if (answer == "1")
            {
                Warrior warrior = new Warrior();
                Stats = warrior;
            }
            else if (answer == "2")
            {
                Mage mage = new Mage();
                Stats = mage;
            }
            else
            {
                Console.WriteLine("Других альтушек нет. Выбери 1 или 2");
                goto again;
            }

            Console.WriteLine("Как зовут твою альтушку?");
            Stats.Name = Console.ReadLine();
            Console.WriteLine($"Здоровье альтушки: {Stats.CurrentHP}");
            Console.WriteLine($"Броня альтушки: {Stats.Armor}");
            Console.WriteLine($"Скорость альтушки: {Stats.Speed}");
            Console.WriteLine($"Урон альтушки: {Stats.Damage}");
            
        }

        public override void RunAction(Room room)
        {
            Console.ForegroundColor = color;
            Stats.PrintAction();
            int.TryParse(Console.ReadLine(), out int index);
            Stats.Actions[index].Run(this, room);
            Console.WriteLine($"Атака начата");


        }
    }
}
