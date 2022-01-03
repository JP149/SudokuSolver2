using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SudokuSolver2;

namespace SudokuSolver2.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(args[0]);

            Loader loader = new Loader(args[0]);
            ushort[] cells = loader.LoadGrid();

            Sudoku sudoku = new Sudoku(cells);
            
            Solver solver = new Solver(sudoku);

            bool solved = solver.Solve();

            if (solved)
                System.Console.WriteLine(sudoku);
            else
                System.Console.WriteLine("Could not solve the puzzle");
        }
    }
}
