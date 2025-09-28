namespace ConsoleApp1;

//Complexity: O(n^2)
public static class InsertionSort
{
    public static int[] Sort(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            for(int j = i; j > 0; j--)
            {
                if (nums[j] < nums[j - 1])
                {
                    (nums[j], nums[j - 1]) = (nums[j - 1], nums[j]);
                }
            }
        }

        return nums;
    }
}