using System.Collections.Generic;

public class Stack<Item> : IEnumerable<Item>
{

  //create a nested Node class
  private class Node
  {
    public Item data; //value of Node object
    public Node next; //next element in stack

  }

  //number of items in the stack
  public int Size { get; private set; }

  //create first node in stack
  private Node first;

  //empty stack initializer
  public Stack()
  {
    first = null;
    Size = 0;
  }

  //check if stack is empty
  public bool IsEmpty()
  {
    return first == null;
  }

  //pop first generic item and return popped
  public Item Pop()
  {
    if (IsEmpty())
    {
      throw new IndexOutOfRangeException("Stack underflow");
    }

    var popped = first; //save to return
    first = first.next; //second item in stack becomes first

    return popped;
  }

  //push to beginning of the stack
  public void Push(Item data)
  {

    var oldFirst = first;
    first = new Node();
    first.data = data;
    first.next = oldFirst;

    Size++;

  }



}