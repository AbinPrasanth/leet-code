public class Solution {
    public string LargestGoodInteger(string num) {
        string maxGood = "";

        for (int i = 0; i <= num.Length - 3; i++){
            string sub = num.Substring(i, 3);

            if(sub[0]==sub[1] && sub[1]==sub[2]){
                if (String.Compare(sub, maxGood)>0){
                    maxGood=sub;
                }
            }
        }
        return maxGood;
    }
}