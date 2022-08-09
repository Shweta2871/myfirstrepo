using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
namespace Bank_Complaint_Queries
{
    class ComplaintCsvReader
    {
        public List<Complaint> GetComplaints()
        {
            string path = @"C:\Users\SHWETA\Desktop\Complaints_Project-main\complaints.csv";

            List<Complaint> complaints = new List<Complaint>();
            using (TextFieldParser parser = new TextFieldParser(path))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    Complaint c = new Complaint();
                    c.Date_Received = fields[0];
                    c.Product = fields[1];
                    c.SubProduct = fields[2];
                    c.Issue = fields[3];
                    c.SubIssue = fields[4];
                    c.Company = fields[5];
                    c.State = fields[6];
                    c.ZipCode = fields[7];
                    c.MethodOfSubmission = fields[8];
                    c.DateSentToCompany = fields[9];
                    c.CompanyResponseToConsumer = fields[10];
                    c.IsResponseOnTime = fields[11] == "Yes" ? true : false;
                    c.IsConsumerDisputed = fields[12] == "Yes" ? true : false;
                    c.ComplaintId = fields[13];
                    complaints.Add(c);
                }
                Console.WriteLine("NewLine");
            }
            return complaints;
        }
    }
}
