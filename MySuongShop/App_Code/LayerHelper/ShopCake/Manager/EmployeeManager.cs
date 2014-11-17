
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.EmployeeManager
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
using Library.Tools;
using SD.LLBLGen.Pro.ORMSupportClasses;

using LayerHelper.Service.BLL;
using LayerHelper.Service.DAL.EntityClasses;
namespace LayerHelper.ShopCake.BLL
{
	public class EmployeeManager : EmployeeManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public EmployeeManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of EmployeeManager
		/// </summary>
		/// <returns>An instant of EmployeeManager class</returns>
		public static EmployeeManager CreateInstant()
		{
			return new EmployeeManager();
		}

        public DataTable GetAll()
        {
            string strSQL = "Select * From Employee";
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL);
        }

        public string getName(Guid Id)
        {
            EmployeeEntity data = SelectOne(Id);
            if (data != null)
            {
                return data.Name;
            }
            LayerHelper.Service.DAL.HelperClasses.EntityCollection<AspnetUsersEntity> u = AspnetUsersManager.CreateInstant().SelectByUserIdLST(Id);
            if (u != null && u.Items.Count > 0)
            {
                return u[0].UserName;
            }
            return "";
        }
	}
}
