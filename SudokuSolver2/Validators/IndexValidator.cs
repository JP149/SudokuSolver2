using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.Validators
{
    public sealed class IndexValidator : IValidator
    {
        private Sudoku sudoku;
        List<IValidator> validators = new List<IValidator>();

        public IndexValidator(Sudoku sudoku)
        {
            this.sudoku = sudoku;
            validators.Add(new RowValidator(sudoku));
            validators.Add(new ColumnValidator(sudoku));
            validators.Add(new BoxValidator(sudoku));
        }

        public bool IsValid(ushort index)
        {
            bool isValid = false;
            foreach (var valildator in validators)
            {
                isValid = valildator.IsValid(index);
                if (!isValid)
                    break;
            }
            return isValid;
        }
    }
}
