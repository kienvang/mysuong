




/*
'===============================================================================
'  LayerHelper.Service.BL.AspnetUsersInRolesManagerBase
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
	public class AspnetUsersInRolesManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AspnetUsersInRolesManagerBase()
		{
			// Nothing for now.
		}
		
		public AspnetUsersInRolesEntity Insert(AspnetUsersInRolesEntity _AspnetUsersInRolesEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_AspnetUsersInRolesEntity, true);
			}
			return _AspnetUsersInRolesEntity;
		}

		
		public AspnetUsersInRolesEntity Insert(Guid UserId, Guid RoleId)
		{
			AspnetUsersInRolesEntity _AspnetUsersInRolesEntity = new AspnetUsersInRolesEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AspnetUsersInRolesEntity.UserId = UserId;
				_AspnetUsersInRolesEntity.RoleId = RoleId;
				adapter.SaveEntity(_AspnetUsersInRolesEntity, true);
			}
			return _AspnetUsersInRolesEntity;
		}

		public AspnetUsersInRolesEntity Insert()
		{
			AspnetUsersInRolesEntity _AspnetUsersInRolesEntity = new AspnetUsersInRolesEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				adapter.SaveEntity(_AspnetUsersInRolesEntity, true);
			}
			return _AspnetUsersInRolesEntity;
		}

		public bool Update(AspnetUsersInRolesEntity _AspnetUsersInRolesEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(AspnetUsersInRolesFields.UserId == _AspnetUsersInRolesEntity.UserId);
					_PredicateExpression.Add(AspnetUsersInRolesFields.RoleId == _AspnetUsersInRolesEntity.RoleId);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_AspnetUsersInRolesEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(AspnetUsersInRolesEntity _AspnetUsersInRolesEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_AspnetUsersInRolesEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid UserId, Guid RoleId)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetUsersInRolesEntity _AspnetUsersInRolesEntity = new AspnetUsersInRolesEntity(UserId, RoleId);
				if (adapter.FetchEntity(_AspnetUsersInRolesEntity))
				{
				
					adapter.SaveEntity(_AspnetUsersInRolesEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(Guid UserId, Guid RoleId)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetUsersInRolesEntity _AspnetUsersInRolesEntity = new AspnetUsersInRolesEntity(UserId, RoleId);
				if (adapter.FetchEntity(_AspnetUsersInRolesEntity))
				{
					adapter.DeleteEntity(_AspnetUsersInRolesEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("AspnetUsersInRolesEntity", null);
			}
		}
		
		
		public int DeleteByUserId(Guid UserId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersInRolesFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetUsersInRolesEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByRoleId(Guid RoleId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersInRolesFields.RoleId == RoleId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetUsersInRolesEntity", filter);
			}
			return toReturn;
		}
		

		
		public AspnetUsersInRolesEntity SelectOne(Guid UserId, Guid RoleId)
		{
			AspnetUsersInRolesEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetUsersInRolesEntity _AspnetUsersInRolesEntity = new AspnetUsersInRolesEntity(UserId, RoleId);
				if (adapter.FetchEntity(_AspnetUsersInRolesEntity))
				{
					toReturn = _AspnetUsersInRolesEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetUsersInRolesCollection = new EntityCollection(new AspnetUsersInRolesEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetUsersInRolesCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<AspnetUsersInRolesEntity>
		public EntityCollection<AspnetUsersInRolesEntity> SelectAllLST()
		{
			EntityCollection<AspnetUsersInRolesEntity> _AspnetUsersInRolesCollection = new EntityCollection<AspnetUsersInRolesEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetUsersInRolesCollection, null, 0, null);
			}
			return _AspnetUsersInRolesCollection;
		}
		
		// Return EntityCollection<AspnetUsersInRolesEntity>
		public EntityCollection<AspnetUsersInRolesEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<AspnetUsersInRolesEntity> _AspnetUsersInRolesCollection = new EntityCollection<AspnetUsersInRolesEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetUsersInRolesCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetUsersInRolesCollection;
		}


		
		// Return EntityCollection<AspnetUsersInRolesEntity>
		public EntityCollection<AspnetUsersInRolesEntity> SelectByUserIdLST(Guid UserId)
		{
			EntityCollection<AspnetUsersInRolesEntity> _AspnetUsersInRolesCollection = new EntityCollection<AspnetUsersInRolesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersInRolesFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetUsersInRolesCollection, filter, 0, null);
			}
			return _AspnetUsersInRolesCollection;
		}
		
		// Return EntityCollection<AspnetUsersInRolesEntity>
		public EntityCollection<AspnetUsersInRolesEntity> SelectByUserIdLST_Paged(Guid UserId, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetUsersInRolesEntity> _AspnetUsersInRolesCollection = new EntityCollection<AspnetUsersInRolesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersInRolesFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetUsersInRolesCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetUsersInRolesCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUserIdRDT(Guid UserId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetUsersInRolesCollection = new EntityCollection(new AspnetUsersInRolesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersInRolesFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetUsersInRolesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUserIdRDT_Paged(Guid UserId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetUsersInRolesCollection = new EntityCollection(new AspnetUsersInRolesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersInRolesFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetUsersInRolesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetUsersInRolesEntity>
		public EntityCollection<AspnetUsersInRolesEntity> SelectByRoleIdLST(Guid RoleId)
		{
			EntityCollection<AspnetUsersInRolesEntity> _AspnetUsersInRolesCollection = new EntityCollection<AspnetUsersInRolesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersInRolesFields.RoleId == RoleId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetUsersInRolesCollection, filter, 0, null);
			}
			return _AspnetUsersInRolesCollection;
		}
		
		// Return EntityCollection<AspnetUsersInRolesEntity>
		public EntityCollection<AspnetUsersInRolesEntity> SelectByRoleIdLST_Paged(Guid RoleId, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetUsersInRolesEntity> _AspnetUsersInRolesCollection = new EntityCollection<AspnetUsersInRolesEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersInRolesFields.RoleId == RoleId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetUsersInRolesCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetUsersInRolesCollection;
		}
		
		// Return DataTable
		public DataTable SelectByRoleIdRDT(Guid RoleId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetUsersInRolesCollection = new EntityCollection(new AspnetUsersInRolesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersInRolesFields.RoleId == RoleId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetUsersInRolesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByRoleIdRDT_Paged(Guid RoleId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetUsersInRolesCollection = new EntityCollection(new AspnetUsersInRolesEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersInRolesFields.RoleId == RoleId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetUsersInRolesCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
