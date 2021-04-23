using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Здравствуйте вас приветствует математическая программа");
        Console.WriteLine("пажалуйста введите число. ");

        String S = Console.ReadLine();

        if (S == "q")
        {
            return;
        }
        int c1, c2, c3;
        NewMethod(S, out c1, out c2, out c3);
        Console.WriteLine("Факториал равет " + c1); Console.WriteLine("Сума от 1 до N равна " + c2);

        Console.WriteLine("максимальное четное число меньше N равно" + c3);
        Console.ReadLine();
    }

    private static void NewMethod(string S, out int c1, out int c2, out int c3)
    {
        int M = Int32.Parse(S);
        c1 = 1;
        c2 = 0;
        c3 = 0;
        for (int i = 1; i <= M; i++)
        {
            c1 = c1 * i;
            c2 = c2 + i;
            if (i % 2 == 0)
            {
                c3 = i;
            }
        }
    }
}