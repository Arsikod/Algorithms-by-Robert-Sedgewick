public class Quick
{
  private static int partition(IComparable[] array, int lo, int hi)
  {
    int i = lo;
    int j = hi;

    while (true)
    {
      //keep incrementing i as long as it is less than lo
      while (Less(array[++i], array[lo]))
      {
        if (i == hi) //exit if we run out of elements
        {
          break;
        }
      }
      //keep decrementing j as long as it is greater than lo
      while (Less(array[lo], array[--j]))
      {
        if (j == lo) //exit if we run out of elements
        {
          break;
        }
      }

      //test if pointers cross (i became on the right and j became on the left)
      if (i >= j)
      {
        break;
      }
      //every time i is greater than j we swap places
      Exch(array, i, j);
    }
    //at the end we just swap final j value with lo
    exch(array, lo, j);
    return j;
  }

  public static void sort(IComparable[] arr)
  {
    StdRandom.shuffle(arr);
    sort(arr, 0, arr.Length - 1);
  }

  private static void sort(IComparable[] arr, int lo, int hi)
  {
    if (hi <= lo + CUTOFF - 1)
    {
      Insertion.sort(arr, lo, hi);
      return;
    }
    int j = partition(arr, lo, hi); //tells us at which position is j
    sort(arr, lo, j - 1); //sorts recursively left part of j
    sort(arr, j + 1, hi); //sorts recursively right part of j
  }
}