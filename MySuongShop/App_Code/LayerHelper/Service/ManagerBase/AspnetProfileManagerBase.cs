




/*
'===============================================================================
'  LayerHelper.Service.BL.AspnetProfileManagerBase
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
	public class AspnetProfileManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AspnetProfileManagerBase()
		{
			// Nothing for now.
		}
		
		public AspnetProfileEntity Insert(AspnetProfileEntity _AspnetProfileEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_AspnetProfileEntity, true);
			}
			return _AspnetProfileEntity;
		}

		
		public AspnetProfileEntity Insert(Guid UserId, string PropertyNames, string PropertyValuesString, byte[] PropertyValuesBinary, DateTime LastUpdatedDate)
		{
			AspnetProfileEntity _AspnetProfileEntity = new AspnetProfileEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AspnetProfileEntity.UserId = UserId;
				_AspnetProfileEntity.PropertyNames = PropertyNames;
				_AspnetProfileEntity.PropertyValuesString = PropertyValuesString;
				_AspnetProfileEntity.PropertyValuesBinary = PropertyValuesBinary;
				_AspnetProfileEntity.LastUpdatedDate = LastUpdatedDate;
				adapter.SaveEntity(_AspnetProfileEntity, true);
			}
			return _AspnetProfileEntity;
		}

		public AspnetProfileEntity Insert(string PropertyNames, string PropertyValuesString, byte[] PropertyValuesBinary, DateTime LastUpdatedDate)
		{
			AspnetProfileEntity _AspnetProfileEntity = new AspnetProfileEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AspnetProfileEntity.PropertyNames = PropertyNames;
				_AspnetProfileEntity.PropertyValuesString = PropertyValuesString;
				_AspnetProfileEntity.PropertyValuesBinary = PropertyValuesBinary;
				_AspnetProfileEntity.LastUpdatedDate = LastUpdatedDate;
				adapter.SaveEntity(_AspnetProfileEntity, true);
			}
			return _AspnetProfileEntity;
		}

		public bool Update(AspnetProfileEntity _AspnetProfileEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(AspnetProfileFields.UserId == _AspnetProfileEntity.UserId);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_AspnetProfileEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(AspnetProfileEntity _AspnetProfileEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_AspnetProfileEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid UserId, string PropertyNames, string PropertyValuesString, byte[] PropertyValuesBinary, DateTime LastUpdatedDate)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetProfileEntity _AspnetProfileEntity = new AspnetProfileEntity(UserId);
				if (adapter.FetchEntity(_AspnetProfileEntity))
				{
				
					_AspnetProfileEntity.PropertyNames = PropertyNames;
					_AspnetProfileEntity.PropertyValuesString = PropertyValuesString;
					_AspnetProfileEntity.PropertyValuesBinary = PropertyValuesBinary;
					_AspnetProfileEntity.LastUpdatedDate = LastUpdatedDate;
					adapter.SaveEntity(_AspnetProfileEntity, true);
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
				AspnetProfileEntity _AspnetProfileEntity = new AspnetProfileEntity(UserId);
				if (adapter.FetchEntity(_AspnetProfileEntity))
				{
					adapter.DeleteEntity(_AspnetProfileEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("AspnetProfileEntity", null);
			}
		}
		
		
		public int DeleteByUserId(Guid UserId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetProfileEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPropertyNames(string PropertyNames)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.PropertyNames == PropertyNames);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetProfileEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPropertyValuesString(string PropertyValuesString)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.PropertyValuesString == PropertyValuesString);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetProfileEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPropertyValuesBinary(byte[] PropertyValuesBinary)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.PropertyValuesBinary == PropertyValuesBinary);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetProfileEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLastUpdatedDate(DateTime LastUpdatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.LastUpdatedDate == LastUpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetProfileEntity", filter);
			}
			return toReturn;
		}
		

		
		public AspnetProfileEntity SelectOne(Guid UserId)
		{
			AspnetProfileEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetProfileEntity _AspnetProfileEntity = new AspnetProfileEntity(UserId);
				if (adapter.FetchEntity(_AspnetProfileEntity))
				{
					toReturn = _AspnetProfileEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetProfileCollection = new EntityCollection(new AspnetProfileEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetProfileCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<AspnetProfileEntity>
		public EntityCollection<AspnetProfileEntity> SelectAllLST()
		{
			EntityCollection<AspnetProfileEntity> _AspnetProfileCollection = new EntityCollection<AspnetProfileEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetProfileCollection, null, 0, null);
			}
			return _AspnetProfileCollection;
		}
		
		// Return EntityCollection<AspnetProfileEntity>
		public EntityCollection<AspnetProfileEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<AspnetProfileEntity> _AspnetProfileCollection = new EntityCollection<AspnetProfileEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetProfileCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetProfileCollection;
		}


		
		// Return EntityCollection<AspnetProfileEntity>
		public EntityCollection<AspnetProfileEntity> SelectByUserIdLST(Guid UserId)
		{
			EntityCollection<AspnetProfileEntity> _AspnetProfileCollection = new EntityCollection<AspnetProfileEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetProfileCollection, filter, 0, null);
			}
			return _AspnetProfileCollection;
		}
		
		// Return EntityCollection<AspnetProfileEntity>
		public EntityCollection<AspnetProfileEntity> SelectByUserIdLST_Paged(Guid UserId, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetProfileEntity> _AspnetProfileCollection = new EntityCollection<AspnetProfileEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetProfileCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetProfileCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUserIdRDT(Guid UserId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetProfileCollection = new EntityCollection(new AspnetProfileEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetProfileCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUserIdRDT_Paged(Guid UserId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetProfileCollection = new EntityCollection(new AspnetProfileEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetProfileCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetProfileEntity>
		public EntityCollection<AspnetProfileEntity> SelectByPropertyNamesLST(string PropertyNames)
		{
			EntityCollection<AspnetProfileEntity> _AspnetProfileCollection = new EntityCollection<AspnetProfileEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.PropertyNames == PropertyNames);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetProfileCollection, filter, 0, null);
			}
			return _AspnetProfileCollection;
		}
		
		// Return EntityCollection<AspnetProfileEntity>
		public EntityCollection<AspnetProfileEntity> SelectByPropertyNamesLST_Paged(string PropertyNames, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetProfileEntity> _AspnetProfileCollection = new EntityCollection<AspnetProfileEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.PropertyNames == PropertyNames);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetProfileCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetProfileCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPropertyNamesRDT(string PropertyNames)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetProfileCollection = new EntityCollection(new AspnetProfileEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.PropertyNames == PropertyNames);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetProfileCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPropertyNamesRDT_Paged(string PropertyNames, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetProfileCollection = new EntityCollection(new AspnetProfileEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.PropertyNames == PropertyNames);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetProfileCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetProfileEntity>
		public EntityCollection<AspnetProfileEntity> SelectByPropertyValuesStringLST(string PropertyValuesString)
		{
			EntityCollection<AspnetProfileEntity> _AspnetProfileCollection = new EntityCollection<AspnetProfileEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.PropertyValuesString == PropertyValuesString);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetProfileCollection, filter, 0, null);
			}
			return _AspnetProfileCollection;
		}
		
		// Return EntityCollection<AspnetProfileEntity>
		public EntityCollection<AspnetProfileEntity> SelectByPropertyValuesStringLST_Paged(string PropertyValuesString, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetProfileEntity> _AspnetProfileCollection = new EntityCollection<AspnetProfileEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.PropertyValuesString == PropertyValuesString);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetProfileCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetProfileCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPropertyValuesStringRDT(string PropertyValuesString)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetProfileCollection = new EntityCollection(new AspnetProfileEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.PropertyValuesString == PropertyValuesString);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetProfileCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPropertyValuesStringRDT_Paged(string PropertyValuesString, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetProfileCollection = new EntityCollection(new AspnetProfileEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.PropertyValuesString == PropertyValuesString);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetProfileCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetProfileEntity>
		public EntityCollection<AspnetProfileEntity> SelectByPropertyValuesBinaryLST(byte[] PropertyValuesBinary)
		{
			EntityCollection<AspnetProfileEntity> _AspnetProfileCollection = new EntityCollection<AspnetProfileEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.PropertyValuesBinary == PropertyValuesBinary);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetProfileCollection, filter, 0, null);
			}
			return _AspnetProfileCollection;
		}
		
		// Return EntityCollection<AspnetProfileEntity>
		public EntityCollection<AspnetProfileEntity> SelectByPropertyValuesBinaryLST_Paged(byte[] PropertyValuesBinary, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetProfileEntity> _AspnetProfileCollection = new EntityCollection<AspnetProfileEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.PropertyValuesBinary == PropertyValuesBinary);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetProfileCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetProfileCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPropertyValuesBinaryRDT(byte[] PropertyValuesBinary)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetProfileCollection = new EntityCollection(new AspnetProfileEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.PropertyValuesBinary == PropertyValuesBinary);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetProfileCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPropertyValuesBinaryRDT_Paged(byte[] PropertyValuesBinary, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetProfileCollection = new EntityCollection(new AspnetProfileEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.PropertyValuesBinary == PropertyValuesBinary);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetProfileCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetProfileEntity>
		public EntityCollection<AspnetProfileEntity> SelectByLastUpdatedDateLST(DateTime LastUpdatedDate)
		{
			EntityCollection<AspnetProfileEntity> _AspnetProfileCollection = new EntityCollection<AspnetProfileEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.LastUpdatedDate == LastUpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetProfileCollection, filter, 0, null);
			}
			return _AspnetProfileCollection;
		}
		
		// Return EntityCollection<AspnetProfileEntity>
		public EntityCollection<AspnetProfileEntity> SelectByLastUpdatedDateLST_Paged(DateTime LastUpdatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetProfileEntity> _AspnetProfileCollection = new EntityCollection<AspnetProfileEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.LastUpdatedDate == LastUpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetProfileCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetProfileCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLastUpdatedDateRDT(DateTime LastUpdatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetProfileCollection = new EntityCollection(new AspnetProfileEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.LastUpdatedDate == LastUpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetProfileCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLastUpdatedDateRDT_Paged(DateTime LastUpdatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetProfileCollection = new EntityCollection(new AspnetProfileEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetProfileFields.LastUpdatedDate == LastUpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetProfileCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
