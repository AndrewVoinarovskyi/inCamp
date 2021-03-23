using System;

namespace tiktak
{
    class Program
    {
        
        static void Main(string[] args)
        {
            

            const char empty = ' ';
            char[,] field = new char[3,3];
            int turn = 0;
            bool game = false;
            for(var i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    field[i,j] = empty;
                }
            }
            GameField(field);

            while (game == false)
            {
                game = DetermineWinner(empty, field, game, turn);
                turn += 1;
            }
            Console.ReadKey();
        }
        static void GameField(char[,] Field)
        {
            const string line = "-+-+-";
            const string vert = "|";
            Console.WriteLine($"{Field[0, 0]}{vert}{Field[0, 1]}{vert}{Field[0, 2]}");
            Console.WriteLine(line);
            Console.WriteLine($"{Field[1, 0]}{vert}{Field[1, 1]}{vert}{Field[1, 2]}");
            Console.WriteLine(line);
            Console.WriteLine($"{Field[2, 0]}{vert}{Field[2, 1]}{vert}{Field[2, 2]}");
        }
        static bool DetermineWinner(char Empty, char[,] Field, bool Game, int turn)
        {
            const char X = 'X';
            const char O = 'O';
            string first, second;
            int line;
            int column;
            bool flag = true;
            int player = (turn % 2) + 1;

            do
            {
                try
                {
                    Console.WriteLine($"Player {player} change line (1-3):");
                    first = Console.ReadLine();
                    line = Convert.ToInt32(first) - 1;
                    Console.WriteLine($"Player {player} change column (1-3):");
                    second = Console.ReadLine();
                    column = Convert.ToInt32(second) - 1;
                    if ((first.Length ==  1) && (second.Length == 1))
                    {
                        if ((line >= 0 && line < 3) && (column >= 0 && column <3))
                        {
                            if (Field[line,column] == Empty)
                            {
                                if (player ==1)
                                {
                                    Field[line,column] = X;
                                }
                                else 
                                {
                                    Field[line,column] = O;
                                }
                                flag = false;
                            }
                            else
                            {
                                Console.WriteLine("Changed row is not empty. Choose another one.");
                            }
                        }
                         else
                        {
                            Console.WriteLine("Error. Input 1, 2 or 3.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error. Input only ONE number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error. Input correct data.");
                }
            }
            while(flag);

            Game = (Empty != Field[0,0]) && (Field[0,0] == Field[0,1]) && (Field[0,1] == Field[0,2]) ||
                   (Empty != Field[1,0]) && (Field[1,0] == Field[1,1]) && (Field[1,1] == Field[1,2]) ||
                   (Empty != Field[2,0]) && (Field[2,0] == Field[2,1]) && (Field[2,1] == Field[2,2]) ||
                   (Empty != Field[0,0]) && (Field[0,0] == Field[1,0]) && (Field[1,0] == Field[2,0]) ||
                   (Empty != Field[0,1]) && (Field[0,1] == Field[1,1]) && (Field[1,1] == Field[2,1]) ||
                   (Empty != Field[0,2]) && (Field[0,2] == Field[1,2]) && (Field[1,2] == Field[2,2]) ||
                   (Empty != Field[0,0]) && (Field[0,0] == Field[1,1]) && (Field[1,1] == Field[2,2]) ||
                   (Empty != Field[0,2]) && (Field[0,2] == Field[1,1]) && (Field[1,1] == Field[2,0]);

            GameField(Field);
            if (Game)
                Console.WriteLine($"Player {player} is winner");
            else if (turn == 8)
            {
                Game = true;
                Console.WriteLine("Draw");
            }

            return Game;
        }
    }
}