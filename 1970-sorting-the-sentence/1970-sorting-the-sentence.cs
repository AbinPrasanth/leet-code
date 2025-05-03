public class Solution {
    public string SortSentence(string s) {
        string[] parts= s.Split(' ');
        string[] result = new string[parts.Length];

        foreach(string word in parts)
        {
            int index = word[word.Length-1]-'1';
            result[index]= word.Substring(0,word.Length-1);
        }
        return string.Join(" ",result);
    }
}