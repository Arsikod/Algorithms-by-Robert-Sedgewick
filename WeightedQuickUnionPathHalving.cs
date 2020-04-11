public class WeightedQuickUnionWithPathHalving
{
  //initiate id and size arrays
  private int[] id;
  private int[] sz;
  public int Count { get; private set; }

  //constructor to set id, size and count
  public WeightedQuickUnionWithPathHalving(int numberOfItems)
  {

    id = new int[numberOfItems];
    sz = new int[numberOfItems];
    Count = numberOfItems; //number of disjoint sets

    //set ids and initial size
    for (int i = 0; i < numberOfItems; i++)
    {
      id[i] = i; //initial id is itself => points at itself
      sz[i] = 1; //initial sizes of any element is 1;
    }
  }

  //find roots of elements
  public int Find(int i)
  {

    while (i != id[i])
    {
      id[i] = id[id[i]]; //path halving
      i = id[i]; //keep going up to root
    }

    return i; //returns a root of an element
  }

  //check if elements have same root(connected)
  public bool Connected(int i, int j)
  {

    return Find(i) == Find(j);

  }

  //union by weight and increase size of larger tree by smaller one
  public void Union(int i, int j)
  {

    int iRoot = Find(i); //store roots of each element in variable
    int jRoot = Find(j); //store roots of each element in variable

    if (iRoot == jRoot)
    {
      return; // exit the function if roots are the same as Connected(i, j)
    }

    if (sz[iRoot] < sz[jRoot])
    {
      sz[jRoot] += sz[iRoot]; //add size of smaller tree to larger tree
      id[iRoot] = jRoot; //set root of larger as root of smaller
    }
    else
    {
      sz[iRoot] += sz[jRoot];
      id[jRoot] = iRoot;
    }

    Count--; //adjust size of disjoint sets
  }


}