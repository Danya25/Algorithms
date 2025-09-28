using ConsoleApp1;

var a = 0;
var b = 0;
// Fibonacci algorithm
//var res = Fibonacci.FibonaciRec(0, 1, 5);
//var resFor = Fibonacci.FibonaciFor(0, 1, 5);

//Arrays algorithm
//var lowestNum = Arrays.FindLowestNum([1, 5, 9, -2, 2313, -1, 0]);

//Bubble sort
//var nums = new int[] { 7, 3, 9, 12, 11 };
//var swappedNums = BubbleSort.Sort(nums);

//Selection sort
/*var nums = new int[] { 7, 3, 9, 12, 11 };
var swappedNums = SelectionSort.Sort(nums);*/

//Insertion sort
var nums = new int[] { 7, 3, 9, 12, 11 };
var swappedNums = InsertionSort.Sort(nums);


foreach(var num in swappedNums)
{
    Console.WriteLine(num);
}