function processData(input) {  
  let reps = input[0];
  let strings = input.splice(1);
 
  for (var i = 0; i < reps; i++) {
    console.log(getSimilarity(strings[i]));
  }
  
  function getSimilarity(str){
    let strLength = str.length;
    let similaritiesFound = 0;
    let stepCounter = 0;
    for (var curPos = 0; curPos < strLength; curPos++){
      while ((stepCounter + curPos) < strLength && str[stepCounter] === str[curPos + stepCounter]){
        ++stepCounter; // move one step in comparison
        ++similaritiesFound; // match found
      }
      stepCounter = 0;
    }
    return similaritiesFound;
  }

//  console.log(reps, strings);
} 

process.stdin.resume();
process.stdin.setEncoding("ascii");
_input = "";
process.stdin.on("data", function (input) {
    _input += input;
});

process.stdin.on("end", function () {
   processData(_input.split('\n'));
});
