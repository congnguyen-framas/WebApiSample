using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApiSample.Models
{
    public class OrderDetailModel
    {
        public int OrderDetailId { get; set; }
        public int ColumnId { get; set; }
        public int OrderId { get; set; }
        /// <summary>
        /// TimeLead Id
        /// </summary>
        public int TlId { get; set; }
        public int BrandId { get; set; }
        public string DetailValue { get; set; }
        public bool Actived { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        public OrderDetailModel()
        {

        }

        public OrderDetailModel(DataRow row)
        {
            this.OrderDetailId = !string.IsNullOrEmpty(row["OrderDetailId"].ToString()) ? Convert.ToInt32(row["OrderDetailId"]) : 0;
            this.ColumnId = !string.IsNullOrEmpty(row["ColumnId"].ToString()) ? Convert.ToInt32(row["ColumnId"]) : 0;
            this.OrderId = !string.IsNullOrEmpty(row["OrderId"].ToString()) ? Convert.ToInt32(row["OrderId"]) : 0;
            this.DetailValue = !string.IsNullOrEmpty(row["DetailValue"].ToString()) ? row["DetailValue"].ToString() : null;
            this.Actived = !string.IsNullOrEmpty(row["Actived"].ToString()) ? Convert.ToBoolean(row["Actived"]) : false;
            this.CreatedDate = !string.IsNullOrEmpty(row["CreatedDate"].ToString()) ? Convert.ToDateTime(row["CreatedDate"]) : DateTime.Now;
            this.CreatedBy = !string.IsNullOrEmpty(row["CreatedBy"].ToString()) ? Convert.ToInt32(row["CreatedBy"]) : 0;
        }
    }
}