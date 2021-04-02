using System;

namespace App05MonoGame
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new RPG_Game())
                game.Run();
        }
    }
}
