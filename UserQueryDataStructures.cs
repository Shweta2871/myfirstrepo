using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bank_Complaint_Queries
{
    class UserQueryDataStructures
    {

        public void displayListOfComplaintsBasedOnYear(List<Complaint> complaints, string year)
        {
            var dataset = (from cp in complaints where cp.DateSentToCompany.Substring(6) == year select cp);

            if (!dataset.Any())
            {
                throw new Exception("No records found");
            }
            Console.WriteLine($"Details of Complaints in year {year}");
            foreach (var cp in dataset)
            {
                Console.WriteLine(cp);
            }

        }

        public void displayListOfComplaintsBasedOnBank(List<Complaint> complaints, string BankName)
        {
            var dataset = (from cp in complaints where cp.Company == BankName select cp);

            if (!dataset.Any())
            {
                throw new Exception("No records found");
            }

            Console.WriteLine($"Details of Complaints made by Bank {BankName}");



            foreach (var cp in dataset)
            {
                Console.WriteLine(cp);
            }


        }

        public void displayComplaintById(List<Complaint> complaints, string c_id)
        {
            var dataset = (from cp in complaints where cp.ComplaintId == c_id select cp);
            if (!dataset.Any())
            {
                throw new Exception("No records found");
            }
            Console.WriteLine($"Details of Complaint with id:{c_id}");
            
            foreach(var cp in dataset)
            {
                Console.WriteLine(cp);
            }
        }

        public void displayNoOfDaysToCloseComplaintById(List<Complaint> complaints,string c_id)
        {
            var ds = (from cp in complaints where cp.ComplaintId == c_id select cp);

            if (!ds.Any())
            {
                throw new Exception("No records found");
            }
            Console.WriteLine($"No of days to close Complaint with id:{c_id}");
            foreach(var cp in ds)
            {
                string f_date = cp.Date_Received;
                string l_date = cp.DateSentToCompany;

                DateTime f_d, l_d;
                if (f_date.Contains("-"))
                {
                    f_d = DateTime.ParseExact(f_date, "dd-mm-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                }
                else
                {
                    f_d = DateTime.ParseExact(f_date, "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                }
                if (l_date.Contains("-"))
                {
                    l_d = DateTime.ParseExact(l_date, "dd-mm-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                }
                else
                {
                    l_d = DateTime.ParseExact(l_date, "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                }

                int days = (int)Math.Round((l_d - f_d).TotalDays);
                Console.WriteLine(days);
               
            }
        }

        public void displayComplaintsClosedOrWithExplanation(List<Complaint> complaints)
        {
            var ds = (from cp in complaints where (cp.CompanyResponseToConsumer == "Closed" || cp.CompanyResponseToConsumer == "Closed with explanation") select cp);

            if (!ds.Any())
            {
                throw new Exception("No record found");
            }

            Console.WriteLine("Details of Complaints which are closed or closed with explanation:");
            foreach(var c in ds)
            {
                Console.WriteLine(c);
            }
        }

        public void displayComplaintsTimelyResponse(List<Complaint> complaints)
        {
            var ds = (from cp in complaints where cp.IsResponseOnTime == true select cp);

            if (!ds.Any())
            {
                throw new Exception("No record found");
            }

            Console.WriteLine("Details of Complaints which received timely response:");

            foreach(var c in ds)
            {
                Console.WriteLine(c);
            }
        }


    }
}
