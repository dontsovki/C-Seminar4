// Напишите программу, которая принимает на вход число N и выдаёт количество чисел в числе N
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int c = GetCountNums(num);
Console.WriteLine($"Количество цифр = {c}");

// Console.WriteLine($"Количество цифр = {GetCountNums(16)}");


int GetCountNums(int number)
{
    int count = 0;
    while(number>0)
    {
        count++;
        number/=10;
    }
    return count;
}




//Console.WriteLine("Введите число: ");
//string a = Convert.ToString(Console.ReadLine());
//int i = Convert.ToInt32(a.Length);

//Console.WriteLine($"В числе {a} ровно {i} цифр");
