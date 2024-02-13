
namespace a;
public class SinglyLinkedList<T>
{
    public class Node
    {
        public T Data;
        public Node Next;

        public Node(T val)
        {
            Data = val;
            Next = null;
        }
    }

    public Node Head { get; private set; }

    public SinglyLinkedList()
    {
        Head = null;
    }

    public void Display()
    {
        Console.WriteLine("List : ");
        Node trav = Head;

        while (trav != null)
        {
            Console.WriteLine(trav.Data);
            trav = trav.Next;
        }
        Console.WriteLine("");
    }

    public void AddFirst(T val)
    {
        Node newNode = new Node(val);
        newNode.Next = Head;
        Head = newNode;
    }

    public void AddLast(T val)
    {
        Node newNode = new Node(val);
        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node trav = Head;
            while (trav.Next != null)
                trav = trav.Next;
            trav.Next = newNode;
        }
    }

    public void RemoveFirst()
    {
        if (Head != null)
            Head = Head.Next;
    }

    public bool IsEmpty()
    {
        return Head == null;
    }

    public int Count()
    {
        int count = 0;
        Node trav = Head;
        while (trav != null)
        {
            count++;
            trav = trav.Next;
        }
        return count;
    }
}

public class Queue<T>
{
    private SinglyLinkedList<T> list;

    public Queue()
    {
        list = new SinglyLinkedList<T>();
    }

    public void Enqueue(T item)
    {
        list.AddLast(item);
    }

    public T Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        T data = list.Head.Data;
        list.RemoveFirst();
        return data;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        return list.Head.Data;
    }

    public bool IsEmpty()
    {
        return list.IsEmpty();
    }

    public int Count()
    {
        return list.Count();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine("Dequeued element: " + queue.Dequeue());
        Console.WriteLine("Dequeued element: " + queue.Dequeue());

        Console.WriteLine("Front element: " + queue.Peek());

        Console.WriteLine("Is queue empty? " + queue.IsEmpty());

        queue.Enqueue(40);
        queue.Enqueue(50);

        while (!queue.IsEmpty())
        {
            Console.WriteLine("Dequeued element: " + queue.Dequeue());
        }
    }
}
