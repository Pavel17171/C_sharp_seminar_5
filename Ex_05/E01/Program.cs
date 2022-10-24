// E01 Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

double k1 = 2;
int b1 = -1;
double k2 = -3;
int b2 = 1;

double x = Math.Round((b1 - b2) / (k2 - k1), 2);
double y = Math.Round((k2 * x + b2), 2);

Console.WriteLine($"Координаты точки пересечения двух прямых: ({x}; {y})");