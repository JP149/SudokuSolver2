using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2
{
    public class Loader
    {
        string sudokuString;

        ushort[] cells = new ushort[81];

        public Loader(string sudoku)
        {
            this.sudokuString = sudoku;
        }

        public ushort[] LoadGrid()
        {
            if (string.IsNullOrEmpty(sudokuString))
                return cells;

            ParseSudokuString();

            return cells;
        }

        private void ParseSudokuString()
        {
            int cell = 0;
            foreach (char charNumber in sudokuString)
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