using System;

namespace Les_1311
{
    class BeachGame : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"{name} играет пляж");
        }
    }
}
