public class TicTacToeGame
{
    private char[,] board;
    private char currentPlayer;
    private bool gameOver;
    private char winner;

    public TicTacToeGame()
    {
        board = new char[3, 3];
        currentPlayer = 'X';
        gameOver = false;
        winner = '\0';
    }

    public char GetCurrentPlayer()
    {
        return currentPlayer;
    }

    public bool IsGameOver()
    {
        return gameOver;
    }

    public char GetWinner()
    {
        return winner;
    }

    public void MakeMove(int row, int col)
    {
        if (board[row, col] == '\0')
        {
            board[row, col] = currentPlayer;
            SwitchPlayer();
        }
        else
        {
            Console.WriteLine("Invalid move. The cell is already occupied.");
        }
    }

    public void PrintBoard()
    {
        Console.WriteLine("Current Board:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public bool CheckForWinner()
    {
        // Check rows, columns, and diagonals for a winner
        // (You can implement the detailed logic here)

        // For simplicity, let's assume 'X' wins if they fill any row
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == 'X' && board[i, 1] == 'X' && board[i, 2] == 'X')
            {
                winner = 'X';
                gameOver = true;
                return true;
            }
        }

        // Switch player if the board is not full
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == '\0')
                {
                    return false;
                }
            }
        }

        // If the board is full and there is no winner, it's a draw
        gameOver = true;
        return false;
    }

    private void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }
}
