using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03_06
{

    //Створіть клас «Закордонний паспорт». Вам необхідно
    //зберігати інформацію про номер паспорта, ПІБ власника,
    //дату видачі, тощо.Передбачити механізми ініціалізації
    //полів класу.Якщо значення для ініціалізації неправильне - генеруйте виняток.

    internal class InternationalPassport
    {
        private string _persName {  get; set; }
        private string _passId { get; set; }
        private string _passCountry { get; set; }

        public InternationalPassport() { }
        public InternationalPassport(string persName, string passId,string passCountry) {
            _passCountry = passCountry;
            _persName = persName;
            _passId = passId;
        }



        
        public void showPass()
        {
            Console.WriteLine($"Name: {_persName}\nID: {_passId}\nCountry: {_passCountry}");
        }

        public void regPass()
        {
          
            try
            {
                string newName, newPassId, newPassCountry;
                Console.Write("Enter name: ");
                newName = Console.ReadLine();
                if (String.IsNullOrEmpty(newName)) //IsNullOrEmpty == (str == null || str.Length == 0)
                {
                    throw new Exception("You enter incorrect  name\n");
                }

                Console.Write("Enter pass ID: ");
                newPassId = Console.ReadLine();
                if (String.IsNullOrEmpty(newPassId))
                {
                    throw new Exception("You enter incorrect passpor ID\n");
                }

                Console.Write("Enter country: ");
                newPassCountry = Console.ReadLine();
                if (String.IsNullOrEmpty(newPassCountry)) 
                {
                    throw new Exception("You enter incorrect country\n");
                }

                
                _passId = newPassId;
                _persName = newName; 
                _passCountry= newPassCountry;
                

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error message: {ex.Message}");
            }
        }
    }
}
