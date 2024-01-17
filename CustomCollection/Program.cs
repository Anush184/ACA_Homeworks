using CustomCollection;
using CustomCollectionExample;

internal class Program
{
    public static void Main(string[] args)
    {
        CustomCollection<int> customCollection = new CustomCollection<int>();
        CustomCollectionOperations customCollectionOperations = new();

        customCollection.ElementAdded += customCollectionOperations.CustomCollection_ElementAdded;
        customCollection.ElementRemoved += customCollectionOperations.CustomCollection_ElementRemoved;

        customCollection.Add(1);
        customCollection.Add(2);
        customCollection.Add(3);
        customCollection.Add(4);
        customCollection.Add(5);
      
        customCollection.ShowElements();

        customCollection.Remove(1);
        customCollection.Remove(9);

        customCollection.ShowElements();
    }
}