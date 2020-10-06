using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApiSample.Models
{
    public class UserLogModel
    {
        public int LogId { get; set; }
        public DateTime LoggedDate { get; set; }
        public int UserId { get; set; }
        public string ComputerName { get; set; }
        public int ColumnId { get; set; }
        public string LoggedInfo { get; set; }

        public UserLogModel()
        {

        }

        public UserLogModel(DataRow row)
        {
            this.LogId = !string.IsNullOrEmpty(row["LogId"].ToString()) ? Convert.ToInt32(row["LogId"]) : 0;
            this.LoggedDate = !string.IsNullOrEmpty(row["LoggedDate"].ToString()) ? Convert.ToDateTime(row["LoggedDate"]) : DateTime.Now;
            this.UserId = !string.IsNullOrEmpty(row["UserId"].ToString()) ? Convert.ToInt32(row["UserId"]) : 0;
            this.ComputerName = row["ComputerName"].ToString();
            this.ColumnId = !string.IsNullOrEmpty(row["ColumnId"].ToString()) ? Convert.ToInt32(row["ColumnId"]) : 0;
            this.LoggedInfo = row["LoggedInfo"].ToString();
        }
    }
}