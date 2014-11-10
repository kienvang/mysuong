




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.CartSessionManagerBase
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
	public class CartSessionManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CartSessionManagerBase()
		{
			// Nothing for now.
		}
		
		public CartSessionEntity Insert(CartSessionEntity _CartSessionEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_CartSessionEntity, true);
			}
			return _CartSessionEntity;
		}

		
		public CartSessionEntity Insert(Guid SessionId, string UserName, string UserIp, DateTime CreatedDate, bool IsSold)
		{
			CartSessionEntity _CartSessionEntity = new CartSessionEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_CartSessionEntity.SessionId = SessionId;
				_CartSessionEntity.UserName = UserName;
				_CartSessionEntity.UserIp = UserIp;
				_CartSessionEntity.CreatedDate = CreatedDate;
				_CartSessionEntity.IsSold = IsSold;
				adapter.SaveEntity(_CartSessionEntity, true);
			}
			return _CartSessionEntity;
		}

		public CartSessionEntity Insert(string UserName, string UserIp, DateTime CreatedDate, bool IsSold)
		{
			CartSessionEntity _CartSessionEntity = new CartSessionEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_CartSessionEntity.UserName = UserName;
				_CartSessionEntity.UserIp = UserIp;
				_CartSessionEntity.CreatedDate = CreatedDate;
				_CartSessionEntity.IsSold = IsSold;
				adapter.SaveEntity(_CartSessionEntity, true);
			}
			return _CartSessionEntity;
		}

		public bool Update(CartSessionEntity _CartSessionEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(CartSessionFields.SessionId == _CartSessionEntity.SessionId);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_CartSessionEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(CartSessionEntity _CartSessionEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_CartSessionEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid SessionId, string UserName, string UserIp, DateTime CreatedDate, bool IsSold)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CartSessionEntity _CartSessionEntity = new CartSessionEntity(SessionId);
				if (adapter.FetchEntity(_CartSessionEntity))
				{
				
					_CartSessionEntity.UserName = UserName;
					_CartSessionEntity.UserIp = UserIp;
					_CartSessionEntity.CreatedDate = CreatedDate;
					_CartSessionEntity.IsSold = IsSold;
					adapter.SaveEntity(_CartSessionEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(Guid SessionId)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CartSessionEntity _CartSessionEntity = new CartSessionEntity(SessionId);
				if (adapter.FetchEntity(_CartSessionEntity))
				{
					adapter.DeleteEntity(_CartSessionEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("CartSessionEntity", null);
			}
		}
		
		
		public int DeleteBySessionId(Guid SessionId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.SessionId == SessionId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CartSessionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUserName(string UserName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CartSessionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUserIp(string UserIp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.UserIp == UserIp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CartSessionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedDate(DateTime CreatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CartSessionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsSold(bool IsSold)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.IsSold == IsSold);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CartSessionEntity", filter);
			}
			return toReturn;
		}
		

		
		public CartSessionEntity SelectOne(Guid SessionId)
		{
			CartSessionEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CartSessionEntity _CartSessionEntity = new CartSessionEntity(SessionId);
				if (adapter.FetchEntity(_CartSessionEntity))
				{
					toReturn = _CartSessionEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartSessionCollection = new EntityCollection(new CartSessionEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartSessionCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<CartSessionEntity>
		public EntityCollection<CartSessionEntity> SelectAllLST()
		{
			EntityCollection<CartSessionEntity> _CartSessionCollection = new EntityCollection<CartSessionEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartSessionCollection, null, 0, null);
			}
			return _CartSessionCollection;
		}
		
		// Return EntityCollection<CartSessionEntity>
		public EntityCollection<CartSessionEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<CartSessionEntity> _CartSessionCollection = new EntityCollection<CartSessionEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartSessionCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _CartSessionCollection;
		}


		
		// Return EntityCollection<CartSessionEntity>
		public EntityCollection<CartSessionEntity> SelectBySessionIdLST(Guid SessionId)
		{
			EntityCollection<CartSessionEntity> _CartSessionCollection = new EntityCollection<CartSessionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.SessionId == SessionId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartSessionCollection, filter, 0, null);
			}
			return _CartSessionCollection;
		}
		
		// Return EntityCollection<CartSessionEntity>
		public EntityCollection<CartSessionEntity> SelectBySessionIdLST_Paged(Guid SessionId, int PageNumber, int PageSize)
		{
			EntityCollection<CartSessionEntity> _CartSessionCollection = new EntityCollection<CartSessionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.SessionId == SessionId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartSessionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CartSessionCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySessionIdRDT(Guid SessionId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartSessionCollection = new EntityCollection(new CartSessionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.SessionId == SessionId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartSessionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySessionIdRDT_Paged(Guid SessionId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartSessionCollection = new EntityCollection(new CartSessionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.SessionId == SessionId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartSessionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CartSessionEntity>
		public EntityCollection<CartSessionEntity> SelectByUserNameLST(string UserName)
		{
			EntityCollection<CartSessionEntity> _CartSessionCollection = new EntityCollection<CartSessionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartSessionCollection, filter, 0, null);
			}
			return _CartSessionCollection;
		}
		
		// Return EntityCollection<CartSessionEntity>
		public EntityCollection<CartSessionEntity> SelectByUserNameLST_Paged(string UserName, int PageNumber, int PageSize)
		{
			EntityCollection<CartSessionEntity> _CartSessionCollection = new EntityCollection<CartSessionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartSessionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CartSessionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUserNameRDT(string UserName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartSessionCollection = new EntityCollection(new CartSessionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartSessionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUserNameRDT_Paged(string UserName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartSessionCollection = new EntityCollection(new CartSessionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.UserName == UserName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartSessionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CartSessionEntity>
		public EntityCollection<CartSessionEntity> SelectByUserIpLST(string UserIp)
		{
			EntityCollection<CartSessionEntity> _CartSessionCollection = new EntityCollection<CartSessionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.UserIp == UserIp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartSessionCollection, filter, 0, null);
			}
			return _CartSessionCollection;
		}
		
		// Return EntityCollection<CartSessionEntity>
		public EntityCollection<CartSessionEntity> SelectByUserIpLST_Paged(string UserIp, int PageNumber, int PageSize)
		{
			EntityCollection<CartSessionEntity> _CartSessionCollection = new EntityCollection<CartSessionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.UserIp == UserIp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartSessionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CartSessionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUserIpRDT(string UserIp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartSessionCollection = new EntityCollection(new CartSessionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.UserIp == UserIp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartSessionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUserIpRDT_Paged(string UserIp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartSessionCollection = new EntityCollection(new CartSessionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.UserIp == UserIp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartSessionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CartSessionEntity>
		public EntityCollection<CartSessionEntity> SelectByCreatedDateLST(DateTime CreatedDate)
		{
			EntityCollection<CartSessionEntity> _CartSessionCollection = new EntityCollection<CartSessionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartSessionCollection, filter, 0, null);
			}
			return _CartSessionCollection;
		}
		
		// Return EntityCollection<CartSessionEntity>
		public EntityCollection<CartSessionEntity> SelectByCreatedDateLST_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<CartSessionEntity> _CartSessionCollection = new EntityCollection<CartSessionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartSessionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CartSessionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT(DateTime CreatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartSessionCollection = new EntityCollection(new CartSessionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartSessionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartSessionCollection = new EntityCollection(new CartSessionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartSessionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CartSessionEntity>
		public EntityCollection<CartSessionEntity> SelectByIsSoldLST(bool IsSold)
		{
			EntityCollection<CartSessionEntity> _CartSessionCollection = new EntityCollection<CartSessionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.IsSold == IsSold);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartSessionCollection, filter, 0, null);
			}
			return _CartSessionCollection;
		}
		
		// Return EntityCollection<CartSessionEntity>
		public EntityCollection<CartSessionEntity> SelectByIsSoldLST_Paged(bool IsSold, int PageNumber, int PageSize)
		{
			EntityCollection<CartSessionEntity> _CartSessionCollection = new EntityCollection<CartSessionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.IsSold == IsSold);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CartSessionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CartSessionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsSoldRDT(bool IsSold)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartSessionCollection = new EntityCollection(new CartSessionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.IsSold == IsSold);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartSessionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsSoldRDT_Paged(bool IsSold, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CartSessionCollection = new EntityCollection(new CartSessionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CartSessionFields.IsSold == IsSold);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CartSessionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
