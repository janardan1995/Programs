//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace FunctionalProgramming
//{
//    class TicTakTeo1
//    {
//        //public static void Tic1()
//        //{
//        //    char[] arr = new char[9] { '-','-', '-', '-', '-', '-', '-', '-', '-' } ;
//        //   // Display(arr);
//        //    int i = 9;
//        //    while (i > 0)
//        //    {
//        //        char a=CallComputer(arr);
//        //        Display(arr);
//        //        ComputerWin(arr);
//        //        CallUser(arr);
//        //        Display(arr);
//        //        UserWin(arr);





//        //        i--;
//        //    }

//        //}
//        //public static void Display(char[] arr)
//        //{
//        //    for (int i = 0; i <= 2; i++)
//        //    {
//        //        Console.Write(arr[i]);
//        //    }
//        //    Console.WriteLine();
//        //    for (int i = 0; i <= 2; i++)
//        //    {
//        //        Console.Write(arr[i]);
//        //    }
//        //    Console.WriteLine();
//        //    for (int i = 0; i <= 2; i++)
//        //    {
//        //        Console.Write(arr[i]);
//        //    }
//        //    Console.WriteLine();
//        //}
//        //public static char CallComputer(char[] arr)
//        //{
//        //    Console.WriteLine("computer turns");
//        //    int x = Utility.Random1();
//        //    //

//        //    switch (x)
//        //    {
//        //        case 1:

//        //            if (arr[0]!='X'|| arr[0] != 'O')
//        //            {
//        //                arr[0] = 'X';
//        //                return arr[0];
//        //                // Console.WriteLine(1);
//        //            }
//        //            else
//        //            {
//        //                CallComputer(arr);
//        //            }

//        //            break;

//        //        case 2:
//        //            if (arr[1] != 'X' || arr[1] != 'O')
//        //            {
//        //                arr[1] = 'X';
//        //                return arr[1];
//        //                // Console.WriteLine(1);
//        //            }
//        //            else
//        //            {
//        //                CallComputer(arr);
//        //            }
//        //            break;

//        //        case 3:
//        //            if (arr[2] != 'X' || arr[2] != 'O')
//        //            {
//        //                arr[2] = 'X';
//        //                return arr[2];
//        //                // Console.WriteLine(1);
//        //            }
//        //            else
//        //            {
//        //                CallComputer(arr);
//        //            }
//        //            break;

//        //        case 4:
//        //            if (arr[3] != 'X' || arr[3] != 'O')
//        //            {
//        //                arr[3] = 'X';
//        //                return arr[3];
//        //                // Console.WriteLine(1);
//        //            }
//        //            else
//        //            {
//        //                CallComputer(arr);
//        //            }
//        //            break;

//        //        case 5:
//        //            if (arr[4] != 'X' || arr[4] != 'O')
//        //            {
//        //                arr[4] = 'X';
//        //                return arr[4];
//        //                // Console.WriteLine(1);
//        //            }
//        //            else
//        //            {
//        //                CallComputer(arr);
//        //            }
//        //            break;

//        //        case 6:
//        //            if (arr[5] != 'X' || arr[5] != 'O')
//        //            {
//        //                arr[5] = 'X';
//        //                return arr[5];
//        //                // Console.WriteLine(1);
//        //            }
//        //            else
//        //            {
//        //                CallComputer(arr);
//        //            }
//        //            break;

//        //        case 7:
//        //            if (arr[6] != 'X' || arr[6] != 'O')
//        //            {
//        //                arr[6] = 'X';
//        //                return arr[6];
//        //                // Console.WriteLine(1);
//        //            }
//        //            else
//        //            {
//        //                CallComputer(arr);
//        //            }
//        //            break;

//        //        case 8:
//        //            if (arr[7] != 'X' || arr[7] != 'O')
//        //            {
//        //                arr[7] = 'X';
//        //                return arr[7];
//        //                // Console.WriteLine(1);
//        //            }
//        //            else
//        //            {
//        //                CallComputer(arr);
//        //            }
//        //            break;

//        //        case 9:
//        //            if (arr[8] != 'X' || arr[8] != 'O')
//        //            {
//        //                arr[8] = 'X';
//        //                return arr[8];
//        //                // Console.WriteLine(1);
//        //            }
//        //            else
//        //            {
//        //                CallComputer(arr);
//        //            }
//        //            break;

