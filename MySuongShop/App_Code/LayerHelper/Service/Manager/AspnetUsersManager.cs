
/*
'===============================================================================
'  LayerHelper.Service.BL.AspnetUsersManager
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LayerHelper.Service.BLL;
using LayerHelper.Service.DAL;
using LayerHelper.Service.DAL.EntityClasses;
using LayerHelper.Service.DAL.FactoryClasses;
using LayerHelper.Service.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using Library.Tools;
namespace LayerHelper.Service.BLL
{
	public class AspnetUsersManager : AspnetUsersManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AspnetUsersManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of AspnetUsersManager
		/// </summary>
		/// <returns>An instant of AspnetUsersManager class</returns>
		public static AspnetUsersManager CreateInstant()
		{
			return new AspnetUsersManager();
		}

        public DataTable GetAll()
        {
            string strSQL = "Select u.* From aspnet_Users u INNER JOIN aspnet_Membership m ON u.UserId = m.UserId";
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringService, CommandType.Text, strSQL);
        }

        
	}
}
