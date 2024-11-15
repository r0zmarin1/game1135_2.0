using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1135_2._0
{
    public class Room
    {
        public Creature Player { get; set; }
        public List<Creature> Enemies { get; set; }

        public Room(Player player) 
        {
            this.Player = player;
        }

        public void RunBattle()
        {

        }
    }
}
