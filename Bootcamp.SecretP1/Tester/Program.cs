using System;
using Bootcamp.SecretP1;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string question in Prompter.Instance)
            {
                var value = Prompter.Instance.DebugValue(question);

                do
                {
                    Console.WriteLine(question);
                } while (!Prompter.Instance.IsCorrectAnswer(Console.ReadLine()));
            }
        }
    }
}
