using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = 5;
            Console.WriteLine("Print Pattern:");
            PrintPattern(n);

            int n2 = 6;
            Console.WriteLine("Print Series:");
            PrintSeries(n2);
            Console.WriteLine();

            string s = "09:15:35PM";
            string t = USFtime(s);
            Console.WriteLine(t);

            int n3 = 110;
            int k = 11;
            Console.WriteLine("USF Numbers:");
            USFnumbers(n3, k);

            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            Console.WriteLine("Palindrome indices:");
            PalindromePairs(words);
            
            Console.WriteLine("Combination where Player 1 wins:");
            Stones(21);

        }

        private static void PrintPattern(int n)
        {
            try
            {
                //as long as n is greater than 0, run for loop
                if (n > 0)
                {
                    // For loop initialized with integer i, assigned to n and printing the value of i so long it is less than 1
                    for (int i = n; i >= 1; i--)
                    {
                        Console.Write(i);

                    }
                    //print in a new line
                    Console.WriteLine();
                    //calling the method 'PrintPattern' with decremented value of n-1
                    PrintPattern(n - 1);
                    Console.ReadLine();
                }

                }
            catch
            {
                Console.WriteLine("Exception occurred while computing PrintPattern");
            }
        }
        
        private static void PrintSeries(int n2)
        {
            try
            {
                //Declaring a variable called n2
                
                //Declaring a variable temp and assigning its value to 0
                int temp = 0;
                //Run a For loop initialized with integer i as long as i is less than num
                for (int i = 1; i <= n2; i++)
                {
                    //For each value of i, add i to temp and assign it to temp
                    temp = temp + i;
                    //Print each value of temp in the same line and increment the value of i for next iteration
                   
                    Console.Write(temp + " ");
                    
                }

                Console.ReadLine();


            }
           
            catch
            {
                Console.WriteLine("Exception occurred while computing PrintSeries");
            }
        }

        public static string USFtime(string s)
        {
            try
            {
                
                //Initializing a string called 'str' and storing AM or PM from the timeframe using a substring function
                string str = s.Substring(8, 2);
                //if str contains AM, execute the following statements
                if (str == "AM")
                {
                    //logic is to convert hours and minutes to seconds by dividing each by the total number of seconds
                    int hourstoseconds = (Convert.ToInt32(s.Substring(0, 2))) * 60 * 60;
                    int minutestoseconds = (Convert.ToInt32(s.Substring(3, 2))) * 60;
                    int seconds = Convert.ToInt32(s.Substring(6, 2));
                    //computing the total number of seconds
                    int totalseconds = hourstoseconds + minutestoseconds + seconds;
                    //calculating usf hour by dividing total seconds by 2700 which is the toal number of seconds in an hour in USF planet which is 60*45
                    int usf_hour = totalseconds / 2700;
                    int usf_minute = (totalseconds - (usf_hour * 2700)) / 45;
                    int usf_second = totalseconds - (usf_hour * 2700) - (usf_minute * 45);
                    //printing the converted USF time in hh:mm:ss format
                    Console.WriteLine("USF time is:" + usf_hour + ":" + usf_minute + ":" + usf_second);
                    Console.ReadLine();
                }

                else
                {
                    //if str contains PM, adding 12 hours to the number of hours before converting into seconds
                    int hourstoseconds = (12 + (Convert.ToInt32(s.Substring(0, 2)))) * 60 * 60;
                    int minutestoseconds = (Convert.ToInt32(s.Substring(3, 2))) * 60;
                    int seconds = Convert.ToInt32(s.Substring(6, 2));
                    int totalseconds = hourstoseconds + minutestoseconds + seconds;
                    int usf_hour = totalseconds / 2700;
                    int usf_minute = (totalseconds - (usf_hour * 2700)) / 45;
                    int usf_second = totalseconds - (usf_hour * 2700) - (usf_minute * 45);
                    //printing the converted USF time in hh:mm:ss format
                    Console.WriteLine("USF time is:" + usf_hour + ":" + usf_minute + ":" + usf_second);
                    Console.ReadLine();
                }


            }
            catch
            {
                Console.WriteLine("Exception occurred while computing USFtime");
            }
            return null;
        }

        public static void USFnumbers(int n3, int k)
        {
            try
            {
                
               
                //Initializing an object array of size 220 to store integer and string values
                object[] array1 = new object[220];
                // For loop initialized with an integer i 
                for (int i = 1; i <= n3; i++)
                {
                    array1[i] = i;
                    //checking if i is divisible by 3 and 5, if true replacing i with US in the array
                    if (((i % 3) == 0) && ((i % 5) == 0))
                    {
                        array1[i] = "US";
                    }
                    //checking if i is divisible by 5 and 7, if true replacing i with SF in the array
                    else if (((i % 5) == 0) && ((i % 7) == 0))
                    {
                        array1[i] = "SF";
                    }
                    //checking if i is divisible by 3, if true replacing i with U in the array
                    else if ((i % 3) == 0)
                    {
                        array1[i] = "U";
                    }
                    //checking if i is divisible by 5, if true replacing i with S in the array
                    else if ((i % 5) == 0)
                    {
                        array1[i] = "S";
                    }
                    //checking if i is divisible by 7, if true replacing i with F in the array
                    else if ((i % 7) == 0)
                    {
                        array1[i] = "F";
                    }


                }
                //For loop initialized with an integer j
                for (int j = 1; j <= n3; j++)
                {
                    //printing the value of j in a line as long as j divided by 11 is not equal to 0
                    if (j % k != 0)
                    {
                        Console.Write(array1[j] + " ");
                    }
                    else
                    {
                        //printing the value of j in a new line when j divided by 11 is 0
                        Console.WriteLine(array1[j] + " ");
                    }
                }

                Console.ReadLine();

            }

            catch
            {
                Console.WriteLine("Exception occurred while computing USFnumbers");

            }
        }


        public static void PalindromePairs(string[] words)
        {
            try
            {
                //initialize a string
                string y;
                //run for loop as long as i is less than the length of the string
                for (int i = 0; i < words.Length; i++)
                {
                    //run for loop as long as i is less than the length of the string
                    for (int j = 0; j < words.Length; j++)
                    {
                        //execute the statements only when i is not equal j
                        if (i != j)
                        {
                            //concatenate both the strings and store it in y
                            y = words[i] + words[j];
                            //initialize an empty string called 'palind'
                            string palind = "";
                            //initialize a for loop with m as lenght of string-1 and execute as long as m>=0
                            for (int m = y.Length - 1; m >= 0; m--)
                            {
                                //add palind and string y and assign it to palind
                                palind = palind + y[m];
                            }
                            //check if y is equal to palind and write the indices if true
                            if (y == palind)
                            {
                                Console.WriteLine(i + "," + j);
                            }                            

                        }
                        Console.ReadLine();
                    }
                }
            }
         
            catch
            {

                Console.WriteLine("Exception occured while computing     PalindromePairs()");
            }
        }

        public static void Stones(int n4)
        {
            try
            {
                //logic is that whenever the number of stones is divisible by 4, player 1 loses the game.
                int turns_player2 = n4 / 4; // calculates no. of turns that player 2 requires to win the game
                int stones_PLayer2 = turns_player2 * 4; //no. of stones required for player 2 to win.
                int turns_player1 = (stones_PLayer2) / 2 + 1;// no. of turns required when Player 1 wins
                int[] turns = new int[turns_player1+2];
                Random var = new Random();//initializing an instance of random to generate the moves of Player2

                if (n4 % 4 !=0)
                {
                    turns[0] = n4 % 4; // the first move will always be number of stones modulus 4
                    for(int i=1; i<= turns_player1;i+=2)
                    {
                        turns[i] = var.Next(1, 3);// generates moves by Player 2
                        turns[i + 1] = 4 - turns[i]; // Player 1 will always play 4 minus the move of Player 2

                    }
                    for(int k =0; k <= turns_player1-1;k++)
                    {
                        Console.WriteLine(turns[k]); // Prints the array of the number of moves.
                        Console.ReadLine();
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }




    }










}



      







    
