using Core;

namespace LaforeChapter3;

// https://thimbleby.gitlab.io/algorithm-wiki-site/wiki/selection_sort/
public static class SelectionSort
{
    public static int[] Sort(int[] nums)
    {
        Console.WriteLine("Origin");
        ArraysUtils.PrintIntValues(nums);

        for (var outerIndex = 0; outerIndex < nums.Length; outerIndex++)
        {
            int minIndex = outerIndex;

            for (var innerIndex = outerIndex + 1; innerIndex < nums.Length; innerIndex++)
            {
                var innerValue = nums[innerIndex];

                if (innerValue < nums[minIndex])
                {
                    minIndex = innerIndex;
                }
            }

            var temp = nums[outerIndex];
            nums[outerIndex] = nums[minIndex];
            nums[minIndex] = temp;
        }

        return nums;
    }
}