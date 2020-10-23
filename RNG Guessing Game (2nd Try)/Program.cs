using System;
using System.Security.Cryptography;
using System.Threading;

namespace RNG_Guessing_Game__2nd_Try_

{ class Program
    {
        static int num;
       
        static int numuser;

        static string numusercheck;

        // Global Variable

        static void Main(string[] args)

        {
            var randomnum = new Random();
            num = randomnum.Next(1, 11); 
            Start(); } //Goes directly to start




        static void Start()
        {
            {
                

                Console.WriteLine("Choose a number from 0 - 10"); //Tells user what number to choose
                numusercheck = Console.ReadLine();
                

                //Console.WriteLine("Test Num " + num); //This is for checking what number the rng chose
                                if (numusercheck == "1" || numusercheck == "2" || numusercheck == "3" || numusercheck == "4" || numusercheck == "5" || numusercheck == "6" || numusercheck == "7" || numusercheck == "8" || numusercheck == "9" || numusercheck == "10")

                { numuser = Convert.ToInt32(numusercheck); //Converting number to integer

                 Check(); }

                else

                {
                    Console.WriteLine("Please choose a number from 0 - 10"); //Ask user which number to choose from
                    

                    Start();


                }
            }




            static void Check() //Made this for checking purposes only
            {
                while (num != numuser) //While Loop to check if num is not = numuser
                {
                    Console.WriteLine("Try again");  //ask user to try again

                    numuser = Convert.ToInt32(Console.ReadLine());
                }



                Console.WriteLine("You won");



            }
        }
    }
}



