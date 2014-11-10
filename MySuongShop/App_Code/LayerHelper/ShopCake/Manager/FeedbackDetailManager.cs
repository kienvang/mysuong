
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.FeedbackDetailManager
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
	public class FeedbackDetailManager : FeedbackDetailManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public FeedbackDetailManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of FeedbackDetailManager
		/// </summary>
		/// <returns>An instant of FeedbackDetailManager class</returns>
		public static FeedbackDetailManager CreateInstant()
		{
			return new FeedbackDetailManager();
		}

        public DataTable GetAll(Guid feedbackid)
        {
            string strSQL = "Select * From FeedbackDetail Where FeedbackId = @id Order By CreatedDate desc";
            SqlParameter param = new SqlParameter("@Id", feedbackid);
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, param);
        }

	}
}
