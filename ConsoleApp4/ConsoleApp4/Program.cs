// See https://aka.ms/new-console-template for more information1.
// 1. Verilən ədədə və ya ondan böyük ən yaxın ədədə qədər secondFibonaççi ardıcıllığını ekrana çap edin.
int num = 8;
int secondFib=1;
int firstFib = 0;
//0; 1; 1; 2; 3; 5; 8; 13; 21; 34; 55; 89...

Console.WriteLine(firstFib);
while (firstFib <= num && firstFib!=num) 
{
    int sum;
    sum = secondFib + firstFib;
    firstFib = secondFib;
    secondFib = sum;
    Console.WriteLine(firstFib);
}

Console.WriteLine("==========================================================================");

// 2.2 dəyişənin dəyərlərini 3cü dəyişən istifadə etmədən dəyişin. Məs :
int a = 14;
int b = 9;
a = b + a;
b = a - b;
a = a - b;
Console.WriteLine($"a ->{a}");
Console.WriteLine($"b ->{b}");