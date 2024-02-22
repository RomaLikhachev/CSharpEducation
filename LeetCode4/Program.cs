// https://leetcode.com/problems/median-of-two-sorted-arrays/

// Example 1:
//
// Input: nums1 = [1,3], nums2 = [2]
// Output: 2.00000
// Explanation: merged array = [1,2,3] and median is 2.
//
// Example 2:
//
// Input: nums1 = [1,2], nums2 = [3,4]
// Output: 2.50000
// Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.

var result = new Solution().FindMedianSortedArrays([1,2], [3,4]);
Console.WriteLine(result);

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var sortedSet = new SortedList<int, int>();

        foreach (var item in nums1)
        {
            sortedSet.TryAdd(item, item);
        }

        foreach (var item in nums2)
        {
            sortedSet.TryAdd(item, item);
        }

        double result;

        var count = sortedSet.Count;
        var medianIndex = count / 2;

        var isZero = count % 2 == 0;
        if (isZero)
        {
            var first = sortedSet.GetValueAtIndex(medianIndex);
            if (first == 0)
            {
                result = 0;
            }
            else
            {
                var two = sortedSet.GetValueAtIndex(medianIndex - 1);
                result = (first + two) / 2.0;
            }
        }
        else
        {
            result = sortedSet.GetValueAtIndex(medianIndex);
        }

        return result;
    }
}