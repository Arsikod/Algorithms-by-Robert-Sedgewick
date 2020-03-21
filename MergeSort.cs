public class MergeSort : IComparable
{

  private static void merge(IComparable[] arr, IComparable[] aux, int lo, int mid, int hi)
  {

    for (int k = lo; k <= hi; k++) //copy main array into aux array
    {
      aux[k] = arr[k];
    }

    //merge
    int i = lo;
    int j = mid + 1;

    for (int k = lo; k <= hi; k++)
    {
      if (i > mid)
      { //if left side is exhausted
        arr[k] = aux[j++];
      }
      else if (j > hi)
      { //if right side is exhausted
        arr[k] = aux[k];
      }
      else if (Less(aux[j], aux[i])) //compare and copy back into array
      {
        arr[k] = aux[j++];
      }
      else
      {
        arr[k] = aux[i++];
      }
    }
  }

  private static void Sort(IComparable[] arr, IComparable[] aux, int lo, int hi)
  {
    if (hi <= lo) return; //exit when reaches the bottom elements (length < 2)

    int mid = (lo + hi - 1) / 2;

    Sort(arr, aux, lo, mid); //sort recursively left side [lo...mid]
    Sort(arr, aux, mid + 1, hi); //sort recursively right side [mid + 1, hi]

    if (!Less(arr[j], arr[i])) return; //check if already sorted

    merge(arr, aux, lo, mid, hi);

  }

  //sort for creating aux array
  private static void Sort(IComparable[] arr)
  {
    aux = new IComparable[arr.Length];
    Sort(arr, aux, 0, arr.Length - 1);
  }

  private static bool Less(IComparable v, IComparable w)
  { //helper function to compare
    return v.CompareTo(w) < 0;
  }

}