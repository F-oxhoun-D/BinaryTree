namespace BinaryTree
{
    public class Solution
    {
        // обход бинарного дерева по порядку
        public IList<int> InorderTraversal(TreeNode root) => Traversal(root, []);

        private static IList<int> Traversal(TreeNode root, IList<int> tree)
        {
            if (root == null) return tree;

            if (root.left == null && root.right == null)
            {
                tree.Add(root.val);
                return tree;
            }

            Traversal(root.left!, tree);
            tree.Add(root.val);
            Traversal(root.right, tree);

            return tree;
        }
    }
}
