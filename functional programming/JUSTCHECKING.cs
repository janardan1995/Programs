using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalProgramming
{
    class JUSTCHECKING
    {
       public static void Ok()
        {
            Console.WriteLine("computer turns");
            int x = Utility.Random1();
            //
            char[] arr = new char[9] { '-', '-', '-', '-', '-', '-', '-', '-', '-' };
            switch (x)
            {
                case 1:

                    if (arr[0] != 'X' || arr[0] != 'O')
                    {
                        arr[0] = 'X';
                       
                        // Console.WriteLine(1);
                    }
                    //else
                    //{
                    //    CallComputer(arr);
                    //}

                    break;

                case 2:
                    if (arr[1] != 'X' || arr[1] != 'O')
                    {
                        arr[1] = 'X';
                       // return arr[1];
                        // Console.WriteLine(1);
                    }
                    //else
                    //{
                    //    CallComputer(arr);
                    //}
                    break;

                case 3:
                    if (arr[2] != 'X' || arr[2] != 'O')
                    {
                        arr[2] = 'X';
                       // return arr[2];
                        // Console.WriteLine(1);
                    }
                    //else
                    //{
                    //    CallComputer(arr);
                    //}
                    break;

                case 4:
                    if (arr[3] != 'X' || arr[3] != 'O')
                    {
                        arr[3] = 'X';
                       // return arr[3];
                        // Console.WriteLine(1);
                    }
                    //else
                    //{
                    //    CallComputer(arr);
                    //}
                    break;

                case 5:
                    if (arr[4] != 'X' || arr[4] != 'O')
                    {
                        arr[4] = 'X';
                        //return arr[4];
                        // Console.WriteLine(1);
                    }
                    //else
                    //{
                    //    CallComputer(arr);
                    //}
                    break;

                case 6:
                    if (arr[5] != 'X' || arr[5] != 'O')
                    {
                        arr[5] = 'X';
                       // return arr[5];
                        // Console.WriteLine(1);
                    }
                    //else
                    //{
                    //    CallComputer(arr);
                    //}
                    break;

                case 7:
                    if (arr[6] != 'X' || arr[6] != 'O')
                    {
                        arr[6] = 'X';
                       // return arr[6];
                        // Console.WriteLine(1);
                    }
                    //else
                    //{
                    //    CallComputer(arr);
                    //}
                    break;

                case 8:
                    if (arr[7] != 'X' || arr[7] != 'O')
                    {
                        arr[7] = 'X';
                       // return arr[7];
                        // Console.WriteLine(1);
                    }
                    //else
                    //{
                    //    CallComputer(arr);
                    //}
                    break;

                case 9:
                    if (arr[8] != 'X' || arr[8] != 'O')
                    {
                        arr[8] = 'X';
                       // return arr[8];
                        // Console.WriteLine(1);
                    }
                    //else
                    //{
                    //    CallComputer(arr);
                    //}
                    break;

                default:
                    Console.WriteLine("INVALID INPUT");
                    
                    break;
            }
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
