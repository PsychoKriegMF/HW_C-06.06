using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_C_06._06
{
    public class NoPositiveNumbersExceptions : Exception
    {
        public NoPositiveNumbersExceptions() : base("Нет положительных чисел!") { }
    }
    public class ContactException : Exception
    {
        public ContactException() : base("Не корректные данные!") { }
    }
}
