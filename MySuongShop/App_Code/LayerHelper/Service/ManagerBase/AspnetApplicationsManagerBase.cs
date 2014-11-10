


/*
'===============================================================================
'  LayerHelper.Service.BL.AspnetApplicationsManagerBase
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
	public class AspnetApplicationsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AspnetApplicationsManagerBase()
		{
			// Nothing for now.
		}
		
		public AspnetApplicationsEntity Insert(AspnetApplicationsEntity _AspnetApplicationsEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_AspnetApplicationsEntity, true);
			}
			return _AspnetApplicationsEntity;
		}

		
		public AspnetApplicationsEntity Insert(string ApplicationName, string LoweredApplicationName, Guid ApplicationId, string Description)
		{
			AspnetApplicationsEntity _AspnetApplicationsEntity = new AspnetApplicationsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AspnetApplicationsEntity.ApplicationName = ApplicationName;
				_AspnetApplicationsEntity.LoweredApplicationName = LoweredApplicationName;
				_AspnetApplicationsEntity.ApplicationId = ApplicationId;
				_AspnetApplicationsEntity.Description = Description;
				adapter.SaveEntity(_AspnetApplicationsEntity, true);
			}
			return _AspnetApplicationsEntity;
		}

		public AspnetApplicationsEntity Insert(string ApplicationName, string LoweredApplicationName, string Description)
		{
			AspnetApplicationsEntity _AspnetApplicationsEntity = new AspnetApplicationsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AspnetApplicationsEntity.ApplicationName = ApplicationName;
				_AspnetApplicationsEntity.LoweredApplicationName = LoweredApplicationName;
				_AspnetApplicationsEntity.Description = Description;
				adapter.SaveEntity(_AspnetApplicationsEntity, true);
			}
			return _AspnetApplicationsEntity;
		}

		public bool Update(AspnetApplicationsEntity _AspnetApplicationsEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(AspnetApplicationsFields.ApplicationId == _AspnetApplicationsEntity.ApplicationId);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_AspnetApplicationsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(AspnetApplicationsEntity _AspnetApplicationsEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_AspnetApplicationsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(string ApplicationName, string LoweredApplicationName, Guid ApplicationId, string Description)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetApplicationsEntity _AspnetApplicationsEntity = new AspnetApplicationsEntity(ApplicationId);
				if (adapter.FetchEntity(_AspnetApplicationsEntity))
				{
				
					_AspnetApplicationsEntity.ApplicationName = ApplicationName;
					_AspnetApplicationsEntity.LoweredApplicationName = LoweredApplicationName;
					_AspnetApplicationsEntity.Description = Description;
					adapter.SaveEntity(_AspnetApplicationsEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(Guid ApplicationId)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetApplicationsEntity _AspnetApplicationsEntity = new AspnetApplicationsEntity(ApplicationId);
				if (adapter.FetchEntity(_AspnetApplicationsEntity))
				{
					adapter.DeleteEntity(_AspnetApplicationsEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("AspnetApplicationsEntity", null);
			}
		}
		
		
		public int DeleteByApplicationName(string ApplicationName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetApplicationsFields.ApplicationName == ApplicationName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetApplicationsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoweredApplicationName(string LoweredApplicationName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetApplicationsFields.LoweredApplicationName == LoweredApplicationName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetApplicationsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByApplicationId(Guid ApplicationId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetApplicationsFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetApplicationsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDescription(string Description)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetApplicationsFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetApplicationsEntity", filter);
			}
			return toReturn;
		}
		

		
		public AspnetApplicationsEntity SelectOne(Guid ApplicationId)
		{
			AspnetApplicationsEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetApplicationsEntity _AspnetApplicationsEntity = new AspnetApplicationsEntity(ApplicationId);
				if (adapter.FetchEntity(_AspnetApplicationsEntity))
				{
					toReturn = _AspnetApplicationsEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetApplicationsCollection = new EntityCollection(new AspnetApplicationsEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetApplicationsCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<AspnetApplicationsEntity>
		public EntityCollection<AspnetApplicationsEntity> SelectAllLST()
		{
			EntityCollection<AspnetApplicationsEntity> _AspnetApplicationsCollection = new EntityCollection<AspnetApplicationsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetApplicationsCollection, null, 0, null);
			}
			return _AspnetApplicationsCollection;
		}
		
		// Return EntityCollection<AspnetApplicationsEntity>
		public EntityCollection<AspnetApplicationsEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<AspnetApplicationsEntity> _AspnetApplicationsCollection = new EntityCollection<AspnetApplicationsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetApplicationsCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetApplicationsCollection;
		}


		
		// Return EntityCollection<AspnetApplicationsEntity>
		public EntityCollection<AspnetApplicationsEntity> SelectByApplicationNameLST(string ApplicationName)
		{
			EntityCollection<AspnetApplicationsEntity> _AspnetApplicationsCollection = new EntityCollection<AspnetApplicationsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetApplicationsFields.ApplicationName == ApplicationName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetApplicationsCollection, filter, 0, null);
			}
			return _AspnetApplicationsCollection;
		}
		
		// Return EntityCollection<AspnetApplicationsEntity>
		public EntityCollection<AspnetApplicationsEntity> SelectByApplicationNameLST_Paged(string ApplicationName, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetApplicationsEntity> _AspnetApplicationsCollection = new EntityCollection<AspnetApplicationsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetApplicationsFields.ApplicationName == ApplicationName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetApplicationsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetApplicationsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByApplicationNameRDT(string ApplicationName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetApplicationsCollection = new EntityCollection(new AspnetApplicationsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetApplicationsFields.ApplicationName == ApplicationName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetApplicationsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByApplicationNameRDT_Paged(string ApplicationName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetApplicationsCollection = new EntityCollection(new AspnetApplicationsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetApplicationsFields.ApplicationName == ApplicationName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetApplicationsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetApplicationsEntity>
		public EntityCollection<AspnetApplicationsEntity> SelectByLoweredApplicationNameLST(string LoweredApplicationName)
		{
			EntityCollection<AspnetApplicationsEntity> _AspnetApplicationsCollection = new EntityCollection<AspnetApplicationsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetApplicationsFields.LoweredApplicationName == LoweredApplicationName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetApplicationsCollection, filter, 0, null);
			}
			return _AspnetApplicationsCollection;
		}
		
		// Return EntityCollection<AspnetApplicationsEntity>
		public EntityCollection<AspnetApplicationsEntity> SelectByLoweredApplicationNameLST_Paged(string LoweredApplicationName, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetApplicationsEntity> _AspnetApplicationsCollection = new EntityCollection<AspnetApplicationsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetApplicationsFields.LoweredApplicationName == LoweredApplicationName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetApplicationsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetApplicationsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoweredApplicationNameRDT(string LoweredApplicationName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetApplicationsCollection = new EntityCollection(new AspnetApplicationsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetApplicationsFields.LoweredApplicationName == LoweredApplicationName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetApplicationsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoweredApplicationNameRDT_Paged(string LoweredApplicationName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetApplicationsCollection = new EntityCollection(new AspnetApplicationsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetApplicationsFields.LoweredApplicationName == LoweredApplicationName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetApplicationsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetApplicationsEntity>
		public EntityCollection<AspnetApplicationsEntity> SelectByApplicationIdLST(Guid ApplicationId)
		{
			EntityCollection<AspnetApplicationsEntity> _AspnetApplicationsCollection = new EntityCollection<AspnetApplicationsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetApplicationsFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetApplicationsCollection, filter, 0, null);
			}
			return _AspnetApplicationsCollection;
		}
		
		// Return EntityCollection<AspnetApplicationsEntity>
		public EntityCollection<AspnetApplicationsEntity> SelectByApplicationIdLST_Paged(Guid ApplicationId, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetApplicationsEntity> _AspnetApplicationsCollection = new EntityCollection<AspnetApplicationsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetApplicationsFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetApplicationsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetApplicationsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByApplicationIdRDT(Guid ApplicationId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetApplicationsCollection = new EntityCollection(new AspnetApplicationsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetApplicationsFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetApplicationsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByApplicationIdRDT_Paged(Guid ApplicationId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetApplicationsCollection = new EntityCollection(new AspnetApplicationsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetApplicationsFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetApplicationsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetApplicationsEntity>
		public EntityCollection<AspnetApplicationsEntity> SelectByDescriptionLST(string Description)
		{
			EntityCollection<AspnetApplicationsEntity> _AspnetApplicationsCollection = new EntityCollection<AspnetApplicationsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetApplicationsFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetApplicationsCollection, filter, 0, null);
			}
			return _AspnetApplicationsCollection;
		}
		
		// Return EntityCollection<AspnetApplicationsEntity>
		public EntityCollection<AspnetApplicationsEntity> SelectByDescriptionLST_Paged(string Description, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetApplicationsEntity> _AspnetApplicationsCollection = new EntityCollection<AspnetApplicationsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetApplicationsFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetApplicationsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetApplicationsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDescriptionRDT(string Description)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetApplicationsCollection = new EntityCollection(new AspnetApplicationsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetApplicationsFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetApplicationsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDescriptionRDT_Paged(string Description, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetApplicationsCollection = new EntityCollection(new AspnetApplicationsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetApplicationsFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetApplicationsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
