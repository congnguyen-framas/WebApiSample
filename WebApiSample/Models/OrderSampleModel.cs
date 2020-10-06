using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApiSample.Models
{
    public class OrderSampleModel
    {
        public int OrderSampleId { get; set; }
        public int TlId { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RTD { get; set; }
        public string PoNum { get; set; }
        public string OcNum { get; set; }
        public string Season { get; set; }
        public string DevStage { get; set; }
        public string ItemName { get; set; }
        public string ArtNumber { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int OrderQty { get; set; }
        public string PrintType { get; set; }
        public int ParentOrder { get; set; }
        public bool Actived { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        public OrderSampleModel()
        {

        }

        public OrderSampleModel(DataRow row) 
        {
            this.OrderSampleId = !string.IsNullOrEmpty(row["OrderId"].ToString()) ? Convert.ToInt32(row["OrderId"]) : 0;
            this.TlId = !string.IsNullOrEmpty(row["OrderId"].ToString()) ? Convert.ToInt32(row["OrderId"]) : 0;
            this.BrandId = !string.IsNullOrEmpty(row["OrderId"].ToString()) ? Convert.ToInt32(row["OrderId"]) : 0;
            this.BrandName = !string.IsNullOrEmpty(row["OrderId"].ToString()) ? row["OrderId"].ToString() : null;
            this.CustomerName = !string.IsNullOrEmpty(row["OrderId"].ToString()) ? row["OrderId"].ToString() : null;
            this.OrderDate = !string.IsNullOrEmpty(row["OrderId"].ToString()) ? Convert.ToDateTime(row["OrderId"]) : DateTime.Now;
            this.RTD = !string.IsNullOrEmpty(row["OrderId"].ToString()) ? Convert.ToDateTime(row["OrderId"]) : DateTime.Now;
            this.PoNum = !string.IsNullOrEmpty(row["OrderId"].ToString()) ? row["OrderId"].ToString() : null;
            this.OcNum = !string.IsNullOrEmpty(row["OrderId"].ToString()) ? row["OrderId"].ToString() : null;
            this.Season = !string.IsNullOrEmpty(row["OrderId"].ToString()) ? row["OrderId"].ToString() : null;
            this.DevStage = !string.IsNullOrEmpty(row["OrderId"].ToString()) ? row["OrderId"].ToString() : null;
            this.ItemName = !string.IsNullOrEmpty(row["OrderId"].ToString()) ? row["OrderId"].ToString() : null;
            this.ArtNumber = !string.IsNullOrEmpty(row["OrderId"].ToString()) ? row["OrderId"].ToString() : null;
            this.Color = !string.IsNullOrEmpty(row["OrderId"].ToString()) ? row["OrderId"].ToString() : null;
            this.Size = !string.IsNullOrEmpty(row["OrderId"].ToString()) ? row["OrderId"].ToString() : null;
            this.OrderQty = !string.IsNullOrEmpty(row["OrderId"].ToString()) ? Convert.ToInt32(row["OrderId"]) : 0;
            this.PrintType = !string.IsNullOrEmpty(row["OrderId"].ToString()) ? row["OrderId"].ToString() : null;
            this.ParentOrder = !string.IsNullOrEmpty(row["OrderId"].ToString()) ? Convert.ToInt32(row["OrderId"]) : 0;
            this.Actived = !string.IsNullOrEmpty(row["OrderId"].ToString()) ? Convert.ToBoolean(row["OrderId"]) : false;
            this.CreatedDate = !string.IsNullOrEmpty(row["OrderId"].ToString()) ? Convert.ToDateTime(row["OrderId"]) : DateTime.Now;
            this.CreatedBy = !string.IsNullOrEmpty(row["OrderId"].ToString()) ? Convert.ToInt32(row["OrderId"]) : 0;
        }
    }
}