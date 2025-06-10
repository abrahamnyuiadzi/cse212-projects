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
        {
            return;
        }
        // TODO Start Problem 1

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
        if (value == Data)
        {
            return true;
        }
        // if the value is less recursively search in left subtree
        else if (value < Data)
        {
            if (Left == null)
                return false;
            else
                return Left.Contains(value);
        }
        else
        {
            // if the value is greater recursively search in left subtree
            if (Right == null)
                return false;
            else
                return Right.Contains(value);
        }
        // TODO Start Problem 2

    }

    public int GetHeight()
    {
        int leftHeight = Left != null ? Left.GetHeight() : 0;
        int rightHeight = Right != null ? Right.GetHeight() : 0;

        return 1 + Math.Max(leftHeight, rightHeight);
    }
}