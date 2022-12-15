//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
//Строки использовать нельзя

Console.WriteLine("Enter the number:");
int entered_number = Convert.ToInt32(Console.ReadLine());
int n = entered_number; 
int sum = 0;
while (n > 0) 
{
    int digit = n % 10; 
    sum = sum + digit; 
    n = n / 10; 
}

Console.WriteLine($"Сумма: {sum}");
