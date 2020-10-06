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
    public class DbBrand
    {
        #region singleton
        private static DbBrand _instance;
        public static DbBrand Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DbBrand();
                }
                return _instance;
            }
            set => _instance = value;
        }
        public DbBrand()
        {

        }
        #endregion

        //get MaterialCode and MaterialName
        public DataTable GetAllTable()
        {
            return DataProvider.Instance.ExecuteQuery("sp_Brand_GetAll");
        }

        public BrandModel GetId(int brandId)
        {
            BrandModel result;
            DataTable _data = DataProvider.Instance.ExecuteQuery("sp_Brand_GetById @BrandId", new object[] { brandId });

            if (_data != null && _data.Rows.Count > 0)
            {
                result = new BrandModel(_data.Rows[0]);
            }
            else
            {
                result = null;
            }
            return result;
        }

        public List<BrandModel> GetAllList()
        {
            List<BrandModel> result = new List<BrandModel>();

            DataTable data = DataProvider.Instance.ExecuteQuery("sp_Brand_GetAll");

            foreach (DataRow item in data.Rows)
            {
                result.Add(new BrandModel(item));
            }

            return result;
        }

        public int InsertDb(BrandModel data)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("sp_Brand_Insert @brandName , @createdBy", new object[] { data.BrandName, data.CreatedBy });

            return result;
        }

        public int UpdateDb(BrandModel data)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("sp_Brand_Update @brandId , @BrandName , @Actived , @CreatedBy"
                , new object[] { data.BrandId, data.BrandName, data.Actived, data.CreatedBy });

            return result;
        }

        public int TransactionQuery(List<SqlTransactionQueryList> listQuery)
        {
            return DataProvider.Instance.ExecuteSqlTransaction(listQuery);
        }

        /// <summary>
        /// Get maxId Table.
        /// </summary>
        /// <returns>Return = 0 --> eror or empty. Return > 0 --> OK.</returns>
        public int GetMaxId()
        {
            int result = 0;

            DataTable _data = DataProvider.Instance.ExecuteQuery("sp_Common_GetMaxIdTable @tableName", new object[] { "tblBrand" });

            if (_data != null && _data.Rows.Count > 0)
            {
                result = Convert.ToInt32(_data.Rows[0][0]);
            }
            
            return result;
            //return DataProvider.Instance.ExecuteNonQuery_GetIdIdentity("sp_Brand_GetMaxId");
        }
    }
}
