




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.EmployeeManagerBase
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
	public class EmployeeManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public EmployeeManagerBase()
		{
			// Nothing for now.
		}
		
		public EmployeeEntity Insert(EmployeeEntity _EmployeeEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_EmployeeEntity, true);
			}
			return _EmployeeEntity;
		}

		
		public EmployeeEntity Insert(Guid Id, string Username, string Name, string Phone, string Address, DateTime Birthday, Guid BranchId, bool IsManage, bool IsDeleted)
		{
			EmployeeEntity _EmployeeEntity = new EmployeeEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_EmployeeEntity.Id = Id;
				_EmployeeEntity.Username = Username;
				_EmployeeEntity.Name = Name;
				_EmployeeEntity.Phone = Phone;
				_EmployeeEntity.Address = Address;
				_EmployeeEntity.Birthday = Birthday;
				_EmployeeEntity.BranchId = BranchId;
				_EmployeeEntity.IsManage = IsManage;
				_EmployeeEntity.IsDeleted = IsDeleted;
				adapter.SaveEntity(_EmployeeEntity, true);
			}
			return _EmployeeEntity;
		}

		public EmployeeEntity Insert(string Username, string Name, string Phone, string Address, DateTime Birthday, Guid BranchId, bool IsManage, bool IsDeleted)
		{
			EmployeeEntity _EmployeeEntity = new EmployeeEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_EmployeeEntity.Username = Username;
				_EmployeeEntity.Name = Name;
				_EmployeeEntity.Phone = Phone;
				_EmployeeEntity.Address = Address;
				_EmployeeEntity.Birthday = Birthday;
				_EmployeeEntity.BranchId = BranchId;
				_EmployeeEntity.IsManage = IsManage;
				_EmployeeEntity.IsDeleted = IsDeleted;
				adapter.SaveEntity(_EmployeeEntity, true);
			}
			return _EmployeeEntity;
		}

		public bool Update(EmployeeEntity _EmployeeEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(EmployeeFields.Id == _EmployeeEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_EmployeeEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(EmployeeEntity _EmployeeEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_EmployeeEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string Username, string Name, string Phone, string Address, DateTime Birthday, Guid BranchId, bool IsManage, bool IsDeleted)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				EmployeeEntity _EmployeeEntity = new EmployeeEntity(Id);
				if (adapter.FetchEntity(_EmployeeEntity))
				{
				
					_EmployeeEntity.Username = Username;
					_EmployeeEntity.Name = Name;
					_EmployeeEntity.Phone = Phone;
					_EmployeeEntity.Address = Address;
					_EmployeeEntity.Birthday = Birthday;
					_EmployeeEntity.BranchId = BranchId;
					_EmployeeEntity.IsManage = IsManage;
					_EmployeeEntity.IsDeleted = IsDeleted;
					adapter.SaveEntity(_EmployeeEntity, true);
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
				EmployeeEntity _EmployeeEntity = new EmployeeEntity(Id);
				if (adapter.FetchEntity(_EmployeeEntity))
				{
					adapter.DeleteEntity(_EmployeeEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("EmployeeEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EmployeeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUsername(string Username)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Username == Username);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EmployeeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByName(string Name)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EmployeeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPhone(string Phone)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EmployeeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAddress(string Address)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EmployeeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByBirthday(DateTime Birthday)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Birthday == Birthday);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EmployeeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByBranchId(Guid BranchId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.BranchId == BranchId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EmployeeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsManage(bool IsManage)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.IsManage == IsManage);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EmployeeEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsDeleted(bool IsDeleted)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("EmployeeEntity", filter);
			}
			return toReturn;
		}
		

		
		public EmployeeEntity SelectOne(Guid Id)
		{
			EmployeeEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				EmployeeEntity _EmployeeEntity = new EmployeeEntity(Id);
				if (adapter.FetchEntity(_EmployeeEntity))
				{
					toReturn = _EmployeeEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmployeeCollection = new EntityCollection(new EmployeeEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmployeeCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<EmployeeEntity>
		public EntityCollection<EmployeeEntity> SelectAllLST()
		{
			EntityCollection<EmployeeEntity> _EmployeeCollection = new EntityCollection<EmployeeEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmployeeCollection, null, 0, null);
			}
			return _EmployeeCollection;
		}
		
		// Return EntityCollection<EmployeeEntity>
		public EntityCollection<EmployeeEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<EmployeeEntity> _EmployeeCollection = new EntityCollection<EmployeeEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmployeeCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _EmployeeCollection;
		}


		
		// Return EntityCollection<EmployeeEntity>
		public EntityCollection<EmployeeEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<EmployeeEntity> _EmployeeCollection = new EntityCollection<EmployeeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmployeeCollection, filter, 0, null);
			}
			return _EmployeeCollection;
		}
		
		// Return EntityCollection<EmployeeEntity>
		public EntityCollection<EmployeeEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<EmployeeEntity> _EmployeeCollection = new EntityCollection<EmployeeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmployeeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EmployeeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmployeeCollection = new EntityCollection(new EmployeeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmployeeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmployeeCollection = new EntityCollection(new EmployeeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmployeeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EmployeeEntity>
		public EntityCollection<EmployeeEntity> SelectByUsernameLST(string Username)
		{
			EntityCollection<EmployeeEntity> _EmployeeCollection = new EntityCollection<EmployeeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Username == Username);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmployeeCollection, filter, 0, null);
			}
			return _EmployeeCollection;
		}
		
		// Return EntityCollection<EmployeeEntity>
		public EntityCollection<EmployeeEntity> SelectByUsernameLST_Paged(string Username, int PageNumber, int PageSize)
		{
			EntityCollection<EmployeeEntity> _EmployeeCollection = new EntityCollection<EmployeeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Username == Username);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmployeeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EmployeeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUsernameRDT(string Username)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmployeeCollection = new EntityCollection(new EmployeeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Username == Username);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmployeeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUsernameRDT_Paged(string Username, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmployeeCollection = new EntityCollection(new EmployeeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Username == Username);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmployeeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EmployeeEntity>
		public EntityCollection<EmployeeEntity> SelectByNameLST(string Name)
		{
			EntityCollection<EmployeeEntity> _EmployeeCollection = new EntityCollection<EmployeeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmployeeCollection, filter, 0, null);
			}
			return _EmployeeCollection;
		}
		
		// Return EntityCollection<EmployeeEntity>
		public EntityCollection<EmployeeEntity> SelectByNameLST_Paged(string Name, int PageNumber, int PageSize)
		{
			EntityCollection<EmployeeEntity> _EmployeeCollection = new EntityCollection<EmployeeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmployeeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EmployeeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNameRDT(string Name)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmployeeCollection = new EntityCollection(new EmployeeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmployeeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNameRDT_Paged(string Name, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmployeeCollection = new EntityCollection(new EmployeeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmployeeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EmployeeEntity>
		public EntityCollection<EmployeeEntity> SelectByPhoneLST(string Phone)
		{
			EntityCollection<EmployeeEntity> _EmployeeCollection = new EntityCollection<EmployeeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmployeeCollection, filter, 0, null);
			}
			return _EmployeeCollection;
		}
		
		// Return EntityCollection<EmployeeEntity>
		public EntityCollection<EmployeeEntity> SelectByPhoneLST_Paged(string Phone, int PageNumber, int PageSize)
		{
			EntityCollection<EmployeeEntity> _EmployeeCollection = new EntityCollection<EmployeeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmployeeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EmployeeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPhoneRDT(string Phone)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmployeeCollection = new EntityCollection(new EmployeeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmployeeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPhoneRDT_Paged(string Phone, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmployeeCollection = new EntityCollection(new EmployeeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmployeeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EmployeeEntity>
		public EntityCollection<EmployeeEntity> SelectByAddressLST(string Address)
		{
			EntityCollection<EmployeeEntity> _EmployeeCollection = new EntityCollection<EmployeeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmployeeCollection, filter, 0, null);
			}
			return _EmployeeCollection;
		}
		
		// Return EntityCollection<EmployeeEntity>
		public EntityCollection<EmployeeEntity> SelectByAddressLST_Paged(string Address, int PageNumber, int PageSize)
		{
			EntityCollection<EmployeeEntity> _EmployeeCollection = new EntityCollection<EmployeeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmployeeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EmployeeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAddressRDT(string Address)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmployeeCollection = new EntityCollection(new EmployeeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmployeeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAddressRDT_Paged(string Address, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmployeeCollection = new EntityCollection(new EmployeeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmployeeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EmployeeEntity>
		public EntityCollection<EmployeeEntity> SelectByBirthdayLST(DateTime Birthday)
		{
			EntityCollection<EmployeeEntity> _EmployeeCollection = new EntityCollection<EmployeeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Birthday == Birthday);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmployeeCollection, filter, 0, null);
			}
			return _EmployeeCollection;
		}
		
		// Return EntityCollection<EmployeeEntity>
		public EntityCollection<EmployeeEntity> SelectByBirthdayLST_Paged(DateTime Birthday, int PageNumber, int PageSize)
		{
			EntityCollection<EmployeeEntity> _EmployeeCollection = new EntityCollection<EmployeeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Birthday == Birthday);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmployeeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EmployeeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByBirthdayRDT(DateTime Birthday)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmployeeCollection = new EntityCollection(new EmployeeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Birthday == Birthday);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmployeeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByBirthdayRDT_Paged(DateTime Birthday, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmployeeCollection = new EntityCollection(new EmployeeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.Birthday == Birthday);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmployeeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EmployeeEntity>
		public EntityCollection<EmployeeEntity> SelectByBranchIdLST(Guid BranchId)
		{
			EntityCollection<EmployeeEntity> _EmployeeCollection = new EntityCollection<EmployeeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.BranchId == BranchId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmployeeCollection, filter, 0, null);
			}
			return _EmployeeCollection;
		}
		
		// Return EntityCollection<EmployeeEntity>
		public EntityCollection<EmployeeEntity> SelectByBranchIdLST_Paged(Guid BranchId, int PageNumber, int PageSize)
		{
			EntityCollection<EmployeeEntity> _EmployeeCollection = new EntityCollection<EmployeeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.BranchId == BranchId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmployeeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EmployeeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByBranchIdRDT(Guid BranchId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmployeeCollection = new EntityCollection(new EmployeeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.BranchId == BranchId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmployeeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByBranchIdRDT_Paged(Guid BranchId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmployeeCollection = new EntityCollection(new EmployeeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.BranchId == BranchId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmployeeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EmployeeEntity>
		public EntityCollection<EmployeeEntity> SelectByIsManageLST(bool IsManage)
		{
			EntityCollection<EmployeeEntity> _EmployeeCollection = new EntityCollection<EmployeeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.IsManage == IsManage);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmployeeCollection, filter, 0, null);
			}
			return _EmployeeCollection;
		}
		
		// Return EntityCollection<EmployeeEntity>
		public EntityCollection<EmployeeEntity> SelectByIsManageLST_Paged(bool IsManage, int PageNumber, int PageSize)
		{
			EntityCollection<EmployeeEntity> _EmployeeCollection = new EntityCollection<EmployeeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.IsManage == IsManage);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmployeeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EmployeeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsManageRDT(bool IsManage)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmployeeCollection = new EntityCollection(new EmployeeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.IsManage == IsManage);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmployeeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsManageRDT_Paged(bool IsManage, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmployeeCollection = new EntityCollection(new EmployeeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.IsManage == IsManage);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmployeeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<EmployeeEntity>
		public EntityCollection<EmployeeEntity> SelectByIsDeletedLST(bool IsDeleted)
		{
			EntityCollection<EmployeeEntity> _EmployeeCollection = new EntityCollection<EmployeeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmployeeCollection, filter, 0, null);
			}
			return _EmployeeCollection;
		}
		
		// Return EntityCollection<EmployeeEntity>
		public EntityCollection<EmployeeEntity> SelectByIsDeletedLST_Paged(bool IsDeleted, int PageNumber, int PageSize)
		{
			EntityCollection<EmployeeEntity> _EmployeeCollection = new EntityCollection<EmployeeEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_EmployeeCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _EmployeeCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsDeletedRDT(bool IsDeleted)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmployeeCollection = new EntityCollection(new EmployeeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmployeeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsDeletedRDT_Paged(bool IsDeleted, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _EmployeeCollection = new EntityCollection(new EmployeeEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(EmployeeFields.IsDeleted == IsDeleted);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_EmployeeCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
