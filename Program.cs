﻿public class SinglyLinkedList
{
    // node is static member class of SinglyLinkedList
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int val)
        {
            Data = val;
            Next = null;
        }
    }

    private Node head;


    public SinglyLinkedList()
    {
        head = null;

    }

    // Add other methods for the SinglyLinkedList class, such as Add, Remove, etc.
    public void Display()
    {
        Console.WriteLine("List : ");
        Node trav = head;

        while (trav != null)
        {
            Console.WriteLine(trav.Data);
            trav = trav.Next;
        }
        Console.WriteLine("");
    }

    public void AddFirst(int val)
    {
        // create new node and init it
        Node newNode = new Node(val);

        // new node next should point to head
        newNode.Next = head;

        // head should point to new node
        head = newNode;
    }
    public void AddLast(int val)
    {
        // create new node & init it
        Node newNode = new Node(val);

        // special 1: if list is empty, make new node as first node of list
        if (head == null)
        {
            head = newNode;
        }
        // general: add node at the end
        else
        {
            // traverse till last node
            Node trav = head;

            while (trav.Next != null)
                trav = trav.Next;

            // add new node after trav (trav.next)
            trav.Next = newNode;
        }
    }
    // ...
    public void AddAtPos(int val, int pos)
    {
        // special 1: if list is empty, add node at the start
        // special 2: if pos<=1, add node at the start
        if (head == null || pos <= 1)
            AddFirst(val);
        // general: add node at given pos
        else
        {
            // allocate & init new node
            Node newNode = new Node(val);

            // traverse till pos-1 (trav)
            Node trav = head;

            for (int i = 1; i < pos - 1; i++)
            {
                // special 3: if pos > length of list, add node at the end.
                if (trav.Next == null)
                    break;

                trav = trav.Next;
            }

            // newnode's next should point to trav's next
            newNode.Next = trav.Next;

            // trav's next should pointer to new node
            trav.Next = newNode;
        }
    }

    public void DelAll()
    {
        head = null;
        // all nodes will be garbage collected
    }


}



public class Program
{
    static void Main(string[] args)
    {
        SinglyLinkedList list = new SinglyLinkedList();
        int choice, val, pos;

        // var sc = new System.IO.StreamReader(Console.OpenStandardInput());
        do
        {
            Console.WriteLine("\n0. Exit\n1. Display\n2. Add First\n3.  Add Last\n4. Add At Pos\n5. Del First\n6.  Del Last\n7. Del At Pos\n8. Del All\nEnter choice: ");
            // choice = int.Parse(sc.ReadLine());
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: // Display
                    list.Display();
                    break;

                case 2: // Add First
                    Console.Write("Enter new element: ");
                    val = int.Parse(Console.ReadLine());
                    list.AddFirst(val);
                    break;

                case 3: // Add Last
                    Console.Write("Enter new element: ");
                    val = int.Parse(Console.ReadLine());
                    list.AddLast(val);
                    break;


                case 4: // Add At Pos
                    Console.Write("Enter new element: ");
                    val = int.Parse(Console.ReadLine());

                    Console.Write("Enter element position: ");
                    pos = int.Parse(Console.ReadLine());
                    list.AddAtPos(val, pos);
                    break;




                case 8: // Del All
                    list.DelAll();
                    break;
            }

        } while (choice != 0);




    }
}
