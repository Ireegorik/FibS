using System;

namespace FibS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(1,-3));
            Console.ReadKey();
        }
        static int Fib(int mode, int value)
        {
            int curFib = 0;
            int secondFib = 1;
            int temp = 0;
            switch (mode)
            {
                case 1:
                    if (value < 0)
                    {
                        secondFib = -1;
                        for (int i = 0; i > value; i--)
                        {
                            temp = curFib;
                            curFib = curFib + secondFib;
                            secondFib = temp;
                        }
                        return curFib;
                    }
                    else
                    {
                        for (int i = 0; i < value; i++)
                        {
                            temp = curFib;
                            curFib = curFib + secondFib;
                            secondFib = temp;
                        }
                        return curFib;
                    }

                    break;
                case 2:
                    int index = 0;
                    if(value != 0)
                    {

                        while ((curFib <= value))
                        {
                            index++;
                            temp = curFib;
                            curFib = curFib + secondFib;
                            if (value == curFib) return index;
                            secondFib = temp;

                        }
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                    break;
            }
            return -2;
        }
    }
}
