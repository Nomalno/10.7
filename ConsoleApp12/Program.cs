int P(int a, int b, int c)
{
    int osntr = (a - b) / 2;
    int bokovaya = osntr % c;
    int p = a + b + bokovaya * 2;
    return p;
}
int a, b, c;
int pp = 0; int pp2 = 0;
Console.WriteLine("Основание:");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вершина:");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Высота:");
c = Convert.ToInt32(Console.ReadLine());
pp += P(a, b, c);

Console.WriteLine("Perimiter pervogo: {0}", pp);
Console.WriteLine("\t Введи значения для второй фигруы");
Console.WriteLine("Основание:");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вершина:");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Высота:");

c = Convert.ToInt32(Console.ReadLine());
pp2 = P(a, b, c);
pp += P(a, b, c);
Console.WriteLine("Периметр второго{0}", pp2);
Console.WriteLine("Сумма периметров{0}", pp);
Console.ReadKey();

