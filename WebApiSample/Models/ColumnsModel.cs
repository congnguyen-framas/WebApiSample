using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApiSample.Models
{
    public class ColumnsModel
    {
        public int ColumnId { get; set; }
        public string ColumnName { get; set; }
        public string ColumnDescription { get; set; }
        public int Departmentid { get; set; }
        public int StepUsing { get; set; }
        public bool Actived { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int ColumnType { get; set; }

        public ColumnsModel()
        {

        }

        public ColumnsModel(DataRow row)
        {
            this.ColumnId = !string.IsNullOrEmpty(row["ColumnId"].ToString()) ? Convert.ToInt32(row["ColumnId"]) : 0;
            this.ColumnName = !string.IsNullOrEmpty(row["ColumnIName"].ToString()) ? row["ColumnIName"].ToString() : null;
            this.ColumnDescription = !string.IsNullOrEmpty(row["ColumnDescription"].ToString()) ? row["ColumnDescription"].ToString() : null;
            this.Departmentid = !string.IsNullOrEmpty(row["DepartmentId"].ToString()) ? Convert.ToInt32(row["DepartmentId"]) : 0;
            this.StepUsing = !string.IsNullOrEmpty(row["StepUsing"].ToString()) ? Convert.ToInt32(row["StepUsing"]) : 0;
            this.Actived = !string.IsNullOrEmpty(row["Actived"].ToString()) ? Convert.ToBoolean(row["Actived"]) : false;
            this.CreatedDate = !string.IsNullOrEmpty(row["CreatedDate"].ToString()) ? Convert.ToDateTime(row["CreatedDate"]) : DateTime.Now;
            this.CreatedBy = !string.IsNullOrEmpty(row["CreatedBy"].ToString()) ? Convert.ToInt32(row["CreatedBy"]) : 0;
            this.ColumnType = !string.IsNullOrEmpty(row["ColumnType"].ToString()) ? Convert.ToInt32(row["ColumnType"]) : 0;
        }
    }
}