using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Algorithm
{
    class regexxxxxxxxx
    {
        public static void reee()
        {
                Console.WriteLine("enter DOB");
            String fullName = Console.ReadLine();


            string strRegex = @"[0-9]{1}[1-2]{1}/[0-9]{1}[1-2]{1}/[1-2]{1}[0-9]{3}";
            Regex re = new Regex(strRegex);

            if (re.IsMatch(fullName)) {
                Console.WriteLine("yes i found it");
            }
            else
            {
                Console.WriteLine("invalide try again");
              
            }
            string str = "hello janardan";
            string[] arr = str.Split(" "); 
            Console.WriteLine("{0}",arr[0]);

        }
    }
}
