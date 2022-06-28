Console.WriteLine("задача 13");
Console.Write("введите число: ");//1234
int numb = Convert.ToInt32(Console.ReadLine());
int razrjad = 10;
int count =1;

if (numb/100==0)
{
 Console.WriteLine("третьей цифры нет");
}
else{
   int digit1= numb/razrjad; //1234/10=123
    while (digit1>0)//+
    { digit1=digit1 / 10; // 123%10=3
    count++;
    
        }
  
    Math.Pow(10, (count-3));
    int B = Convert.ToInt32(Math.Pow(10, (count-3)));
    int A = numb/B;
    
    int digit3 = A%10;
    Console.WriteLine("третья цифра = " + digit3);
     
}