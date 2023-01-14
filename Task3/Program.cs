// Программа, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
void GetSumNums(int number)
{
    int prois = 1;
    for (int i = 2; i <= number; i++)
    {
        prois *= i;
    } 
    Console.WriteLine($"Cумма цифр от 1 до {Math.Abs(number)}: {prois}");
}

Console.Clear();

//GetSumNums(-5);
//GetSumNums(58);
//GetSumNums(25);
//GetSumNums(16);

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
GetSumNums(n);

Console.WriteLine("Введите число A");
GetSumNums(Convert.ToInt32(Console.ReadLine()));


// //Напишите программу, которая принимает 
// //на вход число N и выдаёт произведение чисел от 1 до N.

//Console.Clear();
//Console.Write("Введите число: ");
//int num = int.Parse(Console.ReadLine());
//Console.WriteLine($"Произведение цифр = {GetMultiply(num)}");


//int GetMultiply(int number)
//{
//    int result = 1;
//    for (int i = 2; i <= number; i++)
//    {
//        result *= i;
//    }
//    return result;
//}
