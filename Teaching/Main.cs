using DataStructure;

internal class Program
{
    private static void Main(string[] args)
    {
        BinaryTree<int> binaryTree = new BinaryTree<int>(50, null);

        binaryTree.add(60);
        binaryTree.add(70);
        binaryTree.add(55);
        binaryTree.add(10);
        binaryTree.add(15);
        binaryTree.add(20);

        binaryTree.remove(70);
        binaryTree.remove(15);
        binaryTree.remove(50);

        binaryTree.print();
    }

}