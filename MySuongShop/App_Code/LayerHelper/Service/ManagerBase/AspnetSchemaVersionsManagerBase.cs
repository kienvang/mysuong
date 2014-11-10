




/*
'===============================================================================
'  LayerHelper.Service.BL.AspnetSchemaVersionsManagerBase
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
	public class AspnetSchemaVersionsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AspnetSchemaVersionsManagerBase()
		{
			// Nothing for now.
		}
		
		public AspnetSchemaVersionsEntity Insert(AspnetSchemaVersionsEntity _AspnetSchemaVersionsEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_AspnetSchemaVersionsEntity, true);
			}
			return _AspnetSchemaVersionsEntity;
		}

		
		public AspnetSchemaVersionsEntity Insert(string Feature, string CompatibleSchemaVersion, bool IsCurrentVersion)
		{
			AspnetSchemaVersionsEntity _AspnetSchemaVersionsEntity = new AspnetSchemaVersionsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AspnetSchemaVersionsEntity.Feature = Feature;
				_AspnetSchemaVersionsEntity.CompatibleSchemaVersion = CompatibleSchemaVersion;
				_AspnetSchemaVersionsEntity.IsCurrentVersion = IsCurrentVersion;
				adapter.SaveEntity(_AspnetSchemaVersionsEntity, true);
			}
			return _AspnetSchemaVersionsEntity;
		}

		public AspnetSchemaVersionsEntity Insert(bool IsCurrentVersion)
		{
			AspnetSchemaVersionsEntity _AspnetSchemaVersionsEntity = new AspnetSchemaVersionsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AspnetSchemaVersionsEntity.IsCurrentVersion = IsCurrentVersion;
				adapter.SaveEntity(_AspnetSchemaVersionsEntity, true);
			}
			return _AspnetSchemaVersionsEntity;
		}

		public bool Update(AspnetSchemaVersionsEntity _AspnetSchemaVersionsEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(AspnetSchemaVersionsFields.Feature == _AspnetSchemaVersionsEntity.Feature);
					_PredicateExpression.Add(AspnetSchemaVersionsFields.CompatibleSchemaVersion == _AspnetSchemaVersionsEntity.CompatibleSchemaVersion);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_AspnetSchemaVersionsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(AspnetSchemaVersionsEntity _AspnetSchemaVersionsEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_AspnetSchemaVersionsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(string Feature, string CompatibleSchemaVersion, bool IsCurrentVersion)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetSchemaVersionsEntity _AspnetSchemaVersionsEntity = new AspnetSchemaVersionsEntity(Feature, CompatibleSchemaVersion);
				if (adapter.FetchEntity(_AspnetSchemaVersionsEntity))
				{
				
					_AspnetSchemaVersionsEntity.IsCurrentVersion = IsCurrentVersion;
					adapter.SaveEntity(_AspnetSchemaVersionsEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(string Feature, string CompatibleSchemaVersion)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetSchemaVersionsEntity _AspnetSchemaVersionsEntity = new AspnetSchemaVersionsEntity(Feature, CompatibleSchemaVersion);
				if (adapter.FetchEntity(_AspnetSchemaVersionsEntity))
				{
					adapter.DeleteEntity(_AspnetSchemaVersionsEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("AspnetSchemaVersionsEntity", null);
			}
		}
		
		
		public int DeleteByFeature(string Feature)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetSchemaVersionsFields.Feature == Feature);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetSchemaVersionsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCompatibleSchemaVersion(string CompatibleSchemaVersion)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetSchemaVersionsFields.CompatibleSchemaVersion == CompatibleSchemaVersion);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetSchemaVersionsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsCurrentVersion(bool IsCurrentVersion)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetSchemaVersionsFields.IsCurrentVersion == IsCurrentVersion);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetSchemaVersionsEntity", filter);
			}
			return toReturn;
		}
		

		
		public AspnetSchemaVersionsEntity SelectOne(string Feature, string CompatibleSchemaVersion)
		{
			AspnetSchemaVersionsEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetSchemaVersionsEntity _AspnetSchemaVersionsEntity = new AspnetSchemaVersionsEntity(Feature, CompatibleSchemaVersion);
				if (adapter.FetchEntity(_AspnetSchemaVersionsEntity))
				{
					toReturn = _AspnetSchemaVersionsEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetSchemaVersionsCollection = new EntityCollection(new AspnetSchemaVersionsEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetSchemaVersionsCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<AspnetSchemaVersionsEntity>
		public EntityCollection<AspnetSchemaVersionsEntity> SelectAllLST()
		{
			EntityCollection<AspnetSchemaVersionsEntity> _AspnetSchemaVersionsCollection = new EntityCollection<AspnetSchemaVersionsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetSchemaVersionsCollection, null, 0, null);
			}
			return _AspnetSchemaVersionsCollection;
		}
		
		// Return EntityCollection<AspnetSchemaVersionsEntity>
		public EntityCollection<AspnetSchemaVersionsEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<AspnetSchemaVersionsEntity> _AspnetSchemaVersionsCollection = new EntityCollection<AspnetSchemaVersionsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetSchemaVersionsCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetSchemaVersionsCollection;
		}


		
		// Return EntityCollection<AspnetSchemaVersionsEntity>
		public EntityCollection<AspnetSchemaVersionsEntity> SelectByFeatureLST(string Feature)
		{
			EntityCollection<AspnetSchemaVersionsEntity> _AspnetSchemaVersionsCollection = new EntityCollection<AspnetSchemaVersionsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetSchemaVersionsFields.Feature == Feature);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetSchemaVersionsCollection, filter, 0, null);
			}
			return _AspnetSchemaVersionsCollection;
		}
		
		// Return EntityCollection<AspnetSchemaVersionsEntity>
		public EntityCollection<AspnetSchemaVersionsEntity> SelectByFeatureLST_Paged(string Feature, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetSchemaVersionsEntity> _AspnetSchemaVersionsCollection = new EntityCollection<AspnetSchemaVersionsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetSchemaVersionsFields.Feature == Feature);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetSchemaVersionsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetSchemaVersionsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByFeatureRDT(string Feature)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetSchemaVersionsCollection = new EntityCollection(new AspnetSchemaVersionsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetSchemaVersionsFields.Feature == Feature);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetSchemaVersionsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByFeatureRDT_Paged(string Feature, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetSchemaVersionsCollection = new EntityCollection(new AspnetSchemaVersionsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetSchemaVersionsFields.Feature == Feature);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetSchemaVersionsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetSchemaVersionsEntity>
		public EntityCollection<AspnetSchemaVersionsEntity> SelectByCompatibleSchemaVersionLST(string CompatibleSchemaVersion)
		{
			EntityCollection<AspnetSchemaVersionsEntity> _AspnetSchemaVersionsCollection = new EntityCollection<AspnetSchemaVersionsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetSchemaVersionsFields.CompatibleSchemaVersion == CompatibleSchemaVersion);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetSchemaVersionsCollection, filter, 0, null);
			}
			return _AspnetSchemaVersionsCollection;
		}
		
		// Return EntityCollection<AspnetSchemaVersionsEntity>
		public EntityCollection<AspnetSchemaVersionsEntity> SelectByCompatibleSchemaVersionLST_Paged(string CompatibleSchemaVersion, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetSchemaVersionsEntity> _AspnetSchemaVersionsCollection = new EntityCollection<AspnetSchemaVersionsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetSchemaVersionsFields.CompatibleSchemaVersion == CompatibleSchemaVersion);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetSchemaVersionsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetSchemaVersionsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCompatibleSchemaVersionRDT(string CompatibleSchemaVersion)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetSchemaVersionsCollection = new EntityCollection(new AspnetSchemaVersionsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetSchemaVersionsFields.CompatibleSchemaVersion == CompatibleSchemaVersion);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetSchemaVersionsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCompatibleSchemaVersionRDT_Paged(string CompatibleSchemaVersion, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetSchemaVersionsCollection = new EntityCollection(new AspnetSchemaVersionsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetSchemaVersionsFields.CompatibleSchemaVersion == CompatibleSchemaVersion);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetSchemaVersionsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetSchemaVersionsEntity>
		public EntityCollection<AspnetSchemaVersionsEntity> SelectByIsCurrentVersionLST(bool IsCurrentVersion)
		{
			EntityCollection<AspnetSchemaVersionsEntity> _AspnetSchemaVersionsCollection = new EntityCollection<AspnetSchemaVersionsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetSchemaVersionsFields.IsCurrentVersion == IsCurrentVersion);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetSchemaVersionsCollection, filter, 0, null);
			}
			return _AspnetSchemaVersionsCollection;
		}
		
		// Return EntityCollection<AspnetSchemaVersionsEntity>
		public EntityCollection<AspnetSchemaVersionsEntity> SelectByIsCurrentVersionLST_Paged(bool IsCurrentVersion, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetSchemaVersionsEntity> _AspnetSchemaVersionsCollection = new EntityCollection<AspnetSchemaVersionsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetSchemaVersionsFields.IsCurrentVersion == IsCurrentVersion);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetSchemaVersionsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetSchemaVersionsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsCurrentVersionRDT(bool IsCurrentVersion)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetSchemaVersionsCollection = new EntityCollection(new AspnetSchemaVersionsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetSchemaVersionsFields.IsCurrentVersion == IsCurrentVersion);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetSchemaVersionsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsCurrentVersionRDT_Paged(bool IsCurrentVersion, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetSchemaVersionsCollection = new EntityCollection(new AspnetSchemaVersionsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetSchemaVersionsFields.IsCurrentVersion == IsCurrentVersion);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetSchemaVersionsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
