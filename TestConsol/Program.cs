using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace TestConsol
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary2.Helper.Calculator x = new ClassLibrary2.Helper.Calculator();
            var y = x.Add(2, 3);
        }
    }
}
