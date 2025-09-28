namespace ConsoleApp1;

// Complexity: O(n^2), because of the nested for loop
public static class BubbleSort
{
    public static int[] Sort(int[] nums)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            var swapped = false;
            for (int b = 0; i < nums.Length - 1 - b; b++)
            {
                if (nums[b] > nums[b + 1])
                {
                    (nums[b], nums[b + 1]) = (nums[b + 1], nums[b]);
                    swapped = true;
                }
                else if(!swapped)
                {
                    break;
                }
            }
        }

        return nums;
    }
}