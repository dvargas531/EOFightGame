using System;

namespace EOFightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Boxer redCorner = new Boxer("Mike Tyson");
            Boxer blueCorner = new Boxer("Evander Holyfield");

            new Fight(
                360,
                new Stat(100, 4, redCorner),
                new Stat(100, 6, blueCorner)
                ).Start();
        }
    }
}