//        //        default:
//        //            Console.WriteLine("INVALID INPUT");
//        //            CallComputer(arr);
//        //            return arr[0];
//        //            break;
//        //    }
//        //}
//        //public static void CallUser(char[] arr)
//        //{
//        //    Console.WriteLine("enter the no");
//        //    int x = int.Parse(Console.ReadLine());

//        //    switch (x)
//        //    {
//        //        case 1:

//        //            if (arr[0] != 'X' || arr[0] != 'O')
//        //            {
//        //                arr[0] = 'O';
//        //                // Console.WriteLine(1);
//        //            }
//        //            else
//        //            {
//        //                CallUser(arr);
//        //            }
//        //            break;

//        //        case 2:
//        //            if (arr[1] != 'X' || arr[1] != 'O')
//        //            {
//        //                arr[1] = 'O';
//        //                // Console.WriteLine(1);
//        //            }
//        //            else
//        //            {
//        //                CallUser(arr);
//        //            }
//        //            break;

//        //        case 3:
//        //            if (arr[2] != 'X' || arr[2] != 'O')
//        //            {
//        //                arr[2] = 'O';
//        //                // Console.WriteLine(1);
//        //            }
//        //            else
//        //            {
//        //                CallUser(arr);
//        //            }
//        //            break;

//        //        case 4:
//        //            if (arr[3] != 'X' || arr[3] != 'O')
//        //            {
//        //                arr[3] = 'O';
//        //                // Console.WriteLine(1);
//        //            }
//        //            else
//        //            {
//        //                CallUser(arr);
//        //            }
//        //            break;

//        //        case 5:
//        //            if (arr[4] != 'X' || arr[4] != 'O')
//        //            {
//        //                arr[4] = 'O';
//        //                // Console.WriteLine(1);
//        //            }
//        //            else
//        //            {
//        //                CallUser(arr);
//        //            }
//        //            break;

//        //        case 6:
//        //            if (arr[5] != 'X' || arr[5] != 'O')
//        //            {
//        //                arr[5] = 'O';
//        //                // Console.WriteLine(1);
//        //            }
//        //            else
//        //            {
//        //                CallUser(arr);
//        //            }
//        //            break;

//        //        case 7:
//        //            if (arr[6] != 'X' || arr[6] != 'O')
//        //            {
//        //                arr[6] = 'O';
//        //                // Console.WriteLine(1);
//        //            }
//        //            else
//        //            {
//        //                CallUser(arr);
//        //            }
//        //            break;

//        //        case 8:
//        //            if (arr[7] != 'X' || arr[7] != 'O')
//        //            {
//        //                arr[7] = 'O';
//        //                // Console.WriteLine(1);
//        //            }
//        //            else
//        //            {
//        //                CallUser(arr);
//        //            }
//        //            break;

//        //        case 9:
//        //            if (arr[8] != 'X' || arr[8] != 'O')
//        //            {
//        //                arr[8] = 'O';
//        //                // Console.WriteLine(1);
//        //            }
//        //            else
//        //            {
//        //                CallUser(arr);
//        //            }
//        //            break;

//        //        default:
//        //            Console.WriteLine("INVALID INPUT");
//        //            CallUser(arr);
//        //            break;
//        //    }
//        //}
//        //public static void ComputerWin(char[] arr)
//        //{
//        //    if (arr[0] == 'X' && arr[1] == 'X' && arr[2] == 'X' || arr[0] == 'X' && arr[3] == 'X' && arr[6] == 'X'
//        //           || arr[0] == 'X' && arr[4] == 'X' && arr[8] == 'X' || arr[3] == 'X' && arr[4] == 'X' && arr[5] == 'X' ||
//        //          arr[6] == 'X' && arr[7] == 'X' && arr[8] == 'X' || arr[1] == 'X' && arr[4] == 'X' && arr[7] == 'X' ||
//        //              arr[2] == 'X' && arr[5] == 'X' && arr[8] == 'X' || arr[6] == 'X' && arr[4] == 'X' && arr[2] == 'X')
//        //    {
//        //        Console.WriteLine("Computer win");
//        //        Environment.Exit(0);
//        //    }

