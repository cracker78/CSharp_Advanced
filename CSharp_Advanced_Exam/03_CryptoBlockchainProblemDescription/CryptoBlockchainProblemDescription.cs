using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_CryptoBlockchainProblemDescription
{
    class CryptoBlockchainProblemDescription
    {
        static void Main()
        {
            string pattern = @"(?<=[(\{|\[)]).*(\d*)(?=[(\}|\])])";

            Regex regex=new Regex(pattern);



        }
    }
}
