/**
 * @param {number[]} nums
 * @return {string}
 */
var largestNumber = function(nums) {
    let str = nums.map(String)
    str.sort((a,b)=>(b+a)-(a+b))
    if (str[0]==='0')return '0'
    return str.join('')
};