using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        // Create an instance of the supporting class
        TicTacToeGame game = new TicTacToeGame();

        // Start the game loop
        while (!game.IsGameOver())
        {
            // Print the current board
            game.PrintBoard();

            // Get the current player's move
            Console.WriteLine($"Player {game.GetCurrentPlayer()}'s turn");
            Console.Write("Enter row (0-2): ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter column (0-2): ");
            int col = int.Parse(Console.ReadLine());

            // Make the move and switch to the next player
            game.MakeMove(row, col);

            // Check for a winner
            if (game.CheckForWinner())
            {
                // Print the final board
                game.PrintBoard();

                // Announce the winner
                Console.WriteLine($"Player {game.GetWinner()} wins!");
                return;
            }
        }

        // If the game ends in a draw
        Console.WriteLine("It's a draw!");
    }
}
