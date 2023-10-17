// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Enter b1");
double  b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter k1");
double  k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter b2");
double  b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = Function(k1,b1,k2,b2);

double Function(double K1,double B1,double K2,double B2){
    double x = K1 - K2; 
    double b = B2 - B1;
    return b / x;
}
double y = k1 * x + b1;
Console.WriteLine($" b1 = {b1} , k1 = {k1} , b2 = {b2} , k2 = {k2} -----> ({x} , {y}) ");