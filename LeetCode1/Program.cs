// https://leetcode.com/problems/two-sum/

using System.Collections;

int[] result = new Solution().TwoSum([1, 1, 7, 1, 1, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1], 11);
Array.ForEach(result, Console.WriteLine);

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var result = new int[2];
        var verifiedNumDict = new Dictionary<int, int>(nums.Length);

        for (var index = 0; index < nums.Length; index++)
        {
            var value = nums[index];

            var remain = target - value;

            if (verifiedNumDict.ContainsKey(remain))
            {
                result[0] = index;
                result[1] = verifiedNumDict[remain];
                break;
            }
            else
            {
                verifiedNumDict.TryAdd(value, index);
            }
        }

        return result;
    }
}