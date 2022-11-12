using System;
using System.Collections.Specialized;

class RangeOfArray
{
    int a;
    int b;
    int[] A = new int[0];
    public RangeOfArray(int a, int b)
    {
        this.a = a; this.b = b;
        A = new int[b - a + 1];
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = 1;
        }
    }
    public int this[int index]
    {
        get // читання з позиції index
        {
            return A[Math.Abs(index) - Math.Abs(a)];
        }
        set
        {
            A[Math.Abs(index) - Math.Abs(a)] = value;
        }
    }
    public void see()
    {
        for (int i = 0; i < A.Length; i++)
        {
            Console.WriteLine("element[" +( a + i )+ "]:" + A[i]);
        }
    }

    class Program
    {
        static void Main()
        {
            int a = 0, b = 0, c = 0;
            Console.WriteLine("Кожний елемент буде заповнений одиницями . . .\n\n"
                + "Введіть початок діапазону");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (b < a)
            {
                c = a;
                a = b;
                b = c;
                Console.WriteLine("Ви ввели неправильно діпазон, тому тепер він виглядає так: " + a + " : " + b);
            }
            else if (b == a)
            {
                Console.WriteLine("Такий діпазон неможливий");
                return;
            }
            RangeOfArray AR = new RangeOfArray(a, b);
            AR.see();
        }
    }
}