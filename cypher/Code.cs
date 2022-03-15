using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cypher
{
    internal class Code
    {
        static int[] getValues(string text)
        {
            char[] codeArray = new char[text.Length];
            int[] codeValue = new int[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                codeArray[i] = text[i];
                codeValue[i] = codeArray[i];
                if (codeValue[i] < 'a' & codeValue[i] >= 'A')
                {
                    codeValue[i] = codeValue[i] + ('a' - 'A');
                }
                else if (codeValue[i] < 'A')
                {
                    codeValue[i] = codeValue[i];
                }
            }
            return codeValue;
        }
    }
}
