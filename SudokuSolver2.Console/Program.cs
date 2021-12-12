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
            
            Sudoku sudoku = new Sudoku(args[0]);

            bool solved = Solver.Solve(sudoku);

            if (solved)
                System.Console.WriteLine(sudoku);
            else
                System.Console.WriteLine("Could not solve the puzzle");
        }
    }
}
