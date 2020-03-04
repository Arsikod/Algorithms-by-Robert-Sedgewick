public class Insertion : IComparable
{

  public static void Sort(Comparable[] array)
  {
    int numberOfItems = array.Length;

    for (int i = 0; i < numberOfItems; i++)
    {
      for (int j = i; j > 0; j--)
      {
        if (Less(array[j], array[i]))
        {
          Exch(array, j, j - 1);
        }
      }
    }
  }

  public static bool Less(IComparable[] array, int i, int j)
  {
    return i.CompareTo(j) < 0;
  }

  public static void Exch(IComparable array, int i, int j)
  {
    IComparable swap = array[i];
    array[i] = array[j];
    array[j] = swap;
  }



}