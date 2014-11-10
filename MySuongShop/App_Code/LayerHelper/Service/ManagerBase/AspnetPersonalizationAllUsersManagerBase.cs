




/*
'===============================================================================
'  LayerHelper.Service.BL.AspnetPersonalizationAllUsersManagerBase
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
	public class AspnetPersonalizationAllUsersManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AspnetPersonalizationAllUsersManagerBase()
		{
			// Nothing for now.
		}
		
		public AspnetPersonalizationAllUsersEntity Insert(AspnetPersonalizationAllUsersEntity _AspnetPersonalizationAllUsersEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_AspnetPersonalizationAllUsersEntity, true);
			}
			return _AspnetPersonalizationAllUsersEntity;
		}

		
		public AspnetPersonalizationAllUsersEntity Insert(Guid PathId, byte[] PageSettings, DateTime LastUpdatedDate)
		{
			AspnetPersonalizationAllUsersEntity _AspnetPersonalizationAllUsersEntity = new AspnetPersonalizationAllUsersEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AspnetPersonalizationAllUsersEntity.PathId = PathId;
				_AspnetPersonalizationAllUsersEntity.PageSettings = PageSettings;
				_AspnetPersonalizationAllUsersEntity.LastUpdatedDate = LastUpdatedDate;
				adapter.SaveEntity(_AspnetPersonalizationAllUsersEntity, true);
			}
			return _AspnetPersonalizationAllUsersEntity;
		}

		public AspnetPersonalizationAllUsersEntity Insert(byte[] PageSettings, DateTime LastUpdatedDate)
		{
			AspnetPersonalizationAllUsersEntity _AspnetPersonalizationAllUsersEntity = new AspnetPersonalizationAllUsersEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AspnetPersonalizationAllUsersEntity.PageSettings = PageSettings;
				_AspnetPersonalizationAllUsersEntity.LastUpdatedDate = LastUpdatedDate;
				adapter.SaveEntity(_AspnetPersonalizationAllUsersEntity, true);
			}
			return _AspnetPersonalizationAllUsersEntity;
		}

		public bool Update(AspnetPersonalizationAllUsersEntity _AspnetPersonalizationAllUsersEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(AspnetPersonalizationAllUsersFields.PathId == _AspnetPersonalizationAllUsersEntity.PathId);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_AspnetPersonalizationAllUsersEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(AspnetPersonalizationAllUsersEntity _AspnetPersonalizationAllUsersEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_AspnetPersonalizationAllUsersEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid PathId, byte[] PageSettings, DateTime LastUpdatedDate)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetPersonalizationAllUsersEntity _AspnetPersonalizationAllUsersEntity = new AspnetPersonalizationAllUsersEntity(PathId);
				if (adapter.FetchEntity(_AspnetPersonalizationAllUsersEntity))
				{
				
					_AspnetPersonalizationAllUsersEntity.PageSettings = PageSettings;
					_AspnetPersonalizationAllUsersEntity.LastUpdatedDate = LastUpdatedDate;
					adapter.SaveEntity(_AspnetPersonalizationAllUsersEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(Guid PathId)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetPersonalizationAllUsersEntity _AspnetPersonalizationAllUsersEntity = new AspnetPersonalizationAllUsersEntity(PathId);
				if (adapter.FetchEntity(_AspnetPersonalizationAllUsersEntity))
				{
					adapter.DeleteEntity(_AspnetPersonalizationAllUsersEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("AspnetPersonalizationAllUsersEntity", null);
			}
		}
		
		
		public int DeleteByPathId(Guid PathId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationAllUsersFields.PathId == PathId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetPersonalizationAllUsersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPageSettings(byte[] PageSettings)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationAllUsersFields.PageSettings == PageSettings);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetPersonalizationAllUsersEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLastUpdatedDate(DateTime LastUpdatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationAllUsersFields.LastUpdatedDate == LastUpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetPersonalizationAllUsersEntity", filter);
			}
			return toReturn;
		}
		

		
		public AspnetPersonalizationAllUsersEntity SelectOne(Guid PathId)
		{
			AspnetPersonalizationAllUsersEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetPersonalizationAllUsersEntity _AspnetPersonalizationAllUsersEntity = new AspnetPersonalizationAllUsersEntity(PathId);
				if (adapter.FetchEntity(_AspnetPersonalizationAllUsersEntity))
				{
					toReturn = _AspnetPersonalizationAllUsersEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPersonalizationAllUsersCollection = new EntityCollection(new AspnetPersonalizationAllUsersEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPersonalizationAllUsersCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<AspnetPersonalizationAllUsersEntity>
		public EntityCollection<AspnetPersonalizationAllUsersEntity> SelectAllLST()
		{
			EntityCollection<AspnetPersonalizationAllUsersEntity> _AspnetPersonalizationAllUsersCollection = new EntityCollection<AspnetPersonalizationAllUsersEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPersonalizationAllUsersCollection, null, 0, null);
			}
			return _AspnetPersonalizationAllUsersCollection;
		}
		
		// Return EntityCollection<AspnetPersonalizationAllUsersEntity>
		public EntityCollection<AspnetPersonalizationAllUsersEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<AspnetPersonalizationAllUsersEntity> _AspnetPersonalizationAllUsersCollection = new EntityCollection<AspnetPersonalizationAllUsersEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPersonalizationAllUsersCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetPersonalizationAllUsersCollection;
		}


		
		// Return EntityCollection<AspnetPersonalizationAllUsersEntity>
		public EntityCollection<AspnetPersonalizationAllUsersEntity> SelectByPathIdLST(Guid PathId)
		{
			EntityCollection<AspnetPersonalizationAllUsersEntity> _AspnetPersonalizationAllUsersCollection = new EntityCollection<AspnetPersonalizationAllUsersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationAllUsersFields.PathId == PathId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPersonalizationAllUsersCollection, filter, 0, null);
			}
			return _AspnetPersonalizationAllUsersCollection;
		}
		
		// Return EntityCollection<AspnetPersonalizationAllUsersEntity>
		public EntityCollection<AspnetPersonalizationAllUsersEntity> SelectByPathIdLST_Paged(Guid PathId, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetPersonalizationAllUsersEntity> _AspnetPersonalizationAllUsersCollection = new EntityCollection<AspnetPersonalizationAllUsersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationAllUsersFields.PathId == PathId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPersonalizationAllUsersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetPersonalizationAllUsersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPathIdRDT(Guid PathId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPersonalizationAllUsersCollection = new EntityCollection(new AspnetPersonalizationAllUsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationAllUsersFields.PathId == PathId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPersonalizationAllUsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPathIdRDT_Paged(Guid PathId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPersonalizationAllUsersCollection = new EntityCollection(new AspnetPersonalizationAllUsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationAllUsersFields.PathId == PathId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPersonalizationAllUsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetPersonalizationAllUsersEntity>
		public EntityCollection<AspnetPersonalizationAllUsersEntity> SelectByPageSettingsLST(byte[] PageSettings)
		{
			EntityCollection<AspnetPersonalizationAllUsersEntity> _AspnetPersonalizationAllUsersCollection = new EntityCollection<AspnetPersonalizationAllUsersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationAllUsersFields.PageSettings == PageSettings);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPersonalizationAllUsersCollection, filter, 0, null);
			}
			return _AspnetPersonalizationAllUsersCollection;
		}
		
		// Return EntityCollection<AspnetPersonalizationAllUsersEntity>
		public EntityCollection<AspnetPersonalizationAllUsersEntity> SelectByPageSettingsLST_Paged(byte[] PageSettings, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetPersonalizationAllUsersEntity> _AspnetPersonalizationAllUsersCollection = new EntityCollection<AspnetPersonalizationAllUsersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationAllUsersFields.PageSettings == PageSettings);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPersonalizationAllUsersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetPersonalizationAllUsersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPageSettingsRDT(byte[] PageSettings)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPersonalizationAllUsersCollection = new EntityCollection(new AspnetPersonalizationAllUsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationAllUsersFields.PageSettings == PageSettings);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPersonalizationAllUsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPageSettingsRDT_Paged(byte[] PageSettings, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPersonalizationAllUsersCollection = new EntityCollection(new AspnetPersonalizationAllUsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationAllUsersFields.PageSettings == PageSettings);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPersonalizationAllUsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetPersonalizationAllUsersEntity>
		public EntityCollection<AspnetPersonalizationAllUsersEntity> SelectByLastUpdatedDateLST(DateTime LastUpdatedDate)
		{
			EntityCollection<AspnetPersonalizationAllUsersEntity> _AspnetPersonalizationAllUsersCollection = new EntityCollection<AspnetPersonalizationAllUsersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationAllUsersFields.LastUpdatedDate == LastUpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPersonalizationAllUsersCollection, filter, 0, null);
			}
			return _AspnetPersonalizationAllUsersCollection;
		}
		
		// Return EntityCollection<AspnetPersonalizationAllUsersEntity>
		public EntityCollection<AspnetPersonalizationAllUsersEntity> SelectByLastUpdatedDateLST_Paged(DateTime LastUpdatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetPersonalizationAllUsersEntity> _AspnetPersonalizationAllUsersCollection = new EntityCollection<AspnetPersonalizationAllUsersEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationAllUsersFields.LastUpdatedDate == LastUpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPersonalizationAllUsersCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetPersonalizationAllUsersCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLastUpdatedDateRDT(DateTime LastUpdatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPersonalizationAllUsersCollection = new EntityCollection(new AspnetPersonalizationAllUsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationAllUsersFields.LastUpdatedDate == LastUpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPersonalizationAllUsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLastUpdatedDateRDT_Paged(DateTime LastUpdatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPersonalizationAllUsersCollection = new EntityCollection(new AspnetPersonalizationAllUsersEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPersonalizationAllUsersFields.LastUpdatedDate == LastUpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPersonalizationAllUsersCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
