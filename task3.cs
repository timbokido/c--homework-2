// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int number = new Random().Next(0,10);
if (number == 0) {Console.WriteLine(number + ". нет нулевого дня недели");}
if (number == 1) {Console.WriteLine(number + ". понедельник, рабочий день");}
if (number == 2) {Console.WriteLine(number + ". вторник, рабочий день");}
if (number == 3) {Console.WriteLine(number + ". среда, рабочий день");}
if (number == 4) {Console.WriteLine(number + ". четверг, рабочий день");}
if (number == 5) {Console.WriteLine(number + ". пятница, рабочий день");}
if (number == 6) {Console.WriteLine(number + ". суббота, выходной");}
if (number == 7) {Console.WriteLine(number + ". воскресенье, выходной");}
if (number == 8) {Console.WriteLine(number + ". нет восьмого дня недели");}
if (number == 9) {Console.WriteLine(number + ". нет девятого дня недели");}