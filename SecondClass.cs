using System.Numerics;

namespace Mission4Assignment;


public class SecondClass
{
    // method that receives and prints the board
    public void PrintBoard(char[,] board)
    {
        // print the actual board
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($" {board[i, 0]}  |  {board[i, 1]} |  {board[i, 2]}");
            if (i < 2) Console.WriteLine("----|----|----");
        }


    }

    // Method to check if there is a winner
    public bool CheckWinner(char[,] board, char player)
    {
        // Check rows, columns, and diagonals
        for (int i = 0; i < 3; i++)
        {
            // Check rows and columns
            if ((board[i, 0] == player && board[i, 1] == player && board[i, 2] == player) ||
                (board[0, i] == player && board[1, i] == player && board[2, i] == player)) return true;
        }


        // Check diagonals
        if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) return true;
        if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player) return true;


        return false;
    }

    public bool CheckBoard(char[,] board)
    {
        for (int i = 0; i < 3; i++)  // Loop through rows
        {
            for (int j = 0; j < 3; j++)  // Loop through columns
            {
                // If any cell is NOT 'X' or 'O', the board is not full
                if (board[i, j] != 'X' && board[i, j] != 'O')
                {
                    return false;
                }
            }
        }
        return true; // If all cells contain 'X' or 'O', the board is full
    }
}
