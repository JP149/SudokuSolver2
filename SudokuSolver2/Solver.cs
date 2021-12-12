using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2
{
    public static class Solver
    {
        public static bool Solve(Sudoku sudoku)
        {
            return BackTrack(sudoku, 0);
        }

        /// <summary>
        /// The Backtrack Algorithm
        /// Start at index
        /// If not a fixed value (0 is unfixed), 
        /// Iterate through 1-9 at index, check if value is valid(in box, row an column at each iteration, 
        /// Backtrack the next index until solved
        /// If fixed, skip iterating at index move to next index
        /// </summary>
        public static bool BackTrack(Sudoku sudoku, ushort index)
        {
            if (index == 81)
                return true;

            if (sudoku.Cells[index] != 0)
            {
                ushort nextIndex = (ushort)(index + 1);
                return BackTrack(sudoku, nextIndex);
            }

            for (ushort i = 1; i <= 9; i++)
            {
                sudoku.Cells[index] = i;

                if (sudoku.IsValid(index))
                {
                    ushort nextIndex = (ushort)(index+1);
                    if (!BackTrack(sudoku, nextIndex))
                        continue;
                    else
                        return true;
                }
            }

            //Value at index causes invalid sudoku puzzle
            //set the cell at index back to unfixed (0)
            sudoku.Cells[index] = 0;
            return false;
        }
    }
}
