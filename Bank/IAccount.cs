using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public interface IAccount
    {
        int MaxConsecutiveLetters(string input);
        int MaxConsecutiveDigits(string input);
    }
}
