
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.NewsManager
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
	public class NewsManager : NewsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NewsManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of NewsManager
		/// </summary>
		/// <returns>An instant of NewsManager class</returns>
		public static NewsManager CreateInstant()
		{
			return new NewsManager();
		}

        public string GetUniqueTextIdFromUnicodeText(string UnicodeText)
        {
            string strSql = "SELECT TextId FROM News WHERE TextId = @TextId";
            string textId = WebUtility.GetUniqueTextIdFromUnicodeText(UnicodeText, "@TextId", strSql
                , SqlHelper.ConnectionStringShopCake, NewsFields.TextId.MaxLength);
            return textId;
        }

        public NewsEntity GetNews(string TextId)
        {
            EntityCollection<NewsEntity> items = new EntityCollection<NewsEntity>();

            IPredicateExpression predicate = new PredicateExpression();
            predicate.Add(NewsFields.TextId == TextId);

            RelationPredicateBucket filter = new RelationPredicateBucket();
            filter.PredicateExpression.Add(predicate);

            using (DataAccessAdapterBase adapter = new DataAccessAdapterFactory().CreateAdapter())
            {
                adapter.FetchEntityCollection(items, filter);
            }

            if (items != null && items.Count > 0)
                return items[0];
            return null;
        }

        public DataTable GetNewsMenu()
        {
            string strSql = "Select * From News Where IsVisible = 1 and IsMenu = 1 Order By Subject";
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSql);
        }

        public DataTable GetNewsList()
        {
            string strSql = "Select * From News Where IsVisible = 1 and IsMenu = 0 Order By CreatedDate desc";
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSql);
        }
	}
}
