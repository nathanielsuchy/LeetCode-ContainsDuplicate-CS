# LeetCode-ContainsDuplicate-CS
A solution for LeetCode "Contains Duplicate" in C#

## Explanation
In this problem we have to search an array for duplicates. If we find any number that is in the array more than once we return `true` otherwise return false.

Initialize an empty List of ints for the numbers we've already in the array. Iterate over the numbers in the nums array, on each iteration search the numbersSeenSoFar array for said number. If a match is found return true. If after each number has been compared to the numbersSeenSoFar array and no matches are found return false.

**Stats**
- Time Complexity: `O(n)` At most we iterate over the array once
- Memory Complexitiy: `O(n)` At most this is the size of the array

**Leetcode's Score**
Runtime: 2885 ms, faster than 5.01% of C# online submissions for Contains Duplicate.
Memory Usage: 49.3 MB, less than 16.39% of C# online submissions for Contains Duplicate.

## Solution
```cs
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
```
