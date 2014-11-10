




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.CustomerInGroupManagerBase
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
	public class CustomerInGroupManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CustomerInGroupManagerBase()
		{
			// Nothing for now.
		}
		
		public CustomerInGroupEntity Insert(CustomerInGroupEntity _CustomerInGroupEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_CustomerInGroupEntity, true);
			}
			return _CustomerInGroupEntity;
		}

		
		public CustomerInGroupEntity Insert(Guid Id, Guid CustomerId, Guid GroupId)
		{
			CustomerInGroupEntity _CustomerInGroupEntity = new CustomerInGroupEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_CustomerInGroupEntity.Id = Id;
				_CustomerInGroupEntity.CustomerId = CustomerId;
				_CustomerInGroupEntity.GroupId = GroupId;
				adapter.SaveEntity(_CustomerInGroupEntity, true);
			}
			return _CustomerInGroupEntity;
		}

		public CustomerInGroupEntity Insert(Guid CustomerId, Guid GroupId)
		{
			CustomerInGroupEntity _CustomerInGroupEntity = new CustomerInGroupEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_CustomerInGroupEntity.CustomerId = CustomerId;
				_CustomerInGroupEntity.GroupId = GroupId;
				adapter.SaveEntity(_CustomerInGroupEntity, true);
			}
			return _CustomerInGroupEntity;
		}

		public bool Update(CustomerInGroupEntity _CustomerInGroupEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(CustomerInGroupFields.Id == _CustomerInGroupEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_CustomerInGroupEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(CustomerInGroupEntity _CustomerInGroupEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_CustomerInGroupEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid CustomerId, Guid GroupId)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CustomerInGroupEntity _CustomerInGroupEntity = new CustomerInGroupEntity(Id);
				if (adapter.FetchEntity(_CustomerInGroupEntity))
				{
				
					_CustomerInGroupEntity.CustomerId = CustomerId;
					_CustomerInGroupEntity.GroupId = GroupId;
					adapter.SaveEntity(_CustomerInGroupEntity, true);
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
				CustomerInGroupEntity _CustomerInGroupEntity = new CustomerInGroupEntity(Id);
				if (adapter.FetchEntity(_CustomerInGroupEntity))
				{
					adapter.DeleteEntity(_CustomerInGroupEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("CustomerInGroupEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerInGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomerInGroupEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCustomerId(Guid CustomerId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerInGroupFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomerInGroupEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGroupId(Guid GroupId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerInGroupFields.GroupId == GroupId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomerInGroupEntity", filter);
			}
			return toReturn;
		}
		

		
		public CustomerInGroupEntity SelectOne(Guid Id)
		{
			CustomerInGroupEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CustomerInGroupEntity _CustomerInGroupEntity = new CustomerInGroupEntity(Id);
				if (adapter.FetchEntity(_CustomerInGroupEntity))
				{
					toReturn = _CustomerInGroupEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerInGroupCollection = new EntityCollection(new CustomerInGroupEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerInGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<CustomerInGroupEntity>
		public EntityCollection<CustomerInGroupEntity> SelectAllLST()
		{
			EntityCollection<CustomerInGroupEntity> _CustomerInGroupCollection = new EntityCollection<CustomerInGroupEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerInGroupCollection, null, 0, null);
			}
			return _CustomerInGroupCollection;
		}
		
		// Return EntityCollection<CustomerInGroupEntity>
		public EntityCollection<CustomerInGroupEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<CustomerInGroupEntity> _CustomerInGroupCollection = new EntityCollection<CustomerInGroupEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerInGroupCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _CustomerInGroupCollection;
		}


		
		// Return EntityCollection<CustomerInGroupEntity>
		public EntityCollection<CustomerInGroupEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<CustomerInGroupEntity> _CustomerInGroupCollection = new EntityCollection<CustomerInGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerInGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerInGroupCollection, filter, 0, null);
			}
			return _CustomerInGroupCollection;
		}
		
		// Return EntityCollection<CustomerInGroupEntity>
		public EntityCollection<CustomerInGroupEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<CustomerInGroupEntity> _CustomerInGroupCollection = new EntityCollection<CustomerInGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerInGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerInGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomerInGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerInGroupCollection = new EntityCollection(new CustomerInGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerInGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerInGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerInGroupCollection = new EntityCollection(new CustomerInGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerInGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerInGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomerInGroupEntity>
		public EntityCollection<CustomerInGroupEntity> SelectByCustomerIdLST(Guid CustomerId)
		{
			EntityCollection<CustomerInGroupEntity> _CustomerInGroupCollection = new EntityCollection<CustomerInGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerInGroupFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerInGroupCollection, filter, 0, null);
			}
			return _CustomerInGroupCollection;
		}
		
		// Return EntityCollection<CustomerInGroupEntity>
		public EntityCollection<CustomerInGroupEntity> SelectByCustomerIdLST_Paged(Guid CustomerId, int PageNumber, int PageSize)
		{
			EntityCollection<CustomerInGroupEntity> _CustomerInGroupCollection = new EntityCollection<CustomerInGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerInGroupFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerInGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomerInGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCustomerIdRDT(Guid CustomerId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerInGroupCollection = new EntityCollection(new CustomerInGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerInGroupFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerInGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCustomerIdRDT_Paged(Guid CustomerId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerInGroupCollection = new EntityCollection(new CustomerInGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerInGroupFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerInGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomerInGroupEntity>
		public EntityCollection<CustomerInGroupEntity> SelectByGroupIdLST(Guid GroupId)
		{
			EntityCollection<CustomerInGroupEntity> _CustomerInGroupCollection = new EntityCollection<CustomerInGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerInGroupFields.GroupId == GroupId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerInGroupCollection, filter, 0, null);
			}
			return _CustomerInGroupCollection;
		}
		
		// Return EntityCollection<CustomerInGroupEntity>
		public EntityCollection<CustomerInGroupEntity> SelectByGroupIdLST_Paged(Guid GroupId, int PageNumber, int PageSize)
		{
			EntityCollection<CustomerInGroupEntity> _CustomerInGroupCollection = new EntityCollection<CustomerInGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerInGroupFields.GroupId == GroupId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerInGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomerInGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGroupIdRDT(Guid GroupId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerInGroupCollection = new EntityCollection(new CustomerInGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerInGroupFields.GroupId == GroupId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerInGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGroupIdRDT_Paged(Guid GroupId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerInGroupCollection = new EntityCollection(new CustomerInGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerInGroupFields.GroupId == GroupId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerInGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
