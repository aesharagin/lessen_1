// 3. Напишите программу вычисления функции:
//  x = f(a)

System.Console.WriteLine("Введите число => ");             // Вывести приглашение на консоль
string inputedString2 = Console.ReadLine();      // Ввод пользователя в строку
int number2 = Convert.ToInt32(inputedString2);    // Преобразование введенной строки в число
int cube = number2*number2*number2;
System.Console.WriteLine(cube);
