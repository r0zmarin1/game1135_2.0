using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1135_2._0
{
    public class Player : Creature
    {
        public override void RunAction(Room room)
        {
            Console.WriteLine(Stats.PrintAction);
            int.TryParse(Console.ReadLine(), out int index);
            Stats.Actions[index].Run(this, room);

        }
    }
}
