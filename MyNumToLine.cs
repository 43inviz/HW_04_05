using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03_06

    //Користувач вводить словами цифру від 0 до 9. Додаток
    //має перевести слово у цифру.Наприклад, якщо користувач
    //ввів five, додаток має вивести на екран 5. 
{
    internal class MyNumToLine
    {
        private Dictionary<char,string> _dictionary;
        public MyNumToLine() {
            _dictionary = new Dictionary<char, string>()
            {
                {'0',"ZERO"},
                {'1',"ONE"},
                {'2',"TWO" },
                {'3',"THREE" },
                {'4',"FOUR" },
                {'5',"FIVE" },
                {'6',"SIX" },
                {'7',"SEVEN" },
                {'8',"EIGHT" },
                {'9',"NINE\n" }
            };

        }
        
        public string reversNumToLine(char num)
        {
             
            return _dictionary[num];
        }


    }
}
