static class BinarySearchArray
{
    /*
     * Params: 1-10, 9
     * 1: 1-10
     * 2: 6-10
     * 3: 8-10
     * 4: 9
     */
    public static int binarySearch(int[] nums, int searchKey)
    {
        var lowerBound = 0;
        var upperBound = nums.Length - 1;
        var currentIndex = 0;

        while (true)
        {
            currentIndex = (lowerBound + upperBound) / 2;
            var currentValue = nums[currentIndex];

            if (currentValue == searchKey)
            {
                return currentIndex; // Элемент найден
            }
            else if (lowerBound > upperBound)
            {
                return -1; // Элемент не найден
            }
            else
            {
                // Деление диапазона
                if (currentValue < searchKey)
                {
                    lowerBound = currentIndex + 1; // В верхней половине
                }
                else
                {
                    upperBound = currentIndex - 1; // В нижней половине
                }
            }
        }
    }
}