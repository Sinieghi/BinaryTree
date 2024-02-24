class StackMethods
{
    public Stack stack;
    public StackMethods() { stack = null; }

    public void Create(int size)
    {
        System.Console.WriteLine("Size");
        stack = new()
        {
            Size = size,
            Top = -1
        };
        stack.S = new Node<int>[stack.Size];
    }

    public void Display()
    {
        int i;
        for (i = stack.Top; i >= 0; i--)
        {
            System.Console.WriteLine(stack.S[i]);
            System.Console.WriteLine();
        }
    }
    public void Push(Node<int> x)
    {
        if (stack.Top == stack.Size - 1) System.Console.WriteLine("Overflow");
        else
        {
            stack.Top++;
            stack.S[stack.Top] = x;
        }
    }

    public Node<int> Pop()
    {
        Node<int> x = null;
        if (stack.Top == -1) System.Console.WriteLine("Underflow");
        else x = stack.S[stack.Top--];
        return x;
    }

    public Node<int> Peek(int index)
    {
        Node<int> x = null;
        if (stack.Top - index + 1 < 0) System.Console.WriteLine("Invalid index");
        else { x = stack.S[stack.Top - index + 1]; }
        return x;
    }

    public bool IsEmpty()
    {
        if (stack == null) return true;
        if (stack.Top == -1)
            return true;
        return false;
    }
    public bool IsFull()
    {
        return stack.Top == stack.Size - 1;
    }

    public Node<int> StackTop()
    {
        if (!IsEmpty()) return stack.S[stack.Top];
        return null;
    }
}