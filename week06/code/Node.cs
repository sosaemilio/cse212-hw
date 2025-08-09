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
        // TODO Start Problem 1

        // Check if the value is a duplicate
        if (value == Data)
        {
            return;
        }

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
        // TODO Start Problem 2
        if (value == Data)
        {
            return true;
        }
        else if (value < Data)
        {
            // Search the left subtree
            return Left?.Contains(value) ?? false;
        }
        else
        {
            // Search the right subtree
            return Right?.Contains(value) ?? false;
        }

    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        int leftHeight = (Left != null) ? Left.GetHeight() : -1;
        int rightHeight = (Right != null) ? Right.GetHeight() : -1;

        return Math.Max(leftHeight, rightHeight) + 1;
    }
}