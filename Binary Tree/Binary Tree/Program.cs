using Binary_Tree;

RedBlackTree tree = new RedBlackTree();
tree.Insert(10);
tree.Insert(20);
tree.Insert(5);
tree.Insert(2);
tree.Insert(7);
tree.Insert(15);
tree.Insert(30);
tree.Insert(40);
tree.Insert(50);
tree.Insert(60);
tree.Insert(70);
tree.Print();

List<Node> searchResults = new List<Node> { tree.Search(30), tree.Search(35) };
foreach (Node result in searchResults)
{
    if (result != null) Console.WriteLine($"\nFound: {result.Data}"); // Found: 30
    else Console.WriteLine("\nNot found"); // Not found
}