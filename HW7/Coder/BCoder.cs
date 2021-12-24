using Coder.Common;
using System.Text;

namespace Coder
{
    public sealed class BCoder : ICoder
    {

        public string Encode(string str)
        {
            StringBuilder output = new StringBuilder();
            foreach (char symbol in str)
            {
                if (symbol >= 'А' && symbol <= 'Я')
                {
                    output.Append(ChangeSymbols('А','Я', symbol));
                    continue;
                }
                if (symbol >= 'а' && symbol <= 'я')
                {
                    output.Append(ChangeSymbols('а', 'я', symbol));
                    continue;
                }
                output.Append(symbol);
            }
            return output.ToString();
        }

        public string Decode(string str)
        {
            return Encode(str);
        }

        private char ChangeSymbols(char beginChar, char endChar, char forChange) 
        {
            return (char)(endChar - (forChange - beginChar));
        }


    }
}
