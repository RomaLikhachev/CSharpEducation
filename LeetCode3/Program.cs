https: //leetcode.com/problems/longest-substring-without-repeating-characters/

// Ввод: s = "abcabcbb"
// Вывод: 3
// Объяснение: Ответ: "abc" длиной 3.

// Ввод: s = «bbbbb»
// Вывод: 1
// Объяснение: Ответ — «b» длиной 1.

// Ввод: s = "pwwkew"
// Вывод: 3
// Объяснение: Ответ: "wke" длиной 3.

var result = new Solution().LengthOfLongestSubstring("pwwkew");

Console.WriteLine(result);

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var symbols = s.ToCharArray();

        var len = symbols.Length;
        var lastIndex = symbols.Length - 1;

        var lastMax = 0;
        var latestIndex = 0;
        IDictionary<char, int> dir = new Dictionary<char, int>();

        for (var index = 0; index < len; index++)
        {
            var symbol = symbols[index];

            if (dir.ContainsKey(symbol))
            {
                var previewIndex = dir[symbol];
                var count = index - previewIndex;

                if (count > lastMax)
                {
                    lastMax = count;

                    latestIndex = previewIndex + 1;
                }

                dir.Remove(symbol);
            }
            else if (index == lastIndex)
            {
                var count = len - latestIndex;

                if (count > lastMax)
                {
                    lastMax = count;
                }
            }

            dir.Add(symbol, index);
        }

        return lastMax == 0 ? s.Length : lastMax;
    }
}