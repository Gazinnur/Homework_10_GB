//## Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
//без использования math.pow
Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В");
int B = Convert.ToInt32(Console.ReadLine());
int PowOF(int A,int B)
{
    int pow=1;
    if (A>0)
    {for (int i = 1; i <= B; i++)
        {
            pow=pow*A;
        }        
    }
    else pow=0;
    return pow;
}

int POWER=PowOF(A,B);
Console.WriteLine(POWER);