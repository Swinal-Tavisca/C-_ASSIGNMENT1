using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    
    class Current
    {

        Dictionary<int, String> my_database_name = new Dictionary<int, String>()
        {
            { 1,"RAM"},
            { 2,"SHAM"},
            { 3,"ROHIT"}
        };
        Dictionary<int, int> my_database_amount = new Dictionary<int, int>()
        {
            {1,0 },
            {2,0 },
            {3,0 }
        };
        int id = 0;
        public Current()
        {

            int flag = 0;
            Console.WriteLine("ENTER YOUR ID");
            id = int.Parse(Console.ReadLine());
            //int id;

            do
            {
                Console.WriteLine();
                Console.WriteLine("ENTER YOUR OPTIONS");
                Console.WriteLine("1. VIEW DETAILS ");
                Console.WriteLine("2. DEPOSITE MONEY");
                Console.WriteLine("3. WITHDRAW MONEY");
                Console.WriteLine("4. CALCULATE INTEREST");
                Console.WriteLine("5. EXIT");

                int options = int.Parse(Console.ReadLine());
                if (options == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("1. NAME : {0}", my_database_name[id]);
                    Console.WriteLine("2. ID : {0}", id);
                    Console.WriteLine("3. AMOUNT : {0}", my_database_amount[id]);
                }
                else if (options == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("ENTER AMOUNT TO BE DEPOSITE");
                    int amount = int.Parse(Console.ReadLine());
                    my_database_amount[id] = my_database_amount[id] + amount;
                    Console.WriteLine("CURRENT BALANCE : {0}", my_database_amount[id]);


                }
                else if (options == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("ENTER AMOUNT TO BE WITHDRAW");
                    int amount = int.Parse(Console.ReadLine());
                    if(my_database_amount[id]<0)
                    {
                        Console.WriteLine("BALANCE IS 0. \n DEPOSITE AMMOUNT");
                    }
                    else
                    {
                        my_database_amount[id] = my_database_amount[id] - amount;
                        Console.WriteLine("CURRENT BALANCE : {0}", my_database_amount[id]);
                    }
                    
                }
                else if (options == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("RATE OF INTEREST = 5%");
                    Console.WriteLine("PERIOD IF INTEREST = 1 Year");
                    Console.WriteLine("TOTAL INTEREST : {0}", (my_database_amount[id] * 0.01));

                }
                else if (options == 5)
                {
                    flag++;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("WRONG INPUT");
                }


            } while (flag == 0);

        }
    }
}
