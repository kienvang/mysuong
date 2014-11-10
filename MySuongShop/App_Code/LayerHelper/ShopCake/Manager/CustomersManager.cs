
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.CustomersManager
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
using System.Text;
using System.Collections;

namespace LayerHelper.ShopCake.BLL
{
	public class CustomersManager : CustomersManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CustomersManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of CustomersManager
		/// </summary>
		/// <returns>An instant of CustomersManager class</returns>
		public static CustomersManager CreateInstant()
		{
			return new CustomersManager();
		}

        public CustomersEntity GetByName(string CustomerName)
        {
            EntityCollection<CustomersEntity> cus = new EntityCollection<CustomersEntity>();

            IPredicateExpression predicate = new PredicateExpression();
            predicate.Add(CustomersFields.UserName == CustomerName);
            //predicate.AddWithAnd(CustomersFields.Telphone == "");

            RelationPredicateBucket filter = new RelationPredicateBucket();
            filter.PredicateExpression.Add(predicate);

            SortExpression sort = new SortExpression();
            sort.Add(CustomersFields.UserName | SortOperator.Ascending);

            using (DataAccessAdapterBase adapter = new DataAccessAdapterFactory().CreateAdapter())
            {
                adapter.FetchEntityCollection(cus, filter, 0, sort);
            }

            if (cus != null && cus.Count > 0)
                return cus[0];
            return null;
        }

        public DataTable GetAll()
        {
            string strSQL = "Select * From Customers";
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL);
        }

        public DataTable GetCustomerInGroup(Guid groupId)
        {
            string strSQL = "Select c.*, (Select IsNull(Sum(TotalPaid),0) from Orders Where CustomerId = c.Id) as Total " +
                            "From Customers c INNER JOIN CustomerInGroup g ON c.Id=g.customerId " +
                            "Where g.GroupId = @id Order By c.FullName";
            SqlParameter param = new SqlParameter("@id", groupId);
            return SqlHelper.ExecuteDataTable(CommandType.Text, strSQL, param);
        }

        public DataTable GetCustomerSearchGroup(Guid groupId, string fullName, string email, string total_from, string total_to)
        {
            string strSQL = @"Select *
                              From (Select c1.Id, IsNull(SUM(totalpaid), 0) as Total
	                                From Customers c1 LEFT JOIN Orders o ON c1.Id = o.CustomerId
	                                group by c1.Id) as c0 INNER JOIN Customers c ON c.Id = c0.Id
                              Where c.Id NOT IN (Select CustomerId From CustomerInGroup Where GroupId = @id) {0}
                              Order By c.FullName";
            Hashtable paramss = new Hashtable();
            paramss["id"] = groupId;

            string strWhere = "";
            if (fullName != string.Empty)
            {
                strWhere += " and c.FullName LIKE @FullName ";
                paramss["FullName"] = "%" + fullName + "%";
            }

            if (email != string.Empty)
            {
                strWhere += " and c.Email = @Email ";
                paramss["Email"] = email;
            }

            if (total_from != string.Empty || total_to != string.Empty)
            {
                double totalFrom = 0;
                double totalTo = double.MaxValue;

                if (total_from != string.Empty)
                    totalFrom = FNumber.ConvertDouble(total_from);

                if (total_to != string.Empty)
                    totalTo = FNumber.ConvertDouble(total_to);

                strWhere += " and c0.Total >= @TotalFrom and c0.Total <= @TotalTo ";
                paramss["TotalFrom"] = totalFrom;
                paramss["TotalTo"] = totalTo;
            }

            strSQL = string.Format(strSQL, strWhere);

            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, paramss, CommandType.Text, strSQL);
        }
	}
}
