




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.NewsletterInProductManagerBase
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
	public class NewsletterInProductManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NewsletterInProductManagerBase()
		{
			// Nothing for now.
		}
		
		public NewsletterInProductEntity Insert(NewsletterInProductEntity _NewsletterInProductEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_NewsletterInProductEntity, true);
			}
			return _NewsletterInProductEntity;
		}

		
		public NewsletterInProductEntity Insert(Guid Id, Guid NewsletterId, Guid ProductId)
		{
			NewsletterInProductEntity _NewsletterInProductEntity = new NewsletterInProductEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NewsletterInProductEntity.Id = Id;
				_NewsletterInProductEntity.NewsletterId = NewsletterId;
				_NewsletterInProductEntity.ProductId = ProductId;
				adapter.SaveEntity(_NewsletterInProductEntity, true);
			}
			return _NewsletterInProductEntity;
		}

		public NewsletterInProductEntity Insert(Guid NewsletterId, Guid ProductId)
		{
			NewsletterInProductEntity _NewsletterInProductEntity = new NewsletterInProductEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NewsletterInProductEntity.NewsletterId = NewsletterId;
				_NewsletterInProductEntity.ProductId = ProductId;
				adapter.SaveEntity(_NewsletterInProductEntity, true);
			}
			return _NewsletterInProductEntity;
		}

		public bool Update(NewsletterInProductEntity _NewsletterInProductEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(NewsletterInProductFields.Id == _NewsletterInProductEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_NewsletterInProductEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(NewsletterInProductEntity _NewsletterInProductEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_NewsletterInProductEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid NewsletterId, Guid ProductId)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NewsletterInProductEntity _NewsletterInProductEntity = new NewsletterInProductEntity(Id);
				if (adapter.FetchEntity(_NewsletterInProductEntity))
				{
				
					_NewsletterInProductEntity.NewsletterId = NewsletterId;
					_NewsletterInProductEntity.ProductId = ProductId;
					adapter.SaveEntity(_NewsletterInProductEntity, true);
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
				NewsletterInProductEntity _NewsletterInProductEntity = new NewsletterInProductEntity(Id);
				if (adapter.FetchEntity(_NewsletterInProductEntity))
				{
					adapter.DeleteEntity(_NewsletterInProductEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("NewsletterInProductEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInProductFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NewsletterInProductEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNewsletterId(Guid NewsletterId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInProductFields.NewsletterId == NewsletterId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NewsletterInProductEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByProductId(Guid ProductId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInProductFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NewsletterInProductEntity", filter);
			}
			return toReturn;
		}
		

		
		public NewsletterInProductEntity SelectOne(Guid Id)
		{
			NewsletterInProductEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NewsletterInProductEntity _NewsletterInProductEntity = new NewsletterInProductEntity(Id);
				if (adapter.FetchEntity(_NewsletterInProductEntity))
				{
					toReturn = _NewsletterInProductEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterInProductCollection = new EntityCollection(new NewsletterInProductEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterInProductCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<NewsletterInProductEntity>
		public EntityCollection<NewsletterInProductEntity> SelectAllLST()
		{
			EntityCollection<NewsletterInProductEntity> _NewsletterInProductCollection = new EntityCollection<NewsletterInProductEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterInProductCollection, null, 0, null);
			}
			return _NewsletterInProductCollection;
		}
		
		// Return EntityCollection<NewsletterInProductEntity>
		public EntityCollection<NewsletterInProductEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterInProductEntity> _NewsletterInProductCollection = new EntityCollection<NewsletterInProductEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterInProductCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterInProductCollection;
		}


		
		// Return EntityCollection<NewsletterInProductEntity>
		public EntityCollection<NewsletterInProductEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<NewsletterInProductEntity> _NewsletterInProductCollection = new EntityCollection<NewsletterInProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInProductFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterInProductCollection, filter, 0, null);
			}
			return _NewsletterInProductCollection;
		}
		
		// Return EntityCollection<NewsletterInProductEntity>
		public EntityCollection<NewsletterInProductEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterInProductEntity> _NewsletterInProductCollection = new EntityCollection<NewsletterInProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInProductFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterInProductCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterInProductCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterInProductCollection = new EntityCollection(new NewsletterInProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInProductFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterInProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterInProductCollection = new EntityCollection(new NewsletterInProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInProductFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterInProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NewsletterInProductEntity>
		public EntityCollection<NewsletterInProductEntity> SelectByNewsletterIdLST(Guid NewsletterId)
		{
			EntityCollection<NewsletterInProductEntity> _NewsletterInProductCollection = new EntityCollection<NewsletterInProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInProductFields.NewsletterId == NewsletterId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterInProductCollection, filter, 0, null);
			}
			return _NewsletterInProductCollection;
		}
		
		// Return EntityCollection<NewsletterInProductEntity>
		public EntityCollection<NewsletterInProductEntity> SelectByNewsletterIdLST_Paged(Guid NewsletterId, int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterInProductEntity> _NewsletterInProductCollection = new EntityCollection<NewsletterInProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInProductFields.NewsletterId == NewsletterId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterInProductCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterInProductCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNewsletterIdRDT(Guid NewsletterId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterInProductCollection = new EntityCollection(new NewsletterInProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInProductFields.NewsletterId == NewsletterId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterInProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNewsletterIdRDT_Paged(Guid NewsletterId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterInProductCollection = new EntityCollection(new NewsletterInProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInProductFields.NewsletterId == NewsletterId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterInProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NewsletterInProductEntity>
		public EntityCollection<NewsletterInProductEntity> SelectByProductIdLST(Guid ProductId)
		{
			EntityCollection<NewsletterInProductEntity> _NewsletterInProductCollection = new EntityCollection<NewsletterInProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInProductFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterInProductCollection, filter, 0, null);
			}
			return _NewsletterInProductCollection;
		}
		
		// Return EntityCollection<NewsletterInProductEntity>
		public EntityCollection<NewsletterInProductEntity> SelectByProductIdLST_Paged(Guid ProductId, int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterInProductEntity> _NewsletterInProductCollection = new EntityCollection<NewsletterInProductEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInProductFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterInProductCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterInProductCollection;
		}
		
		// Return DataTable
		public DataTable SelectByProductIdRDT(Guid ProductId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterInProductCollection = new EntityCollection(new NewsletterInProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInProductFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterInProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByProductIdRDT_Paged(Guid ProductId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterInProductCollection = new EntityCollection(new NewsletterInProductEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInProductFields.ProductId == ProductId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterInProductCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
