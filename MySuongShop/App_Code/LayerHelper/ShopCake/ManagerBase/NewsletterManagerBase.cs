


/*
'===============================================================================
'  LayerHelper.ShopCake.BL.NewsletterManagerBase
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
	public class NewsletterManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public NewsletterManagerBase()
		{
			// Nothing for now.
		}
		
		public NewsletterEntity Insert(NewsletterEntity _NewsletterEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_NewsletterEntity, true);
			}
			return _NewsletterEntity;
		}

		
		public NewsletterEntity Insert(Guid Id, string Subject, string Body, DateTime SendDate, bool IsSend, string EmailSend, string EmailQueue, string State, DateTime StartDate, DateTime EndDate, bool IsEnable, string CreatedBy, DateTime CreatedDate, string UpdatedBy, DateTime UpdatedDate, bool IsSendAll)
		{
			NewsletterEntity _NewsletterEntity = new NewsletterEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NewsletterEntity.Id = Id;
				_NewsletterEntity.Subject = Subject;
				_NewsletterEntity.Body = Body;
				_NewsletterEntity.SendDate = SendDate;
				_NewsletterEntity.IsSend = IsSend;
				_NewsletterEntity.EmailSend = EmailSend;
				_NewsletterEntity.EmailQueue = EmailQueue;
				_NewsletterEntity.State = State;
				_NewsletterEntity.StartDate = StartDate;
				_NewsletterEntity.EndDate = EndDate;
				_NewsletterEntity.IsEnable = IsEnable;
				_NewsletterEntity.CreatedBy = CreatedBy;
				_NewsletterEntity.CreatedDate = CreatedDate;
				_NewsletterEntity.UpdatedBy = UpdatedBy;
				_NewsletterEntity.UpdatedDate = UpdatedDate;
				_NewsletterEntity.IsSendAll = IsSendAll;
				adapter.SaveEntity(_NewsletterEntity, true);
			}
			return _NewsletterEntity;
		}

		public NewsletterEntity Insert(string Subject, string Body, DateTime SendDate, bool IsSend, string EmailSend, string EmailQueue, string State, DateTime StartDate, DateTime EndDate, bool IsEnable, string CreatedBy, DateTime CreatedDate, string UpdatedBy, DateTime UpdatedDate, bool IsSendAll)
		{
			NewsletterEntity _NewsletterEntity = new NewsletterEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_NewsletterEntity.Subject = Subject;
				_NewsletterEntity.Body = Body;
				_NewsletterEntity.SendDate = SendDate;
				_NewsletterEntity.IsSend = IsSend;
				_NewsletterEntity.EmailSend = EmailSend;
				_NewsletterEntity.EmailQueue = EmailQueue;
				_NewsletterEntity.State = State;
				_NewsletterEntity.StartDate = StartDate;
				_NewsletterEntity.EndDate = EndDate;
				_NewsletterEntity.IsEnable = IsEnable;
				_NewsletterEntity.CreatedBy = CreatedBy;
				_NewsletterEntity.CreatedDate = CreatedDate;
				_NewsletterEntity.UpdatedBy = UpdatedBy;
				_NewsletterEntity.UpdatedDate = UpdatedDate;
				_NewsletterEntity.IsSendAll = IsSendAll;
				adapter.SaveEntity(_NewsletterEntity, true);
			}
			return _NewsletterEntity;
		}

		public bool Update(NewsletterEntity _NewsletterEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(NewsletterFields.Id == _NewsletterEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_NewsletterEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(NewsletterEntity _NewsletterEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_NewsletterEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string Subject, string Body, DateTime SendDate, bool IsSend, string EmailSend, string EmailQueue, string State, DateTime StartDate, DateTime EndDate, bool IsEnable, string CreatedBy, DateTime CreatedDate, string UpdatedBy, DateTime UpdatedDate, bool IsSendAll)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NewsletterEntity _NewsletterEntity = new NewsletterEntity(Id);
				if (adapter.FetchEntity(_NewsletterEntity))
				{
				
					_NewsletterEntity.Subject = Subject;
					_NewsletterEntity.Body = Body;
					_NewsletterEntity.SendDate = SendDate;
					_NewsletterEntity.IsSend = IsSend;
					_NewsletterEntity.EmailSend = EmailSend;
					_NewsletterEntity.EmailQueue = EmailQueue;
					_NewsletterEntity.State = State;
					_NewsletterEntity.StartDate = StartDate;
					_NewsletterEntity.EndDate = EndDate;
					_NewsletterEntity.IsEnable = IsEnable;
					_NewsletterEntity.CreatedBy = CreatedBy;
					_NewsletterEntity.CreatedDate = CreatedDate;
					_NewsletterEntity.UpdatedBy = UpdatedBy;
					_NewsletterEntity.UpdatedDate = UpdatedDate;
					_NewsletterEntity.IsSendAll = IsSendAll;
					adapter.SaveEntity(_NewsletterEntity, true);
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
				NewsletterEntity _NewsletterEntity = new NewsletterEntity(Id);
				if (adapter.FetchEntity(_NewsletterEntity))
				{
					adapter.DeleteEntity(_NewsletterEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("NewsletterEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NewsletterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySubject(string Subject)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.Subject == Subject);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NewsletterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByBody(string Body)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.Body == Body);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NewsletterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySendDate(DateTime SendDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.SendDate == SendDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NewsletterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsSend(bool IsSend)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.IsSend == IsSend);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NewsletterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEmailSend(string EmailSend)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.EmailSend == EmailSend);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NewsletterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEmailQueue(string EmailQueue)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.EmailQueue == EmailQueue);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NewsletterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByState(string State)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.State == State);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NewsletterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByStartDate(DateTime StartDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.StartDate == StartDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NewsletterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEndDate(DateTime EndDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.EndDate == EndDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NewsletterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsEnable(bool IsEnable)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.IsEnable == IsEnable);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NewsletterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedBy(string CreatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NewsletterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedDate(DateTime CreatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NewsletterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedBy(string UpdatedBy)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NewsletterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUpdatedDate(DateTime UpdatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NewsletterEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsSendAll(bool IsSendAll)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.IsSendAll == IsSendAll);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("NewsletterEntity", filter);
			}
			return toReturn;
		}
		

		
		public NewsletterEntity SelectOne(Guid Id)
		{
			NewsletterEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				NewsletterEntity _NewsletterEntity = new NewsletterEntity(Id);
				if (adapter.FetchEntity(_NewsletterEntity))
				{
					toReturn = _NewsletterEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectAllLST()
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, null, 0, null);
			}
			return _NewsletterCollection;
		}
		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterCollection;
		}


		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null);
			}
			return _NewsletterCollection;
		}
		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectBySubjectLST(string Subject)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.Subject == Subject);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null);
			}
			return _NewsletterCollection;
		}
		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectBySubjectLST_Paged(string Subject, int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.Subject == Subject);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySubjectRDT(string Subject)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.Subject == Subject);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySubjectRDT_Paged(string Subject, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.Subject == Subject);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByBodyLST(string Body)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.Body == Body);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null);
			}
			return _NewsletterCollection;
		}
		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByBodyLST_Paged(string Body, int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.Body == Body);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByBodyRDT(string Body)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.Body == Body);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByBodyRDT_Paged(string Body, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.Body == Body);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectBySendDateLST(DateTime SendDate)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.SendDate == SendDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null);
			}
			return _NewsletterCollection;
		}
		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectBySendDateLST_Paged(DateTime SendDate, int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.SendDate == SendDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySendDateRDT(DateTime SendDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.SendDate == SendDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySendDateRDT_Paged(DateTime SendDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.SendDate == SendDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByIsSendLST(bool IsSend)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.IsSend == IsSend);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null);
			}
			return _NewsletterCollection;
		}
		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByIsSendLST_Paged(bool IsSend, int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.IsSend == IsSend);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsSendRDT(bool IsSend)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.IsSend == IsSend);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsSendRDT_Paged(bool IsSend, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.IsSend == IsSend);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByEmailSendLST(string EmailSend)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.EmailSend == EmailSend);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null);
			}
			return _NewsletterCollection;
		}
		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByEmailSendLST_Paged(string EmailSend, int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.EmailSend == EmailSend);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEmailSendRDT(string EmailSend)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.EmailSend == EmailSend);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEmailSendRDT_Paged(string EmailSend, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.EmailSend == EmailSend);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByEmailQueueLST(string EmailQueue)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.EmailQueue == EmailQueue);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null);
			}
			return _NewsletterCollection;
		}
		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByEmailQueueLST_Paged(string EmailQueue, int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.EmailQueue == EmailQueue);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEmailQueueRDT(string EmailQueue)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.EmailQueue == EmailQueue);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEmailQueueRDT_Paged(string EmailQueue, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.EmailQueue == EmailQueue);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByStateLST(string State)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.State == State);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null);
			}
			return _NewsletterCollection;
		}
		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByStateLST_Paged(string State, int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.State == State);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByStateRDT(string State)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.State == State);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByStateRDT_Paged(string State, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.State == State);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByStartDateLST(DateTime StartDate)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.StartDate == StartDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null);
			}
			return _NewsletterCollection;
		}
		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByStartDateLST_Paged(DateTime StartDate, int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.StartDate == StartDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByStartDateRDT(DateTime StartDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.StartDate == StartDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByStartDateRDT_Paged(DateTime StartDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.StartDate == StartDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByEndDateLST(DateTime EndDate)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.EndDate == EndDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null);
			}
			return _NewsletterCollection;
		}
		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByEndDateLST_Paged(DateTime EndDate, int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.EndDate == EndDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEndDateRDT(DateTime EndDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.EndDate == EndDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEndDateRDT_Paged(DateTime EndDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.EndDate == EndDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByIsEnableLST(bool IsEnable)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.IsEnable == IsEnable);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null);
			}
			return _NewsletterCollection;
		}
		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByIsEnableLST_Paged(bool IsEnable, int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.IsEnable == IsEnable);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsEnableRDT(bool IsEnable)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.IsEnable == IsEnable);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsEnableRDT_Paged(bool IsEnable, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.IsEnable == IsEnable);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByCreatedByLST(string CreatedBy)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null);
			}
			return _NewsletterCollection;
		}
		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByCreatedByLST_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT(string CreatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedByRDT_Paged(string CreatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.CreatedBy == CreatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByCreatedDateLST(DateTime CreatedDate)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null);
			}
			return _NewsletterCollection;
		}
		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByCreatedDateLST_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT(DateTime CreatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByUpdatedByLST(string UpdatedBy)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null);
			}
			return _NewsletterCollection;
		}
		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByUpdatedByLST_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT(string UpdatedBy)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedByRDT_Paged(string UpdatedBy, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.UpdatedBy == UpdatedBy);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByUpdatedDateLST(DateTime UpdatedDate)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null);
			}
			return _NewsletterCollection;
		}
		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByUpdatedDateLST_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT(DateTime UpdatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUpdatedDateRDT_Paged(DateTime UpdatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.UpdatedDate == UpdatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByIsSendAllLST(bool IsSendAll)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.IsSendAll == IsSendAll);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null);
			}
			return _NewsletterCollection;
		}
		
		// Return EntityCollection<NewsletterEntity>
		public EntityCollection<NewsletterEntity> SelectByIsSendAllLST_Paged(bool IsSendAll, int PageNumber, int PageSize)
		{
			EntityCollection<NewsletterEntity> _NewsletterCollection = new EntityCollection<NewsletterEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.IsSendAll == IsSendAll);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_NewsletterCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _NewsletterCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsSendAllRDT(bool IsSendAll)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.IsSendAll == IsSendAll);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsSendAllRDT_Paged(bool IsSendAll, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _NewsletterCollection = new EntityCollection(new NewsletterEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(NewsletterFields.IsSendAll == IsSendAll);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_NewsletterCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
