// See https://aka.ms/new-console-template for more information
using System.Linq;
using ClassLibrary1;
using ClassLibrary2;

// Enumerable.DistinctBy is provided by EnumerableExtensions.cs in ClassLibrary2 for net462 and
// by System.Linq for .net6.0
int[] source = { 1, 2, 3, 2, 1 };
var testString = source.DistinctBy(c => c).ToArray().ToString();

var class1 = new Class1();
var class2 = new Class2();
var class1Output = class1.TestMethod();
var class2Output = class2.TestMethod();

Console.WriteLine(class1Output);
Console.WriteLine(class2Output);
