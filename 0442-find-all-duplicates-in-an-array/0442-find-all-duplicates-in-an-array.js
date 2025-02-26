/**
 * @param {number[]} nums
 * @return {number[]}
 */
var findDuplicates = function(nums) {
     let result = [];

    for (let i = 0; i < nums.length; i++) {
        let index = Math.abs(nums[i]) - 1; // Convert number to index

        if (nums[index] < 0) {
            // If already negative, it means we encountered this number before
            result.push(index + 1);
        } else {
            // Mark as visited by making it negative
            nums[index] = -nums[index];
        }
    }

    return result;

};