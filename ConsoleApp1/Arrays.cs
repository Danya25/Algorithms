namespace ConsoleApp1;

public static class Arrays
{
    public static int FindLowestNum(int[] nums)
    {
        var lowest = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            var currVal = nums[i];
            if (lowest > currVal)
            {
                lowest = currVal;
            }
        }

        return lowest;
    }
}