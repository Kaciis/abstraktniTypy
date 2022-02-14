global using System;
using System.Diagnostics;


int[] pole = new int[1000000];


Random rnd = new Random();


for(int i = 0 ;i < 1000000; i++){
    pole[i] = rnd.Next(0, 100000);
}



Stopwatch stopwatchLinear = new Stopwatch();
Stopwatch stopwatchBinary = new Stopwatch();

#region LinearSearch
stopwatchLinear.Start();

Search.Linear(pole, 10000);

stopwatchLinear.Stop();

Console.WriteLine("Linear search : {0}", stopwatchLinear.Elapsed);

#endregion

Array.Sort(pole);

#region BinarySearch
stopwatchBinary.Start();


Search.binarySearch(pole, 0, pole.Length-1, 0);

stopwatchBinary.Stop();
Console.WriteLine("binary search : {0}", stopwatchBinary.Elapsed);
#endregion