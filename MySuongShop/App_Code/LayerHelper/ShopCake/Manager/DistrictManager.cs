
/*
'===============================================================================
'  LayerHelper.ShopCake.BL.DistrictManager
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
	public class DistrictManager : DistrictManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DistrictManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of DistrictManager
		/// </summary>
		/// <returns>An instant of DistrictManager class</returns>
		public static DistrictManager CreateInstant()
		{
			return new DistrictManager();
		}

        public DataTable GetAll()
        {
            string strSQL = "select * from district order by sortorder,name";
            return SqlHelper.ExecuteDataTable(CommandType.Text, strSQL);
        }
	}
}
