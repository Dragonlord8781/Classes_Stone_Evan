using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Stone_Evan
{
    class Greetings
    {
        //creates the public function: Welcome
        public void Welcome()
        {
            //Writes line saying hello (O-si-yo)
            Console.WriteLine("Osiyo, Welcome User!");
        }

        //creates the pubic function: Hello, also gives it the string parameter: name
        public void Hello(string name)
        {
            //writes a line thanking the user for logging on using the name string parameter 
            Console.WriteLine($"Well, {name}, thank you for logging on.");
        }

    }
}
