using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que10
{
    class ABC
    {
        public void Method()
        {
            MyClass obj = new MyClass();
            obj.PublicMethod();
        }
    }
    class main
    {
        static void Main(string[] args)
        {
            ABC obj1 = new ABC();
            obj1.Method();
        }
    }
}
