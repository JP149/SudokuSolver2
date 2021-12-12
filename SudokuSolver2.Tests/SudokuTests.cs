using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SudokuSolver2.Tests
{
    [TestClass]
    public class SudokuTests
    {
        [TestMethod]
        public void SudokuSolveTest()
        {
            string sudokuString =
                "--5--839-" +
                "-3-------" +
                "---7---8-" +
                "--45--6-2" +
                "61-------" +
                "2---49---" +
                "-----24-5" +
                "--9-8----" +
                "56-------";

            Sudoku sudoku = new Sudoku(sudokuString);

            bool solved = Solver.Solve(sudoku);
            
            Assert.IsTrue(solved);

            string solvedSudokuString = sudoku.ToString();

            Debug.WriteLine(sudokuString);
            Debug.WriteLine(solvedSudokuString);
        }
    }
}
