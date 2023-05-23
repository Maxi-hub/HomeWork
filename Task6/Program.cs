// Программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите целое число:" );
int number = Convert.ToInt32(Console.ReadLine()); 

int result = (number % 2);

if(result == 0) Console.WriteLine("true"); 
else Console.WriteLine("false"); 
