using Core;

namespace LaforeChapter3;

public static class InsertionSort
{
    /*
     * https://thimbleby.gitlab.io/algorithm-wiki-site/wiki/insertion_sort/
     * Sample:
     * 1, 2, 3, 0, 7
     * 1, 2, 3, [], 7
     * [], 1, 2, 3, 7
     * 0, 1, 2, 3, 7
     */
    public static int[] Sort(int[] nums)
    {
        Console.WriteLine("Origin");
        ArraysUtils.PrintIntValues(nums);

        // outerIndex - separator marker
        for (var outerIndex = 0; outerIndex < nums.Length; outerIndex++)
        {
            // Copy marked element
            var outerValue = nums[outerIndex];

            // Start moving with outerIndex
            var innerIndex = outerIndex;

            // Smaller element not found yet
            while (innerIndex > 0 && nums[innerIndex - 1] >= outerValue)
            {
                // Move element right
                nums[innerIndex] = nums[innerIndex - 1];
                // Move one position to the left
                innerIndex--;
            }

            // Insert marked element
            nums[innerIndex] = outerValue;
        }

        return nums;
    }
}