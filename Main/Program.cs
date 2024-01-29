namespace Main
{
    internal class Program
    {
        /// <summary>
        /// Tutorial: https://www.csharptutorial.net/csharp-tutorial/c-indexer/
        /// </summary>
        static void Main(string[] args)
        {
            int index = 5;

            // Example 1: return the word at a certain position in a sentence
            var sentence = new Sentence("The quick brown fox jumps over the lazy dog");
            Console.WriteLine("The word at position {0} is: \"{1}\"", index, sentence[index]);

            // Example 2: return every item in the list which is a multiplier of the number passed as parameter
            var items = new ItemList(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 });
            Console.WriteLine("Multipliers of {0} are: {1}", index, String.Join(", ", items[index].ToArray()));

            // Examle 3: return an object property with an indexer
            var p = new Person()
            {
                ID = 1,
                FirstName = "Foo",
                LastName = "Bar"
            };
            Console.WriteLine("Property \"FirstName\" is of type {0} and has value \"{1}\"", p["FirstName"].GetType(), p["FirstName"]);
        }
    }
}