namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string dna = string.Empty;

            int sequenceCount = 0;
            int currSequenceCount = 0;
            int maxSequenceCount = 0;
            int[] maxDNA = new int[length];
            int index = int.MaxValue;
            int minIndex = int.MaxValue; // no used yet
            int sum = 0;
            int maxSum = 0;
            bool isvalid = false;
            int sample = 0;
            int bestSample = 1;
            while ((dna = Console.ReadLine()) != "Clone them!")
            {
                sum = 0;
                sample++;
                isvalid = false;
                int[] currentArray = dna
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int i = 0; i < currentArray.Length; i++)
                {
                    if (currentArray[i] != 0)
                    {
                        sum++;
                    }
                }
                for (int i = currentArray.Length - 1; i >= 0; i--)
                {
                    currSequenceCount++;
                    if (currentArray[i] == 1)
                    {
                        if (currSequenceCount > sequenceCount)
                        {
                            index = i;
                            sequenceCount = currSequenceCount;
                        }
                        else if (currSequenceCount == sequenceCount)
                        {
                            index = i;
                        }
                    }
                    else
                    {
                        currSequenceCount = 0;
                    }
                    if (currSequenceCount == maxSequenceCount && index == minIndex && sum > maxSum)
                    {
                        maxDNA = currentArray;
                        maxSum = sum;
                        isvalid = true;
                    }
                    else if (currSequenceCount == maxSequenceCount && index < minIndex)
                    {
                        maxDNA = currentArray;
                        maxSum = sum;
                        isvalid = true;
                    }
                    else if (currSequenceCount > maxSequenceCount)
                    {
                        maxDNA = currentArray;
                        maxSum = sum;
                        isvalid = true;
                    }
                    if (sequenceCount > maxSequenceCount)
                    {
                        maxSequenceCount = sequenceCount;
                    }
                    if (index < minIndex)
                    {
                        minIndex = index;
                    }
                }
                currSequenceCount = 0;
                if (isvalid)
                {
                    bestSample = sample;
                }
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {maxSum}.");
            Console.WriteLine(String.Join(" ", maxDNA));
        }
    }
}