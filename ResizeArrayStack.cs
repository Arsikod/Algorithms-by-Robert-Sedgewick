using System.Collections.Generic;

namespace Algs4
{
  public class ResizedArrayStack<Item> : IEnumerable<Item>
  {
    private Item[] arrayOfItems; //declare array with generic type
    private int numberOfElements; //number of elements in stack

    //initialize empty stack with array of size 1
    public ResizedArrayStack()
    {
      arrayOfItems = new Item[1];
      numberOfElements = 0;
    }

    //check if stack is empty
    public bool IsEmpty
    {
      get { return numberOfElements == 0; }
    }

    //do the resizing but make sure that it does not happen frequently
    public void Resize(int capacity)
    {

      Item[] temporaryArray = new Item[capacity]; //create new sized array
      for (int i = 0; i < numberOfElements; i++)
      {
        temporaryArray[i] = arrayOfItems[i]; //copy from original array
      }

      arrayOfItems = temporaryArray;
    }

    public void Push(Item item)
    {
      if (arrayOfItems.Length == numberOfElements)
      {
        Resize(arrayOfItems.Length * 2); //double if array is full
      }
      arrayOfItems[numberOfElements++] = item;
    }

    public Item Pop()
    {
      if (IsEmpty())
      {
        throw new InvalidOperation("Stack underflow");
      }

      Item item = arrayOfItems[numberOfElements - 1]; //save item to return
      arrayOfItems[numberOfElements - 1] = default(Item); //avoid loitering by setting to null
      numberOfElements--;

      if (numberOfElements > 0 && numberOfElements == arrayOfItems.Length / 4)
      { //check if array is quarter full
        Resize(arrayOfItems.Length / 2); //then we resize it to half full
      }
      return item;
    }
  }
}