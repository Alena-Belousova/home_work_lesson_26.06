Console.WriteLine("задача 13");
Console.Write("введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());
int razrjad = 10;
int count =1;

if (numb/100==0)
{
 Console.WriteLine("третьей цифры нет");
}
else{
   int digit1= numb/razrjad; 
    while (digit1>0)
    { digit1=digit1 / 10; 
    count++;
    
        }
  
    Math.Pow(10, (count-3));
    int B = Convert.ToInt32(Math.Pow(10, (count-3)));
    int A = numb/B;// А = numb/(10^(count-3))

    //A и В проходные переменные для того чтобы "вычленить" первые три цифры числа numb
        int digit3 = A%10;
    Console.WriteLine("третья цифра = " + digit3);
     
}