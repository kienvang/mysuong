




/*
'===============================================================================
'  LayerHelper.Service.BL.AspnetMembershipManagerBase
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
	public class AspnetMembershipManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public AspnetMembershipManagerBase()
		{
			// Nothing for now.
		}
		
		public AspnetMembershipEntity Insert(AspnetMembershipEntity _AspnetMembershipEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_AspnetMembershipEntity, true);
			}
			return _AspnetMembershipEntity;
		}

		
		public AspnetMembershipEntity Insert(Guid ApplicationId, Guid UserId, string Password, int PasswordFormat, string PasswordSalt, string MobilePin, string Email, string LoweredEmail, string PasswordQuestion, string PasswordAnswer, bool IsApproved, bool IsLockedOut, DateTime CreateDate, DateTime LastLoginDate, DateTime LastPasswordChangedDate, DateTime LastLockoutDate, int FailedPasswordAttemptCount, DateTime FailedPasswordAttemptWindowStart, int FailedPasswordAnswerAttemptCount, DateTime FailedPasswordAnswerAttemptWindowStart, string Comment)
		{
			AspnetMembershipEntity _AspnetMembershipEntity = new AspnetMembershipEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AspnetMembershipEntity.ApplicationId = ApplicationId;
				_AspnetMembershipEntity.UserId = UserId;
				_AspnetMembershipEntity.Password = Password;
				_AspnetMembershipEntity.PasswordFormat = PasswordFormat;
				_AspnetMembershipEntity.PasswordSalt = PasswordSalt;
				_AspnetMembershipEntity.MobilePin = MobilePin;
				_AspnetMembershipEntity.Email = Email;
				_AspnetMembershipEntity.LoweredEmail = LoweredEmail;
				_AspnetMembershipEntity.PasswordQuestion = PasswordQuestion;
				_AspnetMembershipEntity.PasswordAnswer = PasswordAnswer;
				_AspnetMembershipEntity.IsApproved = IsApproved;
				_AspnetMembershipEntity.IsLockedOut = IsLockedOut;
				_AspnetMembershipEntity.CreateDate = CreateDate;
				_AspnetMembershipEntity.LastLoginDate = LastLoginDate;
				_AspnetMembershipEntity.LastPasswordChangedDate = LastPasswordChangedDate;
				_AspnetMembershipEntity.LastLockoutDate = LastLockoutDate;
				_AspnetMembershipEntity.FailedPasswordAttemptCount = FailedPasswordAttemptCount;
				_AspnetMembershipEntity.FailedPasswordAttemptWindowStart = FailedPasswordAttemptWindowStart;
				_AspnetMembershipEntity.FailedPasswordAnswerAttemptCount = FailedPasswordAnswerAttemptCount;
				_AspnetMembershipEntity.FailedPasswordAnswerAttemptWindowStart = FailedPasswordAnswerAttemptWindowStart;
				_AspnetMembershipEntity.Comment = Comment;
				adapter.SaveEntity(_AspnetMembershipEntity, true);
			}
			return _AspnetMembershipEntity;
		}

		public AspnetMembershipEntity Insert(Guid ApplicationId, string Password, int PasswordFormat, string PasswordSalt, string MobilePin, string Email, string LoweredEmail, string PasswordQuestion, string PasswordAnswer, bool IsApproved, bool IsLockedOut, DateTime CreateDate, DateTime LastLoginDate, DateTime LastPasswordChangedDate, DateTime LastLockoutDate, int FailedPasswordAttemptCount, DateTime FailedPasswordAttemptWindowStart, int FailedPasswordAnswerAttemptCount, DateTime FailedPasswordAnswerAttemptWindowStart, string Comment)
		{
			AspnetMembershipEntity _AspnetMembershipEntity = new AspnetMembershipEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_AspnetMembershipEntity.ApplicationId = ApplicationId;
				_AspnetMembershipEntity.Password = Password;
				_AspnetMembershipEntity.PasswordFormat = PasswordFormat;
				_AspnetMembershipEntity.PasswordSalt = PasswordSalt;
				_AspnetMembershipEntity.MobilePin = MobilePin;
				_AspnetMembershipEntity.Email = Email;
				_AspnetMembershipEntity.LoweredEmail = LoweredEmail;
				_AspnetMembershipEntity.PasswordQuestion = PasswordQuestion;
				_AspnetMembershipEntity.PasswordAnswer = PasswordAnswer;
				_AspnetMembershipEntity.IsApproved = IsApproved;
				_AspnetMembershipEntity.IsLockedOut = IsLockedOut;
				_AspnetMembershipEntity.CreateDate = CreateDate;
				_AspnetMembershipEntity.LastLoginDate = LastLoginDate;
				_AspnetMembershipEntity.LastPasswordChangedDate = LastPasswordChangedDate;
				_AspnetMembershipEntity.LastLockoutDate = LastLockoutDate;
				_AspnetMembershipEntity.FailedPasswordAttemptCount = FailedPasswordAttemptCount;
				_AspnetMembershipEntity.FailedPasswordAttemptWindowStart = FailedPasswordAttemptWindowStart;
				_AspnetMembershipEntity.FailedPasswordAnswerAttemptCount = FailedPasswordAnswerAttemptCount;
				_AspnetMembershipEntity.FailedPasswordAnswerAttemptWindowStart = FailedPasswordAnswerAttemptWindowStart;
				_AspnetMembershipEntity.Comment = Comment;
				adapter.SaveEntity(_AspnetMembershipEntity, true);
			}
			return _AspnetMembershipEntity;
		}

		public bool Update(AspnetMembershipEntity _AspnetMembershipEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(AspnetMembershipFields.UserId == _AspnetMembershipEntity.UserId);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_AspnetMembershipEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(AspnetMembershipEntity _AspnetMembershipEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_AspnetMembershipEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid ApplicationId, Guid UserId, string Password, int PasswordFormat, string PasswordSalt, string MobilePin, string Email, string LoweredEmail, string PasswordQuestion, string PasswordAnswer, bool IsApproved, bool IsLockedOut, DateTime CreateDate, DateTime LastLoginDate, DateTime LastPasswordChangedDate, DateTime LastLockoutDate, int FailedPasswordAttemptCount, DateTime FailedPasswordAttemptWindowStart, int FailedPasswordAnswerAttemptCount, DateTime FailedPasswordAnswerAttemptWindowStart, string Comment)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetMembershipEntity _AspnetMembershipEntity = new AspnetMembershipEntity(UserId);
				if (adapter.FetchEntity(_AspnetMembershipEntity))
				{
				
					_AspnetMembershipEntity.ApplicationId = ApplicationId;
					_AspnetMembershipEntity.Password = Password;
					_AspnetMembershipEntity.PasswordFormat = PasswordFormat;
					_AspnetMembershipEntity.PasswordSalt = PasswordSalt;
					_AspnetMembershipEntity.MobilePin = MobilePin;
					_AspnetMembershipEntity.Email = Email;
					_AspnetMembershipEntity.LoweredEmail = LoweredEmail;
					_AspnetMembershipEntity.PasswordQuestion = PasswordQuestion;
					_AspnetMembershipEntity.PasswordAnswer = PasswordAnswer;
					_AspnetMembershipEntity.IsApproved = IsApproved;
					_AspnetMembershipEntity.IsLockedOut = IsLockedOut;
					_AspnetMembershipEntity.CreateDate = CreateDate;
					_AspnetMembershipEntity.LastLoginDate = LastLoginDate;
					_AspnetMembershipEntity.LastPasswordChangedDate = LastPasswordChangedDate;
					_AspnetMembershipEntity.LastLockoutDate = LastLockoutDate;
					_AspnetMembershipEntity.FailedPasswordAttemptCount = FailedPasswordAttemptCount;
					_AspnetMembershipEntity.FailedPasswordAttemptWindowStart = FailedPasswordAttemptWindowStart;
					_AspnetMembershipEntity.FailedPasswordAnswerAttemptCount = FailedPasswordAnswerAttemptCount;
					_AspnetMembershipEntity.FailedPasswordAnswerAttemptWindowStart = FailedPasswordAnswerAttemptWindowStart;
					_AspnetMembershipEntity.Comment = Comment;
					adapter.SaveEntity(_AspnetMembershipEntity, true);
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
				AspnetMembershipEntity _AspnetMembershipEntity = new AspnetMembershipEntity(UserId);
				if (adapter.FetchEntity(_AspnetMembershipEntity))
				{
					adapter.DeleteEntity(_AspnetMembershipEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("AspnetMembershipEntity", null);
			}
		}
		
		
		public int DeleteByApplicationId(Guid ApplicationId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetMembershipEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUserId(Guid UserId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetMembershipEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPassword(string Password)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.Password == Password);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetMembershipEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPasswordFormat(int PasswordFormat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.PasswordFormat == PasswordFormat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetMembershipEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPasswordSalt(string PasswordSalt)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.PasswordSalt == PasswordSalt);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetMembershipEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMobilePin(string MobilePin)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.MobilePin == MobilePin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetMembershipEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEmail(string Email)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetMembershipEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoweredEmail(string LoweredEmail)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.LoweredEmail == LoweredEmail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetMembershipEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPasswordQuestion(string PasswordQuestion)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.PasswordQuestion == PasswordQuestion);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetMembershipEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPasswordAnswer(string PasswordAnswer)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.PasswordAnswer == PasswordAnswer);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetMembershipEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsApproved(bool IsApproved)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.IsApproved == IsApproved);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetMembershipEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsLockedOut(bool IsLockedOut)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.IsLockedOut == IsLockedOut);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetMembershipEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreateDate(DateTime CreateDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.CreateDate == CreateDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetMembershipEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLastLoginDate(DateTime LastLoginDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.LastLoginDate == LastLoginDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetMembershipEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLastPasswordChangedDate(DateTime LastPasswordChangedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.LastPasswordChangedDate == LastPasswordChangedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetMembershipEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLastLockoutDate(DateTime LastLockoutDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.LastLockoutDate == LastLockoutDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetMembershipEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByFailedPasswordAttemptCount(int FailedPasswordAttemptCount)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.FailedPasswordAttemptCount == FailedPasswordAttemptCount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetMembershipEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByFailedPasswordAttemptWindowStart(DateTime FailedPasswordAttemptWindowStart)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.FailedPasswordAttemptWindowStart == FailedPasswordAttemptWindowStart);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetMembershipEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByFailedPasswordAnswerAttemptCount(int FailedPasswordAnswerAttemptCount)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.FailedPasswordAnswerAttemptCount == FailedPasswordAnswerAttemptCount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetMembershipEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByFailedPasswordAnswerAttemptWindowStart(DateTime FailedPasswordAnswerAttemptWindowStart)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.FailedPasswordAnswerAttemptWindowStart == FailedPasswordAnswerAttemptWindowStart);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetMembershipEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByComment(string Comment)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.Comment == Comment);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("AspnetMembershipEntity", filter);
			}
			return toReturn;
		}
		

		
		public AspnetMembershipEntity SelectOne(Guid UserId)
		{
			AspnetMembershipEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				AspnetMembershipEntity _AspnetMembershipEntity = new AspnetMembershipEntity(UserId);
				if (adapter.FetchEntity(_AspnetMembershipEntity))
				{
					toReturn = _AspnetMembershipEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectAllLST()
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, null, 0, null);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetMembershipCollection;
		}


		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByApplicationIdLST(Guid ApplicationId)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByApplicationIdLST_Paged(Guid ApplicationId, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return DataTable
		public DataTable SelectByApplicationIdRDT(Guid ApplicationId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByApplicationIdRDT_Paged(Guid ApplicationId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.ApplicationId == ApplicationId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByUserIdLST(Guid UserId)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByUserIdLST_Paged(Guid UserId, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUserIdRDT(Guid UserId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUserIdRDT_Paged(Guid UserId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.UserId == UserId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByPasswordLST(string Password)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.Password == Password);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByPasswordLST_Paged(string Password, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.Password == Password);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPasswordRDT(string Password)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.Password == Password);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPasswordRDT_Paged(string Password, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.Password == Password);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByPasswordFormatLST(int PasswordFormat)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.PasswordFormat == PasswordFormat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByPasswordFormatLST_Paged(int PasswordFormat, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.PasswordFormat == PasswordFormat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPasswordFormatRDT(int PasswordFormat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.PasswordFormat == PasswordFormat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPasswordFormatRDT_Paged(int PasswordFormat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.PasswordFormat == PasswordFormat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByPasswordSaltLST(string PasswordSalt)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.PasswordSalt == PasswordSalt);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByPasswordSaltLST_Paged(string PasswordSalt, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.PasswordSalt == PasswordSalt);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPasswordSaltRDT(string PasswordSalt)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.PasswordSalt == PasswordSalt);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPasswordSaltRDT_Paged(string PasswordSalt, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.PasswordSalt == PasswordSalt);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByMobilePinLST(string MobilePin)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.MobilePin == MobilePin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByMobilePinLST_Paged(string MobilePin, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.MobilePin == MobilePin);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMobilePinRDT(string MobilePin)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.MobilePin == MobilePin);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMobilePinRDT_Paged(string MobilePin, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.MobilePin == MobilePin);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByEmailLST(string Email)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByEmailLST_Paged(string Email, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEmailRDT(string Email)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEmailRDT_Paged(string Email, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByLoweredEmailLST(string LoweredEmail)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.LoweredEmail == LoweredEmail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByLoweredEmailLST_Paged(string LoweredEmail, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.LoweredEmail == LoweredEmail);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoweredEmailRDT(string LoweredEmail)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.LoweredEmail == LoweredEmail);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoweredEmailRDT_Paged(string LoweredEmail, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.LoweredEmail == LoweredEmail);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByPasswordQuestionLST(string PasswordQuestion)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.PasswordQuestion == PasswordQuestion);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByPasswordQuestionLST_Paged(string PasswordQuestion, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.PasswordQuestion == PasswordQuestion);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPasswordQuestionRDT(string PasswordQuestion)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.PasswordQuestion == PasswordQuestion);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPasswordQuestionRDT_Paged(string PasswordQuestion, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.PasswordQuestion == PasswordQuestion);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByPasswordAnswerLST(string PasswordAnswer)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.PasswordAnswer == PasswordAnswer);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByPasswordAnswerLST_Paged(string PasswordAnswer, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.PasswordAnswer == PasswordAnswer);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPasswordAnswerRDT(string PasswordAnswer)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.PasswordAnswer == PasswordAnswer);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPasswordAnswerRDT_Paged(string PasswordAnswer, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.PasswordAnswer == PasswordAnswer);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByIsApprovedLST(bool IsApproved)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.IsApproved == IsApproved);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByIsApprovedLST_Paged(bool IsApproved, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.IsApproved == IsApproved);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsApprovedRDT(bool IsApproved)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.IsApproved == IsApproved);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsApprovedRDT_Paged(bool IsApproved, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.IsApproved == IsApproved);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByIsLockedOutLST(bool IsLockedOut)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.IsLockedOut == IsLockedOut);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByIsLockedOutLST_Paged(bool IsLockedOut, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.IsLockedOut == IsLockedOut);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsLockedOutRDT(bool IsLockedOut)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.IsLockedOut == IsLockedOut);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsLockedOutRDT_Paged(bool IsLockedOut, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.IsLockedOut == IsLockedOut);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByCreateDateLST(DateTime CreateDate)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.CreateDate == CreateDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByCreateDateLST_Paged(DateTime CreateDate, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.CreateDate == CreateDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreateDateRDT(DateTime CreateDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.CreateDate == CreateDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreateDateRDT_Paged(DateTime CreateDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.CreateDate == CreateDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByLastLoginDateLST(DateTime LastLoginDate)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.LastLoginDate == LastLoginDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByLastLoginDateLST_Paged(DateTime LastLoginDate, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.LastLoginDate == LastLoginDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLastLoginDateRDT(DateTime LastLoginDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.LastLoginDate == LastLoginDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLastLoginDateRDT_Paged(DateTime LastLoginDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.LastLoginDate == LastLoginDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByLastPasswordChangedDateLST(DateTime LastPasswordChangedDate)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.LastPasswordChangedDate == LastPasswordChangedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByLastPasswordChangedDateLST_Paged(DateTime LastPasswordChangedDate, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.LastPasswordChangedDate == LastPasswordChangedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLastPasswordChangedDateRDT(DateTime LastPasswordChangedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.LastPasswordChangedDate == LastPasswordChangedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLastPasswordChangedDateRDT_Paged(DateTime LastPasswordChangedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.LastPasswordChangedDate == LastPasswordChangedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByLastLockoutDateLST(DateTime LastLockoutDate)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.LastLockoutDate == LastLockoutDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByLastLockoutDateLST_Paged(DateTime LastLockoutDate, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.LastLockoutDate == LastLockoutDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLastLockoutDateRDT(DateTime LastLockoutDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.LastLockoutDate == LastLockoutDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLastLockoutDateRDT_Paged(DateTime LastLockoutDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.LastLockoutDate == LastLockoutDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByFailedPasswordAttemptCountLST(int FailedPasswordAttemptCount)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.FailedPasswordAttemptCount == FailedPasswordAttemptCount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByFailedPasswordAttemptCountLST_Paged(int FailedPasswordAttemptCount, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.FailedPasswordAttemptCount == FailedPasswordAttemptCount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return DataTable
		public DataTable SelectByFailedPasswordAttemptCountRDT(int FailedPasswordAttemptCount)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.FailedPasswordAttemptCount == FailedPasswordAttemptCount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByFailedPasswordAttemptCountRDT_Paged(int FailedPasswordAttemptCount, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.FailedPasswordAttemptCount == FailedPasswordAttemptCount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByFailedPasswordAttemptWindowStartLST(DateTime FailedPasswordAttemptWindowStart)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.FailedPasswordAttemptWindowStart == FailedPasswordAttemptWindowStart);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByFailedPasswordAttemptWindowStartLST_Paged(DateTime FailedPasswordAttemptWindowStart, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.FailedPasswordAttemptWindowStart == FailedPasswordAttemptWindowStart);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return DataTable
		public DataTable SelectByFailedPasswordAttemptWindowStartRDT(DateTime FailedPasswordAttemptWindowStart)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.FailedPasswordAttemptWindowStart == FailedPasswordAttemptWindowStart);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByFailedPasswordAttemptWindowStartRDT_Paged(DateTime FailedPasswordAttemptWindowStart, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.FailedPasswordAttemptWindowStart == FailedPasswordAttemptWindowStart);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByFailedPasswordAnswerAttemptCountLST(int FailedPasswordAnswerAttemptCount)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.FailedPasswordAnswerAttemptCount == FailedPasswordAnswerAttemptCount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByFailedPasswordAnswerAttemptCountLST_Paged(int FailedPasswordAnswerAttemptCount, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.FailedPasswordAnswerAttemptCount == FailedPasswordAnswerAttemptCount);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return DataTable
		public DataTable SelectByFailedPasswordAnswerAttemptCountRDT(int FailedPasswordAnswerAttemptCount)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.FailedPasswordAnswerAttemptCount == FailedPasswordAnswerAttemptCount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByFailedPasswordAnswerAttemptCountRDT_Paged(int FailedPasswordAnswerAttemptCount, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.FailedPasswordAnswerAttemptCount == FailedPasswordAnswerAttemptCount);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByFailedPasswordAnswerAttemptWindowStartLST(DateTime FailedPasswordAnswerAttemptWindowStart)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.FailedPasswordAnswerAttemptWindowStart == FailedPasswordAnswerAttemptWindowStart);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByFailedPasswordAnswerAttemptWindowStartLST_Paged(DateTime FailedPasswordAnswerAttemptWindowStart, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.FailedPasswordAnswerAttemptWindowStart == FailedPasswordAnswerAttemptWindowStart);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return DataTable
		public DataTable SelectByFailedPasswordAnswerAttemptWindowStartRDT(DateTime FailedPasswordAnswerAttemptWindowStart)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.FailedPasswordAnswerAttemptWindowStart == FailedPasswordAnswerAttemptWindowStart);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByFailedPasswordAnswerAttemptWindowStartRDT_Paged(DateTime FailedPasswordAnswerAttemptWindowStart, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.FailedPasswordAnswerAttemptWindowStart == FailedPasswordAnswerAttemptWindowStart);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByCommentLST(string Comment)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.Comment == Comment);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return EntityCollection<AspnetMembershipEntity>
		public EntityCollection<AspnetMembershipEntity> SelectByCommentLST_Paged(string Comment, int PageNumber, int PageSize)
		{
			EntityCollection<AspnetMembershipEntity> _AspnetMembershipCollection = new EntityCollection<AspnetMembershipEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.Comment == Comment);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_AspnetMembershipCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _AspnetMembershipCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCommentRDT(string Comment)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.Comment == Comment);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCommentRDT_Paged(string Comment, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _AspnetMembershipCollection = new EntityCollection(new AspnetMembershipEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(AspnetMembershipFields.Comment == Comment);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_AspnetMembershipCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
