using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_teoria
{
    class WrongModelException : Exception
    {
        public WrongModelException() : base("BŁĘDNY MODEL DANYCH!"){}
    }
}
