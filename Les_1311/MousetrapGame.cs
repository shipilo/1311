using System;

namespace Les_1311
{
    class MousetrapGame : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"{name} играет мышеловку");
        }
    }
}
