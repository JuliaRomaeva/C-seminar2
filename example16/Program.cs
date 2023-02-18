// Напишите программу, которая принимает на вход два числа и проверяет,
//  является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Clear();
Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());

if(num1 * num1 == num2 || num2 * num2 == num1){
    Console.Write($"{num1},{num2} -> да ");
}
else{
    Console.WriteLine($"{num1},{num2} -> нет ");
}

// Console.Clear();
// // // string s = "12312345";
// // // string s1 = Convert.ToString(s[0]);
// // Console.Write($" {s} -> {s1}     ");
// Console.Write("Введите число a: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите число b: ");
// int b = int.Parse(Console.ReadLine());
// if (a * a == b)
// {
//     Console.WriteLine("b квадрат a")
// }else if (b * b == a){
//     Console.WriteLine("a квадрат b");
// }else{
//     Console.WriteLine("не является");
// }