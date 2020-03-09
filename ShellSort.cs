public class Shell
{

  public static void Sort(IComparable[] array)
  {

    int numberOfitems = array.Length;

    //Knuths 3x+1 increment sequence
    int h = 1;
    while (h < N / 3)
    {
      h = 3 * h + 1;
    }

    while (h >= 1)
    {
      //h-sort the array
      for (int i = h; i < numberOfitems; i++)
      {
        for (int j = i; j >= h && Less(array[j], array[j - h]); j -= h)
        {
          Exch(array, j, j - h);
        }
      }
      h = h / 3;
    }

  }

  public static bool Less(IComparable v, IComparable w)
  {
    return v.CompareTo(w) < 0;
  }

  public static void Exch(IComparable[] array, int i, int j)
  {
    IComparable swap = array[i];
    array[i] = array[j];
    array[j] = swap;
  }

}