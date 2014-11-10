




/*
'===============================================================================
'  LayerHelper.Service.BL.AspnetPathsManagerBase
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
	public class AspnetPathsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AspnetPathsManagerBase()
		{
			// Nothing for now.
		}
		
		public AspnetPathsEntity Insert(AspnetPathsEntity _AspnetPathsEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_AspnetPathsEntity, true);
			}
			return _AspnetPathsEntity;
		}

		
		public AspnetPathsEntity Insert(Guid ApplicationId, Guid PathId, string Path, string LoweredPath)
		{
			AspnetPathsEntity _AspnetPathsEntity = new AspnetPathsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AspnetPathsEntity.ApplicationId = ApplicationId;
				_AspnetPathsEntity.PathId = PathId;
				_AspnetPathsEntity.Path = Path;
				_AspnetPathsEntity.LoweredPath = LoweredPath;
				adapter.SaveEntity(_AspnetPathsEntity, true);
			}
			return _AspnetPathsEntity;
		}

		public AspnetPathsEntity Insert(Guid ApplicationId, string Path, string LoweredPath)
		{
			AspnetPathsEntity _AspnetPathsEntity = new AspnetPathsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AspnetPathsEntity.ApplicationId = ApplicationId;
				_AspnetPathsEntity.Path = Path;
				_AspnetPathsEntity.LoweredPath = LoweredPath;
				adapter.SaveEntity(_AspnetPathsEntity, true);
			}
			return _AspnetPathsEntity;
		}

		public bool Update(AspnetPathsEntity _AspnetPathsEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(AspnetPathsFields.PathId == _AspnetPathsEntity.PathId);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_AspnetPathsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(AspnetPathsEntity _AspnetPathsEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_AspnetPathsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid ApplicationId, Guid PathId, string Path, string LoweredPath)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetPathsEntity _AspnetPathsEntity = new AspnetPathsEntity(PathId);
				if (adapter.FetchEntity(_AspnetPathsEntity))
				{
				
					_AspnetPathsEntity.ApplicationId = ApplicationId;
					_AspnetPathsEntity.Path = Path;
					_AspnetPathsEntity.LoweredPath = LoweredPath;
					adapter.SaveEntity(_AspnetPathsEntity, true);
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
				AspnetPathsEntity _AspnetPathsEntity = new AspnetPathsEntity(PathId);
				if (adapter.FetchEntity(_AspnetPathsEntity))
				{
					adapter.DeleteEntity(_AspnetPathsEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("AspnetPathsEntity", null);
			}
		}
		
		
		public int DeleteByApplicationId(Guid ApplicationId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPathsFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetPathsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPathId(Guid PathId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPathsFields.PathId == PathId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetPathsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPath(string Path)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPathsFields.Path == Path);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetPathsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoweredPath(string LoweredPath)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPathsFields.LoweredPath == LoweredPath);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetPathsEntity", filter);
			}
			return toReturn;
		}
		

		
		public AspnetPathsEntity SelectOne(Guid PathId)
		{
			AspnetPathsEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetPathsEntity _AspnetPathsEntity = new AspnetPathsEntity(PathId);
				if (adapter.FetchEntity(_AspnetPathsEntity))
				{
					toReturn = _AspnetPathsEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPathsCollection = new EntityCollection(new AspnetPathsEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPathsCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<AspnetPathsEntity>
		public EntityCollection<AspnetPathsEntity> SelectAllLST()
		{
			EntityCollection<AspnetPathsEntity> _AspnetPathsCollection = new EntityCollection<AspnetPathsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPathsCollection, null, 0, null);
			}
			return _AspnetPathsCollection;
		}
		
		// Return EntityCollection<AspnetPathsEntity>
		public EntityCollection<AspnetPathsEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<AspnetPathsEntity> _AspnetPathsCollection = new EntityCollection<AspnetPathsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPathsCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetPathsCollection;
		}


		
		// Return EntityCollection<AspnetPathsEntity>
		public EntityCollection<AspnetPathsEntity> SelectByApplicationIdLST(Guid ApplicationId)
		{
			EntityCollection<AspnetPathsEntity> _AspnetPathsCollection = new EntityCollection<AspnetPathsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPathsFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPathsCollection, filter, 0, null);
			}
			return _AspnetPathsCollection;
		}
		
		// Return EntityCollection<AspnetPathsEntity>
		public EntityCollection<AspnetPathsEntity> SelectByApplicationIdLST_Paged(Guid ApplicationId, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetPathsEntity> _AspnetPathsCollection = new EntityCollection<AspnetPathsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPathsFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPathsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetPathsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByApplicationIdRDT(Guid ApplicationId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPathsCollection = new EntityCollection(new AspnetPathsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPathsFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPathsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByApplicationIdRDT_Paged(Guid ApplicationId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPathsCollection = new EntityCollection(new AspnetPathsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPathsFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPathsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetPathsEntity>
		public EntityCollection<AspnetPathsEntity> SelectByPathIdLST(Guid PathId)
		{
			EntityCollection<AspnetPathsEntity> _AspnetPathsCollection = new EntityCollection<AspnetPathsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPathsFields.PathId == PathId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPathsCollection, filter, 0, null);
			}
			return _AspnetPathsCollection;
		}
		
		// Return EntityCollection<AspnetPathsEntity>
		public EntityCollection<AspnetPathsEntity> SelectByPathIdLST_Paged(Guid PathId, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetPathsEntity> _AspnetPathsCollection = new EntityCollection<AspnetPathsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPathsFields.PathId == PathId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPathsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetPathsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPathIdRDT(Guid PathId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPathsCollection = new EntityCollection(new AspnetPathsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPathsFields.PathId == PathId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPathsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPathIdRDT_Paged(Guid PathId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPathsCollection = new EntityCollection(new AspnetPathsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPathsFields.PathId == PathId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPathsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetPathsEntity>
		public EntityCollection<AspnetPathsEntity> SelectByPathLST(string Path)
		{
			EntityCollection<AspnetPathsEntity> _AspnetPathsCollection = new EntityCollection<AspnetPathsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPathsFields.Path == Path);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPathsCollection, filter, 0, null);
			}
			return _AspnetPathsCollection;
		}
		
		// Return EntityCollection<AspnetPathsEntity>
		public EntityCollection<AspnetPathsEntity> SelectByPathLST_Paged(string Path, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetPathsEntity> _AspnetPathsCollection = new EntityCollection<AspnetPathsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPathsFields.Path == Path);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPathsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetPathsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPathRDT(string Path)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPathsCollection = new EntityCollection(new AspnetPathsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPathsFields.Path == Path);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPathsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPathRDT_Paged(string Path, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPathsCollection = new EntityCollection(new AspnetPathsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPathsFields.Path == Path);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPathsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetPathsEntity>
		public EntityCollection<AspnetPathsEntity> SelectByLoweredPathLST(string LoweredPath)
		{
			EntityCollection<AspnetPathsEntity> _AspnetPathsCollection = new EntityCollection<AspnetPathsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPathsFields.LoweredPath == LoweredPath);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPathsCollection, filter, 0, null);
			}
			return _AspnetPathsCollection;
		}
		
		// Return EntityCollection<AspnetPathsEntity>
		public EntityCollection<AspnetPathsEntity> SelectByLoweredPathLST_Paged(string LoweredPath, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetPathsEntity> _AspnetPathsCollection = new EntityCollection<AspnetPathsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPathsFields.LoweredPath == LoweredPath);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetPathsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetPathsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoweredPathRDT(string LoweredPath)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPathsCollection = new EntityCollection(new AspnetPathsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPathsFields.LoweredPath == LoweredPath);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPathsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoweredPathRDT_Paged(string LoweredPath, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetPathsCollection = new EntityCollection(new AspnetPathsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetPathsFields.LoweredPath == LoweredPath);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetPathsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
