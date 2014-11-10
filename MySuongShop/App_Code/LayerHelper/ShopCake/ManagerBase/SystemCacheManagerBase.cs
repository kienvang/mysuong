




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.SystemCacheManagerBase
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LayerHelper.ShopCake.BLL;
using LayerHelper.ShopCake.DAL;
using LayerHelper.ShopCake.DAL.EntityClasses;
using LayerHelper.ShopCake.DAL.FactoryClasses;
using LayerHelper.ShopCake.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LayerHelper.ShopCake.BLL
{
	public class SystemCacheManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public SystemCacheManagerBase()
		{
			// Nothing for now.
		}
		
		public SystemCacheEntity Insert(SystemCacheEntity _SystemCacheEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_SystemCacheEntity, true);
			}
			return _SystemCacheEntity;
		}

		
		public SystemCacheEntity Insert(string Id, string Data, string DataType, int TimeOut)
		{
			SystemCacheEntity _SystemCacheEntity = new SystemCacheEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_SystemCacheEntity.Id = Id;
				_SystemCacheEntity.Data = Data;
				_SystemCacheEntity.DataType = DataType;
				_SystemCacheEntity.TimeOut = TimeOut;
				adapter.SaveEntity(_SystemCacheEntity, true);
			}
			return _SystemCacheEntity;
		}

		public SystemCacheEntity Insert(string Data, string DataType, int TimeOut)
		{
			SystemCacheEntity _SystemCacheEntity = new SystemCacheEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_SystemCacheEntity.Data = Data;
				_SystemCacheEntity.DataType = DataType;
				_SystemCacheEntity.TimeOut = TimeOut;
				adapter.SaveEntity(_SystemCacheEntity, true);
			}
			return _SystemCacheEntity;
		}

		public bool Update(SystemCacheEntity _SystemCacheEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(SystemCacheFields.Id == _SystemCacheEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_SystemCacheEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(SystemCacheEntity _SystemCacheEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_SystemCacheEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(string Id, string Data, string DataType, int TimeOut)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				SystemCacheEntity _SystemCacheEntity = new SystemCacheEntity(Id);
				if (adapter.FetchEntity(_SystemCacheEntity))
				{
				
					_SystemCacheEntity.Data = Data;
					_SystemCacheEntity.DataType = DataType;
					_SystemCacheEntity.TimeOut = TimeOut;
					adapter.SaveEntity(_SystemCacheEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(string Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				SystemCacheEntity _SystemCacheEntity = new SystemCacheEntity(Id);
				if (adapter.FetchEntity(_SystemCacheEntity))
				{
					adapter.DeleteEntity(_SystemCacheEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("SystemCacheEntity", null);
			}
		}
		
		
		public int DeleteById(string Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SystemCacheFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SystemCacheEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByData(string Data)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SystemCacheFields.Data == Data);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SystemCacheEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDataType(string DataType)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SystemCacheFields.DataType == DataType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SystemCacheEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTimeOut(int TimeOut)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SystemCacheFields.TimeOut == TimeOut);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("SystemCacheEntity", filter);
			}
			return toReturn;
		}
		

		
		public SystemCacheEntity SelectOne(string Id)
		{
			SystemCacheEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				SystemCacheEntity _SystemCacheEntity = new SystemCacheEntity(Id);
				if (adapter.FetchEntity(_SystemCacheEntity))
				{
					toReturn = _SystemCacheEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SystemCacheCollection = new EntityCollection(new SystemCacheEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SystemCacheCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<SystemCacheEntity>
		public EntityCollection<SystemCacheEntity> SelectAllLST()
		{
			EntityCollection<SystemCacheEntity> _SystemCacheCollection = new EntityCollection<SystemCacheEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SystemCacheCollection, null, 0, null);
			}
			return _SystemCacheCollection;
		}
		
		// Return EntityCollection<SystemCacheEntity>
		public EntityCollection<SystemCacheEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<SystemCacheEntity> _SystemCacheCollection = new EntityCollection<SystemCacheEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SystemCacheCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _SystemCacheCollection;
		}


		
		// Return EntityCollection<SystemCacheEntity>
		public EntityCollection<SystemCacheEntity> SelectByIdLST(string Id)
		{
			EntityCollection<SystemCacheEntity> _SystemCacheCollection = new EntityCollection<SystemCacheEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SystemCacheFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SystemCacheCollection, filter, 0, null);
			}
			return _SystemCacheCollection;
		}
		
		// Return EntityCollection<SystemCacheEntity>
		public EntityCollection<SystemCacheEntity> SelectByIdLST_Paged(string Id, int PageNumber, int PageSize)
		{
			EntityCollection<SystemCacheEntity> _SystemCacheCollection = new EntityCollection<SystemCacheEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SystemCacheFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SystemCacheCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SystemCacheCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(string Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SystemCacheCollection = new EntityCollection(new SystemCacheEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SystemCacheFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SystemCacheCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(string Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SystemCacheCollection = new EntityCollection(new SystemCacheEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SystemCacheFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SystemCacheCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SystemCacheEntity>
		public EntityCollection<SystemCacheEntity> SelectByDataLST(string Data)
		{
			EntityCollection<SystemCacheEntity> _SystemCacheCollection = new EntityCollection<SystemCacheEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SystemCacheFields.Data == Data);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SystemCacheCollection, filter, 0, null);
			}
			return _SystemCacheCollection;
		}
		
		// Return EntityCollection<SystemCacheEntity>
		public EntityCollection<SystemCacheEntity> SelectByDataLST_Paged(string Data, int PageNumber, int PageSize)
		{
			EntityCollection<SystemCacheEntity> _SystemCacheCollection = new EntityCollection<SystemCacheEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SystemCacheFields.Data == Data);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SystemCacheCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SystemCacheCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDataRDT(string Data)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SystemCacheCollection = new EntityCollection(new SystemCacheEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SystemCacheFields.Data == Data);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SystemCacheCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDataRDT_Paged(string Data, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SystemCacheCollection = new EntityCollection(new SystemCacheEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SystemCacheFields.Data == Data);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SystemCacheCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SystemCacheEntity>
		public EntityCollection<SystemCacheEntity> SelectByDataTypeLST(string DataType)
		{
			EntityCollection<SystemCacheEntity> _SystemCacheCollection = new EntityCollection<SystemCacheEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SystemCacheFields.DataType == DataType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SystemCacheCollection, filter, 0, null);
			}
			return _SystemCacheCollection;
		}
		
		// Return EntityCollection<SystemCacheEntity>
		public EntityCollection<SystemCacheEntity> SelectByDataTypeLST_Paged(string DataType, int PageNumber, int PageSize)
		{
			EntityCollection<SystemCacheEntity> _SystemCacheCollection = new EntityCollection<SystemCacheEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SystemCacheFields.DataType == DataType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SystemCacheCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SystemCacheCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDataTypeRDT(string DataType)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SystemCacheCollection = new EntityCollection(new SystemCacheEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SystemCacheFields.DataType == DataType);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SystemCacheCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDataTypeRDT_Paged(string DataType, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SystemCacheCollection = new EntityCollection(new SystemCacheEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SystemCacheFields.DataType == DataType);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SystemCacheCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<SystemCacheEntity>
		public EntityCollection<SystemCacheEntity> SelectByTimeOutLST(int TimeOut)
		{
			EntityCollection<SystemCacheEntity> _SystemCacheCollection = new EntityCollection<SystemCacheEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SystemCacheFields.TimeOut == TimeOut);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SystemCacheCollection, filter, 0, null);
			}
			return _SystemCacheCollection;
		}
		
		// Return EntityCollection<SystemCacheEntity>
		public EntityCollection<SystemCacheEntity> SelectByTimeOutLST_Paged(int TimeOut, int PageNumber, int PageSize)
		{
			EntityCollection<SystemCacheEntity> _SystemCacheCollection = new EntityCollection<SystemCacheEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SystemCacheFields.TimeOut == TimeOut);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_SystemCacheCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _SystemCacheCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTimeOutRDT(int TimeOut)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SystemCacheCollection = new EntityCollection(new SystemCacheEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SystemCacheFields.TimeOut == TimeOut);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SystemCacheCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTimeOutRDT_Paged(int TimeOut, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _SystemCacheCollection = new EntityCollection(new SystemCacheEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(SystemCacheFields.TimeOut == TimeOut);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_SystemCacheCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
