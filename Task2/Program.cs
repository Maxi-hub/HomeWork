// Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a = 5;
int b = 7;

int a1 = 2; 
int b1 = 10;

int a2 = -9; 
int b2 = -3;

int max = a;
if (b > max) max = b;
Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {a}");

int max1 = a1;
if (b1 > max1) max1 = b1;
Console.WriteLine($"max = {max1}");
Console.WriteLine($"min = {a1}");

int max2 = a2;
if (b2 > max2) max2 = b2;
Console.WriteLine($"max = {max2}");
Console.WriteLine($"min = {a2}");
