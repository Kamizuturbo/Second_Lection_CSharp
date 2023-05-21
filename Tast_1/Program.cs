// Ищем максимальное из 9 чисел

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2> result) result = arg2;
    if(arg3> result) result = arg3;
    return result;
}
int a1 = 15;
int a2 = 1647;
int a3 = 152411;
int a4 = 15774;
int a5 = 15424147;
int a6 = 15246;
int a7 = 1524;
int a8 = 15454;
int a9 = 155;

int max1 = Max(a1, a2, a3);
int max2 = Max(a4, a5, a6);
int max3 = Max(a7, a8, a9);
int max = Max(max1, max2, max3);

System.Console.WriteLine(max);