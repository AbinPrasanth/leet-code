/**
 * @param {integer} init
 * @return { increment: Function, decrement: Function, reset: Function }
 */
var createCounter = function (init) {
    let curentValue = init
    return {
        increment: () => {
           curentValue += 1;
            return curentValue;
        },
        decrement: () => {
            curentValue -= 1;
            return curentValue;
        },
        reset: () => {
            curentValue = init;
            return curentValue;
        }
    }
};



  const init = 5;
  const counter = createCounter(init);
  const calls = ["increment", "reset", "decrement"];
  const output = calls.map((call) => counter[call]());
  console.log(output);
  