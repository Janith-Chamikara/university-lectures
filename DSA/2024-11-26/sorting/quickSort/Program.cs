// Select Pivot point
// Partitioning => 1, 7, 5, 2, 3 => 1, 2, 3, 7, 5
// Recursion => (1, 2), (7, 5) <-- Base (only one element)

class Sort
{
    // low => first element of the array or subarray
    // high => last element of the array or subarray
    static int Partition(int[] array, int low, int high)
    {
        // Choose the last element as the pivot
        int pivot = array[high];
        // Index of the smaller element
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        // Moving the pivot after the smaller elements
        Swap(array, i + 1, high);
        return i + 1; // Return the index of the pivot
    }

    static void Swap(int[] array, int x, int y)
    {
        int temp = array[x];
        array[x] = array[y];
        array[y] = temp;
    }

    static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivot = Partition(array, low, high);

            // Recursive calls for smaller subarrays
            QuickSort(array, low, pivot - 1);
            QuickSort(array, pivot + 1, high);
        }
    }

    static void Main(string[] args)
    {
        int[] array = { 10, 7, 8, 9, 1, 5, -10, 0, 10, 21 };
        int n = array.Length;

        QuickSort(array, 0, n - 1);

        foreach (int i in array)
        {
            Console.Write(i + "  ");
        }
    }
}