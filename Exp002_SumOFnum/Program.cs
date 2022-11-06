//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
//Console.WriteLine("Введите число");
//string Num = Console.ReadLine();
//Console.WriteLine(Num);
//int sum = 0;
//int length = Num.Length;

//for (int i = 0; i < length; i++)
//{
//   int g=Convert.ToInt32(Num[i]);
//g = Num[i];
// sum = sum + g;
//Console.WriteLine(g);
// Console.WriteLine(Num[1]);
//}
//Console.WriteLine(length);

//int SumOf(string n)
//{
//  int sum = 0;
//int length = n.Length;
//for (int i = 0; i < length; i++)
//{
//  n[i]=Convert.ToInt32(n[i]);
//sum = sum + n[i];
//}
//return sum;
//}

//int result = SumOf(Num);
//Console.WriteLine(result);

Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (Num < 0) Num = -Num;
for (; Num % 10 != 0; Num = Num / 10)
{
    sum = sum + Num % 10;
}
Console.WriteLine(sum);