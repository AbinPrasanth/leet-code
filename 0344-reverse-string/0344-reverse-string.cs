public class Solution {
    public void ReverseString(char[] s) 
    {
        Array.Reverse(s);
    }
    class Program
    {
        static void main()
        {
            char[] s = ['h','e','l','l','o'];
            Solution sol = new Solution();
            sol.ReverseString(s);

            Console.WriteLine("[\""+string.Join("\",\"",s)+"\"]");
        }
    }
}