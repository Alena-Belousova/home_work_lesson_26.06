Console.WriteLine("задача 10");
Console.Write("введите трехзначное число: ");//123
int numb = Convert.ToInt32(Console.ReadLine());
int FirstDigit = numb/10;//123/10=12
int SecondDigit= FirstDigit % 10;//12/10=1.2 (остаток от деления 2)
Console.WriteLine("вторая цифра ="+ SecondDigit);