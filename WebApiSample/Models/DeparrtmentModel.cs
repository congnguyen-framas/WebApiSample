using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApiSample.Models
{
    public class DeparrtmentModel
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public bool Actived { get; set; }

        public DeparrtmentModel()
        {

        }

        public DeparrtmentModel(DataRow row)
        {
            this.DepartmentId = !string.IsNullOrEmpty(row["DepartmentId"].ToString()) ? Convert.ToInt32(row["DepartmentId"]) : 0;
            this.DepartmentName = row["DepartmentName"].ToString();
            this.Actived = !string.IsNullOrEmpty(row["Actived"].ToString()) ? Convert.ToBoolean(row["Actived"]) : false;
        }
    }
}