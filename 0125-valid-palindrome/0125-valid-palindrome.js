/**
 * @param {string} s
 * @return {boolean}
 */
var isPalindrome = function(s) {
    const normalized = s.toLowerCase().replace(/[^a-zA-Z0-9]/g, "");
    return normalized === normalized.split("").reverse().join("");
};
console.log(isPalindrome("Racecar!"));