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
                case "selectionsort":
                    Console.WriteLine("Selection Sort: Sorting an array using the Selection Sort algorithm.");
                    Console.WriteLine("Input a comma-separated list of integers to sort, or press Enter to use the default array.");
                    string? selectionInput = Console.ReadLine();
                    int[] selectionArray = string.IsNullOrEmpty(selectionInput) ? [64, 34, 25, 12, 22, 11, 90, 5] : selectionInput.Split(',').Select(int.Parse).ToArray();
                    Console.WriteLine("Original Array: " + string.Join(", ", selectionArray));
                    Console.WriteLine("Sorted Array, min to max: " + string.Join(", ", SelectionSort.Sort(selectionArray, true)));
                    Console.WriteLine("Sorted Array, max to min: " + string.Join(", ", SelectionSort.Sort(selectionArray, false)));
                    break;
                case "stalinsort":
                    Console.WriteLine("Stalin Sort: Sorting an array using the Stalin Sort algorithm.");
                    Console.WriteLine("Input a comma-separated list of integers to sort, or press Enter to use the default array.");
                    string? stalinInput = Console.ReadLine();
                    int[] stalinArray = string.IsNullOrEmpty(stalinInput) ? [64, 34, 25, 12, 22, 11, 90, 5] : stalinInput.Split(',').Select(int.Parse).ToArray();
                    Console.WriteLine("Original Array: " + string.Join(", ", stalinArray));
                    Console.WriteLine("Sorted Array, min to max: " + string.Join(", ", StalinSort.Sort(stalinArray, true)));
                    Console.WriteLine("Sorted Array, max to min: " + string.Join(", ", StalinSort.Sort(stalinArray, false)));
                    break;
                default:
                    Console.WriteLine($"No sort named \"{input}\" is accounted for");
                    break;
            }
            Console.ReadKey(true); // Wait for a key press before closing the console window
        }
    }
}
