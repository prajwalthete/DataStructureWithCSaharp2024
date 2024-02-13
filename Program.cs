public class LinearQueue
{
    private int[] arr;
    private int rear, front;

    public LinearQueue(int size)
    {
        arr = new int[size];
        rear = -1;
        front = -1;
    }
    public bool IsFull()
    {
        return rear == arr.Length - 1;
    }
    public bool IsEmpty()
    {
        return rear == front;
    }
    public void Push(int val)
    {
        if (IsFull())
            throw new Exception("Queue is Full.");
        rear++;
        arr[rear] = val;
    }
    public void Pop()
    {
        if (IsEmpty())
            throw new Exception("Queue is Empty.");
        front++;
    }
    public int Peek()
    {
        if (IsEmpty())
            throw new Exception("Queue is Empty.");
        return arr[front + 1];
    }
}

public class LinearQueueMain
{
    static void Main(string[] args)
    {
        LinearQueue q = new LinearQueue(6);
        int choice, val;
        // var sc = new System.IO.StreamReader(Console.OpenStandardInput());
        do
        {
            Console.WriteLine("\n0. Exit\n1. Push\n2. Pop\n3. Peek\nEnter choice: ");
            // choice = int.Parse(sc.ReadLine());
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: // push
                    try
                    {
                        Console.Write("Enter value to push: ");
                        val = int.Parse(Console.ReadLine());
                        q.Push(val);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 2: // pop
                    try
                    {
                        val = q.Peek();
                        q.Pop();
                        Console.WriteLine("Popped: " + val);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 3: // peek
                    try
                    {
                        val = q.Peek();
                        Console.WriteLine("Peek: " + val);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
            }
        } while (choice != 0);
    }
}
