class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prime numbers between 0 and 1000:");

        for (int num = 0; num <= 1000; num++)
        {
            if (IsPrime(num))
            {
                Console.Write(num + " ");
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
}
