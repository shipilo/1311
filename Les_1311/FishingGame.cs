using System;

namespace Les_1311
{
    class FishingGame : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"{name} играет рыбалку");
        }
    }
}
