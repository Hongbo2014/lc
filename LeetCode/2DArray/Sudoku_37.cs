using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._2DArray
{
    internal class Sudoku_37
    {
        public Sudoku_37()
        {
            var board = new char[][]
            {
                new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
                new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
            };

            SolveSudoku(board);
        }

        public void SolveSudoku(char[][] board)
        {
            if (board == null) return;
            SolveSudokuBackTrack(board);
        }

        private bool SolveSudokuBackTrack(char[][] board)
        {
            for (int i = 0; i < board[0].Length; i++)
            {
                for (int j = 0; j < board[1].Length; j++)
                {
                    if (board[i][j] != '.') continue;
                    for (byte m = 1; m <= 9; m++)
                    {
                        if (IsValid(board, m, i, j))
                        {
                            board[i][j] = Char.Parse(m.ToString());
                            if (SolveSudokuBackTrack(board)) return true;
                            board[i][j] = '.';
                        }
                    }
                    return false;
                }
            }

            return true;
        }

        private bool IsValid(char[][] board, int val, int row, int col)
        {
            for (int i = 0; i < board[0].Length; i++)
            {
                if (board[row][i] - '0' == val) return false;
            }

            for (int i = 0; i < board[1].Length; i++)
            {
                if (board[i][col] - '0' == val) return false;
            }

            int bRow = (row / 3) * 3;
            int bCol = (col / 3) * 3;

            for (int i = bRow; i < bRow + 3; i++)
            {
                for (int j = bCol; j < bCol + 3; j++)
                {
                    if (board[i][j] - '0' == val) return false;
                }
            }

            return true;
        }
    }
}
