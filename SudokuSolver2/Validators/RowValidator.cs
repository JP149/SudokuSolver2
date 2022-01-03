using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.Validators
{
    public class RowValidator : IValidator
    {
        private Sudoku sudoku;

        public RowValidator(Sudoku sudoku)
        {
            this.sudoku = sudoku;
        }
        public bool IsValid(ushort index)
        {
            int cellValue = sudoku.Cells[index];

            int row = index / 9;
            int baseNum = row * 9;

            for (int i = 0; i < 9; i++)
            {
                int rowIndex = baseNum + i;

                if (rowIndex == index)
                    continue;

                if (cellValue == sudoku.Cells[rowIndex])
                    return false;
            }
            return true;
        }
    }
}
