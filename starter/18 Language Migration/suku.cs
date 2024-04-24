// tranlate to c#
using System;

public class Sudoku
{
    private int[,] board;

    public Sudoku()
    {
        // Create a 3x3 Sudoku board
        this.board = new int[3, 3]
        {
            {0, 0, 0},
            {0, 0, 0},
            {0, 0, 0}
        };
    }

    // Function to create the Sudoku board in Console
    public void CreateBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j] == 0 ? " " : board[i, j].ToString());
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    // Function to clear the Sudoku board
    public void ClearBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = 0;
            }
        }
    }
}