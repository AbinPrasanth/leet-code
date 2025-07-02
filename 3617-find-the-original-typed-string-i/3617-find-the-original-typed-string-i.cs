public class Solution {
    public int PossibleStringCount(string word) {
         int count = 1; 
        int i = 0;

        while (i < word.Length)
        {
            int j = i;
            while (j < word.Length && word[j] == word[i])
            {
                j++;
            }

            int groupLength = j - i;

            if (groupLength >= 2)
            {
                count += groupLength - 1;
            }

            i = j; 
        }

        return count;
    }
}