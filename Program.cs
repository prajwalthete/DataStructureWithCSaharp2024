namespace InsertionSortExample
{
    class Program
    {
        // Generic Insertion Sort algorithm implementation
        static void InsertionSort<T>(T[] arr) where T : IComparable<T>
        {
            for (int i = 1; i < arr.Length; i++)
            {
                T key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j].CompareTo(key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the list of words separated by spaces:");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            InsertionSort(words);

            Console.WriteLine("Sorted List of Words:");
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }
    }
}
