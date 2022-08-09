using System;
using System.Collections;
using System.Collections.Generic;
namespace Bank_Complaint_Queries
{
    class User_Console
    {
        public static List<Complaint> Complaints;
        public static void InitializeApp()

        {
            ComplaintCsvReader reader = new ComplaintCsvReader();


            Complaints = reader.GetComplaints();
                
            Console.WriteLine("DOne Initialising.....");

           
            

        }

        public static void PrintMenu()
        {
            Console.WriteLine("----------MENU-----------");
            Console.WriteLine("1.Enter year to display complaints");
            Console.WriteLine("2.Enter Bank_Name to display complaints");
            Console.WriteLine("3.Enter Complaint_id to display complaint");
            Console.WriteLine("4.Complaint_id to display no of days taken to close the complaint");
            Console.WriteLine("5.Complaints closed with explanation ");
            Console.WriteLine("6.Display complaints which recieved timely response:");

        }

        public static void Main(string[] args)
        {

            try
            {
                InitializeApp();

                PrintMenu();

                int choice = Convert.ToInt32(Console.ReadLine());

                UserQueryDataStructures userQuery = new UserQueryDataStructures();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter year:");
                        string year = Console.ReadLine();
                        userQuery.displayListOfComplaintsBasedOnYear(Complaints, year);
                        break;
                    case 2:
                        Console.WriteLine("Enter BankName:");
                        string bank_name = Console.ReadLine();
                        userQuery.displayListOfComplaintsBasedOnBank(Complaints, bank_name);
                        break;
                    case 3:
                        Console.WriteLine("Enter ComplaintId:");
                        string c_id = Console.ReadLine();
                        userQuery.displayComplaintById(Complaints, c_id);
                        break;
                    case 4:
                        Console.WriteLine("Enter ComplaintId:");
                        string cid = Console.ReadLine();
                        userQuery.displayNoOfDaysToCloseComplaintById(Complaints, cid);
                        break;
                    case 5:
                        userQuery.displayComplaintsClosedOrWithExplanation(Complaints);
                        break;
                    case 6:
                        userQuery.displayComplaintsTimelyResponse(Complaints);
                        break;


                }
                Console.WriteLine("EOP");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
