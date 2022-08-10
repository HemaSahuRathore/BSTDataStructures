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
            binaryTree.Insert(22);
            binaryTree.Insert(40);
            binaryTree.Insert(60);
            binaryTree.Insert(95);
            binaryTree.Insert(11);
            binaryTree.Insert(65);
            binaryTree.Insert(3);
            binaryTree.Insert(16);
            binaryTree.Insert(63);
            binaryTree.Insert(67);
            binaryTree.Display();
            binaryTree.GetSize();
            bool result = binaryTree.IfExists(63, binaryTree);
            Console.WriteLine("Element Found : " + result);
        }
    }
}