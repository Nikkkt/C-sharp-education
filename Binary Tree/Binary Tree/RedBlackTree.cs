namespace Binary_Tree
{
    public enum Color { Red, Black }

    public class Node
    {
        public int Data;
        public Color Color;
        public Node Parent;
        public Node Left;
        public Node Right;

        public Node(int data, Color color, Node parent, Node left, Node right)
        {
            Data = data;
            Color = color;
            Parent = parent;
            Left = left;
            Right = right;
        }
    }

    public class RedBlackTree
    {
        public Node root;

        public RedBlackTree() { root = null; }

        public void Insert(int data)
        {
            Node newNode = new Node(data, Color.Red, null, null, null);
            if (root == null) { root = newNode; root.Color = Color.Black; }
            else
            {
                Node current = root;
                Node parent = null;

                while (current != null)
                {
                    parent = current;
                    if (newNode.Data < current.Data) current = current.Left;
                    else current = current.Right;
                }

                newNode.Parent = parent;

                if (newNode.Data < parent.Data) parent.Left = newNode;
                else parent.Right = newNode;

                InsertElement(newNode);
            }
        }

        private void InsertElement(Node node)
        {
            while (node != null && node != root && node.Parent.Color == Color.Red)
            {
                if (node.Parent == node.Parent.Parent.Left)
                {
                    Node uncle = node.Parent.Parent.Right;

                    if (uncle != null && uncle.Color == Color.Red)
                    {
                        node.Parent.Color = Color.Black;
                        uncle.Color = Color.Black;
                        node.Parent.Parent.Color = Color.Red;
                        node = node.Parent.Parent;
                    }
                    else
                    {
                        if (node == node.Parent.Right) { node = node.Parent; LeftRotate(node); }
                        node.Parent.Color = Color.Black;
                        node.Parent.Parent.Color = Color.Red;
                        RightRotate(node.Parent.Parent);
                    }
                }
                else
                {
                    Node uncle = node.Parent.Parent.Left;

                    if (uncle != null && uncle.Color == Color.Red)
                    {
                        node.Parent.Color = Color.Black;
                        uncle.Color = Color.Black;
                        node.Parent.Parent.Color = Color.Red;
                        node = node.Parent.Parent;
                    }
                    else
                    {
                        if (node == node.Parent.Left) { node = node.Parent; RightRotate(node); }
                        node.Parent.Color = Color.Black;
                        node.Parent.Parent.Color = Color.Red;
                        LeftRotate(node.Parent.Parent);
                    }
                }
            }

            root.Color = Color.Black;
        }

        private void LeftRotate(Node node)
        {
            Node rightChild = node.Right;
            node.Right = rightChild.Left;
            if (rightChild.Left != null) rightChild.Left.Parent = node;
            rightChild.Parent = node.Parent;

            if (node.Parent == null) root = rightChild;
            else if (node == node.Parent.Left) node.Parent.Left = rightChild;
            else node.Parent.Right = rightChild;

            rightChild.Left = node;
            node.Parent = rightChild;
        }

        private void RightRotate(Node node)
        {
            Node leftChild = node.Left;
            node.Left = leftChild.Right;
            if (leftChild.Right != null) leftChild.Right.Parent = node;
            leftChild.Parent = node.Parent;

            if (node.Parent == null) root = leftChild;
            else if (node == node.Parent.Right) node.Parent.Right = leftChild;
            else node.Parent.Left = leftChild;

            leftChild.Right = node;
            node.Parent = leftChild;
        }
        public Node Search(int key) { return Search(root, key); }

        private Node Search(Node node, int key)
        {
            if (node == null || node.Data == key) return node;
            if (key < node.Data) return Search(node.Left, key);
            return Search(node.Right, key);
        }

        public void Print() { PrintTree(root, 0); }

        private void PrintTree(Node node, int indent)
        {
            if (node == null) return;
            if (node.Right != null) PrintTree(node.Right, indent + 4);
            if (indent > 0) Console.Write(new string(' ', indent));

            Console.WriteLine(node.Data);

            if (node.Left != null) PrintTree(node.Left, indent + 4);
        }
    }
}
