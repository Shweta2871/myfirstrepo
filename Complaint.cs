using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Complaint_Queries
{
    class Complaint
    {
        public string Date_Received { get; set; }
        public string Product { get; set; }

        public string SubProduct { get; set; }

        public string Issue { get; set; }
        public string SubIssue { get; set; }

        public string Company { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }
        public string MethodOfSubmission { get; set; }

        public string DateSentToCompany { get; set; }
        public string CompanyResponseToConsumer { get; set; }

        public bool IsResponseOnTime { get; set; }

        public bool IsConsumerDisputed { get; set; }

        public string ComplaintId { get; set; }

        public override string ToString()
        {
            string r = $" {Date_Received} :: {Product} :: {SubProduct} :: {Issue} :: {SubIssue} :: {Company} :: {State} :: {ZipCode} :: {MethodOfSubmission} :: {DateSentToCompany} :: {CompanyResponseToConsumer} :: IsResponseOnTime: {IsResponseOnTime} :: IsConsumerDisputed:{IsConsumerDisputed} :: {ComplaintId}";
            return r;
        }

    }
}
