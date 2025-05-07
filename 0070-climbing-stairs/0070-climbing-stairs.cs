public class Solution {
    public int ClimbStairs(int n) {
        if (n<=2) return n;
        int OneStepBefore = 2;
        int TwoStepBefore = 1;
        int Allways = 0;

        for(int i=3;i<=n;i++)
        {
            Allways = OneStepBefore + TwoStepBefore;
            TwoStepBefore = OneStepBefore;
            OneStepBefore = Allways;
        }
        return Allways;
    }
}