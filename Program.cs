namespace D15BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Tree Data Structure"); //welcome msg

            BinaryTree<int> binaryTree = new BinaryTree<int>(56);
            binaryTree.Insert(30);
            binaryTree.Insert(70);
            binaryTree.Insert(85);
            binaryTree.Insert(23);
            binaryTree.Insert(81);
            binaryTree.Insert(96);
            binaryTree.Display();
        }
    }
}