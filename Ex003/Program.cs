Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.Read());
if (a % 2 == 0) Console.WriteLine("Четное");  //УСЛОВИЕ: введенное число делим на 2 и проверяем, остается ли остаток, если нет, то число четное, если да, то число нечетное
else Console.WriteLine("Нечетное");
Console.ReadKey();