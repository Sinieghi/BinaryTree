class Queue<T>
{
    public int Front { get; set; }
    public int Rear { get; set; }
    public int Size { get; set; }
    Node<T>[] Q;

    public Queue(int size)
    {
        Q = new Node<T>[size]; Size = size;
    }


    //circular queue all O(1)
    public void Enqueue(Node<T> x)
    {

        if ((Rear + 1) % Size == Front) System.Console.WriteLine("Queue is full");
        else
        {
            Rear = (Rear + 1) % Size;
            Q[Rear] = x;
        }
    }
    public Node<T> Dequeue()
    {
        Node<T> x = null;
        if (Rear == Front) System.Console.WriteLine("Queue is empty");
        else
        {
            Front = (Front + 1) % Size;
            x = Q[Front];
        }
        return x;
    }

    //those methods allows you to add using Rear or Front 
    public void DEqueue(Node<T> x)
    {

        if (Rear != Size - 1)
        {
            Rear++;
            Q[Rear] = x;
        }
        else if (Front != -1)
        {
            Q[Front] = x;
            Front--;
        }
        else System.Console.WriteLine("Queue is full");

    }
    public Node<T> DEdequeue()
    {
        Node<T> x = null;
        if (Rear == Front) System.Console.WriteLine("Queue is empty");
        else
        {
            Front++;
            x = Q[Front];
        }
        return x;
    }

    public void Display()
    {
        int i = Front + 1;
        do
        {
            System.Console.Write(Q[i] + " ");
            i = (i + 1) % Size;
        } while (i != (Rear + 1) % Size);
        System.Console.WriteLine();
    }
    public bool IsEmpty()
    {
        return Front == Rear;
    }
}