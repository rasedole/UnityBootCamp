using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230719_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(10, 120, 20);
            player.Move();
            Console.WriteLine(player.gold);
            Console.WriteLine(player.hp);
            Console.WriteLine(player.mp);
            player = null;

            //Goblin goblin = new Goblin();
            //goblin.Attack();
            //goblin.Move();
            //goblin = null;

            //Hog hog = new Hog();
            //hog.Attack();
            //hog.Move();
            //hog = null;

            //Slime slime = new Slime();
            //slime.Attack();
            //slime.Move();
            //slime = null;
        }
    }
}
