namespace ConsoleApp1;

// Complexity: O(n^2)
public static class SelectionSort
{
    public static int[] Sort(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for(var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] >= nums[j])
                {
                    (nums[i], nums[j]) = (nums[j], nums[i]);
                }
            }
        }

        return nums;
    }
}