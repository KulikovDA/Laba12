//средний уровень 5
Console.Write("Введите p:");
double p = double.Parse(Console.ReadLine());
const float t = 4.1f;
double k = Math.Sqrt(p*t);
double x = p*Math.Pow(t,2)+Math.Sqrt(k);
double y = Math.Pow(Math.Tan(Math.Pow(x,2)),2)+ k*t;
Console.WriteLine($"y={y:F2}");