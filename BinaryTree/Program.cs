namespace BinaryTree
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите бинарное дерево в формате списка: (1, 2, 3, 4, ...)");
            Console.WriteLine("Если узел отсутствует введите null: (1, 2, 3, null, null, 1, null)");
            Console.WriteLine("Где корень дерева - 1; левый узел - 2 (у него нет узлов); правый - 3 (у него присутствует " +
                "только левый узел - 1)\n\n");

            Console.WriteLine("Дерево в формате списка значений: ");
            string text = Console.ReadLine()!;

            BuildingInTheTreeFromTheList build = new();
            TreeNode treeNode = build.BuildTree(text);
        }
    }
}
