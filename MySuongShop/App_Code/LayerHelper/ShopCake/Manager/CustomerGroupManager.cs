
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.CustomerGroupManager
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL;
using LayerHelper.ShopCake.DAL.EntityClasses;
using LayerHelper.ShopCake.DAL.FactoryClasses;
using LayerHelper.ShopCake.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using Library.Tools;

namespace LayerHelper.ShopCake.BLL
{
	public class CustomerGroupManager : CustomerGroupManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CustomerGroupManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of CustomerGroupManager
		/// </summary>
		/// <returns>An instant of CustomerGroupManager class</returns>
		public static CustomerGroupManager CreateInstant()
		{
			return new CustomerGroupManager();
		}

        public DataTable GetAll()
        {
            string strSQL = "Select *, IsNull((Select count(*) From CustomerInGroup Where g.Id = GroupId),0) total " +
                            "From CustomerGroup g " +
                            "Order By Name";
            return SqlHelper.ExecuteDataTable(CommandType.Text, strSQL);
        }

        public DataTable GetInNewsletter(Guid newsletterId)
        {
            string strSQL = @"Select g.*, (case when ng.id is null then 0 else 1 end) as Selected
                              From CustomerGroup g LEFT JOIN NewsletterInGroup ng ON g.Id = ng.GroupId and ng.NewsletterId = @id";
            SqlParameter param = new SqlParameter("@id", newsletterId);
            return SqlHelper.ExecuteDataTable(CommandType.Text, strSQL, param);
        }

        public bool CheckDelete(Guid id)
        {
            string strSQL = "Select *" +
                            "From CustomerInGroup g " +
                            "Where GroupId = @Id";
            SqlParameter param = new SqlParameter("@Id", id);
            DataTable tbl = SqlHelper.ExecuteDataTable(CommandType.Text, strSQL, param);
            if (tbl != null && tbl.Rows.Count > 0)
                return false;
            return true;
        }
	}
}
