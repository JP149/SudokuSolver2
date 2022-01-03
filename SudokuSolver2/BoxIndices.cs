using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2
{
    /// <summary>
    /// Sudoku Grid Indices
    ///      Box1       Box2      Box3
    ///     0  1  2 |  3  4  5 |  6  7  8 
    ///     9 10 11 | 12 13 14 | 15 16 17 
    ///    18 19 20 | 21 22 23 | 24 25 26
    ///    
    ///      Box4       Box5       Box6
    ///    27 28 29 | 30 31 32 | 33 34 35 
    ///    36 37 38 | 39 40 41 | 42 43 44 
    ///    45 46 47 | 48 49 50 | 51 52 53 
    ///    
    ///      Box7       Box8       Box9
    ///    54 55 56 | 57 58 59 | 60 61 62 
    ///    63 64 65 | 66 67 68 | 69 70 71 
    ///    72 73 74 | 75 76 77 | 78 79 80 
    /// </summary>
    /// 

    public class Box : List<int> { }

    public static class BoxIndices
    {
        public static readonly Box Box1 = new Box { 0, 1, 2, 9, 10, 11, 18, 19, 20 };
        public static readonly Box Box2 = new Box { 3, 4, 5, 12, 13, 14, 21, 22, 23 };
        public static readonly Box Box3 = new Box { 6, 7, 8, 15, 16, 17, 24, 25, 26 };
        public static readonly Box Box4 = new Box { 27, 28, 29, 36, 37, 38, 45, 46, 47 };
        public static readonly Box Box5 = new Box { 30, 31, 32, 39, 40, 41, 48, 49, 50 };
        public static readonly Box Box6 = new Box { 33, 34, 35, 42, 43, 44, 51, 52, 53 };
        public static readonly Box Box7 = new Box { 54, 55, 56, 63, 64, 65, 72, 73, 74 };
        public static readonly Box Box8 = new Box { 57, 58, 59, 66, 67, 68, 75, 76, 77 };
        public static readonly Box Box9 = new Box { 60, 61, 62, 69, 70, 71, 78, 79, 80 };

        public static Box GetBox(int indexToFind)
        {
            if (indexToFind > 80 || indexToFind < 0)
                throw new Exception("Invalid Index, Out of Range");

            Box containedBox = null;

            if (Box1.Contains(indexToFind))
                containedBox = Box1;

            else if (Box2.Contains(indexToFind))
                containedBox = Box2;

            else if (Box3.Contains(indexToFind))
                containedBox = Box3;

            else if (Box4.Contains(indexToFind))
                containedBox = Box4;

            else if (Box5.Contains(indexToFind))
                containedBox = Box5;

            else if (Box6.Contains(indexToFind))
                containedBox = Box6;

            else if (Box7.Contains(indexToFind))
                containedBox = Box7;

            else if (Box8.Contains(indexToFind))
                containedBox = Box8;

            else if (Box9.Contains(indexToFind))
                containedBox = Box9;

            return containedBox;
        }
    }
}
