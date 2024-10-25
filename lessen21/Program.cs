//try
//{
//    Console.WriteLine("Введите последовательность целых чисел");
//    int s = 0, count = 0;
//    do
//    {
//        int n = int.Parse(Console.ReadLine());
//        if (n == 0) break;
//        s += n;
//        count++;
//    }
//    while (true);
//    Console.WriteLine($"Сумма:{s}, количество чисел:{count}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e);
//}
    do
    {
    Console.Clear();
    try
    {
        Console.WriteLine("Mеню:\n"+
            "1 - Обработка числовых последовательностей\n" +
            "2 - Использование условного оператора"+"в теле операторов цикла с условием\n" +
            "3 - Использование условного оператора"+ "после операторов цикла с условием \n" +
            "4 - Использование условного оператора в теле"+ "операторов цикла с условием и после него \n"+
            "5 - выход");
        Console.WriteLine("Выберете пункт меню");
        int n=int.Parse(Console.ReadLine());
        switch (n)
        {
            case 1:
                {
                    Console.WriteLine("Введите последовательность чисел");
                    int m = 0;
                    int p = 1;
                    do
                    {
                        m=int.Parse(Console.ReadLine());
                        p = p * m;
                        Console.WriteLine(p);
                    }
                    while (m !=0);
                }
                break;
            case 2:
                {
                    Console.WriteLine("Введите число");
                    int m = int.Parse(Console.ReadLine());
                    int count3 = 0, countlast = 0, countEven = 0, sumMore = 0, pMore = 1, count0or5=0;
                    int last = m % 10;
                    while(m!=0)
                    {
                        int temp = m % 10;
                        if (temp == 3) count3++;
                        if (temp == last) countlast++;
                        if (temp % 2 == 0) countEven++;
                        if (temp > 5) sumMore += temp;
                        if (temp > 7) pMore *= temp;
                        if (temp == 0 || temp == 5) count0or5++;
                        m /= 10;
                    }
                    Console.WriteLine("Количество цифр 3:"+count3);
                    Console.WriteLine("Последняя цифра встречается:" + countlast+"раз");
                    Console.WriteLine("Количество четных цифр:" + countEven);
                    Console.WriteLine("Количество цифр 3:" + count3);
                    Console.ReadKey();
                }
                break;
            case 3:
                {
                    //double a = 5;
                    //for(int i = 1; i < 5; i++) 
                    //{
                    //    Console.WriteLine(a);
                    //    a += 2;
                    //}
                    //Console.ReadKey();
                    //for (int i = 35; i < 87; i++)
                    //{
                    //    if (i % 7 == 1 || i% 7 == 2 ||i%7==5)
                    //        Console.WriteLine(i);
                    //}
                   
                }
                break;
            case 4: break;
            case 5: break;
        }

    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }
    } while (true);
