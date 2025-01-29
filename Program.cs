using System;
using SupportingClass;
internal class Program
{
    static void Main()
    {
        SecondClass sc = new SecondClass();

        int player = 1;
        int choice;
        string input;
        bool gameOver = false;

        const char playerOneMark = 'X';
        const char playerTwoMark = 'O';

        char[,] boardArray = new char[3, 3]
            {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };

        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        while (!gameOver)
        {
            // Print the board
            sc.PrintBoard(boardArray);

            // Prompt user to select location
            Console.WriteLine("Player {0}, choose a number (1-9) to make your move:", player);

            // Checks the input to be an integer and between 1-9. Otherwise it asks the user to input again.
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 9)
            {
                Console.WriteLine("Invalid option. Please try again.\n");
                continue;
            }

            // check the position where the user is putting their move
            int row = (choice - 1) / 3;
            int col = (choice - 1) % 3;

            // Error check that it is a valid location and a location that is NOT occupied
            if (boardArray[row, col] != playerOneMark && boardArray[row, col] != playerTwoMark) // Check if spot is available
            {
                // Update the board
                boardArray[row, col] = player == 1 ? playerOneMark : playerTwoMark;

                // Check for winner
                gameOver = sc.CheckWinner(boardArray, player);

                // If no winner, switch player
                player = (player == 1) ? 2 : 1;
            }
            else
            {
                //If position is taken, prompt user to enter again.
                Console.WriteLine("That spot is already taken. Try again.\n");
            }

        }
        // Print final board
        sc.PrintBoard(boardArray);

        // Display winner if any

    }

}
