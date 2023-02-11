// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

TaskNumber(25);

int NumberA = SubNumber("Enter number A: ");

int NumberB = SubNumber("Enter number B: ");

int exponentiation (int a, int n )
{
    int result = 1;
    for (int i = 0; i<n ; i++)
    
    {
        result=result*a;
    }
    return result;
}

int Res = exponentiation(NumberA,NumberB);

System.Console.WriteLine($"{NumberA}, {NumberB} -> {Res}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

TaskNumber(27);

int Number = SubNumber("Emter number :");

int Result = 0;
int degree = 1;
int count = 0;

while(degree<Number)
{
    degree*=10;
    count++;
}
for (int i =0; i< count;i++)
{
    Result=Result+Number%10;
    Number/=10;
}
System.Console.WriteLine(Result);


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


TaskNumber(29);

int [] CreateArray()
{

    int [] zeroArray = {0,0,0,0,0,0,0,0};

    int newNumber = 0;

    for (int i = 0; i<zeroArray.Length; i++)
    {
        newNumber = new Random().Next(10);
        zeroArray[i] = newNumber;
    }
    return zeroArray;

}

int [ ] testArray = CreateArray();
var str = string.Join(",", testArray);
Console.WriteLine(str);

void TaskNumber(int TaskNum)
{
    System.Console.WriteLine($"__Задание {TaskNum}__ ");
}

int SubNumber (string text)
{
    System.Console.WriteLine(text);
    int SNumber = int.Parse(Console.ReadLine());
    return SNumber;
}