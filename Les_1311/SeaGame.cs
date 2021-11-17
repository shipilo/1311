using System;

namespace Les_1311
{
    class SeaGame : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"{name} играет море");
        }
    }
}
