//try
//{
//    Console.WriteLine("Введите N");
//    int n = int.Parse(Console.ReadLine());
//    for (int i = 10; i < n; i++)
//    {
//        int min = int.MaxValue;
//        int m = i;
//        while(m!=0)
//        {
//            int temp = i%10;
//            if (temp<min)min = temp;
//            m /= 10;
//        }
//        Console.WriteLine($"{i}-{min}");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    Console.WriteLine("Введите k");
//    int k = int.Parse(Console.ReadLine());
//    double p = 1;
//    for (int j = 10; j < k; j++)
//        if (j != 3) p *= (j - 4) * j / (j - 3);
//    double s = 0;
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

