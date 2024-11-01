public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value == Data)
            return;

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // Base Case: Check if the current node's data matches the target value
        if (value == Data)
            return true;

        // Recursive Case: Search the left subtree if the value is less than the current node's data
        if (value < Data)
        {
            // If there's a left child, continue searching recursively
            return Left != null && Left.Contains(value);
        }
        else
        {
            // Otherwise, search the right subtree
            return Right != null && Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // Base Case: If there are no left or right children, the height is 1 (just the root node).
        if (Left == null && Right == null)
            return 1;

        // Recursive Cases:
        int leftHeight = Left?.GetHeight() ?? 0;  // Get the height of the left subtree, or 0 if there is no left child.
        int rightHeight = Right?.GetHeight() ?? 0; // Get the height of the right subtree, or 0 if there is no right child.

        // Height of the current node is 1 (for the root itself) plus the maximum height of its subtrees.
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}