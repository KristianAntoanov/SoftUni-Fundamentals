namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] cmdArg = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArg[0];
                if (cmdType == "merge")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);
                    FixIvalidIndexes(words, ref startIndex, ref endIndex);
                    MergeWords(words, startIndex, endIndex);
                }
                else if (cmdType == "divide")
                {
                    int index = int.Parse(cmdArg[1]);
                    int partitions = int.Parse(cmdArg[2]);

                    string word = words[index];
                    List<string> partitionList = DivideWord(partitions, word);
                    words.RemoveAt(index);
                    words.InsertRange(index, partitionList);
                }

            }
            Console.WriteLine(string.Join(" ", words));
        }

        private static List<string> DivideWord(int partitions, string word)
        {
            int substringsLength = word.Length / partitions;
            int lastSubstringLength = word.Length - ((partitions - 1) * substringsLength);

            List<string> partitionList = new List<string>();
            for (int i = 0; i < partitions; i++)
            {
                int desiredLength = substringsLength;
                if (i == partitions - 1)
                {
                    desiredLength = lastSubstringLength;
                }
                char[] newPartitionArr = word
                    .Skip(i * substringsLength)
                    .Take(desiredLength)
                    .ToArray();
                string newPartition = string.Join("", newPartitionArr);
                partitionList.Add(newPartition);
            }

            return partitionList;
        }

        static void FixIvalidIndexes(List<string> words, ref int startIndex, ref int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (startIndex >= words.Count)
            {
                startIndex = words.Count - 1;
            }
            if (endIndex <= 0)
            {
                endIndex = 0;
            }
            if (endIndex >= words.Count)
            {
                endIndex = words.Count - 1;
            }
        }

        static void MergeWords(List<string> words, int startIndex, int endIndex)
        {
            string mergeText = string.Empty;
            for (int i = startIndex; i <= endIndex; i++)
            {
                string currWord = words[startIndex];
                mergeText += currWord;
                words.RemoveAt(startIndex);
            }
            words.Insert(startIndex, mergeText);
        }
    }
}