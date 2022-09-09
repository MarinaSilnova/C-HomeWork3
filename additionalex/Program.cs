Console.WriteLine("Введите количество дней ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
int i = 0;
int m = 1;
while(i < n)
{
    int e = Convert.ToInt32(Console.ReadLine());
    if(e > 0)
    {
        count = count + 1;
        if (m < count)
        m = count;
    }
    else
    count = 0;
    i++;
}
Console.WriteLine(m);
