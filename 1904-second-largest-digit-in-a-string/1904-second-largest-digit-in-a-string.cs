public class Solution {
    public int SecondHighest(string s) {
         HashSet<int> digits = new HashSet<int>();

        foreach (char c in s)
        {
            if (char.IsDigit(c))
            {
                digits.Add(c - '0');
            }
        }

        if (digits.Count < 2)
            return -1;

        List<int> sortedDigits = digits.OrderByDescending(d => d).ToList();

        return sortedDigits[1];

    }
}