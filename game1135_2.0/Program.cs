namespace game1135_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Player player = new Player();
            while (!player.IsDead)
            {
                Room room = new Room(player);
                room.RunBattle();   
            }
            Console.WriteLine("Конец игры(");
        }
    }
}
