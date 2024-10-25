try
{
    Console.WriteLine("Введите k");
    int k = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите x");
    int x = int.Parse(Console.ReadLine());
    double s = 0;
    for (int i = 0; i < k; i++)
        s += Math.Sin(i * Math.Pow(x, i));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
