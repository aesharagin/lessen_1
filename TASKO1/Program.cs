// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

Console.Write("Введите число => ");             // Вывести приглашение на консоль
string inputedString = Console.ReadLine();      // Ввод пользователя в строку
int number = Convert.ToInt32(inputedString);    // Преобразование введенной строки в число

int square;                     // Объявление переменной, которая будет содержать квадрат числа
square = number * number;       // Вычисление квадрата числа

// Вывод в консоль
System.Console.WriteLine("Квадрат числа " + number + " равен " + square);

System.Console.WriteLine($"Квадрат числа {number} равен {square}");         // Альтернативный вывод информации
System.Console.WriteLine("Введите число => ");             // Вывести приглашение на консоль
string inputedString2 = Console.ReadLine();      // Ввод пользователя в строку
int number2 = Convert.ToInt32(inputedString2);    // Преобразование введенной строки в число
if (number2 ==square)
{
 System.Console.WriteLine("Первое число равен квадрату второму"); // Вывод в консоль   
}
else
{
  System.Console.WriteLine("Первое число не равен квадрату второму"); // Вывод в консоль   
}