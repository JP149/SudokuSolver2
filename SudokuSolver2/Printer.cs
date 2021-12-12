using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2
{
    public static class Printer
    {
        static public string Print(Sudoku sudoku, bool pretty = false)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            foreach (ushort cell in sudoku.Cells)
            {
                sb.Append(cell);
                if (++count == 9 && pretty)
                {
                    sb.Append("\n");
                    count = 0;
                }
            }
            return sb.ToString();
        }
    }
}
