// Реализация сторонних алгоритмов на C#

// Задание 1
Console.Write("R1 = ");
double R1 = Convert.ToDouble(Console.ReadLine());
Console.Write("R2 = ");
double R2 = Convert.ToDouble(Console.ReadLine());
double R3 = R1 * R2 / (R1 + R2);
Console.WriteLine(R3);


// Задание 2
Console.Write("Rk = ");
double Rk = Convert.ToDouble(Console.ReadLine());
Console.Write("Ro = ");
double Ro = Convert.ToDouble(Console.ReadLine());
double s = 0;
if (Rk > 0 && Ro > 0)
{
    if (Rk > Ro)
    {
        s = Math.PI * ((Rk * Rk) - (Ro * Ro));
        Console.WriteLine(s);
    }
    else Console.WriteLine("Ошибка. Радиуc кольца меньше или равен радиусу отверстия.");
}
else Console.WriteLine("Ошибка. Радиуcы отрицательны.");


// Задание 3
int p = 15;
int[] massiv = new int[20];
Random randNumb = new Random();
for (int i = 0; i < massiv.Length; i++)
{
    massiv[i] = randNumb.Next(0, 11);
    Console.WriteLine(massiv[i]);
}
Console.WriteLine();

int index1 = 0, index2 = 1;
int sumClose = Math.Abs(p - massiv[0] - massiv[1]);
for (int i = 0; i < massiv.Length; i++)
    for (int j = i + 1; j < massiv.Length; j++)
    {
        int min = Math.Abs(p - massiv[i] - massiv[j]);
        if (min <= sumClose)
        {
            index1 = i;
            index2 = j;
            sumClose = min;
        }
    }
Console.WriteLine($"Два различных элемента массива, сумма которых наиболее близка к p: " + massiv[index1] + " " + massiv[index2]);
Console.WriteLine($"Разница между элементов и p: " + sumClose);
Console.ReadKey();


// Задание 4
Console.WriteLine("Введите число n:");
string n = Console.ReadLine();
char[] mas = new char[n.Length];
for (int i = 0; i < n.Length; i++)
{
    mas[i] = n[i];
    Console.WriteLine(mas[i]);
}
int first = Convert.ToInt32(mas[0].ToString());
int last = Convert.ToInt32(mas[mas.Length - 1].ToString());
int sum = first + last;
Console.WriteLine();
Console.WriteLine("Сумма первого и последнего элемента равна: " + sum);
Console.ReadLine();


// Задание 5
Console.WriteLine("Введите число n:");
string n = Console.ReadLine();
char[] mas = new char[n.Length];
for (int j = 0; j < n.Length; j++)
{
    mas[j] = n[j];
    Console.WriteLine(mas[j]);
}
int sum0 = 0;
int sum5 = 0;
int i = 0;
while (i < n.Length)
{
    if (Convert.ToInt32(mas[i].ToString()) == 0)
        sum0++;
    i++;
}
i = 0;
while (i < n.Length)
{
    if (Convert.ToInt32(mas[i].ToString()) == 5)
        sum5++;
    i++;
}
Console.WriteLine();
Console.WriteLine(sum0);
Console.WriteLine(sum5);


// Задание 6
using System;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите n: ");
        int n = Int32.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 2; i <= n; i++)
        {
            if ((i % 2 == 0) && (n % i == 0))
                sum += i;
        }
        Console.WriteLine($"Сумма чет. делителей равна " + sum);
    }
}


// Задания без вариантов

