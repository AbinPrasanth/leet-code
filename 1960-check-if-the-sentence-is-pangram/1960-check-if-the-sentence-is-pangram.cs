public class Solution {
    public bool CheckIfPangram(string sentence) {
        return sentence.ToHashSet().Count==26;
    }
}