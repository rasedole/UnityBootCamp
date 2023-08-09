using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230727_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Block block = new Block();
            Map map = new Map();
            CheckCollision check = new CheckCollision();
            block.MakeBlock();
            map.RenderMap(block);


            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                Console.Clear();
                block.MoveBlock(info.Key);
                map.RenderMap(block);
                check.Check(block, map);

            }
        }
    }
}
