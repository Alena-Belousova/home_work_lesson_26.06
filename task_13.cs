Console.WriteLine("задача 13");
Console.Write("введите число: ");//123
int numb = Convert.ToInt32(Console.ReadLine());
int FirstDigit = numb/100;//12/100=0
if (FirstDigit==0)
{
 Console.WriteLine("третьей цифры нет");
}
else{
    int ThirdDigit = numb%10;//123%10=3
    Console.WriteLine("третья цифра числа = " + ThirdDigit);
}