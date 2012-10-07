using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string requestName = "\nHello, Please enter your name, then press Enter to continue.";
            Console.WriteLine(requestName);
            
            string inputName;
            inputName = Console.ReadLine();
            
            if (inputName.Equals("mickey", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.Write("Hi {0}, I would love it if you would give me a PASS for this assignment?", inputName);    
            }
            else
            {
                Console.Write("Hi {0}, I'm afraid I'm not at liberty to discuss my grade with anyone other than the instructor.", inputName);
            }

            Console.ReadLine();
        }
    }
}
 