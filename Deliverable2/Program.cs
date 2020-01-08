using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            string message = null;
            int checksum = 0;

            Console.WriteLine("What is your message ?");
            input = Console.ReadLine().ToUpper();

            byte[] unicode = System.Text.Encoding.ASCII.GetBytes(input);

            for (int e = 0; e < unicode.Length; e++)
            {
                if (e != unicode.Length - 1)
                {
                    message += (unicode[e] - 64) + "-";
                }
                else 
                {
                    message += (unicode[e] - 64);
                }

                checksum += unicode[e];
            }
            Console.WriteLine("Your encoded message is " + message);

            /* Previous code
            for (int i = 0; i < unicode.Length; i++)
            {
                checksum += unicode[i];
            } */

            Console.WriteLine("Message checksum is " + checksum);          
        }
    }
}
