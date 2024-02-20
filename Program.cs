class Program
{
    static void Main(string[] args)
    {
        BinaryTree<int> tree = new();

        tree.InOrder(tree.Create());
    }
}