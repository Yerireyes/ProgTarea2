using System;
using System.Collections.Generic;
using System.Text;

namespace ProgTarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello down");
            Game game = new Game(1000, 700, ":D");
            game.Run();
        }
    }
}
