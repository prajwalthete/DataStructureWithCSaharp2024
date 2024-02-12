class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prime numbers between 0 and 1000 that are anagrams and palindromes:");

        for (int num = 0; num <= 1000; num++)
        {
            if (IsPrime(num))
            {
                if (IsAnagram(num) && IsPalindrome(num))
                {
                    Console.WriteLine(num + " ");
                }
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        if (number == 2 || number == 3)
        {
            return true;
        }

        if (number % 2 == 0)
        {
            return false;
        }

        int sqrt = (int)Math.Sqrt(number);

        for (int i = 3; i <= sqrt; i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static bool IsAnagram(int number)
    {
        string numStr = number.ToString();
        char[] numChars = numStr.ToCharArray();
        Array.Sort(numChars);
        string sortedNumStr = new string(numChars);
        return numStr.Equals(sortedNumStr);
    }

    static bool IsPalindrome(int number)
    {
        string numStr = number.ToString();
        int left = 0;
        int right = numStr.Length - 1;

        while (left < right)
        {
            if (numStr[left] != numStr[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}
