using System;

namespace inluppg5_10A
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nummer = { 2, 2, 2, 4, 4, 4 , 3};
            int[] appearanceTally = new int[nummer.Length];

            int highestAppearances = 0;
            int highestIndex = 0;
            for (int i = 0; i < nummer.Length; i++)
            {
                int currentHigh = 0;

                for (int j = 0; j < nummer.Length; j++)
                {
                    if (nummer[i] == nummer[j])
                    {
                        currentHigh++;
                    }
                }
                appearanceTally[i] = currentHigh;
                if (currentHigh > highestAppearances)
                {
                    highestAppearances = currentHigh;
                }
            }

            for (int i = 0; i < nummer.Length; i++)
            {
                bool breaker = false;

                if (appearanceTally[i] == highestAppearances)
                {
                    Console.WriteLine(appearanceTally);
                    for (int j = i; j > 0; j--)
                    {
                        if (nummer[j] == nummer[i])
                        {
                            breaker = true;
                        }
                    }
                    if(breaker == false)
                    {
                        Console.WriteLine(nummer[i]);
                    }
                }
            }
        }
    }
}