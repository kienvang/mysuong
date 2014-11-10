




/*
'===============================================================================
'  LayerHelper.Service.BL.AspnetWebEventEventsManagerBase
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
	public class AspnetWebEventEventsManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AspnetWebEventEventsManagerBase()
		{
			// Nothing for now.
		}
		
		public AspnetWebEventEventsEntity Insert(AspnetWebEventEventsEntity _AspnetWebEventEventsEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_AspnetWebEventEventsEntity, true);
			}
			return _AspnetWebEventEventsEntity;
		}

		
		public AspnetWebEventEventsEntity Insert(string EventId, DateTime EventTimeUtc, DateTime EventTime, string EventType, decimal EventSequence, decimal EventOccurrence, int EventCode, int EventDetailCode, string Message, string ApplicationPath, string ApplicationVirtualPath, string MachineName, string RequestUrl, string ExceptionType, string Details)
		{
			AspnetWebEventEventsEntity _AspnetWebEventEventsEntity = new AspnetWebEventEventsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AspnetWebEventEventsEntity.EventId = EventId;
				_AspnetWebEventEventsEntity.EventTimeUtc = EventTimeUtc;
				_AspnetWebEventEventsEntity.EventTime = EventTime;
				_AspnetWebEventEventsEntity.EventType = EventType;
				_AspnetWebEventEventsEntity.EventSequence = EventSequence;
				_AspnetWebEventEventsEntity.EventOccurrence = EventOccurrence;
				_AspnetWebEventEventsEntity.EventCode = EventCode;
				_AspnetWebEventEventsEntity.EventDetailCode = EventDetailCode;
				_AspnetWebEventEventsEntity.Message = Message;
				_AspnetWebEventEventsEntity.ApplicationPath = ApplicationPath;
				_AspnetWebEventEventsEntity.ApplicationVirtualPath = ApplicationVirtualPath;
				_AspnetWebEventEventsEntity.MachineName = MachineName;
				_AspnetWebEventEventsEntity.RequestUrl = RequestUrl;
				_AspnetWebEventEventsEntity.ExceptionType = ExceptionType;
				_AspnetWebEventEventsEntity.Details = Details;
				adapter.SaveEntity(_AspnetWebEventEventsEntity, true);
			}
			return _AspnetWebEventEventsEntity;
		}

		public AspnetWebEventEventsEntity Insert(DateTime EventTimeUtc, DateTime EventTime, string EventType, decimal EventSequence, decimal EventOccurrence, int EventCode, int EventDetailCode, string Message, string ApplicationPath, string ApplicationVirtualPath, string MachineName, string RequestUrl, string ExceptionType, string Details)
		{
			AspnetWebEventEventsEntity _AspnetWebEventEventsEntity = new AspnetWebEventEventsEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AspnetWebEventEventsEntity.EventTimeUtc = EventTimeUtc;
				_AspnetWebEventEventsEntity.EventTime = EventTime;
				_AspnetWebEventEventsEntity.EventType = EventType;
				_AspnetWebEventEventsEntity.EventSequence = EventSequence;
				_AspnetWebEventEventsEntity.EventOccurrence = EventOccurrence;
				_AspnetWebEventEventsEntity.EventCode = EventCode;
				_AspnetWebEventEventsEntity.EventDetailCode = EventDetailCode;
				_AspnetWebEventEventsEntity.Message = Message;
				_AspnetWebEventEventsEntity.ApplicationPath = ApplicationPath;
				_AspnetWebEventEventsEntity.ApplicationVirtualPath = ApplicationVirtualPath;
				_AspnetWebEventEventsEntity.MachineName = MachineName;
				_AspnetWebEventEventsEntity.RequestUrl = RequestUrl;
				_AspnetWebEventEventsEntity.ExceptionType = ExceptionType;
				_AspnetWebEventEventsEntity.Details = Details;
				adapter.SaveEntity(_AspnetWebEventEventsEntity, true);
			}
			return _AspnetWebEventEventsEntity;
		}

		public bool Update(AspnetWebEventEventsEntity _AspnetWebEventEventsEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(AspnetWebEventEventsFields.EventId == _AspnetWebEventEventsEntity.EventId);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_AspnetWebEventEventsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(AspnetWebEventEventsEntity _AspnetWebEventEventsEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_AspnetWebEventEventsEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(string EventId, DateTime EventTimeUtc, DateTime EventTime, string EventType, decimal EventSequence, decimal EventOccurrence, int EventCode, int EventDetailCode, string Message, string ApplicationPath, string ApplicationVirtualPath, string MachineName, string RequestUrl, string ExceptionType, string Details)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetWebEventEventsEntity _AspnetWebEventEventsEntity = new AspnetWebEventEventsEntity(EventId);
				if (adapter.FetchEntity(_AspnetWebEventEventsEntity))
				{
				
					_AspnetWebEventEventsEntity.EventTimeUtc = EventTimeUtc;
					_AspnetWebEventEventsEntity.EventTime = EventTime;
					_AspnetWebEventEventsEntity.EventType = EventType;
					_AspnetWebEventEventsEntity.EventSequence = EventSequence;
					_AspnetWebEventEventsEntity.EventOccurrence = EventOccurrence;
					_AspnetWebEventEventsEntity.EventCode = EventCode;
					_AspnetWebEventEventsEntity.EventDetailCode = EventDetailCode;
					_AspnetWebEventEventsEntity.Message = Message;
					_AspnetWebEventEventsEntity.ApplicationPath = ApplicationPath;
					_AspnetWebEventEventsEntity.ApplicationVirtualPath = ApplicationVirtualPath;
					_AspnetWebEventEventsEntity.MachineName = MachineName;
					_AspnetWebEventEventsEntity.RequestUrl = RequestUrl;
					_AspnetWebEventEventsEntity.ExceptionType = ExceptionType;
					_AspnetWebEventEventsEntity.Details = Details;
					adapter.SaveEntity(_AspnetWebEventEventsEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(string EventId)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetWebEventEventsEntity _AspnetWebEventEventsEntity = new AspnetWebEventEventsEntity(EventId);
				if (adapter.FetchEntity(_AspnetWebEventEventsEntity))
				{
					adapter.DeleteEntity(_AspnetWebEventEventsEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("AspnetWebEventEventsEntity", null);
			}
		}
		
		
		public int DeleteByEventId(string EventId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventId == EventId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetWebEventEventsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEventTimeUtc(DateTime EventTimeUtc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventTimeUtc == EventTimeUtc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetWebEventEventsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEventTime(DateTime EventTime)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventTime == EventTime);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetWebEventEventsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEventType(string EventType)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventType == EventType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetWebEventEventsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEventSequence(decimal EventSequence)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventSequence == EventSequence);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetWebEventEventsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEventOccurrence(decimal EventOccurrence)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventOccurrence == EventOccurrence);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetWebEventEventsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEventCode(int EventCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventCode == EventCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetWebEventEventsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEventDetailCode(int EventDetailCode)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventDetailCode == EventDetailCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetWebEventEventsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMessage(string Message)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.Message == Message);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetWebEventEventsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByApplicationPath(string ApplicationPath)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.ApplicationPath == ApplicationPath);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetWebEventEventsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByApplicationVirtualPath(string ApplicationVirtualPath)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.ApplicationVirtualPath == ApplicationVirtualPath);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetWebEventEventsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMachineName(string MachineName)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.MachineName == MachineName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetWebEventEventsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByRequestUrl(string RequestUrl)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.RequestUrl == RequestUrl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetWebEventEventsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByExceptionType(string ExceptionType)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.ExceptionType == ExceptionType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetWebEventEventsEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDetails(string Details)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.Details == Details);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetWebEventEventsEntity", filter);
			}
			return toReturn;
		}
		

		
		public AspnetWebEventEventsEntity SelectOne(string EventId)
		{
			AspnetWebEventEventsEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetWebEventEventsEntity _AspnetWebEventEventsEntity = new AspnetWebEventEventsEntity(EventId);
				if (adapter.FetchEntity(_AspnetWebEventEventsEntity))
				{
					toReturn = _AspnetWebEventEventsEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectAllLST()
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, null, 0, null);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetWebEventEventsCollection;
		}


		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByEventIdLST(string EventId)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventId == EventId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByEventIdLST_Paged(string EventId, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventId == EventId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEventIdRDT(string EventId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventId == EventId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEventIdRDT_Paged(string EventId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventId == EventId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByEventTimeUtcLST(DateTime EventTimeUtc)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventTimeUtc == EventTimeUtc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByEventTimeUtcLST_Paged(DateTime EventTimeUtc, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventTimeUtc == EventTimeUtc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEventTimeUtcRDT(DateTime EventTimeUtc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventTimeUtc == EventTimeUtc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEventTimeUtcRDT_Paged(DateTime EventTimeUtc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventTimeUtc == EventTimeUtc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByEventTimeLST(DateTime EventTime)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventTime == EventTime);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByEventTimeLST_Paged(DateTime EventTime, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventTime == EventTime);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEventTimeRDT(DateTime EventTime)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventTime == EventTime);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEventTimeRDT_Paged(DateTime EventTime, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventTime == EventTime);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByEventTypeLST(string EventType)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventType == EventType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByEventTypeLST_Paged(string EventType, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventType == EventType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEventTypeRDT(string EventType)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventType == EventType);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEventTypeRDT_Paged(string EventType, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventType == EventType);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByEventSequenceLST(decimal EventSequence)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventSequence == EventSequence);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByEventSequenceLST_Paged(decimal EventSequence, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventSequence == EventSequence);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEventSequenceRDT(decimal EventSequence)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventSequence == EventSequence);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEventSequenceRDT_Paged(decimal EventSequence, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventSequence == EventSequence);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByEventOccurrenceLST(decimal EventOccurrence)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventOccurrence == EventOccurrence);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByEventOccurrenceLST_Paged(decimal EventOccurrence, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventOccurrence == EventOccurrence);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEventOccurrenceRDT(decimal EventOccurrence)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventOccurrence == EventOccurrence);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEventOccurrenceRDT_Paged(decimal EventOccurrence, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventOccurrence == EventOccurrence);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByEventCodeLST(int EventCode)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventCode == EventCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByEventCodeLST_Paged(int EventCode, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventCode == EventCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEventCodeRDT(int EventCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventCode == EventCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEventCodeRDT_Paged(int EventCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventCode == EventCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByEventDetailCodeLST(int EventDetailCode)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventDetailCode == EventDetailCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByEventDetailCodeLST_Paged(int EventDetailCode, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventDetailCode == EventDetailCode);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEventDetailCodeRDT(int EventDetailCode)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventDetailCode == EventDetailCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEventDetailCodeRDT_Paged(int EventDetailCode, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.EventDetailCode == EventDetailCode);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByMessageLST(string Message)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.Message == Message);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByMessageLST_Paged(string Message, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.Message == Message);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMessageRDT(string Message)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.Message == Message);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMessageRDT_Paged(string Message, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.Message == Message);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByApplicationPathLST(string ApplicationPath)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.ApplicationPath == ApplicationPath);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByApplicationPathLST_Paged(string ApplicationPath, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.ApplicationPath == ApplicationPath);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByApplicationPathRDT(string ApplicationPath)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.ApplicationPath == ApplicationPath);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByApplicationPathRDT_Paged(string ApplicationPath, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.ApplicationPath == ApplicationPath);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByApplicationVirtualPathLST(string ApplicationVirtualPath)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.ApplicationVirtualPath == ApplicationVirtualPath);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByApplicationVirtualPathLST_Paged(string ApplicationVirtualPath, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.ApplicationVirtualPath == ApplicationVirtualPath);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByApplicationVirtualPathRDT(string ApplicationVirtualPath)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.ApplicationVirtualPath == ApplicationVirtualPath);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByApplicationVirtualPathRDT_Paged(string ApplicationVirtualPath, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.ApplicationVirtualPath == ApplicationVirtualPath);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByMachineNameLST(string MachineName)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.MachineName == MachineName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByMachineNameLST_Paged(string MachineName, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.MachineName == MachineName);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMachineNameRDT(string MachineName)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.MachineName == MachineName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMachineNameRDT_Paged(string MachineName, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.MachineName == MachineName);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByRequestUrlLST(string RequestUrl)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.RequestUrl == RequestUrl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByRequestUrlLST_Paged(string RequestUrl, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.RequestUrl == RequestUrl);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByRequestUrlRDT(string RequestUrl)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.RequestUrl == RequestUrl);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByRequestUrlRDT_Paged(string RequestUrl, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.RequestUrl == RequestUrl);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByExceptionTypeLST(string ExceptionType)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.ExceptionType == ExceptionType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByExceptionTypeLST_Paged(string ExceptionType, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.ExceptionType == ExceptionType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByExceptionTypeRDT(string ExceptionType)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.ExceptionType == ExceptionType);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByExceptionTypeRDT_Paged(string ExceptionType, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.ExceptionType == ExceptionType);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByDetailsLST(string Details)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.Details == Details);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return EntityCollection<AspnetWebEventEventsEntity>
		public EntityCollection<AspnetWebEventEventsEntity> SelectByDetailsLST_Paged(string Details, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetWebEventEventsEntity> _AspnetWebEventEventsCollection = new EntityCollection<AspnetWebEventEventsEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.Details == Details);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetWebEventEventsCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetWebEventEventsCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDetailsRDT(string Details)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.Details == Details);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDetailsRDT_Paged(string Details, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetWebEventEventsCollection = new EntityCollection(new AspnetWebEventEventsEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetWebEventEventsFields.Details == Details);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetWebEventEventsCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
