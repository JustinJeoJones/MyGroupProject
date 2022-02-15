// See https://aka.ms/new-console-template for more information
using MyTeamProject;

Console.WriteLine("Hello, World!");


Algebra algebra = new Algebra();

// Expected: 5
Console.WriteLine(algebra.Adder(2,3));
// Expected: -1
Console.WriteLine(algebra.Subber(2,3));
// Expected: 6
Console.WriteLine(algebra.Multi(2,3));
// Expected: 1
Console.WriteLine(algebra.Divi(3,3));