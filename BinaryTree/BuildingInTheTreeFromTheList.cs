namespace BinaryTree
{
    public class BuildingInTheTreeFromTheList : IBuildingTree
    {
        public TreeNode BuildTree(string input)
        {
            string[] nodeValues = input.Split(',', StringSplitOptions.RemoveEmptyEntries);
            Queue<TreeNode> queue = new();
            TreeNode root = new(Convert.ToInt32(nodeValues[0]));
            queue.Enqueue(root);

            int i = 1;
            while (i < nodeValues.Length)
            {
                TreeNode current = queue.Dequeue();

                if (i < nodeValues.Length && nodeValues[i] != "null")
                {
                    current.left = new TreeNode(Convert.ToInt32(nodeValues[i]));
                    queue.Enqueue(current.left);
                }
                i++;

                if (i < nodeValues.Length && nodeValues[i] != "null")
                {
                    current.right = new TreeNode(Convert.ToInt32(nodeValues[i]));
                    queue.Enqueue(current.right);
                }
                i++;
            }

            return root;
        }

        public static TreeNode GetNode(TreeNode tree, string path)
        {
            if (string.IsNullOrEmpty(path))
                return new();

            TreeNode root = tree;

            foreach (char c in path)
                root = c == '0' ? root.left : root.right;

            return root;    
        }
    }
}