//        //}
//        //public static void UserWin(char[] arr)
//        //{
//        //    if (arr[0] == 'O' && arr[1] == 'O' && arr[2] == 'O' || arr[0] == 'O' && arr[3] == 'O' && arr[6] == 'O'
//        //           || arr[0] == 'O' && arr[4] == 'O' && arr[8] == 'O' || arr[3] == 'O' && arr[4] == 'O' && arr[5] == 'O' ||
//        //          arr[6] == 'O' && arr[7] == 'O' && arr[8] == 'O' || arr[1] == 'O' && arr[4] == 'O' && arr[7] == 'O' ||
//        //              arr[2] == 'O' && arr[5] == 'O' && arr[8] == 'O' || arr[6] == 'O' && arr[4] == 'O' && arr[2] == 'O')
//        //    {
//        //        Console.WriteLine("uSER win");
//        //        Environment.Exit(0);
//        //    }

//        //}public class TicTacToe {
       
//	static String[] board;
//        static String turn;

//        public static void main(String[] args)
//        {
		
//            board = new String[9];
//            turn = "X";
//            String winner = null;
//            populateEmptyBoard();

//            Console.WriteLine("Welcome to 2 Player Tic Tac Toe.");
//            Console.WriteLine("--------------------------------");
//            printBoard();
//            Console.WriteLine("X's will play first. Enter a slot number to place X in:");

//            while (winner == null)
//            {
//                int numInput;
//                //try
//                //{
//                    numInput = Utility.UtiliReadInt();
//                    if (!(numInput > 0 && numInput <= 9))
//                    {
//                        Console.WriteLine("Invalid input; re-enter slot number:");
//                        continue;
//                    }
//                //}
//                //wrong.....
//                //catch (ArgumentException )
//                //{
//                //    Console.WriteLine("Invalid input; re-enter slot number:");
//                //    continue;
//                //}
//                // string.valueOf(no)+which convert anything to string
               
//                 if (board[numInput - 1].Equals(numInput.ToString()));
//                {
//                    board[numInput - 1] = turn;
//                    if (turn.Equals("X")) 
//                    {
//                        turn = "O";
//                    }
//                    else
//                    {
//                        turn = "X";
//                    }
//                    printBoard();
//                    winner = checkWinner(); 
//                }
//                //else
//                //{
//                //    Console.WriteLine("Slot already taken; re-enter slot number:");
//                //    continue;
//                //}
//            }
//            //incase sensetive term
//            if (winner.Equals(("draw"), StringComparison.OrdinalIgnoreCase))
//            {
//                Console.WriteLine("It's a draw! Thanks for playing.");
//            }
//            else
//            {
//                Console.WriteLine("Congratulations! " + winner + "'s have won! Thanks for playing.");
//            }
//        }

//        static String checkWinner()
//        {
//            for (int a = 0; a < 8; a++)
//            {
//                String line = null;
//                switch (a)
//                {
//                    case 0:
//                        line = board[0] + board[1] + board[2];
//                        break;
//                    case 1:
//                        line = board[3] + board[4] + board[5];
//                        break;
//                    case 2:
//                        line = board[6] + board[7] + board[8];
//                        break;
//                    case 3:
//                        line = board[0] + board[3] + board[6];
//                        break;
//                    case 4:
//                        line = board[1] + board[4] + board[7];
//                        break;
//                    case 5:
//                        line = board[2] + board[5] + board[8];
//                        break;
//                    case 6:
//                        line = board[0] + board[4] + board[8];
//                        break;
//                    case 7:
//                        line = board[2] + board[4] + board[6];
//                        break;
//                }
//                if (line.Equals("XXX"))
//                {
//                    return "X";
//                }
//                else if (line.Equals("OOO"))
//                {
//                    return "O";
//                }
//            }

//            for (int a = 0; a < 9; a++)
//            {
//    //            if ((board).contains((a + 1).ToString()))
//                {
//                    break;
//                }
//                else if (a == 8) return "draw";
//            }

//            Console.WriteLine(turn + "'s turn; enter a slot number to place " + turn + " in:");
//            return null;
//        }

//        static void printBoard()
//        {
//            Console.WriteLine("/---|---|---\\");
//            Console.WriteLine("| " + board[0] + " | " + board[1] + " | " + board[2] + " |");
//            Console.WriteLine("|-----------|");
//            Console.WriteLine("| " + board[3] + " | " + board[4] + " | " + board[5] + " |");
//            Console.WriteLine("|-----------|");
//            Console.WriteLine("| " + board[6] + " | " + board[7] + " | " + board[8] + " |");
//            Console.WriteLine("/---|---|---\\");
//        }

//        static void populateEmptyBoard()
//        {
//            for (int a = 0; a < 9; a++)
//            {
//                board[a] = (a + 1).ToString();
//            }
//        }
//    }

//}
