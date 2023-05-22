int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a = 2;
int b = 3;
int c = 7;
int a1 = 44;
int b1 = 5;
int c1 = 78;
int a2 = 22;
int b2 = 3;
int c2 = 9;

int max = Max(a, b, c);
Console.WriteLine(max);

int max1 = Max(a1, b1, c1);
Console.WriteLine(max1);

int max2 = Max(a2, b2, c2);
Console.WriteLine(max2);



