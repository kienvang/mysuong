




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.CustomerGroupManagerBase
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
	public class CustomerGroupManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CustomerGroupManagerBase()
		{
			// Nothing for now.
		}
		
		public CustomerGroupEntity Insert(CustomerGroupEntity _CustomerGroupEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_CustomerGroupEntity, true);
			}
			return _CustomerGroupEntity;
		}

		
		public CustomerGroupEntity Insert(Guid Id, string Name, bool IsEnable)
		{
			CustomerGroupEntity _CustomerGroupEntity = new CustomerGroupEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_CustomerGroupEntity.Id = Id;
				_CustomerGroupEntity.Name = Name;
				_CustomerGroupEntity.IsEnable = IsEnable;
				adapter.SaveEntity(_CustomerGroupEntity, true);
			}
			return _CustomerGroupEntity;
		}

		public CustomerGroupEntity Insert(string Name, bool IsEnable)
		{
			CustomerGroupEntity _CustomerGroupEntity = new CustomerGroupEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_CustomerGroupEntity.Name = Name;
				_CustomerGroupEntity.IsEnable = IsEnable;
				adapter.SaveEntity(_CustomerGroupEntity, true);
			}
			return _CustomerGroupEntity;
		}

		public bool Update(CustomerGroupEntity _CustomerGroupEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(CustomerGroupFields.Id == _CustomerGroupEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_CustomerGroupEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(CustomerGroupEntity _CustomerGroupEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_CustomerGroupEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string Name, bool IsEnable)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CustomerGroupEntity _CustomerGroupEntity = new CustomerGroupEntity(Id);
				if (adapter.FetchEntity(_CustomerGroupEntity))
				{
				
					_CustomerGroupEntity.Name = Name;
					_CustomerGroupEntity.IsEnable = IsEnable;
					adapter.SaveEntity(_CustomerGroupEntity, true);
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
				CustomerGroupEntity _CustomerGroupEntity = new CustomerGroupEntity(Id);
				if (adapter.FetchEntity(_CustomerGroupEntity))
				{
					adapter.DeleteEntity(_CustomerGroupEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("CustomerGroupEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomerGroupEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByName(string Name)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerGroupFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomerGroupEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsEnable(bool IsEnable)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerGroupFields.IsEnable == IsEnable);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomerGroupEntity", filter);
			}
			return toReturn;
		}
		

		
		public CustomerGroupEntity SelectOne(Guid Id)
		{
			CustomerGroupEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CustomerGroupEntity _CustomerGroupEntity = new CustomerGroupEntity(Id);
				if (adapter.FetchEntity(_CustomerGroupEntity))
				{
					toReturn = _CustomerGroupEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerGroupCollection = new EntityCollection(new CustomerGroupEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<CustomerGroupEntity>
		public EntityCollection<CustomerGroupEntity> SelectAllLST()
		{
			EntityCollection<CustomerGroupEntity> _CustomerGroupCollection = new EntityCollection<CustomerGroupEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerGroupCollection, null, 0, null);
			}
			return _CustomerGroupCollection;
		}
		
		// Return EntityCollection<CustomerGroupEntity>
		public EntityCollection<CustomerGroupEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<CustomerGroupEntity> _CustomerGroupCollection = new EntityCollection<CustomerGroupEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerGroupCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _CustomerGroupCollection;
		}


		
		// Return EntityCollection<CustomerGroupEntity>
		public EntityCollection<CustomerGroupEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<CustomerGroupEntity> _CustomerGroupCollection = new EntityCollection<CustomerGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerGroupCollection, filter, 0, null);
			}
			return _CustomerGroupCollection;
		}
		
		// Return EntityCollection<CustomerGroupEntity>
		public EntityCollection<CustomerGroupEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<CustomerGroupEntity> _CustomerGroupCollection = new EntityCollection<CustomerGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomerGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerGroupCollection = new EntityCollection(new CustomerGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerGroupCollection = new EntityCollection(new CustomerGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomerGroupEntity>
		public EntityCollection<CustomerGroupEntity> SelectByNameLST(string Name)
		{
			EntityCollection<CustomerGroupEntity> _CustomerGroupCollection = new EntityCollection<CustomerGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerGroupFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerGroupCollection, filter, 0, null);
			}
			return _CustomerGroupCollection;
		}
		
		// Return EntityCollection<CustomerGroupEntity>
		public EntityCollection<CustomerGroupEntity> SelectByNameLST_Paged(string Name, int PageNumber, int PageSize)
		{
			EntityCollection<CustomerGroupEntity> _CustomerGroupCollection = new EntityCollection<CustomerGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerGroupFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomerGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNameRDT(string Name)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerGroupCollection = new EntityCollection(new CustomerGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerGroupFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNameRDT_Paged(string Name, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerGroupCollection = new EntityCollection(new CustomerGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerGroupFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomerGroupEntity>
		public EntityCollection<CustomerGroupEntity> SelectByIsEnableLST(bool IsEnable)
		{
			EntityCollection<CustomerGroupEntity> _CustomerGroupCollection = new EntityCollection<CustomerGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerGroupFields.IsEnable == IsEnable);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerGroupCollection, filter, 0, null);
			}
			return _CustomerGroupCollection;
		}
		
		// Return EntityCollection<CustomerGroupEntity>
		public EntityCollection<CustomerGroupEntity> SelectByIsEnableLST_Paged(bool IsEnable, int PageNumber, int PageSize)
		{
			EntityCollection<CustomerGroupEntity> _CustomerGroupCollection = new EntityCollection<CustomerGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerGroupFields.IsEnable == IsEnable);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomerGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsEnableRDT(bool IsEnable)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerGroupCollection = new EntityCollection(new CustomerGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerGroupFields.IsEnable == IsEnable);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsEnableRDT_Paged(bool IsEnable, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerGroupCollection = new EntityCollection(new CustomerGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerGroupFields.IsEnable == IsEnable);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
