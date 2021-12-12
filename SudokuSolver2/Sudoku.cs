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

        public Sudoku(string sudoku)
        {
            Cells = Loader.LoadGrid(sudoku);
        }

        public bool IsValid(ushort index)
        {
            if (ValidInBox(index) && ValidInRow(index) && ValidInColumn(index))
                return true;
            else
                return false;
        }

        private bool ValidInBox(ushort index)
        {
            int cellValue = Cells[index];
            int[] boxIndices = BoxIndices.GetBox(index);

            foreach (var boxIndex in boxIndices)
            {   
                if (index == boxIndex)
                    continue;

                int value = Cells[boxIndex];

                if (value == cellValue)
                    return false;
            }
            return true;
        }

        private bool ValidInRow(ushort index)
        {
            int cellValue = Cells[index];

            int row = index / 9;
            int baseNum = row * 9;
            
            for (int i = 0; i < 9; i++)
            {
                int rowIndex = baseNum + i;
             
                if (rowIndex == index)
                    continue;

                if (cellValue == Cells[rowIndex])
                    return false;
            }
            return true;
        }
        private bool ValidInColumn(ushort index)
        {
            int cellValue = Cells[index];

            int column = index % 9;
            for (int i = 0; i < 9; i++)
            {
                int colIndex = column + i*9;
                
                if (colIndex == index)
                    continue;

                if (cellValue == Cells[colIndex])
                    return false;
            }
            return true;
        }

        public override string ToString()
        {
            return Printer.Print(this);
        }
    }
}
