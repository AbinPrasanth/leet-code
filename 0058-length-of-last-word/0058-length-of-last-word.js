/**
 * @param {string} s
 * @return {number}
 */
  function lengthOfLastWord(s) {
    let words = s.trim().split(" ");
    return words[words.length-1].length;
};
console.log(lengthOfLastWord(" hello world "));