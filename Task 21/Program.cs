// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

int x1 = GetUserInput("Введите X первого числа: ");
int y1 = GetUserInput("Введите Y первого числа: ");
int z1 = GetUserInput("Введите Z первого числа: ");
int x2 = GetUserInput("Введите X второго числа: ");
int y2 = GetUserInput("Введите Y второго числа: ");
int z2 = GetUserInput("Введите Z второго числа: ");

double distance = DistanceSearch(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> {distance}");

static int GetUserInput(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

static double DistanceSearch(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2,2) + Math.Pow(z1 - z2,2));
    return distance;
}