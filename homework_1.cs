// Задание № 2


// See https://aka.ms/new-console-template for more information


Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = 0;
int min = 0;

if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}

Console.WriteLine("Максимальное число это: {0}", max);
Console.WriteLine("Минимальное число это: {0}", min);



/*
// Задание № 4

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (a > b && a > c) {
    max = a;
}
if (b > a && b > c) {
    max = b;
}

if (c > a && c > b) {
    max = c;
}
    
Console.WriteLine("Наибольшее число: {0}", max);

*/

/*
//Задание №6

Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) {
    Console.WriteLine("да");
}
else {
    Console.WriteLine("нет");
}
*/

/*
//Задание № 8

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= n; i = 2 * i)
{
    Console.WriteLine(i);
}
*/


