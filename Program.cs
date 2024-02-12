namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName1 = "wordList.txt";

            try
            {
                string[] words = File.ReadAllText(fileName1)
                                        .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(word => word.Trim().ToLower())
                                        .ToArray();

                // Sort the array lexicographically for binary search
                Array.Sort(words, StringComparer.OrdinalIgnoreCase);


                Console.WriteLine("Words in list after trimming and converting to lowercase:");
                foreach (var word in words)
                {
                    Console.WriteLine(word);
                }

                Console.WriteLine("Enter a word to search: ");
                string searchWord = Console.ReadLine().Trim().ToLower(); // Trim and convert to lowercase

                int index = BinarySearch(words, searchWord);


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

        // Using Compare method 
        public static int BinarySearch(string[] words, string searchWord)
        {
            int low = 0;
            int high = words.Length - 1;

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
    }
}
