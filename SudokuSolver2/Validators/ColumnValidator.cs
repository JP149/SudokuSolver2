using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.Validators
{
    public class ColumnValidator:IValidator
    {
        private Sudoku sudoku;

        public ColumnValidator(Sudoku sudoku)
        {
            this.sudoku = sudoku;
        }

        public bool IsValid(ushort index)
        {
            int cellValue = sudoku.Cells[index];

            int column = index % 9;
            for (int i = 0; i < 9; i++)
            {
                int colIndex = column + i * 9;

                if (colIndex == index)
                    continue;

                if (cellValue == sudoku.Cells[colIndex])
                    return false;
            }
            return true;
        }
    }
}
