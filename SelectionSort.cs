public class Selection : IComparable
{

  public static void Sort(IComparable[] array)
  {

    int numberOfItems = array.Length;

    for (int i = 0; i < numberOfItems; i++)
    {

      int min = i;
      for (int j = i + 1; j < numberOfItems; j++)
      { //for given value of i scan with j index
        if (Less(array[j], array[min])) //check if value on indej is less than on index min
        {
          min = j;
        }
      }
        Exch(array, i, min);
    }


  }

  //sorting helper functions
  public static bool Less(IComparable v, IComparable w)
  {
    return v.CompareTo(w) < 0;
  }

  public static void Exch(IComparable[] array, int i, int j)
  {
    Comparable swap = array[i];
    array[i] = array[j];
    array[j] = swap;
  }

}