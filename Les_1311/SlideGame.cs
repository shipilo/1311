using System;

namespace Les_1311
{
    class SlideGame : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"{name} играет горку");
        }
    }
}
