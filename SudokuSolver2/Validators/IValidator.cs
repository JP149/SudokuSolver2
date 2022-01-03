using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.Validators
{
    public interface IValidator
    {
        bool IsValid(ushort index);
    }
}
