public class MergeBU : IComparable
{
  private static IComparable[] aux;

  private static void Merge(IComparable[] arr, IComparable[] aux, int lo, int mid, int hi)
  {

    for (int k = lo; k <= hi; k++)
    {
      aux[k] = arr[k];
    }

    int i = lo;
    int j = mid + 1;

    for (int k = lo; k <= hi; k++)
    {
      if (i > mid)
      {
        arr[k] = aux[j++];
      }
      else if (j > hi)
      {
        arr[k] = aux[i++];
      }
      else if (Less(aux[j], aux[i]))
      {
        arr[k] = aux[j++];
      }
      else
      {
        arr[k] = aux[i++];
      }
    }
  }

  public static void Sort(IComparable[] arr)
  {
    int numberOfItems = arr.Length;
    aux = new IComparable[numberOfItems];
    for (int size = 1; size < numberOfItems; size = size + size)
    {
      for (int lo = 0; lo < numberOfItems - size; lo += size + size)
      {
        Merge(arr, lo, lo + size - 1, Math.min(lo + size + size - 1, numberOfItems - 1));
      }
    }
  }

  public static void Less(IComparable a, IComparable b)
  {
    return a.CompareTo(b) < 0;
  }
}