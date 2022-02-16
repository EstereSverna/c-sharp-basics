using System;
using System.Linq;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];
        static bool Playing { get; set; }
        static int CountTurns { get; set; }

        private static void Main(string[] args)
        {
            Playing = true;
            CountTurns = 0;

            InitBoard();
            DisplayBoard();

            while (Playing == true)
            {
                Move();
                DisplayBoard();
                CheckWin();
                IsTie();
            }
            Console.Read();
        }

        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
        }

        public static char GetTurn()
        {
            char player1 = 'X';
            char player2 = 'O';

            if (CountTurns % 2 == 0)
            {
                return player1;
            }
            else
            {
                return player2;
            }
        }

        public static void Move()
        {
            var actualPlayer = GetTurn();
            int[] validInput = { 00, 01, 02, 10, 11, 12, 20, 21, 22 };
            int input;

            Console.WriteLine($"{actualPlayer}, choose your location (row, column) turn: ");
            var valid = int.TryParse(Console.ReadLine(), out input);

            while (valid == false || !validInput.Contains(input))
            {
                Console.WriteLine("Not valid input. try again");
                valid = int.TryParse(Console.ReadLine(), out input);
            }

            var column = input % 10;
            var row = (input - column) / 10;

            if (CheckIfTaken(row, column) == true)
            {
                while (CheckIfTaken(row, column) != false)
                {
                    Console.WriteLine($"{actualPlayer}, you chose invalid location (row, column), do it again: ");
                    input = Convert.ToInt32(Console.ReadLine());

                    column = input % 10;
                    row = (input - column) / 10;
                }
            }
            else
            {
                board[row, column] = actualPlayer;
            }
        }

        private static bool CheckIfTaken(int row, int column)
        {
            return board[row, column] != ' ';
        }

        public static void CheckWin()
        {
            if ((board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && (board[0, 0] == 'X' || board[0, 0] == 'O'))
                || (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && (board[1, 0] == 'X' || board[1, 0] == 'O'))
                || (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && (board[2, 0] == 'X' || board[2, 0] == 'O'))
                || (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && (board[0, 0] == 'X' || board[0, 0] == 'O'))
                || (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && (board[0, 1] == 'X' || board[0, 1] == 'O'))
                || (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && (board[0, 2] == 'X' || board[0, 2] == 'O'))
                || (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && (board[0, 0] == 'X' || board[0, 0] == 'O'))
                || (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && (board[2, 0] == 'X' || board[2, 0] == 'O')))
            {
                Playing = false;
                Console.WriteLine($"{GetTurn()}, you Won!");
            }
            else
            {
                CountTurns++;
            }
        }

        private static void IsTie()
        {
            if (CountTurns == 9 && Playing == true)
            {
                Playing = false;
                Console.WriteLine("It's a tie!");
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }
    }
}
