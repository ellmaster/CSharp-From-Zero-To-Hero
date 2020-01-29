using System;
using System.Collections.Generic;

namespace Bootcamp.SecretP1
{
    internal static class SecretStuff
    {
        internal static readonly int[] SecretArray;

        internal static readonly string FirstValue = "Debugger!";

        static SecretStuff()
        {
            int charSum = 0;
            for (int i = 0; i < FirstValue.Length; i++)
            {
                charSum += FirstValue[i];
            }

            Random random = new Random(charSum);
            bool[] alreadyUsed = new bool[100];
            SecretArray = new int[30];

            for (int i = 0; i < 30; i++)
            {
                int number;
                do
                {
                    number = random.Next(0, 100);
                } while (alreadyUsed[number]);

                SecretArray[i] = number;
                alreadyUsed[number] = true;
            }
        }
    }
}
