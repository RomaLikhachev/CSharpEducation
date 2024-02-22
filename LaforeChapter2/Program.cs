// See https://aka.ms/new-console-template for more information

var nums = Enumerable.Range(1, 100).ToArray();

var index = BinarySearchArray.binarySearch(nums, 43);
Console.WriteLine("Index result: " + index);