using Coder.Common;
using System;
using System.Text;

namespace Coder
{
     public sealed class ACoder : ICoder
    {
        public string Encode(string str)
        {
            StringBuilder output = new StringBuilder();
            foreach (char symbol in str)
            {
                if (symbol >= 'А' && symbol <= 'я') //проверка на буквы русского алфавита
                {
                    switch (symbol) //все значения увеличиваем на 1 кроме буквы Я. Ей присваеваем персонально.
                    {
                        case 'Я':
                            output.Append('А');
                            break;
                        case 'я':
                            output.Append('а');
                            break;
                        default:
                            output.Append((char)(symbol+1)); 
                            break;
                    }
                    continue;
                }
                output.Append(symbol);
            }
            return output.ToString();
        }
            
            
        

        public string Decode(string str)    // Всё наоборот. Повторение кода - нехорошо, но как исправить - не знаю.
        {
            StringBuilder output = new StringBuilder();
            foreach (char symbol in str)
            {
                if (symbol >= 'А' && symbol <= 'я')
                {
                    switch (symbol)
                    {
                        case 'А':
                            output.Append('Я');
                            break;
                        case 'а':
                            output.Append('я');
                            break;
                        default:
                            output.Append((char)(symbol - 1));
                            break;
                    }
                    continue;
                }
                output.Append(symbol);
            }
            return output.ToString();
        }
    }



}
