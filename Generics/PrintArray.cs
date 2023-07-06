using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class PrintArray<T>
    {
        private T[]  inputarray;

        public PrintArray(T[] inputarray)
        {
            this.inputarray = inputarray;
        }
        public void toprint()
        {
            foreach (var element in inputarray)
            {
                Console.WriteLine(element);
            }
        }

    }
}
