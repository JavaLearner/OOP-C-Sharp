using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 3;
            char symbol = '*';


            Draw(x, y, symbol);

            int x2 = 5;
            int y2 = 7;
            char symbol2 = '#';

            Draw(x2, y2, symbol2);


            Console.ReadKey();
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
