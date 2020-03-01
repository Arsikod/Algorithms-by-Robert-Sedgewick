public class LinkedQueue
{
  private int numberOfElements;
  private Node first;
  private Node last;

  private class Node
  {
    Item value;
    Node next;

  }

  //empty queue
  public LinkedQueue()
  {
    first = null;
    last = null;
    numberOfElements = 0;
  }

  public bool IsEmpty()
  {
    return numberOfElements;
  }

  //pop item from beginning
  public Item Dequeue()
  {
    if (IsEmpty())
    {
      throw new ExceptionOutOfRange("underflow");
    }

    Item popped = first.value;
    first = first.next;
    numberOfElements--;
    if (IsEmpty())
    {
      last = null;
    }

    return popped;
  }

  public void Enqueue(Item newValue)
  {
    Node oldLast = last;
    last = new Node();
    last.value = newValue;
    last.next = null;
    if (IsEmpty())
    {
      first = last;
    }
    else
    {
      oldLast.next = last;
    }
    numberOfElements++;
  }
}