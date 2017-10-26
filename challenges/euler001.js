process.stdin.resume();
process.stdin.setEncoding('ascii');

var input_stdin = "";
var input_stdin_array = "";
var input_currentline = 0;

process.stdin.on('data', function (data) {
    input_stdin += data;
});

process.stdin.on('end', function () {
    input_stdin_array = input_stdin.split("\n");
    main();    
});

function readLine() {
    return input_stdin_array[input_currentline++];
}

/////////////// ignore above this line ////////////////////

function main() {
    var t = parseInt(readLine());
    for(var a0 = 0; a0 < t; a0++){
        var n = parseInt(readLine());
        console.log(computeMultiples(n));
    }
}

function computeMultiples(maxValue){
  let multiples = iterateMultiples(maxValue, 3, [0]);
  return iterateMultiples(maxValue, 5, multiples).reduce((pv, cv) => pv+cv, 0);
}

function iterateMultiples(maxValue, multiplier, multiples) {
  if (maxValue >= multiplier){
    let maxIterations = getMaxIterations(maxValue, multiplier);
    for (var step = 0; step <= maxIterations; ++step){
      if (multiples.indexOf(step * multiplier) === -1){
        multiples.push(step * multiplier);
      }
    }
  }
  return multiples;
}

function getMaxIterations(maxValue, multiplier) {
  let decrease = maxValue % multiplier === 0 ? multiplier : maxValue % multiplier;
//  console.log(decrease, (maxValue-decrease)/multiplier);
  return (maxValue - decrease) / multiplier;
}
