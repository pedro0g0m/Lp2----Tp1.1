using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infected_Control
{
    class MyException : ApplicationException
    {
        public MyException(string s) : base("Nao repetir pacientes")
        {
        }

        public MyException(Exception e)
        {
            throw new MyException(e.Message);
        }
    }
}
