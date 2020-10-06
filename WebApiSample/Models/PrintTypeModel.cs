using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApiSample.Models
{
    public class PrintTypeModel
    {
        public int PrintTypeId { get; set; }
        public string PrintTypeName { get; set; }
        public bool Actived { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        public PrintTypeModel()
        {

        }

        public PrintTypeModel(DataRow row)
        {
            this.PrintTypeId = !string.IsNullOrEmpty(row["PrintTypeId"].ToString()) ? Convert.ToInt32(row["PrintTypeId"]) : 0;
            this.PrintTypeName = row["PrintTypeName"].ToString();
            this.Actived = !string.IsNullOrEmpty(row["Actived"].ToString()) ? Convert.ToBoolean(row["Actived"]) : false;
            this.CreatedDate = !string.IsNullOrEmpty(row["CreatedDate"].ToString()) ? Convert.ToDateTime(row["CreatedDate"]) : DateTime.Now;
            this.CreatedBy = !string.IsNullOrEmpty(row["CreatedBy"].ToString()) ? Convert.ToInt32(row["CreatedBy"]) : 0;
        }
    }
}