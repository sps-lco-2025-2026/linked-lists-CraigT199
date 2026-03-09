namespace LinkedListIntroduction.Lib;

public class SortedIntegerLinkedList : IntegerLinkedList
{
    public override void Append(int value)
    {
        InsertSorted(value);
    }

    private void InsertSorted(int value)
    {
        if (_head == null || value < _head.Value)
        {
            Prepend(value);
        }
        else
        {
            _head.InsertSorted(value);
        }
    }
}