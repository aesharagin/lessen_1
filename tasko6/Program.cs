// **. Напишите программу, которая на вход принимает значение, а  на выходе показывает обратное значение.
// 1 -> 1 
// 2 -> 0.5
// 0.25 -> 4

System.Console.WriteLine("Введите число => ");             // Вывести приглашение на консоль
string inputedString2 = Console.ReadLine();      // Ввод пользователя в строку
double number2 = Convert.ToDouble(inputedString2);    // Преобразование введенной строки в число
double cnt = 1/number2;
System.Console.WriteLine(cnt);