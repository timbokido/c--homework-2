// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number = new Random().Next(10,40000);
if (number < 100) {
    Console.WriteLine(number);
    Console.WriteLine("третей цифры нет");
}
if ((number >= 100) && (number < 1000)) {
    int a = number % 10;
    Console.WriteLine(number);
    Console.WriteLine(a);
}
if ((number >= 1000) && (number < 10000)) {
    int b = number % 100;
    int a = b/10;
    Console.WriteLine(number);
    Console.WriteLine(a);
}
if (number >= 10000) {
    int b = number % 1000;
    int a = b/100;
    Console.WriteLine(number);
    Console.WriteLine(a);
}
// 10076