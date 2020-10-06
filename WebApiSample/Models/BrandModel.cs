using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApiSample.Models
{
    public class BrandModel
    {
        public BrandModel()
        {

        }
        public BrandModel(DataRow row)
        {
            this.BrandId = !string.IsNullOrEmpty(row["BrandId"].ToString()) ? Convert.ToInt32(row["BrandId"]) : 0;
            this.BrandName = row["BrandName"].ToString();
            this.Actived = !string.IsNullOrEmpty(row["Actived"].ToString()) ? Convert.ToBoolean(row["Actived"]) : false;
            this.CreatedDate = !string.IsNullOrEmpty(row["CreatedDate"].ToString()) ? Convert.ToDateTime(row["CreatedDate"]) : DateTime.Now;
            this.CreatedBy = !string.IsNullOrEmpty(row["CreatedBy"].ToString()) ? Convert.ToInt32(row["CreatedBy"]) : 0;
        }

        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public bool Actived { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}