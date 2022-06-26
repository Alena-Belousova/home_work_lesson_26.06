Console.WriteLine("задача 15");
Console.Write("введите номер дня недели: ");//6
int day = Convert.ToInt32(Console.ReadLine());  
   
       if(day>0 && day<6) {
       Console.WriteLine ("нет");
   }
   else   {
       if (day< 8)  {
       Console.WriteLine ("да");  
     }
     else {Console.WriteLine ("ошибка");
     }
   }
   