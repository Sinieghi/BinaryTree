class BinaryTree<T>
{
    public Node<T>? root = null;

    public Node<int> Create()
    {
        System.Console.WriteLine("Enter root values");
        int x = int.Parse(Console.ReadLine());
        Node<int> p, t, root = new() { data = x, lchild = null, rchild = null };
        Queue<int> queue = new(100);
        queue.Enqueue(root);
        while (!queue.IsEmpty())
        {
            p = queue.Dequeue();

            System.Console.WriteLine("Enter left child of " + p.data);
            x = int.Parse(Console.ReadLine());
            if (x != -1)
            {
                t = new() { data = x, lchild = null, rchild = null };
                p.lchild = t;
                queue.Enqueue(t);
            }
            System.Console.WriteLine("Enter right child of " + p.data);
            x = int.Parse(Console.ReadLine());
            if (x != -1)
            {
                t = new() { data = x, lchild = null, rchild = null };
                p.rchild = t;
                queue.Enqueue(t);
            }
        }
        return root;
    }

    public void PreOrder(Node<T> node)
    {
        if (node != null)
        {
            System.Console.WriteLine(node.data);
            PreOrder(node.lchild);
            PreOrder(node.rchild);
        }
    }

    public void IPreOrder(Node<int> node)
    {
        StackMethods st = new();
        st.Create(20);
        while (node != null || !st.IsEmpty())
        {
            if (node != null)
            {
                System.Console.WriteLine(node.data);
                st.Push(node);
                node = node.lchild;
            }
            else
            {
                node = st.Pop();
                node = node.rchild;
            }
        }
    }
    public void InOrder(Node<T> node)
    {
        if (node != null)
        {
            PreOrder(node.lchild);
            System.Console.WriteLine(node.data);
            PreOrder(node.rchild);
        }
    }

    public void IInOrder(Node<int> node)
    {
        StackMethods st = new();
        st.Create(20);
        while (node != null || !st.IsEmpty())
        {
            if (node != null)
            {
                st.Push(node);
                node = node.lchild;
            }
            else
            {
                node = st.Pop();
                System.Console.WriteLine(node.data);
                node = node.rchild;
            }
        }
    }
    public void PostOrder(Node<T> node)
    {
        if (node != null)
        {
            PreOrder(node.lchild);
            PreOrder(node.rchild);
            System.Console.WriteLine(node.data);
        }
    }

    public int Height(Node<int> root)
    {
        int x, y;
        if (root == null) return 0;
        x = Height(root.lchild);
        y = Height(root.rchild);


        if (x > y) return x + 1;
        else return y + 1;

    }

    public void LevelOrder()
    {
        Queue<T> q = new(100);

        q.Enqueue(root);

        while (!q.IsEmpty())
        {
            root = q.Dequeue();
            if (root.lchild != null)
            {
                System.Console.WriteLine(root.lchild.data);
                q.Enqueue(root.lchild);
            }
            if (root.rchild != null)
            {
                System.Console.WriteLine(root.rchild.data);
                q.Enqueue(root.rchild);
            }
        }

    }

}