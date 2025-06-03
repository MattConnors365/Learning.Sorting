namespace Learning.Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What sort to use?");
            string input = Console.ReadLine() ?? "help";
            switch (input.ToLower())
            {
                case "help":
                    Console.WriteLine("Help: This is a sorting program.");
                    Console.WriteLine("Available sorts: bubblesort");
                    break;
                case "bubblesort":
                    Console.WriteLine("Bubble Sort: Sorting an array using the Bubble Sort algorithm.");
                    Console.WriteLine("Input a comma-separated list of integers to sort, or press Enter to use the default array.");
                    string? inputArray = Console.ReadLine();
                    int[] bubbleArray = string.IsNullOrEmpty(inputArray) ? [64, 34, 25, 12, 22, 11, 90, 5] : inputArray.Split(',').Select(int.Parse).ToArray();
                    Console.WriteLine("Original Array: " + string.Join(", ", bubbleArray));
                    Console.WriteLine("Sorted Array, min to max: " + string.Join(", ", BubbleSort.Sort(bubbleArray, true)));
                    Console.WriteLine("Sorted Array, max to min: " + string.Join(", ", BubbleSort.Sort(bubbleArray, false)));
                    break;
                default:
                    Console.WriteLine($"No sort named \"{input}\" is accounted for");
                    break;
            }
            Console.ReadKey(true); // Wait for a key press before closing the console window
        }
    }
}
