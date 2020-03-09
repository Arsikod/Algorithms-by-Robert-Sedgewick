public class Insertion : IComparable
{

  public static void Sort(Comparable[] array)
  {
    int numberOfItems = array.Length;

    for (int i = 0; i < numberOfItems; i++)
    {
      for (int j = i; j > 0; j--) //j equals to i = iteration number, and keeps getting smaller by 1
      {
        if (Less(array[j], array[i]))
        {
          Exch(array, j, j - 1);
        }
      }
    }
  }

  public static bool Less(IComparable i, IComparable j) //check if j is less that j-1 to its left
  {
    return i.CompareTo(j) < 0;
  }

  public static void Exch(IComparable[] array, int i, int j)
  {
    IComparable swap = array[i];
    array[i] = array[j];
    array[j] = swap;
  }
}