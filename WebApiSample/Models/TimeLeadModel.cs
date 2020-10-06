using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApiSample.Models
{
    public class TimeLeadModel
    {
        public int TLId { get; set; }
        public int BrandId { get; set; }
        public int PrintTypeId { get; set; }
        public double OrderReceived { get; set; }
        public double Admin { get; set; }
        public double Injection { get; set; }
        public double Printing { get; set; }
        public double LabTesting { get; set; }
        public double Shipping { get; set; }
        public double StandardLT { get; set; }
        public bool Actived { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        public TimeLeadModel()
        {

        }

        public TimeLeadModel(DataRow row)
        {
            this.TLId = !string.IsNullOrEmpty(row["LTId"].ToString()) ? Convert.ToInt32(row["LTId"]) : 0;
            this.BrandId = !string.IsNullOrEmpty(row["BrandId"].ToString()) ? Convert.ToInt32(row["BrandId"]) : 0;
            this.PrintTypeId = !string.IsNullOrEmpty(row["PrintTypeId"].ToString()) ? Convert.ToInt32(row["PrintTypeId"]) : 0;

            this.OrderReceived = !string.IsNullOrEmpty(row["PrintTypeId"].ToString()) ? Convert.ToDouble(row["PrintTypeId"]) : 0;
            this.Admin = !string.IsNullOrEmpty(row["Admin"].ToString()) ? Convert.ToDouble(row["Admin"]) : 0;
            this.Injection = !string.IsNullOrEmpty(row["Injection"].ToString()) ? Convert.ToDouble(row["Injection"]) : 0;
            this.Printing = !string.IsNullOrEmpty(row["Printing"].ToString()) ? Convert.ToDouble(row["Printing"]) : 0;
            this.LabTesting = !string.IsNullOrEmpty(row["LabTesting"].ToString()) ? Convert.ToDouble(row["LabTesting"]) : 0;
            this.Shipping = !string.IsNullOrEmpty(row["Shipping"].ToString()) ? Convert.ToDouble(row["Shipping"]) : 0;
            this.StandardLT = !string.IsNullOrEmpty(row["StandardLT"].ToString()) ? Convert.ToDouble(row["StandardLT"]) : 0;

            this.Actived = !string.IsNullOrEmpty(row["Actived"].ToString()) ? Convert.ToBoolean(row["Actived"]) : false;
            this.CreatedDate = !string.IsNullOrEmpty(row["CreatedDate"].ToString()) ? Convert.ToDateTime(row["CreatedDate"]) : DateTime.Now;
            this.CreatedBy = !string.IsNullOrEmpty(row["CreatedBy"].ToString()) ? Convert.ToInt32(row["CreatedBy"]) : 0;
        }
    }
}