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

        Random random = new Random();
        public Room(Player player)
        {
            Player = player;
            int rnd = random.Next(1, 4);
            for (int i = 0; i < rnd; i++)
                Enemies.Add(new Enemy());
        }

        public void RunBattle()
        {
            int dead_enemies = 0;
            foreach (var enemy in Enemies)
            {
                if (enemy.IsDead)
                dead_enemies++;
            }
            int round = 0;
            while (!Player.IsDead && dead_enemies > 0)
            {
                List<Creature> allPlayers = new List<Creature>();
                Console.WriteLine($"Раунд {round++}");
                foreach (var enemy in Enemies)
                {
                    enemy.RandomSpeed();
                    allPlayers.Add(enemy);
                }
                Player.RandomSpeed(); 
                allPlayers.Add(Player);
                var ordered = allPlayers.OrderByDescending(s => s.Stats.Speed);
                foreach (var player in ordered)
                    player.RunAction(this);

            }
            if (!Player.IsDead)
            {
                Console.WriteLine("ура победа сила альтушки победила этот ужасный мир скуфов и роскомнадзоров! больше они не встанут на нашем пути!!!");
            }
        }
    }
    
}

