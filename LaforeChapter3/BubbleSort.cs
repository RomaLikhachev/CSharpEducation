using Core;

namespace LaforeChapter3;

public static class BubbleSort
{
    // https://thimbleby.gitlab.io/algorithm-wiki-site/wiki/bubble_sort/
    public static int[] Sort(int[] nums)
    {
        Console.WriteLine("Origin");
        ArraysUtils.PrintIntValues(nums);

        int outerIndex;

        // Outer loop (reverse)
        for (outerIndex = nums.Length - 1; outerIndex > 1; outerIndex--)
        {
            // Inner loop (direct)
            for (var innerIndex = 0; innerIndex < outerIndex; innerIndex++)
            {
                var nextInnerIndex = innerIndex + 1;

                // Is the order broken?
                if (nums[innerIndex] > nums[nextInnerIndex])
                {
                    // Swap
                    var temp = nums[innerIndex];
                    nums[innerIndex] = nums[nextInnerIndex];
                    nums[nextInnerIndex] = temp;
                }
            }
        }

        return nums;
    }
}