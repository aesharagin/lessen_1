// 4. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

System.Console.WriteLine("Введите число => ");             // Вывести приглашение на консоль
string inputedString2 = Console.ReadLine();      // Ввод пользователя в строку
int number2 = Convert.ToInt32(inputedString2);    // Преобразование введенной строки в число
int cnt = -number2;
while ( cnt <=number2 )
{
    System.Console.WriteLine(cnt);
    cnt =cnt+1;
} 