// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int num;

num = GetUserInput("Введите пятизначное число: ");
num = GetCorrectNumber(num);

int num1 = num/10000;
int num2 = (num%10000)/1000;
int num4 = (num%100)/10;
int num5 = num%10;

if (num1 == num5 && num2 == num4)
    Console.WriteLine($"{num} -> да");
else
    Console.WriteLine($"{num} -> нет");



static int GetUserInput(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
    
}

static int GetCorrectNumber(int number)
{
    
while (number <= 9999) 
{     
    Console.WriteLine("Слишком маленькое число!"); 
    number = GetUserInput("Введите пятизначное число: ");
    return number;
}

while (number > 99999)
{     
    Console.WriteLine("Слишком большое число!"); 
    number = GetUserInput("Введите пятизначное число: ");
    return number;
}
    return number;    
}