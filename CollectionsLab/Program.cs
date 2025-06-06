namespace CollectionsLab
{
    internal class Program
    {
        public static IEnumerable<double> Mathoperations(int num1, int num2)
        {
            yield return num1 + num2;
        }
        static void Main(string[] args)
        {
            //MyStringCollection myCollection = new MyStringCollection(new List<string> { "apple", "banana", "cherry" });
            //myCollection.Add("date");
            //myCollection.Remove("banana");
            //Console.WriteLine("Contains 'apple': " + myCollection.Contains("apple"));
            //Console.WriteLine("Contains 'banana': " + myCollection.Contains("banana"));
            //Console.WriteLine("All items in the collection:");
            //myCollection.PrintAll();
            //=============================================================

            //EvenNumberCollection evenNumbers = new EvenNumberCollection(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            //Console.WriteLine("Even numbers in the collection:");
            //foreach (var number in evenNumbers)
            //{
            //    Console.WriteLine(number);
            //}

            //=============================================================
            foreach (var result in Mathoperations(5, 10))
            {
                Console.WriteLine(result);
            }

        }

        
    }
}
