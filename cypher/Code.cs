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
        static int[] codeValues(string text)
        {
            int[] valuesArray = cypher.Code.getValues(text);
            for (int i = 0; i < text.Length; i++)
            {
                valuesArray[i] = cypher.Code.getValues(text)[i];
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (valuesArray[i] >= 'a' & valuesArray[i] < 'z')
                {
                    valuesArray[i] = valuesArray[i] + 1;
                }
                else if (valuesArray[i] == 'z')
                {
                    valuesArray[i] = 'a';
                }
            }
            return valuesArray;
        }
        static char[] parseValues(string text)
        {
            int[] valuesArray = cypher.Code.codeValues(text);
            char[] charsArray = new char[valuesArray.Length];
            for (int i = 0; i < valuesArray.Length; i++)
            {
                valuesArray[i] = cypher.Code.codeValues(text)[i];
            }
            for (int i = 0; i < valuesArray.Length; i++)
            {
                charsArray[i] = Convert.ToChar(valuesArray[i]);
            }
            return charsArray;
        }
        public static char[] showCypher(string text)
        {
            char[] charsArray = cypher.Code.parseValues(text);
            return charsArray;
        }
        static int[] deCypherValues(string text)
        {
            int[] valueArray = cypher.Code.getValues(text);
            for (int i = 0; i < text.Length; i++)
            {
                valueArray[i] = cypher.Code.getValues(text)[i];
            }
            return valueArray;
        }
        static char[] deCypherParse(string text)
        {
            int[] valueArray = deCypherValues(text);
            char[] charsArray = new char[valueArray.Length];
            for (int i = 0; i < text.Length; i++)
            {
                if (valueArray[i] > 'a')
                {
                    valueArray[i] = valueArray[i] - 1;
                }
                else if (valueArray[i] == 'a')
                {
                    valueArray[i] = 'z';
                }
            }
            for (int i = 0; i < text.Length; i++)
            {
                charsArray[i] = Convert.ToChar(valueArray[i]);
            }
            return charsArray;
        }
        public static char[] deCypher(string text)
        {
            char[] charsArray = deCypherParse(text);
            return charsArray;
        }
    }
}
