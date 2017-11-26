using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListLibrary;

namespace LinkedListConsoleTest
{
    class TestStub
    {
        static void Main(string[] args)
        {
            LinkedListLibrary.LinkedList<string> list = new LinkedListLibrary.LinkedList<string>();

            string newString;

            for (int i = 0; i < 10; i++)
            {
                newString = new string(i.ToString().ToCharArray());
                list.Append(newString);
            }
            Console.WriteLine("-------------Forwards----------");
            list.Display();
            Console.WriteLine("-------------Backwards---------");
            list.DisplayBackwards();
            list.Clear();

            for (int i = 0; i < 10; i++)
            {
                newString = new string(i.ToString().ToCharArray());
                list.Prepend(newString);
            }
            Console.WriteLine("--------------Forwards---------");
            list.Display();
            Console.WriteLine("--------------Backwards--------");
            list.DisplayBackwards();
            list.Clear();
        }
    }
}
