public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var numbersSeenSoFar = new List<int>();
        
        foreach (var num in nums) {
            foreach (var seenNumber in numbersSeenSoFar) {
                if (num == seenNumber) {
                    return true;
                }
            }
            numbersSeenSoFar.Add(num);
        }
        
        return false;
    }
}
