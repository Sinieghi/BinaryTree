class Program
{
    static void Main(string[] args)
    {
        BinaryTree<int> tree = new();
        Node<int> root = tree.Create();
        // tree.LevelOrder(root);
        System.Console.WriteLine(tree.CountChallenge(root));
    }
}