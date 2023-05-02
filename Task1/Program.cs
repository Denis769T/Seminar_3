//  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
string? str = Console.ReadLine()!;

int number = Convert.ToInt32(Convert.ToString(str[0]));
int number1 = Convert.ToInt32(Convert.ToString(str[1]));
int number2 = Convert.ToInt32(Convert.ToString(str[2]));
int number3 = Convert.ToInt32(Convert.ToString(str[3]));

if (str[0] == str[4] && str[1] == str[3])
{
    Console.WriteLine("Число является палиндромом.");
    return;
}

else

    Console.WriteLine("Число не является палиндромом.");


