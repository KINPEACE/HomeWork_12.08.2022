// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

void Num(int[] a)
{
    int count = 0;
    int index = a.Length;
    while(count < index)
    {
        a[count] = Convert.ToInt32(Math.Pow(count, 3));
        count++;
    }
}
void Num1(int[] b)
{
    int count1 = b.Length;
    int index1 = 0;
    while(index1 < count1)
    {
        Console.WriteLine(b[index1] + " ");
        index1++;
    }
}

int[] sqr = new int[a+1];
Num(sqr);
Num1(sqr);