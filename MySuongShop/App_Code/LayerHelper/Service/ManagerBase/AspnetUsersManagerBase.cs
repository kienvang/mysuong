




/*
'===============================================================================
'  LayerHelper.Service.BL.AspnetUsersManagerBase
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
	public class AspnetUsersManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AspnetUsersManagerBase()
		{
			// Nothing for now.
		}
		
		public AspnetUsersEntity Insert(AspnetUsersEntity _AspnetUsersEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_AspnetUsersEntity, true);
			}
			return _AspnetUsersEntity;
		}

		
		public AspnetUsersEntity Insert(Guid ApplicationId, Guid UserId, string UserName, string LoweredUserName, string MobileAlias, bool IsAnonymous, DateTime LastActivityDate)
		{
			AspnetUsersEntity _AspnetUsersEntity = new AspnetUsersEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AspnetUsersEntity.ApplicationId = ApplicationId;
				_AspnetUsersEntity.UserId = UserId;
				_AspnetUsersEntity.UserName = UserName;
				_AspnetUsersEntity.LoweredUserName = LoweredUserName;
				_AspnetUsersEntity.MobileAlias = MobileAlias;
				_AspnetUsersEntity.IsAnonymous = IsAnonymous;
				_AspnetUsersEntity.LastActivityDate = LastActivityDate;
				adapter.SaveEntity(_AspnetUsersEntity, true);
			}
			return _AspnetUsersEntity;
		}

		public AspnetUsersEntity Insert(Guid ApplicationId, string UserName, string LoweredUserName, string MobileAlias, bool IsAnonymous, DateTime LastActivityDate)
		{
			AspnetUsersEntity _AspnetUsersEntity = new AspnetUsersEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AspnetUsersEntity.ApplicationId = ApplicationId;
				_AspnetUsersEntity.UserName = UserName;
				_AspnetUsersEntity.LoweredUserName = LoweredUserName;
				_AspnetUsersEntity.MobileAlias = MobileAlias;
				_AspnetUsersEntity.IsAnonymous = IsAnonymous;
				_AspnetUsersEntity.LastActivityDate = LastActivityDate;
				adapter.SaveEntity(_AspnetUsersEntity, true);
			}
			return _AspnetUsersEntity;
		}

		public bool Update(AspnetUsersEntity _AspnetUsersEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(AspnetUsersFields.UserId == _AspnetUsersEntity.UserId);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_AspnetUsersEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(AspnetUsersEntity _AspnetUsersEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_AspnetUsersEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid ApplicationId, Guid UserId, string UserName, string LoweredUserName, string MobileAlias, bool IsAnonymous, DateTime LastActivityDate)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetUsersEntity _AspnetUsersEntity = new AspnetUsersEntity(UserId);
				if (adapter.FetchEntity(_AspnetUsersEntity))
				{
				
					_AspnetUsersEntity.ApplicationId = ApplicationId;
					_AspnetUsersEntity.UserName = UserName;
					_AspnetUsersEntity.LoweredUserName = LoweredUserName;
					_AspnetUsersEntity.MobileAlias = MobileAlias;
					_AspnetUsersEntity.IsAnonymous = IsAnonymous;
					_AspnetUsersEntity.LastActivityDate = LastActivityDate;
					adapter.SaveEntity(_AspnetUsersEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(Guid UserId)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetUsersEntity _AspnetUsersEntity = new AspnetUsersEntity(UserId);
				if (adapter.FetchEntity(_AspnetUsersEntity))
				{
					adapter.DeleteEntity(_AspnetUsersEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("AspnetUsersEntity", null);
			}
		}
		
		
		public int DeleteByApplicationId(Guid ApplicationId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetUsersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUserId(Guid UserId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetUsersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUserName(string UserName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetUsersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoweredUserName(string LoweredUserName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.LoweredUserName == LoweredUserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetUsersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMobileAlias(string MobileAlias)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.MobileAlias == MobileAlias);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetUsersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsAnonymous(bool IsAnonymous)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.IsAnonymous == IsAnonymous);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetUsersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLastActivityDate(DateTime LastActivityDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.LastActivityDate == LastActivityDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetUsersEntity", filter);
			}
			return toReturn;
		}
		

		
		public AspnetUsersEntity SelectOne(Guid UserId)
		{
			AspnetUsersEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetUsersEntity _AspnetUsersEntity = new AspnetUsersEntity(UserId);
				if (adapter.FetchEntity(_AspnetUsersEntity))
				{
					toReturn = _AspnetUsersEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetUsersCollection = new EntityCollection(new AspnetUsersEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetUsersCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<AspnetUsersEntity>
		public EntityCollection<AspnetUsersEntity> SelectAllLST()
		{
			EntityCollection<AspnetUsersEntity> _AspnetUsersCollection = new EntityCollection<AspnetUsersEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetUsersCollection, null, 0, null);
			}
			return _AspnetUsersCollection;
		}
		
		// Return EntityCollection<AspnetUsersEntity>
		public EntityCollection<AspnetUsersEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<AspnetUsersEntity> _AspnetUsersCollection = new EntityCollection<AspnetUsersEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetUsersCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetUsersCollection;
		}


		
		// Return EntityCollection<AspnetUsersEntity>
		public EntityCollection<AspnetUsersEntity> SelectByApplicationIdLST(Guid ApplicationId)
		{
			EntityCollection<AspnetUsersEntity> _AspnetUsersCollection = new EntityCollection<AspnetUsersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetUsersCollection, filter, 0, null);
			}
			return _AspnetUsersCollection;
		}
		
		// Return EntityCollection<AspnetUsersEntity>
		public EntityCollection<AspnetUsersEntity> SelectByApplicationIdLST_Paged(Guid ApplicationId, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetUsersEntity> _AspnetUsersCollection = new EntityCollection<AspnetUsersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetUsersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetUsersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByApplicationIdRDT(Guid ApplicationId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetUsersCollection = new EntityCollection(new AspnetUsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetUsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByApplicationIdRDT_Paged(Guid ApplicationId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetUsersCollection = new EntityCollection(new AspnetUsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetUsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetUsersEntity>
		public EntityCollection<AspnetUsersEntity> SelectByUserIdLST(Guid UserId)
		{
			EntityCollection<AspnetUsersEntity> _AspnetUsersCollection = new EntityCollection<AspnetUsersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetUsersCollection, filter, 0, null);
			}
			return _AspnetUsersCollection;
		}
		
		// Return EntityCollection<AspnetUsersEntity>
		public EntityCollection<AspnetUsersEntity> SelectByUserIdLST_Paged(Guid UserId, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetUsersEntity> _AspnetUsersCollection = new EntityCollection<AspnetUsersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetUsersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetUsersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUserIdRDT(Guid UserId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetUsersCollection = new EntityCollection(new AspnetUsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetUsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUserIdRDT_Paged(Guid UserId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetUsersCollection = new EntityCollection(new AspnetUsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetUsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetUsersEntity>
		public EntityCollection<AspnetUsersEntity> SelectByUserNameLST(string UserName)
		{
			EntityCollection<AspnetUsersEntity> _AspnetUsersCollection = new EntityCollection<AspnetUsersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetUsersCollection, filter, 0, null);
			}
			return _AspnetUsersCollection;
		}
		
		// Return EntityCollection<AspnetUsersEntity>
		public EntityCollection<AspnetUsersEntity> SelectByUserNameLST_Paged(string UserName, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetUsersEntity> _AspnetUsersCollection = new EntityCollection<AspnetUsersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetUsersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetUsersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUserNameRDT(string UserName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetUsersCollection = new EntityCollection(new AspnetUsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetUsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUserNameRDT_Paged(string UserName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetUsersCollection = new EntityCollection(new AspnetUsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetUsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetUsersEntity>
		public EntityCollection<AspnetUsersEntity> SelectByLoweredUserNameLST(string LoweredUserName)
		{
			EntityCollection<AspnetUsersEntity> _AspnetUsersCollection = new EntityCollection<AspnetUsersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.LoweredUserName == LoweredUserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetUsersCollection, filter, 0, null);
			}
			return _AspnetUsersCollection;
		}
		
		// Return EntityCollection<AspnetUsersEntity>
		public EntityCollection<AspnetUsersEntity> SelectByLoweredUserNameLST_Paged(string LoweredUserName, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetUsersEntity> _AspnetUsersCollection = new EntityCollection<AspnetUsersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.LoweredUserName == LoweredUserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetUsersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetUsersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoweredUserNameRDT(string LoweredUserName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetUsersCollection = new EntityCollection(new AspnetUsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.LoweredUserName == LoweredUserName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetUsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoweredUserNameRDT_Paged(string LoweredUserName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetUsersCollection = new EntityCollection(new AspnetUsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.LoweredUserName == LoweredUserName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetUsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetUsersEntity>
		public EntityCollection<AspnetUsersEntity> SelectByMobileAliasLST(string MobileAlias)
		{
			EntityCollection<AspnetUsersEntity> _AspnetUsersCollection = new EntityCollection<AspnetUsersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.MobileAlias == MobileAlias);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetUsersCollection, filter, 0, null);
			}
			return _AspnetUsersCollection;
		}
		
		// Return EntityCollection<AspnetUsersEntity>
		public EntityCollection<AspnetUsersEntity> SelectByMobileAliasLST_Paged(string MobileAlias, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetUsersEntity> _AspnetUsersCollection = new EntityCollection<AspnetUsersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.MobileAlias == MobileAlias);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetUsersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetUsersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMobileAliasRDT(string MobileAlias)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetUsersCollection = new EntityCollection(new AspnetUsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.MobileAlias == MobileAlias);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetUsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMobileAliasRDT_Paged(string MobileAlias, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetUsersCollection = new EntityCollection(new AspnetUsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.MobileAlias == MobileAlias);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetUsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetUsersEntity>
		public EntityCollection<AspnetUsersEntity> SelectByIsAnonymousLST(bool IsAnonymous)
		{
			EntityCollection<AspnetUsersEntity> _AspnetUsersCollection = new EntityCollection<AspnetUsersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.IsAnonymous == IsAnonymous);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetUsersCollection, filter, 0, null);
			}
			return _AspnetUsersCollection;
		}
		
		// Return EntityCollection<AspnetUsersEntity>
		public EntityCollection<AspnetUsersEntity> SelectByIsAnonymousLST_Paged(bool IsAnonymous, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetUsersEntity> _AspnetUsersCollection = new EntityCollection<AspnetUsersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.IsAnonymous == IsAnonymous);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetUsersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetUsersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsAnonymousRDT(bool IsAnonymous)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetUsersCollection = new EntityCollection(new AspnetUsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.IsAnonymous == IsAnonymous);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetUsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsAnonymousRDT_Paged(bool IsAnonymous, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetUsersCollection = new EntityCollection(new AspnetUsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.IsAnonymous == IsAnonymous);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetUsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetUsersEntity>
		public EntityCollection<AspnetUsersEntity> SelectByLastActivityDateLST(DateTime LastActivityDate)
		{
			EntityCollection<AspnetUsersEntity> _AspnetUsersCollection = new EntityCollection<AspnetUsersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.LastActivityDate == LastActivityDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetUsersCollection, filter, 0, null);
			}
			return _AspnetUsersCollection;
		}
		
		// Return EntityCollection<AspnetUsersEntity>
		public EntityCollection<AspnetUsersEntity> SelectByLastActivityDateLST_Paged(DateTime LastActivityDate, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetUsersEntity> _AspnetUsersCollection = new EntityCollection<AspnetUsersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.LastActivityDate == LastActivityDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetUsersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetUsersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLastActivityDateRDT(DateTime LastActivityDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetUsersCollection = new EntityCollection(new AspnetUsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.LastActivityDate == LastActivityDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetUsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLastActivityDateRDT_Paged(DateTime LastActivityDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetUsersCollection = new EntityCollection(new AspnetUsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetUsersFields.LastActivityDate == LastActivityDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetUsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
