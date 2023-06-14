int InText(string Text)
{
    Console.WriteLine(Text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task41()
{
    int count = 0;
    int m =  InText("Введите колличество чисел");
    for (int i=1;i<=m;i++)
    {
        int num = InText($"Введите {i} число");
        if (num>0) count++;
    }
    Console.WriteLine($"Колличество чисел больше 0 = {count}");

}


void Task43()
{
    int k1  = InText("Введите к1");
    int k2  = InText("Введите к2");
    int b1  = InText("Введите b1");
    int b2  = InText("Введите b2");
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if(k1 == k2)
    {
        Console.WriteLine("Прямые паралельны");
    }
    else
    {
        double x = (b1-b2)/(k1-k2);
        double y = (k2*x+b2);
        Console.WriteLine($"Координаты точки пресечения ({x},{y})");
    }
    


}

Task41();
Task43();