// . Напишите программу вычисления модуля числа.
//	2 -> 2
//	-3 -> 3
//	-7 -> 7

System.Console.WriteLine("Введите число => ");             // Вывести приглашение на консоль
string inputedString2 = Console.ReadLine();      // Ввод пользователя в строку
int number2 = Convert.ToInt32(inputedString2);    // Преобразование введенной строки в число
int cnt;
if (number2>0)
{
  cnt= number2;
}
else
{
   cnt= -number2; 
}
System.Console.WriteLine(cnt);