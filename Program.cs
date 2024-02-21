class Program
{
    static void Main(string[] args)
    {
        BinaryTree<int> tree = new();

        tree.IInOrder(tree.Create());
    }
}