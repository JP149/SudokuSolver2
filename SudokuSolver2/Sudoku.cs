using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2
{
    sealed public class Sudoku
    {
        public ushort[] Cells { get; private set; }

        public Sudoku(ushort[] cells)
        {
            Cells = cells;
        }

        public override string ToString()
        {
            return new Printer(this).Print();
        }
    }
}
