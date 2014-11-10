
/*
'===============================================================================
'  LayerHelper.Service.BL.AspnetMembershipManager
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
	public class AspnetMembershipManager : AspnetMembershipManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AspnetMembershipManager()
		{
			// Nothing for now.
		}
		
		/// <summary>
		/// Method to create an instance of AspnetMembershipManager
		/// </summary>
		/// <returns>An instant of AspnetMembershipManager class</returns>
		public static AspnetMembershipManager CreateInstant()
		{
			return new AspnetMembershipManager();
		}

        public DataTable GetAll()
        {
            string strSQL = "Select u.UserName, m.* From aspnet_Users u INNER JOIN aspnet_Membership m ON u.UserId = m.UserId";
            return SqlHelper.ExecuteDataTable(SqlHelper.ConnectionStringService, CommandType.Text, strSQL);
        }
	}
}
