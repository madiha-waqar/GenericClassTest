using System;

class Program
{
    static void Main(string[] args)
    {
        var collection = new ValueTypeCollection<int>();

        collection.AddItem(5);
        collection.AddItem(3);
        collection.AddItem(10);
        collection.AddItem(1);

        int itemAtIndex1 = collection.GetItem(1);
        Console.WriteLine($"Item at index 1: {itemAtIndex1}");

        var sortedItems = collection.GetSortedDescending();
        Console.WriteLine("Items in descending order:");
        foreach (var item in sortedItems)
        {
            Console.WriteLine(item);
        }
    }
}
