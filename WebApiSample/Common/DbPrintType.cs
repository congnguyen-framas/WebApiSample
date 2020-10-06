using WebApiSample.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.Enums;
using TableDependency.SqlClient.Base.EventArgs;
using WpfClientTest.Common;

namespace WebApiSample.Common
{
    public class DbPrintType
    {
        #region singleton
        private static DbPrintType _instance;
        public static DbPrintType Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DbPrintType();
                }
                return _instance;
            }
            set => _instance = value;
        }
        public DbPrintType()
        {

        }
        #endregion

        //get MaterialCode and MaterialName
        public DataTable GetAllTable()
        {
            return DataProvider.Instance.ExecuteQuery("sp_PrintType_GetAll");
        }

        public PrintTypeModel GetId(int id)
        {
            PrintTypeModel result;
            DataTable _data = DataProvider.Instance.ExecuteQuery("sp_PrintType_GetById @brandId", new object[] { id });

            if (_data != null && _data.Rows.Count > 0)
            {
                result = new PrintTypeModel(_data.Rows[0]);
            }
            else
            {
                result = null;
            }
            return result;
        }

        public List<PrintTypeModel> GetAllList()
        {
            List<PrintTypeModel> result = new List<PrintTypeModel>();

            DataTable data = DataProvider.Instance.ExecuteQuery("sp_PrintType_GetAll");

            foreach (DataRow item in data.Rows)
            {
                result.Add(new PrintTypeModel(item));
            }

            return result;
        }

        public int InsertDb(PrintTypeModel data)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("sp_PrintType_Insert @PrinteTypeName , @CreatedBy", new object[] { data.PrintTypeName, data.CreatedBy });

            return result;
        }

        public int UpdateDb(PrintTypeModel data)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("sp_PrintType_Update @PrintTypeId , @PrintTypeName , @Actived , @CreatedBy", new object[] { data.PrintTypeId, data.PrintTypeName, data.Actived, data.CreatedBy });

            return result;
        }

        public int TransactionQuery(List<SqlTransactionQueryList> listQuery)
        {
            return DataProvider.Instance.ExecuteSqlTransaction(listQuery);
        }

        public int GetMaxId()
        {
            int result = 0;

            DataTable _data = DataProvider.Instance.ExecuteQuery("sp_Common_GetMaxIdTable @tableName", new object[] { "tblPrintType" });

            if (_data != null && _data.Rows.Count > 0)
            {
                result = Convert.ToInt32(_data.Rows[0][0]);
            }

            return result;
        }
    }
}
