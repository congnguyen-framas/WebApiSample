using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApiSample.Models
{
    public class UserModel
    {
        public UserModel()
        {

        }

        public UserModel(DataRow row)
        {
            this.UserId = !string.IsNullOrEmpty(row["UserId"].ToString()) ? Convert.ToInt32(row["UserId"]) : 0;
            this.UserEmail = row["UserEmail"].ToString();
            this.UserPassword = row["UserPassword"].ToString();
            this.DepartmentId = !string.IsNullOrEmpty(row["UserDeft"].ToString()) ? Convert.ToInt32(row["UserDeft"]) : 0;
            this.Actived = !string.IsNullOrEmpty(row["Active"].ToString()) ? Convert.ToBoolean(row["Active"]) : false;
            this.CreatedDate = !string.IsNullOrEmpty(row["CreatedDate"].ToString()) ? Convert.ToDateTime(row["CreatedDate"]) : DateTime.Now;
            this.CreatedBy = !string.IsNullOrEmpty(row["CreatedBy"].ToString()) ? Convert.ToInt32(row["CreatedBy"]) : 0;
        }

        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public int DepartmentId { get; set; }
        public bool Actived { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}