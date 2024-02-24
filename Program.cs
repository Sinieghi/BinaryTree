class Program
{
    static void Main(string[] args)
    {
        BinaryTree<int> tree = new();
        Node<int> root = null;
        tree.CreatePre([10, 20, 30, 40, 50], 5);
        // tree.RInsert(root, 5);
        // tree.RInsert(root, 20);
        // tree.RInsert(root, 8);
        // tree.RInsert(root, 30);
        // // tree.LevelOrder(root);
        // System.Console.WriteLine(tree.CountChallenge(root));
        // System.Console.WriteLine(tree.Search(root, 30).data);
        // tree.RInsert(root, 31);
        tree.Delete(root, 20);
        tree.InOrder(root);
    }
}