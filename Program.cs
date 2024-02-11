using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace a;
class Program
{
    static void Main(string[] args)
    {
        string fineName = @"E:\.NET WORKSPACE-1\Websites1\2023\DataSturctureAlgorithmCsharp2024\wordList.txt";
        try
        {
            List<string> words = File.ReadAllText(fineName)
                                    .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(word => word.Trim().ToLower())
                                    .ToList();

            // Sort the list lexicographically for binary search
            words.Sort(StringComparer.OrdinalIgnoreCase);


            Console.WriteLine("Words in list after trimming and converting to lowercase:");
            words.ForEach(word => Console.WriteLine(word));



            Console.WriteLine("Enter a word to search: ");
            string searchWord = Console.ReadLine().Trim().ToLower(); // Trim and convert to lowercase

            int index = BinarySearch1(words, searchWord);


            if (index >= 0)
            {
                Console.WriteLine($"Word found at index {index}: {words[index]}"); // Output the actual word found
            }
            else
            {
                Console.WriteLine($"Word not found: {searchWord}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static int BinarySearch(List<string> words, string searchWord)
    {
        int low = 0;
        int high = words.Count - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            int comparisonResult = string.Compare(words[mid], searchWord, StringComparison.OrdinalIgnoreCase);

            if (comparisonResult == 0)
            {
                return mid;
            }
            else if (comparisonResult > 0)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return -1; // Word not found
    }


    public static int BinarySearch1(List<string> words, string searchWord)
    {
        int left = 0;
        int right = words.Count - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (string.Equals(words[mid], searchWord, StringComparison.OrdinalIgnoreCase))
            {
                return mid;
            }
            else if (string.Compare(words[mid], searchWord, StringComparison.OrdinalIgnoreCase) > 0)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return -1; // Word not found
    }


}