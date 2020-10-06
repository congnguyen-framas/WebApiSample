using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApiSample.Models
{
    public class UserPermissionModel
    {
        public int UserPermissionId { get; set; }
        public int UserId { get; set; }
        public int ColumnId { get; set; }
        public int Permission { get; set; }
        public bool Actived { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        public UserPermissionModel()
        {

        }

        public UserPermissionModel(DataRow row)
        {
            this.UserPermissionId = !string.IsNullOrEmpty(row["UserPermissionId"].ToString()) ? Convert.ToInt32(row["UserPermissionId"]) : 0;
            this.UserId = !string.IsNullOrEmpty(row["UserId"].ToString()) ? Convert.ToInt32(row["UserId"]) : 0;
            this.ColumnId = !string.IsNullOrEmpty(row["ColumnId"].ToString()) ? Convert.ToInt32(row["ColumnId"]) : 0;
            this.Permission = !string.IsNullOrEmpty(row["Permission"].ToString()) ? Convert.ToInt32(row["Permission"]) : 0;
            this.Actived = !string.IsNullOrEmpty(row["Actived"].ToString()) ? Convert.ToBoolean(row["Actived"]) : false;
            this.CreatedDate = !string.IsNullOrEmpty(row["CreatedDate"].ToString()) ? Convert.ToDateTime(row["CreatedDate"]) : DateTime.Now;
            this.CreatedBy = !string.IsNullOrEmpty(row["CreatedBy"].ToString()) ? Convert.ToInt32(row["CreatedBy"]) : 0;
        }
    }
}