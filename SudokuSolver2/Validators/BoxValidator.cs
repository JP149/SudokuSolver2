using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.Validators
{
    public class BoxValidator:IValidator
    {
        private Sudoku sudoku;

        public BoxValidator(Sudoku sudoku)
        {
            this.sudoku = sudoku;
        }
        public bool IsValid(ushort index)
        {
            int cellValue = sudoku.Cells[index];
            Box boxIndices = BoxIndices.GetBox(index);

            foreach (var boxIndex in boxIndices)
            {
                if (index == boxIndex)
                    continue;

                int value = sudoku.Cells[boxIndex];

                if (value == cellValue)
                    return false;
            }
            return true;
        }
    }
}
