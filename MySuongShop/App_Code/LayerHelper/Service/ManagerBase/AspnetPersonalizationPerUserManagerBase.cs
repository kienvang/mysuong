




/*
'===============================================================================
'  LayerHelper.Service.BL.AspnetPersonalizationPerUserManagerBase
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
	public class AspnetPersonalizationPerUserManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AspnetPersonalizationPerUserManagerBase()
		{
			// Nothing for now.
		}
		
		public AspnetPersonalizationPerUserEntity Insert(AspnetPersonalizationPerUserEntity _AspnetPersonalizationPerUserEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_AspnetPersonalizationPerUserEntity, true);
			}
			return _AspnetPersonalizationPerUserEntity;
		}

		
		public AspnetPersonalizationPerUserEntity Insert(Guid Id, Guid PathId, Guid UserId, byte[] PageSettings, DateTime LastUpdatedDate)
		{
			AspnetPersonalizationPerUserEntity _AspnetPersonalizationPerUserEntity = new AspnetPersonalizationPerUserEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AspnetPersonalizationPerUserEntity.Id = Id;
				_AspnetPersonalizationPerUserEntity.PathId = PathId;
				_AspnetPersonalizationPerUserEntity.UserId = UserId;
				_AspnetPersonalizationPerUserEntity.PageSettings = PageSettings;
				_AspnetPersonalizationPerUserEntity.LastUpdatedDate = LastUpdatedDate;
				adapter.SaveEntity(_AspnetPersonalizationPerUserEntity, true);
			}
			return _AspnetPersonalizationPerUserEntity;
		}

		public AspnetPersonalizationPerUserEntity Insert(Guid PathId, Guid UserId, byte[] PageSettings, DateTime LastUpdatedDate)
		{
			AspnetPersonalizationPerUserEntity _AspnetPersonalizationPerUserEntity = new AspnetPersonalizationPerUserEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AspnetPersonalizationPerUserEntity.PathId = PathId;
				_AspnetPersonalizationPerUserEntity.UserId = UserId;
				_AspnetPersonalizationPerUserEntity.PageSettings = PageSettings;
				_AspnetPersonalizationPerUserEntity.LastUpdatedDate = LastUpdatedDate;
				adapter.SaveEntity(_AspnetPersonalizationPerUserEntity, true);
			}
			return _AspnetPersonalizationPerUserEntity;
		}

		public bool Update(AspnetPersonalizationPerUserEntity _AspnetPersonalizationPerUserEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(AspnetPersonalizationPerUserFields.Id == _AspnetPersonalizationPerUserEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_AspnetPersonalizationPerUserEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(AspnetPersonalizationPerUserEntity _AspnetPersonalizationPerUserEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_AspnetPersonalizationPerUserEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid PathId, Guid UserId, byte[] PageSettings, DateTime LastUpdatedDate)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetPersonalizationPerUserEntity _AspnetPersonalizationPerUserEntity = new AspnetPersonalizationPerUserEntity(Id);
				if (adapter.FetchEntity(_AspnetPersonalizationPerUserEntity))
				{
				
					_AspnetPersonalizationPerUserEntity.PathId = PathId;
					_AspnetPersonalizationPerUserEntity.UserId = UserId;
					_AspnetPersonalizationPerUserEntity.PageSettings = PageSettings;
					_AspnetPersonalizationPerUserEntity.LastUpdatedDate = LastUpdatedDate;
					adapter.SaveEntity(_AspnetPersonalizationPerUserEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(Guid Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetPersonalizationPerUserEntity _AspnetPersonalizationPerUserEntity = new AspnetPersonalizationPerUserEntity(Id);
				if (adapter.FetchEntity(_AspnetPersonalizationPerUserEntity))
				{
					adapter.DeleteEntity(_AspnetPersonalizationPerUserEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("AspnetPersonalizationPerUserEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetPersonalizationPerUserEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPathId(Guid PathId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.PathId == PathId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetPersonalizationPerUserEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUserId(Guid UserId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetPersonalizationPerUserEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPageSettings(byte[] PageSettings)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.PageSettings == PageSettings);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetPersonalizationPerUserEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLastUpdatedDate(DateTime LastUpdatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.LastUpdatedDate == LastUpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetPersonalizationPerUserEntity", filter);
			}
			return toReturn;
		}
		

		
		public AspnetPersonalizationPerUserEntity SelectOne(Guid Id)
		{
			AspnetPersonalizationPerUserEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetPersonalizationPerUserEntity _AspnetPersonalizationPerUserEntity = new AspnetPersonalizationPerUserEntity(Id);
				if (adapter.FetchEntity(_AspnetPersonalizationPerUserEntity))
				{
					toReturn = _AspnetPersonalizationPerUserEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPersonalizationPerUserCollection = new EntityCollection(new AspnetPersonalizationPerUserEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPersonalizationPerUserCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<AspnetPersonalizationPerUserEntity>
		public EntityCollection<AspnetPersonalizationPerUserEntity> SelectAllLST()
		{
			EntityCollection<AspnetPersonalizationPerUserEntity> _AspnetPersonalizationPerUserCollection = new EntityCollection<AspnetPersonalizationPerUserEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPersonalizationPerUserCollection, null, 0, null);
			}
			return _AspnetPersonalizationPerUserCollection;
		}
		
		// Return EntityCollection<AspnetPersonalizationPerUserEntity>
		public EntityCollection<AspnetPersonalizationPerUserEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<AspnetPersonalizationPerUserEntity> _AspnetPersonalizationPerUserCollection = new EntityCollection<AspnetPersonalizationPerUserEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPersonalizationPerUserCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetPersonalizationPerUserCollection;
		}


		
		// Return EntityCollection<AspnetPersonalizationPerUserEntity>
		public EntityCollection<AspnetPersonalizationPerUserEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<AspnetPersonalizationPerUserEntity> _AspnetPersonalizationPerUserCollection = new EntityCollection<AspnetPersonalizationPerUserEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPersonalizationPerUserCollection, filter, 0, null);
			}
			return _AspnetPersonalizationPerUserCollection;
		}
		
		// Return EntityCollection<AspnetPersonalizationPerUserEntity>
		public EntityCollection<AspnetPersonalizationPerUserEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetPersonalizationPerUserEntity> _AspnetPersonalizationPerUserCollection = new EntityCollection<AspnetPersonalizationPerUserEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPersonalizationPerUserCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetPersonalizationPerUserCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPersonalizationPerUserCollection = new EntityCollection(new AspnetPersonalizationPerUserEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPersonalizationPerUserCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPersonalizationPerUserCollection = new EntityCollection(new AspnetPersonalizationPerUserEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPersonalizationPerUserCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetPersonalizationPerUserEntity>
		public EntityCollection<AspnetPersonalizationPerUserEntity> SelectByPathIdLST(Guid PathId)
		{
			EntityCollection<AspnetPersonalizationPerUserEntity> _AspnetPersonalizationPerUserCollection = new EntityCollection<AspnetPersonalizationPerUserEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.PathId == PathId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPersonalizationPerUserCollection, filter, 0, null);
			}
			return _AspnetPersonalizationPerUserCollection;
		}
		
		// Return EntityCollection<AspnetPersonalizationPerUserEntity>
		public EntityCollection<AspnetPersonalizationPerUserEntity> SelectByPathIdLST_Paged(Guid PathId, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetPersonalizationPerUserEntity> _AspnetPersonalizationPerUserCollection = new EntityCollection<AspnetPersonalizationPerUserEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.PathId == PathId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPersonalizationPerUserCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetPersonalizationPerUserCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPathIdRDT(Guid PathId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPersonalizationPerUserCollection = new EntityCollection(new AspnetPersonalizationPerUserEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.PathId == PathId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPersonalizationPerUserCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPathIdRDT_Paged(Guid PathId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPersonalizationPerUserCollection = new EntityCollection(new AspnetPersonalizationPerUserEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.PathId == PathId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPersonalizationPerUserCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetPersonalizationPerUserEntity>
		public EntityCollection<AspnetPersonalizationPerUserEntity> SelectByUserIdLST(Guid UserId)
		{
			EntityCollection<AspnetPersonalizationPerUserEntity> _AspnetPersonalizationPerUserCollection = new EntityCollection<AspnetPersonalizationPerUserEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPersonalizationPerUserCollection, filter, 0, null);
			}
			return _AspnetPersonalizationPerUserCollection;
		}
		
		// Return EntityCollection<AspnetPersonalizationPerUserEntity>
		public EntityCollection<AspnetPersonalizationPerUserEntity> SelectByUserIdLST_Paged(Guid UserId, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetPersonalizationPerUserEntity> _AspnetPersonalizationPerUserCollection = new EntityCollection<AspnetPersonalizationPerUserEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPersonalizationPerUserCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetPersonalizationPerUserCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUserIdRDT(Guid UserId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPersonalizationPerUserCollection = new EntityCollection(new AspnetPersonalizationPerUserEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPersonalizationPerUserCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUserIdRDT_Paged(Guid UserId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPersonalizationPerUserCollection = new EntityCollection(new AspnetPersonalizationPerUserEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPersonalizationPerUserCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetPersonalizationPerUserEntity>
		public EntityCollection<AspnetPersonalizationPerUserEntity> SelectByPageSettingsLST(byte[] PageSettings)
		{
			EntityCollection<AspnetPersonalizationPerUserEntity> _AspnetPersonalizationPerUserCollection = new EntityCollection<AspnetPersonalizationPerUserEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.PageSettings == PageSettings);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPersonalizationPerUserCollection, filter, 0, null);
			}
			return _AspnetPersonalizationPerUserCollection;
		}
		
		// Return EntityCollection<AspnetPersonalizationPerUserEntity>
		public EntityCollection<AspnetPersonalizationPerUserEntity> SelectByPageSettingsLST_Paged(byte[] PageSettings, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetPersonalizationPerUserEntity> _AspnetPersonalizationPerUserCollection = new EntityCollection<AspnetPersonalizationPerUserEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.PageSettings == PageSettings);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPersonalizationPerUserCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetPersonalizationPerUserCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPageSettingsRDT(byte[] PageSettings)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPersonalizationPerUserCollection = new EntityCollection(new AspnetPersonalizationPerUserEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.PageSettings == PageSettings);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPersonalizationPerUserCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPageSettingsRDT_Paged(byte[] PageSettings, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPersonalizationPerUserCollection = new EntityCollection(new AspnetPersonalizationPerUserEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.PageSettings == PageSettings);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPersonalizationPerUserCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetPersonalizationPerUserEntity>
		public EntityCollection<AspnetPersonalizationPerUserEntity> SelectByLastUpdatedDateLST(DateTime LastUpdatedDate)
		{
			EntityCollection<AspnetPersonalizationPerUserEntity> _AspnetPersonalizationPerUserCollection = new EntityCollection<AspnetPersonalizationPerUserEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.LastUpdatedDate == LastUpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPersonalizationPerUserCollection, filter, 0, null);
			}
			return _AspnetPersonalizationPerUserCollection;
		}
		
		// Return EntityCollection<AspnetPersonalizationPerUserEntity>
		public EntityCollection<AspnetPersonalizationPerUserEntity> SelectByLastUpdatedDateLST_Paged(DateTime LastUpdatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetPersonalizationPerUserEntity> _AspnetPersonalizationPerUserCollection = new EntityCollection<AspnetPersonalizationPerUserEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.LastUpdatedDate == LastUpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPersonalizationPerUserCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetPersonalizationPerUserCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLastUpdatedDateRDT(DateTime LastUpdatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPersonalizationPerUserCollection = new EntityCollection(new AspnetPersonalizationPerUserEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.LastUpdatedDate == LastUpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPersonalizationPerUserCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLastUpdatedDateRDT_Paged(DateTime LastUpdatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPersonalizationPerUserCollection = new EntityCollection(new AspnetPersonalizationPerUserEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationPerUserFields.LastUpdatedDate == LastUpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPersonalizationPerUserCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
