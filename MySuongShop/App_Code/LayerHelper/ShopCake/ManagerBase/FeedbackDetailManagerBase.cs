




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.FeedbackDetailManagerBase
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
	public class FeedbackDetailManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public FeedbackDetailManagerBase()
		{
			// Nothing for now.
		}
		
		public FeedbackDetailEntity Insert(FeedbackDetailEntity _FeedbackDetailEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_FeedbackDetailEntity, true);
			}
			return _FeedbackDetailEntity;
		}

		
		public FeedbackDetailEntity Insert(Guid Id, Guid FeedbackId, string Receiver, string Subject, string Body, string CreatedBy, DateTime CreatedDate)
		{
			FeedbackDetailEntity _FeedbackDetailEntity = new FeedbackDetailEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_FeedbackDetailEntity.Id = Id;
				_FeedbackDetailEntity.FeedbackId = FeedbackId;
				_FeedbackDetailEntity.Receiver = Receiver;
				_FeedbackDetailEntity.Subject = Subject;
				_FeedbackDetailEntity.Body = Body;
				_FeedbackDetailEntity.CreatedBy = CreatedBy;
				_FeedbackDetailEntity.CreatedDate = CreatedDate;
				adapter.SaveEntity(_FeedbackDetailEntity, true);
			}
			return _FeedbackDetailEntity;
		}

		public FeedbackDetailEntity Insert(Guid FeedbackId, string Receiver, string Subject, string Body, string CreatedBy, DateTime CreatedDate)
		{
			FeedbackDetailEntity _FeedbackDetailEntity = new FeedbackDetailEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_FeedbackDetailEntity.FeedbackId = FeedbackId;
				_FeedbackDetailEntity.Receiver = Receiver;
				_FeedbackDetailEntity.Subject = Subject;
				_FeedbackDetailEntity.Body = Body;
				_FeedbackDetailEntity.CreatedBy = CreatedBy;
				_FeedbackDetailEntity.CreatedDate = CreatedDate;
				adapter.SaveEntity(_FeedbackDetailEntity, true);
			}
			return _FeedbackDetailEntity;
		}

		public bool Update(FeedbackDetailEntity _FeedbackDetailEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(FeedbackDetailFields.Id == _FeedbackDetailEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_FeedbackDetailEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(FeedbackDetailEntity _FeedbackDetailEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_FeedbackDetailEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid FeedbackId, string Receiver, string Subject, string Body, string CreatedBy, DateTime CreatedDate)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				FeedbackDetailEntity _FeedbackDetailEntity = new FeedbackDetailEntity(Id);
				if (adapter.FetchEntity(_FeedbackDetailEntity))
				{
				
					_FeedbackDetailEntity.FeedbackId = FeedbackId;
					_FeedbackDetailEntity.Receiver = Receiver;
					_FeedbackDetailEntity.Subject = Subject;
					_FeedbackDetailEntity.Body = Body;
					_FeedbackDetailEntity.CreatedBy = CreatedBy;
					_FeedbackDetailEntity.CreatedDate = CreatedDate;
					adapter.SaveEntity(_FeedbackDetailEntity, true);
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
				FeedbackDetailEntity _FeedbackDetailEntity = new FeedbackDetailEntity(Id);
				if (adapter.FetchEntity(_FeedbackDetailEntity))
				{
					adapter.DeleteEntity(_FeedbackDetailEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("FeedbackDetailEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("FeedbackDetailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByFeedbackId(Guid FeedbackId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.FeedbackId == FeedbackId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("FeedbackDetailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByReceiver(string Receiver)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.Receiver == Receiver);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("FeedbackDetailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySubject(string Subject)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.Subject == Subject);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("FeedbackDetailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByBody(string Body)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.Body == Body);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("FeedbackDetailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedBy(string CreatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("FeedbackDetailEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedDate(DateTime CreatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("FeedbackDetailEntity", filter);
			}
			return toReturn;
		}
		

		
		public FeedbackDetailEntity SelectOne(Guid Id)
		{
			FeedbackDetailEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				FeedbackDetailEntity _FeedbackDetailEntity = new FeedbackDetailEntity(Id);
				if (adapter.FetchEntity(_FeedbackDetailEntity))
				{
					toReturn = _FeedbackDetailEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedbackDetailCollection = new EntityCollection(new FeedbackDetailEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedbackDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<FeedbackDetailEntity>
		public EntityCollection<FeedbackDetailEntity> SelectAllLST()
		{
			EntityCollection<FeedbackDetailEntity> _FeedbackDetailCollection = new EntityCollection<FeedbackDetailEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedbackDetailCollection, null, 0, null);
			}
			return _FeedbackDetailCollection;
		}
		
		// Return EntityCollection<FeedbackDetailEntity>
		public EntityCollection<FeedbackDetailEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<FeedbackDetailEntity> _FeedbackDetailCollection = new EntityCollection<FeedbackDetailEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedbackDetailCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _FeedbackDetailCollection;
		}


		
		// Return EntityCollection<FeedbackDetailEntity>
		public EntityCollection<FeedbackDetailEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<FeedbackDetailEntity> _FeedbackDetailCollection = new EntityCollection<FeedbackDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedbackDetailCollection, filter, 0, null);
			}
			return _FeedbackDetailCollection;
		}
		
		// Return EntityCollection<FeedbackDetailEntity>
		public EntityCollection<FeedbackDetailEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<FeedbackDetailEntity> _FeedbackDetailCollection = new EntityCollection<FeedbackDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedbackDetailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _FeedbackDetailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedbackDetailCollection = new EntityCollection(new FeedbackDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedbackDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedbackDetailCollection = new EntityCollection(new FeedbackDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedbackDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<FeedbackDetailEntity>
		public EntityCollection<FeedbackDetailEntity> SelectByFeedbackIdLST(Guid FeedbackId)
		{
			EntityCollection<FeedbackDetailEntity> _FeedbackDetailCollection = new EntityCollection<FeedbackDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.FeedbackId == FeedbackId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedbackDetailCollection, filter, 0, null);
			}
			return _FeedbackDetailCollection;
		}
		
		// Return EntityCollection<FeedbackDetailEntity>
		public EntityCollection<FeedbackDetailEntity> SelectByFeedbackIdLST_Paged(Guid FeedbackId, int PageNumber, int PageSize)
		{
			EntityCollection<FeedbackDetailEntity> _FeedbackDetailCollection = new EntityCollection<FeedbackDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.FeedbackId == FeedbackId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedbackDetailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _FeedbackDetailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByFeedbackIdRDT(Guid FeedbackId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedbackDetailCollection = new EntityCollection(new FeedbackDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.FeedbackId == FeedbackId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedbackDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByFeedbackIdRDT_Paged(Guid FeedbackId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedbackDetailCollection = new EntityCollection(new FeedbackDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.FeedbackId == FeedbackId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedbackDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<FeedbackDetailEntity>
		public EntityCollection<FeedbackDetailEntity> SelectByReceiverLST(string Receiver)
		{
			EntityCollection<FeedbackDetailEntity> _FeedbackDetailCollection = new EntityCollection<FeedbackDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.Receiver == Receiver);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedbackDetailCollection, filter, 0, null);
			}
			return _FeedbackDetailCollection;
		}
		
		// Return EntityCollection<FeedbackDetailEntity>
		public EntityCollection<FeedbackDetailEntity> SelectByReceiverLST_Paged(string Receiver, int PageNumber, int PageSize)
		{
			EntityCollection<FeedbackDetailEntity> _FeedbackDetailCollection = new EntityCollection<FeedbackDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.Receiver == Receiver);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedbackDetailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _FeedbackDetailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByReceiverRDT(string Receiver)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedbackDetailCollection = new EntityCollection(new FeedbackDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.Receiver == Receiver);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedbackDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByReceiverRDT_Paged(string Receiver, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedbackDetailCollection = new EntityCollection(new FeedbackDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.Receiver == Receiver);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedbackDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<FeedbackDetailEntity>
		public EntityCollection<FeedbackDetailEntity> SelectBySubjectLST(string Subject)
		{
			EntityCollection<FeedbackDetailEntity> _FeedbackDetailCollection = new EntityCollection<FeedbackDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.Subject == Subject);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedbackDetailCollection, filter, 0, null);
			}
			return _FeedbackDetailCollection;
		}
		
		// Return EntityCollection<FeedbackDetailEntity>
		public EntityCollection<FeedbackDetailEntity> SelectBySubjectLST_Paged(string Subject, int PageNumber, int PageSize)
		{
			EntityCollection<FeedbackDetailEntity> _FeedbackDetailCollection = new EntityCollection<FeedbackDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.Subject == Subject);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedbackDetailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _FeedbackDetailCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySubjectRDT(string Subject)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedbackDetailCollection = new EntityCollection(new FeedbackDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.Subject == Subject);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedbackDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySubjectRDT_Paged(string Subject, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedbackDetailCollection = new EntityCollection(new FeedbackDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.Subject == Subject);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedbackDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<FeedbackDetailEntity>
		public EntityCollection<FeedbackDetailEntity> SelectByBodyLST(string Body)
		{
			EntityCollection<FeedbackDetailEntity> _FeedbackDetailCollection = new EntityCollection<FeedbackDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.Body == Body);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedbackDetailCollection, filter, 0, null);
			}
			return _FeedbackDetailCollection;
		}
		
		// Return EntityCollection<FeedbackDetailEntity>
		public EntityCollection<FeedbackDetailEntity> SelectByBodyLST_Paged(string Body, int PageNumber, int PageSize)
		{
			EntityCollection<FeedbackDetailEntity> _FeedbackDetailCollection = new EntityCollection<FeedbackDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.Body == Body);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedbackDetailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _FeedbackDetailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByBodyRDT(string Body)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedbackDetailCollection = new EntityCollection(new FeedbackDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.Body == Body);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedbackDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByBodyRDT_Paged(string Body, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedbackDetailCollection = new EntityCollection(new FeedbackDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.Body == Body);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedbackDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<FeedbackDetailEntity>
		public EntityCollection<FeedbackDetailEntity> SelectByCreatedByLST(string CreatedBy)
		{
			EntityCollection<FeedbackDetailEntity> _FeedbackDetailCollection = new EntityCollection<FeedbackDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedbackDetailCollection, filter, 0, null);
			}
			return _FeedbackDetailCollection;
		}
		
		// Return EntityCollection<FeedbackDetailEntity>
		public EntityCollection<FeedbackDetailEntity> SelectByCreatedByLST_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<FeedbackDetailEntity> _FeedbackDetailCollection = new EntityCollection<FeedbackDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedbackDetailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _FeedbackDetailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT(string CreatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedbackDetailCollection = new EntityCollection(new FeedbackDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedbackDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedbackDetailCollection = new EntityCollection(new FeedbackDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedbackDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<FeedbackDetailEntity>
		public EntityCollection<FeedbackDetailEntity> SelectByCreatedDateLST(DateTime CreatedDate)
		{
			EntityCollection<FeedbackDetailEntity> _FeedbackDetailCollection = new EntityCollection<FeedbackDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedbackDetailCollection, filter, 0, null);
			}
			return _FeedbackDetailCollection;
		}
		
		// Return EntityCollection<FeedbackDetailEntity>
		public EntityCollection<FeedbackDetailEntity> SelectByCreatedDateLST_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<FeedbackDetailEntity> _FeedbackDetailCollection = new EntityCollection<FeedbackDetailEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_FeedbackDetailCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _FeedbackDetailCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT(DateTime CreatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedbackDetailCollection = new EntityCollection(new FeedbackDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedbackDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _FeedbackDetailCollection = new EntityCollection(new FeedbackDetailEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(FeedbackDetailFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_FeedbackDetailCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
