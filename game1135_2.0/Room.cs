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
        
        public List<Creature> Enemies { get; set; } = new List<Creature>();

        Random random = new Random();
        public Room(Player player)
        {
            Player = player;
            int rnd = random.Next(1, 6);
            for (int i = 0; i < rnd; i++)
                Enemies.Add(new Enemy());
        }

        public void RunBattle()
        {
            int round = 1;
            while (Enemies.Any(s=>!s.IsDead) && Player.IsDead == false )
            {
                Console.ForegroundColor = ConsoleColor.White;   
                List<Creature> allPlayers = new List<Creature>();
                Console.WriteLine($"Раунд {round++}");
                foreach ( var enemy in Enemies)
                {
                    enemy.RandomSpeed();
                    allPlayers.Add(enemy);
                    Console.WriteLine($"Враг {enemy.Stats.Name}, здоровье  - {enemy.Stats.CurrentHP}, броня  - {enemy.Stats.Armor}, урон - {enemy.Stats.Damage}, скорость - {enemy.Stats.Speed}");
                }
                Player.RandomSpeed(); 
                allPlayers.Add(Player);
                var ordered = allPlayers.OrderByDescending(s => s.Stats.Speed);
                foreach (var player in ordered)
                {
                    if (player.IsDead) 
                        continue;
                    player.RunAction(this);
                    Thread.Sleep(500);
                }
            }
            if (Player.IsDead == false)
            {
                Console.WriteLine("ура победа сила альтушки победила этот ужасный мир скуфов и роскомнадзоров! больше они не встанут на нашем пути!!!");
            }
        }
    }
    
}

