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
  arr = readLine().split(' ');
  arr = arr.map(Number);
  var arraySums = new Array(arr.length).fill(arr.reduce((sum, x) => sum + x, 0));
  for (var i = 0; i < arr.length; i++) {
    arraySums[i] -= arr[i];
  }
  console.log(Math.min(...arraySums), Math.max(...arraySums));
}
