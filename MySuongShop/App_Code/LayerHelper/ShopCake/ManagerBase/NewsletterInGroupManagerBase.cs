




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.NewsletterInGroupManagerBase
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
	public class NewsletterInGroupManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NewsletterInGroupManagerBase()
		{
			// Nothing for now.
		}
		
		public NewsletterInGroupEntity Insert(NewsletterInGroupEntity _NewsletterInGroupEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_NewsletterInGroupEntity, true);
			}
			return _NewsletterInGroupEntity;
		}

		
		public NewsletterInGroupEntity Insert(Guid Id, Guid NewsletterId, Guid GroupId)
		{
			NewsletterInGroupEntity _NewsletterInGroupEntity = new NewsletterInGroupEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NewsletterInGroupEntity.Id = Id;
				_NewsletterInGroupEntity.NewsletterId = NewsletterId;
				_NewsletterInGroupEntity.GroupId = GroupId;
				adapter.SaveEntity(_NewsletterInGroupEntity, true);
			}
			return _NewsletterInGroupEntity;
		}

		public NewsletterInGroupEntity Insert(Guid NewsletterId, Guid GroupId)
		{
			NewsletterInGroupEntity _NewsletterInGroupEntity = new NewsletterInGroupEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NewsletterInGroupEntity.NewsletterId = NewsletterId;
				_NewsletterInGroupEntity.GroupId = GroupId;
				adapter.SaveEntity(_NewsletterInGroupEntity, true);
			}
			return _NewsletterInGroupEntity;
		}

		public bool Update(NewsletterInGroupEntity _NewsletterInGroupEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(NewsletterInGroupFields.Id == _NewsletterInGroupEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_NewsletterInGroupEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(NewsletterInGroupEntity _NewsletterInGroupEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_NewsletterInGroupEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid NewsletterId, Guid GroupId)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NewsletterInGroupEntity _NewsletterInGroupEntity = new NewsletterInGroupEntity(Id);
				if (adapter.FetchEntity(_NewsletterInGroupEntity))
				{
				
					_NewsletterInGroupEntity.NewsletterId = NewsletterId;
					_NewsletterInGroupEntity.GroupId = GroupId;
					adapter.SaveEntity(_NewsletterInGroupEntity, true);
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
				NewsletterInGroupEntity _NewsletterInGroupEntity = new NewsletterInGroupEntity(Id);
				if (adapter.FetchEntity(_NewsletterInGroupEntity))
				{
					adapter.DeleteEntity(_NewsletterInGroupEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("NewsletterInGroupEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NewsletterInGroupEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNewsletterId(Guid NewsletterId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInGroupFields.NewsletterId == NewsletterId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NewsletterInGroupEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGroupId(Guid GroupId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInGroupFields.GroupId == GroupId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NewsletterInGroupEntity", filter);
			}
			return toReturn;
		}
		

		
		public NewsletterInGroupEntity SelectOne(Guid Id)
		{
			NewsletterInGroupEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NewsletterInGroupEntity _NewsletterInGroupEntity = new NewsletterInGroupEntity(Id);
				if (adapter.FetchEntity(_NewsletterInGroupEntity))
				{
					toReturn = _NewsletterInGroupEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterInGroupCollection = new EntityCollection(new NewsletterInGroupEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterInGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<NewsletterInGroupEntity>
		public EntityCollection<NewsletterInGroupEntity> SelectAllLST()
		{
			EntityCollection<NewsletterInGroupEntity> _NewsletterInGroupCollection = new EntityCollection<NewsletterInGroupEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterInGroupCollection, null, 0, null);
			}
			return _NewsletterInGroupCollection;
		}
		
		// Return EntityCollection<NewsletterInGroupEntity>
		public EntityCollection<NewsletterInGroupEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterInGroupEntity> _NewsletterInGroupCollection = new EntityCollection<NewsletterInGroupEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterInGroupCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterInGroupCollection;
		}


		
		// Return EntityCollection<NewsletterInGroupEntity>
		public EntityCollection<NewsletterInGroupEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<NewsletterInGroupEntity> _NewsletterInGroupCollection = new EntityCollection<NewsletterInGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterInGroupCollection, filter, 0, null);
			}
			return _NewsletterInGroupCollection;
		}
		
		// Return EntityCollection<NewsletterInGroupEntity>
		public EntityCollection<NewsletterInGroupEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterInGroupEntity> _NewsletterInGroupCollection = new EntityCollection<NewsletterInGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterInGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterInGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterInGroupCollection = new EntityCollection(new NewsletterInGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterInGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterInGroupCollection = new EntityCollection(new NewsletterInGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInGroupFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterInGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NewsletterInGroupEntity>
		public EntityCollection<NewsletterInGroupEntity> SelectByNewsletterIdLST(Guid NewsletterId)
		{
			EntityCollection<NewsletterInGroupEntity> _NewsletterInGroupCollection = new EntityCollection<NewsletterInGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInGroupFields.NewsletterId == NewsletterId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterInGroupCollection, filter, 0, null);
			}
			return _NewsletterInGroupCollection;
		}
		
		// Return EntityCollection<NewsletterInGroupEntity>
		public EntityCollection<NewsletterInGroupEntity> SelectByNewsletterIdLST_Paged(Guid NewsletterId, int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterInGroupEntity> _NewsletterInGroupCollection = new EntityCollection<NewsletterInGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInGroupFields.NewsletterId == NewsletterId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterInGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterInGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNewsletterIdRDT(Guid NewsletterId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterInGroupCollection = new EntityCollection(new NewsletterInGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInGroupFields.NewsletterId == NewsletterId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterInGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNewsletterIdRDT_Paged(Guid NewsletterId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterInGroupCollection = new EntityCollection(new NewsletterInGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInGroupFields.NewsletterId == NewsletterId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterInGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NewsletterInGroupEntity>
		public EntityCollection<NewsletterInGroupEntity> SelectByGroupIdLST(Guid GroupId)
		{
			EntityCollection<NewsletterInGroupEntity> _NewsletterInGroupCollection = new EntityCollection<NewsletterInGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInGroupFields.GroupId == GroupId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterInGroupCollection, filter, 0, null);
			}
			return _NewsletterInGroupCollection;
		}
		
		// Return EntityCollection<NewsletterInGroupEntity>
		public EntityCollection<NewsletterInGroupEntity> SelectByGroupIdLST_Paged(Guid GroupId, int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterInGroupEntity> _NewsletterInGroupCollection = new EntityCollection<NewsletterInGroupEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInGroupFields.GroupId == GroupId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterInGroupCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterInGroupCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGroupIdRDT(Guid GroupId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterInGroupCollection = new EntityCollection(new NewsletterInGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInGroupFields.GroupId == GroupId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterInGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGroupIdRDT_Paged(Guid GroupId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterInGroupCollection = new EntityCollection(new NewsletterInGroupEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterInGroupFields.GroupId == GroupId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterInGroupCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
