
using OOPLab1n1;

Fraction n = new Fraction(2, 3);
Fraction p = new Fraction(2, 3);


Console.WriteLine("n = " + n.ToString());

;
Console.WriteLine("p = " + p.ToString());

Fraction k = new Fraction(1, 1);

k = n + p;

Console.WriteLine("k = " + k.ToString());

k = n - p;
k.ToString();
Console.WriteLine("k = " + k.ToString());

if (n == p) Console.WriteLine("n = p");
if (n != p) Console.WriteLine("n != p");
if (n > p) Console.WriteLine("n > p");
if (n < p) Console.WriteLine("n < p");

Console.ReadLine();