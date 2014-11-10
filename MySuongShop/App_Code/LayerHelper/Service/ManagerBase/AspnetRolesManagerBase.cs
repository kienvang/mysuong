




/*
'===============================================================================
'  LayerHelper.Service.BL.AspnetRolesManagerBase
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

namespace LayerHelper.Service.BLL
{
	public class AspnetRolesManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AspnetRolesManagerBase()
		{
			// Nothing for now.
		}
		
		public AspnetRolesEntity Insert(AspnetRolesEntity _AspnetRolesEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_AspnetRolesEntity, true);
			}
			return _AspnetRolesEntity;
		}

		
		public AspnetRolesEntity Insert(Guid ApplicationId, Guid RoleId, string RoleName, string LoweredRoleName, string Description)
		{
			AspnetRolesEntity _AspnetRolesEntity = new AspnetRolesEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AspnetRolesEntity.ApplicationId = ApplicationId;
				_AspnetRolesEntity.RoleId = RoleId;
				_AspnetRolesEntity.RoleName = RoleName;
				_AspnetRolesEntity.LoweredRoleName = LoweredRoleName;
				_AspnetRolesEntity.Description = Description;
				adapter.SaveEntity(_AspnetRolesEntity, true);
			}
			return _AspnetRolesEntity;
		}

		public AspnetRolesEntity Insert(Guid ApplicationId, string RoleName, string LoweredRoleName, string Description)
		{
			AspnetRolesEntity _AspnetRolesEntity = new AspnetRolesEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AspnetRolesEntity.ApplicationId = ApplicationId;
				_AspnetRolesEntity.RoleName = RoleName;
				_AspnetRolesEntity.LoweredRoleName = LoweredRoleName;
				_AspnetRolesEntity.Description = Description;
				adapter.SaveEntity(_AspnetRolesEntity, true);
			}
			return _AspnetRolesEntity;
		}

		public bool Update(AspnetRolesEntity _AspnetRolesEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(AspnetRolesFields.RoleId == _AspnetRolesEntity.RoleId);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_AspnetRolesEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(AspnetRolesEntity _AspnetRolesEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_AspnetRolesEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid ApplicationId, Guid RoleId, string RoleName, string LoweredRoleName, string Description)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetRolesEntity _AspnetRolesEntity = new AspnetRolesEntity(RoleId);
				if (adapter.FetchEntity(_AspnetRolesEntity))
				{
				
					_AspnetRolesEntity.ApplicationId = ApplicationId;
					_AspnetRolesEntity.RoleName = RoleName;
					_AspnetRolesEntity.LoweredRoleName = LoweredRoleName;
					_AspnetRolesEntity.Description = Description;
					adapter.SaveEntity(_AspnetRolesEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(Guid RoleId)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetRolesEntity _AspnetRolesEntity = new AspnetRolesEntity(RoleId);
				if (adapter.FetchEntity(_AspnetRolesEntity))
				{
					adapter.DeleteEntity(_AspnetRolesEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("AspnetRolesEntity", null);
			}
		}
		
		
		public int DeleteByApplicationId(Guid ApplicationId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetRolesEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByRoleId(Guid RoleId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.RoleId == RoleId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetRolesEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByRoleName(string RoleName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.RoleName == RoleName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetRolesEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoweredRoleName(string LoweredRoleName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.LoweredRoleName == LoweredRoleName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetRolesEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDescription(string Description)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetRolesEntity", filter);
			}
			return toReturn;
		}
		

		
		public AspnetRolesEntity SelectOne(Guid RoleId)
		{
			AspnetRolesEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetRolesEntity _AspnetRolesEntity = new AspnetRolesEntity(RoleId);
				if (adapter.FetchEntity(_AspnetRolesEntity))
				{
					toReturn = _AspnetRolesEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetRolesCollection = new EntityCollection(new AspnetRolesEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetRolesCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<AspnetRolesEntity>
		public EntityCollection<AspnetRolesEntity> SelectAllLST()
		{
			EntityCollection<AspnetRolesEntity> _AspnetRolesCollection = new EntityCollection<AspnetRolesEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetRolesCollection, null, 0, null);
			}
			return _AspnetRolesCollection;
		}
		
		// Return EntityCollection<AspnetRolesEntity>
		public EntityCollection<AspnetRolesEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<AspnetRolesEntity> _AspnetRolesCollection = new EntityCollection<AspnetRolesEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetRolesCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetRolesCollection;
		}


		
		// Return EntityCollection<AspnetRolesEntity>
		public EntityCollection<AspnetRolesEntity> SelectByApplicationIdLST(Guid ApplicationId)
		{
			EntityCollection<AspnetRolesEntity> _AspnetRolesCollection = new EntityCollection<AspnetRolesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetRolesCollection, filter, 0, null);
			}
			return _AspnetRolesCollection;
		}
		
		// Return EntityCollection<AspnetRolesEntity>
		public EntityCollection<AspnetRolesEntity> SelectByApplicationIdLST_Paged(Guid ApplicationId, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetRolesEntity> _AspnetRolesCollection = new EntityCollection<AspnetRolesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetRolesCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetRolesCollection;
		}
		
		// Return DataTable
		public DataTable SelectByApplicationIdRDT(Guid ApplicationId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetRolesCollection = new EntityCollection(new AspnetRolesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetRolesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByApplicationIdRDT_Paged(Guid ApplicationId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetRolesCollection = new EntityCollection(new AspnetRolesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetRolesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetRolesEntity>
		public EntityCollection<AspnetRolesEntity> SelectByRoleIdLST(Guid RoleId)
		{
			EntityCollection<AspnetRolesEntity> _AspnetRolesCollection = new EntityCollection<AspnetRolesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.RoleId == RoleId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetRolesCollection, filter, 0, null);
			}
			return _AspnetRolesCollection;
		}
		
		// Return EntityCollection<AspnetRolesEntity>
		public EntityCollection<AspnetRolesEntity> SelectByRoleIdLST_Paged(Guid RoleId, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetRolesEntity> _AspnetRolesCollection = new EntityCollection<AspnetRolesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.RoleId == RoleId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetRolesCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetRolesCollection;
		}
		
		// Return DataTable
		public DataTable SelectByRoleIdRDT(Guid RoleId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetRolesCollection = new EntityCollection(new AspnetRolesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.RoleId == RoleId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetRolesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByRoleIdRDT_Paged(Guid RoleId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetRolesCollection = new EntityCollection(new AspnetRolesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.RoleId == RoleId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetRolesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetRolesEntity>
		public EntityCollection<AspnetRolesEntity> SelectByRoleNameLST(string RoleName)
		{
			EntityCollection<AspnetRolesEntity> _AspnetRolesCollection = new EntityCollection<AspnetRolesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.RoleName == RoleName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetRolesCollection, filter, 0, null);
			}
			return _AspnetRolesCollection;
		}
		
		// Return EntityCollection<AspnetRolesEntity>
		public EntityCollection<AspnetRolesEntity> SelectByRoleNameLST_Paged(string RoleName, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetRolesEntity> _AspnetRolesCollection = new EntityCollection<AspnetRolesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.RoleName == RoleName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetRolesCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetRolesCollection;
		}
		
		// Return DataTable
		public DataTable SelectByRoleNameRDT(string RoleName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetRolesCollection = new EntityCollection(new AspnetRolesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.RoleName == RoleName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetRolesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByRoleNameRDT_Paged(string RoleName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetRolesCollection = new EntityCollection(new AspnetRolesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.RoleName == RoleName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetRolesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetRolesEntity>
		public EntityCollection<AspnetRolesEntity> SelectByLoweredRoleNameLST(string LoweredRoleName)
		{
			EntityCollection<AspnetRolesEntity> _AspnetRolesCollection = new EntityCollection<AspnetRolesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.LoweredRoleName == LoweredRoleName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetRolesCollection, filter, 0, null);
			}
			return _AspnetRolesCollection;
		}
		
		// Return EntityCollection<AspnetRolesEntity>
		public EntityCollection<AspnetRolesEntity> SelectByLoweredRoleNameLST_Paged(string LoweredRoleName, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetRolesEntity> _AspnetRolesCollection = new EntityCollection<AspnetRolesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.LoweredRoleName == LoweredRoleName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetRolesCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetRolesCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoweredRoleNameRDT(string LoweredRoleName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetRolesCollection = new EntityCollection(new AspnetRolesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.LoweredRoleName == LoweredRoleName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetRolesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoweredRoleNameRDT_Paged(string LoweredRoleName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetRolesCollection = new EntityCollection(new AspnetRolesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.LoweredRoleName == LoweredRoleName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetRolesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetRolesEntity>
		public EntityCollection<AspnetRolesEntity> SelectByDescriptionLST(string Description)
		{
			EntityCollection<AspnetRolesEntity> _AspnetRolesCollection = new EntityCollection<AspnetRolesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetRolesCollection, filter, 0, null);
			}
			return _AspnetRolesCollection;
		}
		
		// Return EntityCollection<AspnetRolesEntity>
		public EntityCollection<AspnetRolesEntity> SelectByDescriptionLST_Paged(string Description, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetRolesEntity> _AspnetRolesCollection = new EntityCollection<AspnetRolesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetRolesCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetRolesCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDescriptionRDT(string Description)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetRolesCollection = new EntityCollection(new AspnetRolesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetRolesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDescriptionRDT_Paged(string Description, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetRolesCollection = new EntityCollection(new AspnetRolesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetRolesFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetRolesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
