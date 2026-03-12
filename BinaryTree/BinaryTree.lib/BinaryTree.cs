namespace BinaryTree.lib;

public class BinaryTree
{
    BinaryTreeNode? _root;

    public BinaryTree()
    {
        _root = null;
    }

    public BinaryTree(int v)
    {
        _root = new BinaryTreeNode(v);
    }

    public BinaryTree(IList<int> values) : this()
    {
        foreach (int v in values)
            Insert(v);
    }

    public void Insert(int value)
    {
        if (_root == null)
            _root = new BinaryTreeNode(value);
        else
            _root.Insert(value);
    }

    public int Count => _root == null ? 0 : _root.Count;
    public int Sum => _root == null ? 0 : _root.Sum;
}

    internal BinaryTreeNode(int v)
    {
        _value = v;
        _next = null;
    }
    internal BinaryTreeNode(int v, BinaryTreeNode? ptr)
    {
        _value = v;
        _next = ptr;
    }
}

public class BinaryTreeNode
{
    int _value;
    BinaryTreeNode? _next;

    internal int Value => _value;
    internal BinaryTreeNode? Next => _next;
    internal int Count => _next == null ? 1 : 1 + _next.Count;
            
    internal int Sum => _next == null ? _value : _value + _next.Sum;


    internal BinaryTreeNode(int v)
    {
        _value = v;
        _next = null;
    }
    internal BinaryTreeNode(int v, BinaryTreeNode? ptr) 
    {
        _value = v;
        _next = ptr;
    }

    public int Count => _head == null ? 0 : _head.Count;
    public int Sum => _head == null ? 0 : _head.Sum;

    public void Insert(int value)
    {
        if (_root == null)
            _root = new BinaryTreeNode(value);
        else
            _root.Insert(value);


        if (value == Value)
            return; 


        if (value < Value)
        {
            if (Left == null)
                Left = new BinaryTreeNode(value);
            else
                Left.Insert(value);
        }
        else
        {
            if (Right == null)
                Right = new BinaryTreeNode(value);
            else
                Right.Insert(value);
        }
    }

    public void checkDupes(BinaryTreeNode T, int value)
    {
        for(int i =0; i<T.length; i++)
        {
            if(T[i] == value)
                return T;
            else if(_head> value)

            
        }
    }
    }

