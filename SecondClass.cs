namespace Mission4Assignment;

public class SecondClass
{
    // method that receives and prints the board
    public void PrintBoard(char[,] board)
    {
        // print the actual board
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($" {board[i, 0]} | {board[i, 1]} | {board[i, 2]}");
            if (i < 2) Console.WriteLine("----|----|----");
        } 
    }
    
    // receives the board and outputs the board as playing and determines winner
    public bool PlayGame(char[,] board, int input, char playerChoice)
    {
        // check the position where the user is putting their move
        int row = (input - 1) / 3;
        int col = (input - 1) % 3;
        
        // check if the position is valid 
        if (input < 1 || input > 9 || board[row, col] == 'X' || board[row, col] == 'O')
        {
            Console.WriteLine("Invalid move. Please try again.");
            return false; // Move was invalid
        }
        
        // Update the board with the player's move
        board[row, col] = playerChoice;
        return true; // Move was successful
    }
    
    // Method to check if there is a winner
    public bool CheckWinner(char[,] board, char player)
    {
        // Check rows, columns, and diagonals
        for (int i = 0; i < 3; i++)
        {
            // Check rows and columns
            if ((board[i, 0] == player && board[i, 1]  == player && board[i, 2] == player) ||
                (board[0, i] == player && board[1, i] == player && board[2, i] == player)) return true;
        }

        // Check diagonals
        if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player) return true;
        if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player) return true;

        return false; 
    }
    
    // method to check if board is full
    public bool CheckBoard(char[,] board)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == 'X' && board[i, j] == 'O')
                {
                    return false;
                }
            }
        }
        return true;
    }
}