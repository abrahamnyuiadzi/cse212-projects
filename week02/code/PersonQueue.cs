using System.Collections.Generic;
using System.Text;

public class PersonQueue
{
    private readonly Queue<Person> _queue = new();

    public int Length => _queue.Count;

    public void Enqueue(Person person)
    {
        _queue.Enqueue(person);
    }

    public Person Dequeue()
    {
        return _queue.Dequeue();
    }

    public bool IsEmpty()
    {
        return _queue.Count == 0;
    }

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.Append("[");
        sb.Append(string.Join(", ", _queue));
        sb.Append("]");
        return sb.ToString();
    }
}
