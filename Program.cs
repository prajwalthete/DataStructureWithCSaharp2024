namespace dictionaryStudy;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        dictionary.Add("mangos", 11);
        dictionary.Add("apple", 20);
        dictionary.Add("bananas", 30);


        // Checking if a key exists
        bool containsKey = dictionary.ContainsKey("mangos");
        Console.WriteLine("contains Mangos " + containsKey);

        foreach (var item in dictionary)
        {
            Console.WriteLine($"key: {item.Key} ,value : {item.Value}");
        }


        // Accessing elements by key
        Console.WriteLine("value of apple " + dictionary["apple"]);

        // Getting the number of elements
        int count = dictionary.Count;
        Console.WriteLine(count);


        // remove 
        dictionary.Remove("mangos");
        Console.WriteLine("after removing mangos");
        foreach (var item in dictionary)
        {
            Console.WriteLine($"key: {item.Key} ,value : {item.Value}");
        }

        // Clearing the dictionary
        dictionary.Clear();

    }
}