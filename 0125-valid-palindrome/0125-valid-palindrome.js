/**
 * @param {string} s
 * @return {boolean}
 */
var isPalindrome = function(s) {
    let cleaned = s.toLowerCase().replace(/[^a-z0-9]/g, '');
    
    return cleaned === cleaned.split('').reverse().join('');
};

console.log(isPalindrome(" A racecar"))