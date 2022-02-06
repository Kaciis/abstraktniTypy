global using System;
using System.Diagnostics;

Stopwatch stopwatch = new Stopwatch();

int[] pole = {1,2,3,4,5,6,7,8,9};

stopwatch.Start();

Search.binarySearch(pole, 0, pole.Length-1, 7);

stopwatch.Stop();
Console.WriteLine(stopwatch.Elapsed);