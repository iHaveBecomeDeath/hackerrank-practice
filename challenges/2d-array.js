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
    var arr = [];
    for(arr_i = 0; arr_i < 6; arr_i++){
      arr[arr_i] = readLine().split(' ');
      arr[arr_i] = arr[arr_i].map(Number);
    }
  console.log(getMaxSumOfHourGlasses(arr))
}

function getMaxSumOfHourGlasses(matrix) {
  let largestSum = -27, numberOfRows = matrix.length, numberOfColumns = matrix[0].length;
  
  for (var row = 0; row < numberOfRows-2; row++)
  {
    for (var col = 0; col < numberOfColumns-2; col++){
      let currentSum =
        matrix[row][col]
        +matrix[row][col+1]
        +matrix[row][col+2]
        +matrix[row+1][col+1]
        +matrix[row+2][col]
        +matrix[row+2][col+1]
        +matrix[row+2][col+2];
      largestSum = currentSum > largestSum ? currentSum : largestSum;
    }
  }
  return largestSum;
}
