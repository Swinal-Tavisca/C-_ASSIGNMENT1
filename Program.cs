using System;

namespace Assignment1
{
    class Program
    {
        /****************PREDEFINED DETAILS*********************
         * 3 predefined entries have been made in the database with **********ID-1,2,3******
         * Program is divided according to account type
         * each account type have different user
         * A Bank System with following Account Type,

            Saving 
            Current
            DMAT

            Should have the following functions:

            Display Account Details
            Search by Account ID
            Deposit (Any amount)
            Withdraw 
                --Saving Account minimum Balance is 1000.
                -- Current Account minimum Balance is 0.
                -- DMAT Account Minimum balance can be -10000
               Calculate Interest  (4% on Saving Account and  1% on Current )
         * 
         * 
         */
        static void Main(string[] args)
        {
            int flag = 0;
            do
            {
                Console.WriteLine("ENTER YOUR ACCOUNT TYPE");
                Console.WriteLine("1. SAVING");
                Console.WriteLine("2. CURRENT");
                Console.WriteLine("3. DMAT");
                Console.WriteLine("4. EXIT");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Saving saving_object = new Saving();
                }
                else if (option == 2)
                {
                    Current current_object = new Current();
                }
                else if (option == 3)
                {
                    Dmat dmat_object = new Dmat();
                }
                else if(option==4)
                {
                    flag++;
                }
                else
                {
                    Console.WriteLine("ERROR INPUT");
                    flag++;
                }
            } while (flag==0);
            


        }
    }
}
