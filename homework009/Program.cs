// Задача 14. Напишите программу, которая 
// 1. принимает на вход число 
// 2. и проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

bool CheckingNumber(int number)
{
   return number % 7 == 0 && number % 23 == 0;
   
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool result = CheckingNumber(num);
if(result)
{
    Console.Write("Да");
}
else{Console.Write("Нет");}