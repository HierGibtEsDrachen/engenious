using System;
using System.Threading;

namespace TestCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var hold = new ManualResetEvent(false);
            var game = new TestGame();
            game.Run(60, 60);

            hold.WaitOne();
        }
    }
}
