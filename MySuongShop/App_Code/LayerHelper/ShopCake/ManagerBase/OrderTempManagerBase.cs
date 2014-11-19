




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.OrderTempManagerBase
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
	public class OrderTempManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public OrderTempManagerBase()
		{
			// Nothing for now.
		}
		
		public OrderTempEntity Insert(OrderTempEntity _OrderTempEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_OrderTempEntity, true);
			}
			return _OrderTempEntity;
		}

		
		public OrderTempEntity Insert(Guid Id, Guid CustomerId, string ProductName, decimal Amount, decimal Discount, DateTime OrderDate, Guid EmployeeId, string Description)
		{
			OrderTempEntity _OrderTempEntity = new OrderTempEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_OrderTempEntity.Id = Id;
				_OrderTempEntity.CustomerId = CustomerId;
				_OrderTempEntity.ProductName = ProductName;
				_OrderTempEntity.Amount = Amount;
				_OrderTempEntity.Discount = Discount;
				_OrderTempEntity.OrderDate = OrderDate;
				_OrderTempEntity.EmployeeId = EmployeeId;
				_OrderTempEntity.Description = Description;
				adapter.SaveEntity(_OrderTempEntity, true);
			}
			return _OrderTempEntity;
		}

		public OrderTempEntity Insert(Guid CustomerId, string ProductName, decimal Amount, decimal Discount, DateTime OrderDate, Guid EmployeeId, string Description)
		{
			OrderTempEntity _OrderTempEntity = new OrderTempEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_OrderTempEntity.CustomerId = CustomerId;
				_OrderTempEntity.ProductName = ProductName;
				_OrderTempEntity.Amount = Amount;
				_OrderTempEntity.Discount = Discount;
				_OrderTempEntity.OrderDate = OrderDate;
				_OrderTempEntity.EmployeeId = EmployeeId;
				_OrderTempEntity.Description = Description;
				adapter.SaveEntity(_OrderTempEntity, true);
			}
			return _OrderTempEntity;
		}

		public bool Update(OrderTempEntity _OrderTempEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(OrderTempFields.Id == _OrderTempEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_OrderTempEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(OrderTempEntity _OrderTempEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_OrderTempEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid CustomerId, string ProductName, decimal Amount, decimal Discount, DateTime OrderDate, Guid EmployeeId, string Description)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				OrderTempEntity _OrderTempEntity = new OrderTempEntity(Id);
				if (adapter.FetchEntity(_OrderTempEntity))
				{
				
					_OrderTempEntity.CustomerId = CustomerId;
					_OrderTempEntity.ProductName = ProductName;
					_OrderTempEntity.Amount = Amount;
					_OrderTempEntity.Discount = Discount;
					_OrderTempEntity.OrderDate = OrderDate;
					_OrderTempEntity.EmployeeId = EmployeeId;
					_OrderTempEntity.Description = Description;
					adapter.SaveEntity(_OrderTempEntity, true);
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
				OrderTempEntity _OrderTempEntity = new OrderTempEntity(Id);
				if (adapter.FetchEntity(_OrderTempEntity))
				{
					adapter.DeleteEntity(_OrderTempEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("OrderTempEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderTempEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCustomerId(Guid CustomerId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderTempEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByProductName(string ProductName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderTempEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAmount(decimal Amount)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderTempEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDiscount(decimal Discount)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.Discount == Discount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderTempEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByOrderDate(DateTime OrderDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.OrderDate == OrderDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderTempEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEmployeeId(Guid EmployeeId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.EmployeeId == EmployeeId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderTempEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDescription(string Description)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("OrderTempEntity", filter);
			}
			return toReturn;
		}
		

		
		public OrderTempEntity SelectOne(Guid Id)
		{
			OrderTempEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				OrderTempEntity _OrderTempEntity = new OrderTempEntity(Id);
				if (adapter.FetchEntity(_OrderTempEntity))
				{
					toReturn = _OrderTempEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTempCollection = new EntityCollection(new OrderTempEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTempCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<OrderTempEntity>
		public EntityCollection<OrderTempEntity> SelectAllLST()
		{
			EntityCollection<OrderTempEntity> _OrderTempCollection = new EntityCollection<OrderTempEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTempCollection, null, 0, null);
			}
			return _OrderTempCollection;
		}
		
		// Return EntityCollection<OrderTempEntity>
		public EntityCollection<OrderTempEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<OrderTempEntity> _OrderTempCollection = new EntityCollection<OrderTempEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTempCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _OrderTempCollection;
		}


		
		// Return EntityCollection<OrderTempEntity>
		public EntityCollection<OrderTempEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<OrderTempEntity> _OrderTempCollection = new EntityCollection<OrderTempEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTempCollection, filter, 0, null);
			}
			return _OrderTempCollection;
		}
		
		// Return EntityCollection<OrderTempEntity>
		public EntityCollection<OrderTempEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<OrderTempEntity> _OrderTempCollection = new EntityCollection<OrderTempEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTempCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderTempCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTempCollection = new EntityCollection(new OrderTempEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTempCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTempCollection = new EntityCollection(new OrderTempEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTempCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderTempEntity>
		public EntityCollection<OrderTempEntity> SelectByCustomerIdLST(Guid CustomerId)
		{
			EntityCollection<OrderTempEntity> _OrderTempCollection = new EntityCollection<OrderTempEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTempCollection, filter, 0, null);
			}
			return _OrderTempCollection;
		}
		
		// Return EntityCollection<OrderTempEntity>
		public EntityCollection<OrderTempEntity> SelectByCustomerIdLST_Paged(Guid CustomerId, int PageNumber, int PageSize)
		{
			EntityCollection<OrderTempEntity> _OrderTempCollection = new EntityCollection<OrderTempEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTempCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderTempCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCustomerIdRDT(Guid CustomerId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTempCollection = new EntityCollection(new OrderTempEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTempCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCustomerIdRDT_Paged(Guid CustomerId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTempCollection = new EntityCollection(new OrderTempEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.CustomerId == CustomerId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTempCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderTempEntity>
		public EntityCollection<OrderTempEntity> SelectByProductNameLST(string ProductName)
		{
			EntityCollection<OrderTempEntity> _OrderTempCollection = new EntityCollection<OrderTempEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTempCollection, filter, 0, null);
			}
			return _OrderTempCollection;
		}
		
		// Return EntityCollection<OrderTempEntity>
		public EntityCollection<OrderTempEntity> SelectByProductNameLST_Paged(string ProductName, int PageNumber, int PageSize)
		{
			EntityCollection<OrderTempEntity> _OrderTempCollection = new EntityCollection<OrderTempEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTempCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderTempCollection;
		}
		
		// Return DataTable
		public DataTable SelectByProductNameRDT(string ProductName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTempCollection = new EntityCollection(new OrderTempEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTempCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByProductNameRDT_Paged(string ProductName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTempCollection = new EntityCollection(new OrderTempEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.ProductName == ProductName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTempCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderTempEntity>
		public EntityCollection<OrderTempEntity> SelectByAmountLST(decimal Amount)
		{
			EntityCollection<OrderTempEntity> _OrderTempCollection = new EntityCollection<OrderTempEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTempCollection, filter, 0, null);
			}
			return _OrderTempCollection;
		}
		
		// Return EntityCollection<OrderTempEntity>
		public EntityCollection<OrderTempEntity> SelectByAmountLST_Paged(decimal Amount, int PageNumber, int PageSize)
		{
			EntityCollection<OrderTempEntity> _OrderTempCollection = new EntityCollection<OrderTempEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTempCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderTempCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAmountRDT(decimal Amount)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTempCollection = new EntityCollection(new OrderTempEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTempCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAmountRDT_Paged(decimal Amount, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTempCollection = new EntityCollection(new OrderTempEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.Amount == Amount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTempCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderTempEntity>
		public EntityCollection<OrderTempEntity> SelectByDiscountLST(decimal Discount)
		{
			EntityCollection<OrderTempEntity> _OrderTempCollection = new EntityCollection<OrderTempEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.Discount == Discount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTempCollection, filter, 0, null);
			}
			return _OrderTempCollection;
		}
		
		// Return EntityCollection<OrderTempEntity>
		public EntityCollection<OrderTempEntity> SelectByDiscountLST_Paged(decimal Discount, int PageNumber, int PageSize)
		{
			EntityCollection<OrderTempEntity> _OrderTempCollection = new EntityCollection<OrderTempEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.Discount == Discount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTempCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderTempCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDiscountRDT(decimal Discount)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTempCollection = new EntityCollection(new OrderTempEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.Discount == Discount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTempCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDiscountRDT_Paged(decimal Discount, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTempCollection = new EntityCollection(new OrderTempEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.Discount == Discount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTempCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderTempEntity>
		public EntityCollection<OrderTempEntity> SelectByOrderDateLST(DateTime OrderDate)
		{
			EntityCollection<OrderTempEntity> _OrderTempCollection = new EntityCollection<OrderTempEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.OrderDate == OrderDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTempCollection, filter, 0, null);
			}
			return _OrderTempCollection;
		}
		
		// Return EntityCollection<OrderTempEntity>
		public EntityCollection<OrderTempEntity> SelectByOrderDateLST_Paged(DateTime OrderDate, int PageNumber, int PageSize)
		{
			EntityCollection<OrderTempEntity> _OrderTempCollection = new EntityCollection<OrderTempEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.OrderDate == OrderDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTempCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderTempCollection;
		}
		
		// Return DataTable
		public DataTable SelectByOrderDateRDT(DateTime OrderDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTempCollection = new EntityCollection(new OrderTempEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.OrderDate == OrderDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTempCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByOrderDateRDT_Paged(DateTime OrderDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTempCollection = new EntityCollection(new OrderTempEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.OrderDate == OrderDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTempCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderTempEntity>
		public EntityCollection<OrderTempEntity> SelectByEmployeeIdLST(Guid EmployeeId)
		{
			EntityCollection<OrderTempEntity> _OrderTempCollection = new EntityCollection<OrderTempEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.EmployeeId == EmployeeId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTempCollection, filter, 0, null);
			}
			return _OrderTempCollection;
		}
		
		// Return EntityCollection<OrderTempEntity>
		public EntityCollection<OrderTempEntity> SelectByEmployeeIdLST_Paged(Guid EmployeeId, int PageNumber, int PageSize)
		{
			EntityCollection<OrderTempEntity> _OrderTempCollection = new EntityCollection<OrderTempEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.EmployeeId == EmployeeId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTempCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderTempCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEmployeeIdRDT(Guid EmployeeId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTempCollection = new EntityCollection(new OrderTempEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.EmployeeId == EmployeeId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTempCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEmployeeIdRDT_Paged(Guid EmployeeId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTempCollection = new EntityCollection(new OrderTempEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.EmployeeId == EmployeeId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTempCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<OrderTempEntity>
		public EntityCollection<OrderTempEntity> SelectByDescriptionLST(string Description)
		{
			EntityCollection<OrderTempEntity> _OrderTempCollection = new EntityCollection<OrderTempEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTempCollection, filter, 0, null);
			}
			return _OrderTempCollection;
		}
		
		// Return EntityCollection<OrderTempEntity>
		public EntityCollection<OrderTempEntity> SelectByDescriptionLST_Paged(string Description, int PageNumber, int PageSize)
		{
			EntityCollection<OrderTempEntity> _OrderTempCollection = new EntityCollection<OrderTempEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_OrderTempCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _OrderTempCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDescriptionRDT(string Description)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTempCollection = new EntityCollection(new OrderTempEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTempCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDescriptionRDT_Paged(string Description, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _OrderTempCollection = new EntityCollection(new OrderTempEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(OrderTempFields.Description == Description);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_OrderTempCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
