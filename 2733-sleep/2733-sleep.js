/**
 * @param {number} millis
 * @return {Promise}
 */
async function sleep(millis) {
    return new Promise((resolve) => {
    setTimeout(() => {
      console.log(`Slept for 100 milliseconds`); 
      resolve();
    }, millis);
  });
    
}
sleep(100);
/** 
 * let t = Date.now()
 * sleep(100).then(() => console.log(Date.now() - t)) // 100
 */