// Задание 1
namespace 1
{
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите дату (в данном формате: 1 апреля 1900): ");
        var data = Console.ReadLine().ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] month = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
        uint a = Convert.ToUInt32(data[0]);
        string b = data[1];
        uint c = Convert.ToUInt32(data[2]);
        uint D = 0;
        uint[] day = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        uint[] visokosniy = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        for (int i = 0; i < 12; i++)
        {
            if ((c % 4 == 0 && c % 100 != 0) || (c % 400 == 0))
            {
                if (b == month[i])
                {
                    if (a > 0 && a <= visokosniy[i])
                    {
                        uint x = D + a;
                        uint y = 366 - (D + a);
                        Console.WriteLine($"Корректная дата\n{x}\n{y}");
                    }
                    else Console.WriteLine("Некорректная дата");
                }
                D = D + visokosniy[i];
            }
            else
            {
                if (b == month[i])
                {
                    if (a > 0 && a <= day[i])
                    {
                        uint x = D + a;
                        uint y = 365 - (D + a);
                        Console.WriteLine($"Корректная дата\n{x}\n{y}");
                    }
                    else Console.WriteLine("Некорректная дата");
                }
                D = D + day[i];
            }
        }
    }
}
}


// Задание 2
using System;
namespace pr3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер года ");
            int n = int.Parse(Console.ReadLine());
            int I = 0;
            int count = 0;
            int[] years = new int[n];
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] vdays = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] Sanitaryday = new int[55];
            for (int i = 0; i < years.Length; i++)
            {
                int year = i + 1;
                for (int j = 0; j < 12; j++)
                {
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        for (int k = 0; k < vdays[j]; k++)
                        {
                            if (I == 7) { I = 0; }
                            if (year == n && I == 3)
                            {
                                Sanitaryday[count] = k + 1;
                                count++;
                            }
                            I++;
                        }
                    }
                    else
                    {
                        for (int k = 0; k < days[j]; k++)
                        {
                            if (I == 7) { I = 0; }
                            if (year == n && I == 3)
                            {
                                Sanitaryday[count] = k + 1;
                                count++;
                            }
                            I++;
                        }
                    }
                }
            }
            for (int m = 0; m < Sanitaryday.Length; m++)
            {
                if (m < Sanitaryday.Length - 1 && Sanitaryday[m] > Sanitaryday[m + 1])
                {
                    Console.Write(Sanitaryday[m] + " ");
                }
            }
        }
    }
}


// Задание 3
Random rand = new Random();
int i = rand.Next(5);
int count = 1;
Console.WriteLine("Загадано число от 0 до 4. У вас есть 2 попытки, чтобы отгадать данное число");
Console.WriteLine("Введите первое число:");
int k = Convert.ToInt32(Console.ReadLine());
while (count <= 2)
{
    if (i > k)
    {
        Console.WriteLine("Неверно, загадано число больше введенного. Следующая попытка:");
        k = Convert.ToInt32(Console.ReadLine());
    }
    if (i < k)
    {
        Console.WriteLine("Неверно, загадано число меньше введенного. Следующая попытка:");
        k = Convert.ToInt32(Console.ReadLine());
    }
    if (i == k)
    {
        Console.WriteLine("Верно, загадано число " + k + " !!!!!!");
        k = Convert.ToInt32(Console.ReadLine());
        break;
    }
    else
    {
        count++;
        if (count == 2)
        {
            Console.WriteLine("Вам не удалось угадать. Это было число: " + i + " !");
            break;
        }

    }

}
Console.ReadLine();


// Задание 4
using System;
namespace Sample5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("количество элементов массива = ");
            int N = int.Parse(Console.ReadLine());
            Random R = new Random();
            int[] A = new int[N];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = R.Next(-100, 100);
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("\nНовый массив:");
            int[] mas = new int[N];
            for (int i = 0; i < mas.Length; i++)
            {
                int a = R.Next(1, mas.Length + 1);
                if (!mas.Contains(a)) mas[i] = a;
                else i--;
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(A[mas[i] - 1]);
            }
        }
    }
}



// Задание 5
using System.Security.Cryptography;
class Program
{
    public static byte RND()
    {
        RNGCryptoServiceProvider Rand = new RNGCryptoServiceProvider();
        byte[] randomNumber = new byte[1];
        Rand.GetBytes(randomNumber);
        return (randomNumber[0]);
    }
    static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
        {
            double А = RND();
            Console.Write(А + "  ");
        }
    }
}

