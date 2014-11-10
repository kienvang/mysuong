
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.NewsletterManager
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
using System.Collections;

namespace LayerHelper.ShopCake.BLL
{
	public class NewsletterManager : NewsletterManagerBase
	{
        public const string NEW = "NEW";
        public const string PENDING = "PENDING";
        public const string COMPLETE = "COMPLETE";

		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NewsletterManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of NewsletterManager
		/// </summary>
		/// <returns>An instant of NewsletterManager class</returns>
		public static NewsletterManager CreateInstant()
		{
			return new NewsletterManager();
		}

        public DataTable GetAll()
        {
            string strSQL = "Select * From Newsletter";
            return SqlHelper.ExecuteDataTable(CommandType.Text, strSQL);
        }

        public DataTable GetInProuct(Guid newsletterId)
        {
            string strSQL = "Select p.*,c.Id as CatId, c.TextId as CatTextId " +
                            "From (Products p INNER JOIN NewsletterInProduct n ON p.id = n.ProductId) INNER JOIN Catalogs c ON p.CatalogId=c.Id " +
                            "Where n.NewsletterId = @Id and p.IsDelete = 0";
            SqlParameter param = new SqlParameter("@Id", newsletterId);
            return SqlHelper.ExecuteDataTable(CommandType.Text, strSQL, param);
        }

        public DataTable GetProductSearch(Guid newsletterId, string productName, string catName, string price_from, string price_to)
        {
            string strSQL = "Select p.*, c.CatalogName as CatName " +
                            "From Products p INNER JOIN Catalogs c ON p.CatalogId=c.Id " +
                            "Where p.IsDelete = 0 and p.Id NOT IN (Select ProductId From NewsletterInProduct Where NewsletterId = @id) {0} " +
                            "Order By p.ProductName ";

            Hashtable paramss = new Hashtable();
            paramss["id"] = newsletterId;

            string strWhere = "";
            if (productName != string.Empty)
            {
                strWhere += " and p.ProductName LIKE @ProductName ";
                paramss["ProductName"] = "%" + productName + "%";
            }

            if (productName != string.Empty)
            {
                strWhere += " and c.CatalogName LIKE @CatalogName ";
                paramss["CatalogName"] = "%" + catName + "%";
            }

            if (price_from != string.Empty || price_to != string.Empty)
            {
                double priceFrom = 0;
                double priceTo = double.MaxValue;

                if (price_from != string.Empty)
                    priceFrom = FNumber.ConvertDouble(price_from);

                if (price_to != string.Empty)
                    priceTo = FNumber.ConvertDouble(price_to);

                strWhere += " and p.Price >= @PriceFrom and p.Price <= @PriceTo ";
                paramss["PriceFrom"] = priceFrom;
                paramss["PriceTo"] = priceTo;
            }

            strSQL = string.Format(strSQL, strWhere);

            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, paramss, CommandType.Text, strSQL);
        }

        public void DeleteGroup(Guid newsletterId, Guid productId)
        {
            string strSQL = "Delete From NewsletterInProduct Where NewsletterId = @NewsletterId and ProductId = @ProductId";
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@NewsletterId", newsletterId);
            param[1] = new SqlParameter("@ProductId", productId);
            SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL, param);
        }
	}
}
