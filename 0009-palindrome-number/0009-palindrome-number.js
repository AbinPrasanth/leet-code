/**
 * @param {number} x
 * @return {boolean}
 */
var isPalindrome = function(x) {
    const num = x.toString();
    return num === num.split('').reverse().join('');
};
console.log(isPalindrome[121])