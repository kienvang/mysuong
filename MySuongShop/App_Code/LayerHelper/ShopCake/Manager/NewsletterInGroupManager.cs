
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.NewsletterInGroupManager
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
	public class NewsletterInGroupManager : NewsletterInGroupManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NewsletterInGroupManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of NewsletterInGroupManager
		/// </summary>
		/// <returns>An instant of NewsletterInGroupManager class</returns>
		public static NewsletterInGroupManager CreateInstant()
		{
			return new NewsletterInGroupManager();
		}

        public void DeleteGroup(Guid newsletterId, Guid groupId)
        {
            string strSQL = "Delete From NewsletterInGroup Where NewsletterId = @newsletterId and GroupId = @groupId";
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@newsletterId", newsletterId);
            param[1] = new SqlParameter("@groupId", groupId);
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, param);
        }
	}
}
