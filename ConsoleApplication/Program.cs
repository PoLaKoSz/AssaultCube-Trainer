using System;

namespace PoLaKoSz.hu.AssaultCube
{
    class Program
    {
        static void Main(string[] args)
        {
            string gameName = "ac_client";

            CheatEngine engine = new CheatEngine(gameName);

            engine.Run();
        }
    }
}
