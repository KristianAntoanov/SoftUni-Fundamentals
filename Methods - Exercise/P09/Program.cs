namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string n = string.Empty;

            while ((n = Console.ReadLine()) != "END")
            {
                char[] readyArray = ToArray(n);
                char[] reversedArr = ReverseArray(readyArray);
                if (AreArraysEqual(reversedArr, readyArray))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            
        }
        static bool AreArraysEqual(char[] arr1, char[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }

            return true;
        }
        static char[] ToArray(string n)
        {
            char[] arrNum = new char[n.Length];

            for (int i = 0; i < n.Length; i++)
            {
                arrNum[i] = (char)n[i];
            }
            return arrNum;

        }
        static char[] ReverseArray(char[] originalArr)
        {
            char[] reversed = new char[originalArr.Length];
            for (int i = originalArr.Length - 1; i >= 0; i--)
            {
                reversed[reversed.Length - i - 1] = originalArr[i];
            }
            return reversed;
        }
    }
}