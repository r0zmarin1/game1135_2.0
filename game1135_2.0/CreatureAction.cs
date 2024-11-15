using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1135_2._0
{
    public abstract class CreatureAction
    {
        public string Title { get; set; }

        public abstract void Run(Creature actor, Room room);
        
    }
}
