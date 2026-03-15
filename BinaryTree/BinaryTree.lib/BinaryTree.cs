namespace BinaryTree.lib;
public class BinaryTree
{
    private Node? _root;

    public BinaryTree()
    {
        _root = null;
    }

    public BinaryTree(int value)
    {
        _root = new Node(value);
    }

    public BinaryTree(IList<int> values) : this()
    {
        foreach (int value in values)
            Insert(value);
    }

    public void Insert(int value)
    {
        if (_root == null)
            _root = new Node(value);
        else
            _root.Insert(value);
    }

    public bool Contains(int value)
    {
        return _root != null && _root.Contains(value);
    }

    public int Sum
    {
        get
        {
            if (_root == null)
                return 0;
            else
                return _root.Sum;
        }
    }

    public override string ToString()
    {
        return _root == null ? string.Empty : _root.ToInOrderString();
    }

    internal class Node
    {
        private int _value;
        private Node? _left;
        private Node? _right;

        internal Node(int value)
        {
            _value = value;
            _left = null;
            _right = null;
        }

        internal void Insert(int value)
        {
            if (value == _value)
                return;

            if (value < _value)
            {
                if (_left == null)
                    _left = new Node(value);
                else
                    _left.Insert(value);
            }
            else
            {
                if (_right == null)
                    _right = new Node(value);
                else
                    _right.Insert(value);
            }
        }

        internal bool Contains(int value)
        {
            if (value == _value)
                return true;

            if (value < _value)
                return _left != null && _left.Contains(value);

            return _right != null && _right.Contains(value);
        }

        internal int Sum
        {
            get
            {
                int leftSum = _left == null ? 0 : _left.Sum;
                int rightSum = _right == null ? 0 : _right.Sum;
                return leftSum + _value + rightSum;
            }
        }

        internal string ToInOrderString()
        {
            StringBuilder sb = new StringBuilder();

            if (_left != null)
                sb.Append(_left.ToInOrderString());

            if (sb.Length > 0)
                sb.Append(' ');

            sb.Append(_value);

            if (_right != null)
            {
                sb.Append(' ');
                sb.Append(_right.ToInOrderString());
            }

            return sb.ToString();
        }
    }
}