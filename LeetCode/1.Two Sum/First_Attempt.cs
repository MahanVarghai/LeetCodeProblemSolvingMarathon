public class Solution
{
    int buffer;
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            buffer = target - nums[i];
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == buffer && j != i)
                    return new int[] { i, j };
            }
        }
        return [];
    }
}