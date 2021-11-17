using System;

namespace Les_1311
{
    class MyGame : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"name играет в мою игру");
        }
    }
}
