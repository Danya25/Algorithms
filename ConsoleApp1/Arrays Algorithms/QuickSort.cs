namespace ConsoleApp1;
// Complexity O(n log n)
public static class QuickSort
{
    private static int Partition(int[] array, int leftIndex, int rightIndex)
    {
        var startElement = array[rightIndex];
        var i = leftIndex - 1;

        for (int j = leftIndex; j < rightIndex; j++)
        {
            if (array[j] <= startElement)
            {
                i++;
                (array[i], array[j]) = (array[j], array[i]);
            }
        }
        
        (array[i+1], array[rightIndex]) = (array[rightIndex], array[i+1]);

        return i + 1;
    }

    public static int[] Sort(int[] array, int lowIndex = 0, int highIndex = Int32.MaxValue)
    {
        if (highIndex == Int32.MaxValue)
        {
            highIndex = array.Length - 1;
        }
        
        if (lowIndex < highIndex)
        {
            var startIndex = Partition(array, lowIndex, highIndex);
            Sort(array, lowIndex, startIndex - 1);
            Sort(array, startIndex + 1,  highIndex);
        }

        return array;
    }
}