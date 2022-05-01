
using System;
using System.Collections.Generic;

namespace ticTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> board = initializeBoard();
            Console.WriteLine("1 | 2 | 3");
            Console.WriteLine("- + - + -");
            Console.WriteLine("4 | 5 | 6");
            Console.WriteLine("- + - + -");
            Console.WriteLine("7 | 8 | 9");
            Console.WriteLine("Enter a number between 1 and 9 on your turn. Only enter an unused space");
            int turnNum = 0;
            bool xTurn;
            int spot;
            do
            {
                xTurn = isXsTurn(board);
                turnNum++;
                displayBoard(board);
                spot = getUserInput(xTurn);
                updateBoard(board,spot,xTurn);
            }
            while (!GameOver(board, turnNum));
        }
        static List<char> initializeBoard()
        {
            List<char> board = new List<char>{' ',' ',' ',' ',' ',' ',' ',' ',' '};

            return board;
        }
        static void displayBoard(List<char> board)
        {
            Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
            Console.WriteLine("- + - + -");
            Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
            Console.WriteLine("- + - + -");
            Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
        }
        static int getUserInput(bool xTurn)
        {
            if(xTurn)
            {
                Console.WriteLine("x>");
            }
            else
            {
                Console.WriteLine("o>");
            }
            string userInput = Console.ReadLine();
            int spot = int.Parse(userInput) - 1;
            return spot;
        }
        static void updateBoard(List<char> board, int spot, bool xTurn)
        {
            if(xTurn){
                board[spot] = 'x';
            }
            else
            {
                board[spot] = 'o';
            }
        }
        static bool GameOver(List<char> board, int turnCount)
        {
            for (int row = 0; row < 3; row++)
            {
                if (board[row * 3] != ' ' && board[row * 3] == board[row * 3 + 1] && board[row * 3 + 1] == board[row * 3 + 2])
                {
                    displayBoard(board);
                    Console.WriteLine($"The winner is {board[row * 3]}");
                    return true;
                }
            }

            for (int column = 0; column < 3; column++)
            {
                if (board[column] != ' ' && board[column] == board[column + 3] && board[column + 3] == board[column + 6])
                {
                    displayBoard(board);
                    Console.WriteLine($"The winner is {board[column]}");
                    return true;
                }
            }

            if (board[0] != ' ' && board[0] == board[4] && board[4] == board[8])
            {
                displayBoard(board);
                Console.WriteLine($"The winner is {board[4]}");
                return true;
            }
            else if (board[2] != ' ' && board[2] == board[4] && board[4] == board[6])
            {
                displayBoard(board);
                Console.WriteLine($"The winner is {board[4]}");
                return true;
            }
            else if (turnCount >= 9)
            {
                displayBoard(board);
                Console.WriteLine("You have tied");
            }
            return false;
        }
        static bool isXsTurn(List<char> board)
        {
            int emptySpots = 0;
            foreach (char spot in board)
            {
                if (spot == ' ')
                {
                    emptySpots++;
                }
            }
            if (emptySpots % 2 == 0)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
    }
}