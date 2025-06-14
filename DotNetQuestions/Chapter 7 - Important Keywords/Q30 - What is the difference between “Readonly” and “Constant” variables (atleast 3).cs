using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_7___Important_Keywords
{
    public class Constant
    {
        public const int myConstant = 100;
        public const int secondConstant;
        public Constant()
        {
            myConstant = 20;
        }
    }

    public class Readonly
    {
        public readonly int myReadonly = 100;
        public readonly int secondReadonly;
        public Readonly(int ctorreadonly)
        {
            secondReadonly = ctorreadonly;     
        }

    }
}
