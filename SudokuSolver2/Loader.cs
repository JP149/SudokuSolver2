using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2
{
    static class Loader
    {
        public static ushort[] LoadGrid(string sudoku)
        {
            var cells = new ushort[81];

            if (string.IsNullOrEmpty(sudoku))
                return cells;

            ParseSudokuString(sudoku, cells);

            return cells;
        }

        private static void ParseSudokuString(string sudoku, ushort[] cells)
        {
            int cell = 0;
            foreach (char charNumber in sudoku)
            {
                if (charNumber == '-')
                    cells[cell] = 0;
                else
                {
                    Int16 number = 0;
                    Int16.TryParse(charNumber.ToString(), out number);

                    cells[cell] = (ushort)number;
                }

                cell++;
            }
        }
    }
}