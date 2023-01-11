using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Bobby");
            Enemy goblin = new Enemy("Goblin");

            player.ShowStats();
            goblin.ShowStats();

            player.TakeDamage(goblin.DealDamage(), goblin.name);
            player.ShowStats();

            goblin.TakeDamage(player.DealDamage(), player.name);
            goblin.ShowStats();

            Console.ReadKey(true);

        }
    }
}
