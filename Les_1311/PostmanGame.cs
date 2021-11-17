using System;

namespace Les_1311
{
    class PostmanGame : IGame
    {
        public void Play(string name)
        {
            Console.WriteLine($"{name} играет почтальона");
        }
    }
}
