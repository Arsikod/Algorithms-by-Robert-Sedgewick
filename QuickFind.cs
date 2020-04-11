public class QuickFindUF
{

  private int[] id;

  //constructor
  public QuickFindUF(numberOfItems)
  {

    id = new int[numberOfItems];

    for (int i = 0; i < numberOfItems; i++)
    {
      id[i] = i;
    }

  }

  public bool Connected(int p, int q)
  {
    return id[p] == id[q];
  }

  public void Union(int p, int q)
  {

    int pNumber = id[p];
    int qNumber = id[q];

    for (int i = 0; i < id.Length; i++)
    {
      if (id[i] == pNumber)
      {
        id[i] = qNumber;
      }
    }


  }




}