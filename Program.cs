
public class Stack
{
    private int[] arr;
    private int top;


    public Stack(int size)
    {
        arr = new int[size];
        top = -1;

    }
    public void Push(int value)
    {
        if (IsFull())
        {
            throw new InvalidOperationException("Stack is Full.");

        }
        top++;
        arr[top] = value;
    }
    public void Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is Empty.");
        }
        top--;
    }
    public int Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is Empty");
        }
        return arr[top];
    }
    public bool IsFull()
    {
        return (top == arr.Length - 1);
    }
    public bool IsEmpty()
    {
        return top == -1;
    }


}

class Program
{
    static void Main(string[] args)
    {
        Stack s = new(5);
        int choice, val;
        do
        {
            Console.WriteLine("\n0. Exit\n1. Push\n2. Pop\n3. Peek\nEnter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: // push
                    try
                    {
                        Console.Write("Enter value to push: ");
                        val = Convert.ToInt32(Console.ReadLine());
                        s.Push(val);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 2:// pop
                    try
                    {
                        val = s.Peek();
                        s.Pop();
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
                        val = s.Peek();
                        Console.WriteLine("Peek: " + val);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;



                default:
                    break;
            }


        } while (choice != 0);
    }
}