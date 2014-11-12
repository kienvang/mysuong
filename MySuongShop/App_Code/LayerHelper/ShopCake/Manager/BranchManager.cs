
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.BranchManager
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

namespace LayerHelper.ShopCake.BLL
{
	public class BranchManager : BranchManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public BranchManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of BranchManager
		/// </summary>
		/// <returns>An instant of BranchManager class</returns>
		public static BranchManager CreateInstant()
		{
			return new BranchManager();
		}

        public DataTable GetAll()
        {
            string strSQL = "Select * From Branch";
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringShopCake, CommandType.Text, strSQL);
        }

        public string GetName(Guid id)
        {
            BranchEntity data = SelectOne(id);
            if (data != null)
                return data.Name;
            return "";
        }
	}
}
