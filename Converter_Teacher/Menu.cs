using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter_Teacher
{
    class Menu
    {
        char ans;
        int choice;

        public void Display()
        {
            Console.WriteLine("1 - Перевод F -> C");
            Console.WriteLine("2 - Перевод C -> F");
            Console.WriteLine("3 - Выход");
        }
    }
}
