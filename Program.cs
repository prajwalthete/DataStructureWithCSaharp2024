namespace a;
class Program
{
    static void Main(string[] args)
    {
        // string fileName = @"E:\.NET WORKSPACE-1\Websites1\2023\DataStructureAlgorithmCsharp2024\wordList.txt";
        string fileName1 = "TextFile1.txt";

        try
        {
            List<string> words = File.ReadAllText(fileName1)
                                    .Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(word => word.Trim().ToLower())
                                    .ToList();

            // Sort the list lexicographically for binary search
            //words.Sort(StringComparer.OrdinalIgnoreCase);
            words.Sort();


            Console.WriteLine("Words in list after trimming and converting to lowercase:");
            words.ForEach(word => Console.WriteLine(word));



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


    public static int BinarySearch<T>(List<T> items, T searchItem) where T : IComparable<T>
    {
        int low = 0;
        int high = items.Count - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            int comparisonResult = items[mid].CompareTo(searchItem);

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

        return -1; // Item not found
    }

}