


/*
'===============================================================================
'  LayerHelper.ShopCake.BL.CustomerCollectionManagerBase
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
	public class CustomerCollectionManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public CustomerCollectionManagerBase()
		{
			// Nothing for now.
		}
		
		public CustomerCollectionEntity Insert(CustomerCollectionEntity _CustomerCollectionEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_CustomerCollectionEntity, true);
			}
			return _CustomerCollectionEntity;
		}

		
		public CustomerCollectionEntity Insert(Guid Id, string Name, string Address, string Phone, string Email, DateTime Birthday, string Information, DateTime CreatedDate, Guid EmployeeId, Guid GroupId, int DistrictId)
		{
			CustomerCollectionEntity _CustomerCollectionEntity = new CustomerCollectionEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_CustomerCollectionEntity.Id = Id;
				_CustomerCollectionEntity.Name = Name;
				_CustomerCollectionEntity.Address = Address;
				_CustomerCollectionEntity.Phone = Phone;
				_CustomerCollectionEntity.Email = Email;
				_CustomerCollectionEntity.Birthday = Birthday;
				_CustomerCollectionEntity.Information = Information;
				_CustomerCollectionEntity.CreatedDate = CreatedDate;
				_CustomerCollectionEntity.EmployeeId = EmployeeId;
				_CustomerCollectionEntity.GroupId = GroupId;
				_CustomerCollectionEntity.DistrictId = DistrictId;
				adapter.SaveEntity(_CustomerCollectionEntity, true);
			}
			return _CustomerCollectionEntity;
		}

		public CustomerCollectionEntity Insert(string Name, string Address, string Phone, string Email, DateTime Birthday, string Information, DateTime CreatedDate, Guid EmployeeId, Guid GroupId, int DistrictId)
		{
			CustomerCollectionEntity _CustomerCollectionEntity = new CustomerCollectionEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_CustomerCollectionEntity.Name = Name;
				_CustomerCollectionEntity.Address = Address;
				_CustomerCollectionEntity.Phone = Phone;
				_CustomerCollectionEntity.Email = Email;
				_CustomerCollectionEntity.Birthday = Birthday;
				_CustomerCollectionEntity.Information = Information;
				_CustomerCollectionEntity.CreatedDate = CreatedDate;
				_CustomerCollectionEntity.EmployeeId = EmployeeId;
				_CustomerCollectionEntity.GroupId = GroupId;
				_CustomerCollectionEntity.DistrictId = DistrictId;
				adapter.SaveEntity(_CustomerCollectionEntity, true);
			}
			return _CustomerCollectionEntity;
		}

		public bool Update(CustomerCollectionEntity _CustomerCollectionEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(CustomerCollectionFields.Id == _CustomerCollectionEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_CustomerCollectionEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(CustomerCollectionEntity _CustomerCollectionEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_CustomerCollectionEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string Name, string Address, string Phone, string Email, DateTime Birthday, string Information, DateTime CreatedDate, Guid EmployeeId, Guid GroupId, int DistrictId)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CustomerCollectionEntity _CustomerCollectionEntity = new CustomerCollectionEntity(Id);
				if (adapter.FetchEntity(_CustomerCollectionEntity))
				{
				
					_CustomerCollectionEntity.Name = Name;
					_CustomerCollectionEntity.Address = Address;
					_CustomerCollectionEntity.Phone = Phone;
					_CustomerCollectionEntity.Email = Email;
					_CustomerCollectionEntity.Birthday = Birthday;
					_CustomerCollectionEntity.Information = Information;
					_CustomerCollectionEntity.CreatedDate = CreatedDate;
					_CustomerCollectionEntity.EmployeeId = EmployeeId;
					_CustomerCollectionEntity.GroupId = GroupId;
					_CustomerCollectionEntity.DistrictId = DistrictId;
					adapter.SaveEntity(_CustomerCollectionEntity, true);
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
				CustomerCollectionEntity _CustomerCollectionEntity = new CustomerCollectionEntity(Id);
				if (adapter.FetchEntity(_CustomerCollectionEntity))
				{
					adapter.DeleteEntity(_CustomerCollectionEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("CustomerCollectionEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomerCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByName(string Name)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomerCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAddress(string Address)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomerCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPhone(string Phone)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomerCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEmail(string Email)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomerCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByBirthday(DateTime Birthday)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Birthday == Birthday);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomerCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByInformation(string Information)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Information == Information);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomerCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByCreatedDate(DateTime CreatedDate)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomerCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByEmployeeId(Guid EmployeeId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.EmployeeId == EmployeeId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomerCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGroupId(Guid GroupId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.GroupId == GroupId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomerCollectionEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDistrictId(int DistrictId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.DistrictId == DistrictId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("CustomerCollectionEntity", filter);
			}
			return toReturn;
		}
		

		
		public CustomerCollectionEntity SelectOne(Guid Id)
		{
			CustomerCollectionEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				CustomerCollectionEntity _CustomerCollectionEntity = new CustomerCollectionEntity(Id);
				if (adapter.FetchEntity(_CustomerCollectionEntity))
				{
					toReturn = _CustomerCollectionEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectAllLST()
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, null, 0, null);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _CustomerCollectionCollection;
		}


		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, filter, 0, null);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectByNameLST(string Name)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, filter, 0, null);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectByNameLST_Paged(string Name, int PageNumber, int PageSize)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNameRDT(string Name)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNameRDT_Paged(string Name, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectByAddressLST(string Address)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, filter, 0, null);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectByAddressLST_Paged(string Address, int PageNumber, int PageSize)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAddressRDT(string Address)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAddressRDT_Paged(string Address, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectByPhoneLST(string Phone)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, filter, 0, null);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectByPhoneLST_Paged(string Phone, int PageNumber, int PageSize)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPhoneRDT(string Phone)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPhoneRDT_Paged(string Phone, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectByEmailLST(string Email)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, filter, 0, null);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectByEmailLST_Paged(string Email, int PageNumber, int PageSize)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEmailRDT(string Email)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEmailRDT_Paged(string Email, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Email == Email);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectByBirthdayLST(DateTime Birthday)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Birthday == Birthday);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, filter, 0, null);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectByBirthdayLST_Paged(DateTime Birthday, int PageNumber, int PageSize)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Birthday == Birthday);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByBirthdayRDT(DateTime Birthday)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Birthday == Birthday);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByBirthdayRDT_Paged(DateTime Birthday, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Birthday == Birthday);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectByInformationLST(string Information)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Information == Information);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, filter, 0, null);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectByInformationLST_Paged(string Information, int PageNumber, int PageSize)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Information == Information);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByInformationRDT(string Information)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Information == Information);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByInformationRDT_Paged(string Information, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.Information == Information);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectByCreatedDateLST(DateTime CreatedDate)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, filter, 0, null);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectByCreatedDateLST_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT(DateTime CreatedDate)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByCreatedDateRDT_Paged(DateTime CreatedDate, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.CreatedDate == CreatedDate);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectByEmployeeIdLST(Guid EmployeeId)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.EmployeeId == EmployeeId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, filter, 0, null);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectByEmployeeIdLST_Paged(Guid EmployeeId, int PageNumber, int PageSize)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.EmployeeId == EmployeeId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByEmployeeIdRDT(Guid EmployeeId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.EmployeeId == EmployeeId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByEmployeeIdRDT_Paged(Guid EmployeeId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.EmployeeId == EmployeeId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectByGroupIdLST(Guid GroupId)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.GroupId == GroupId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, filter, 0, null);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectByGroupIdLST_Paged(Guid GroupId, int PageNumber, int PageSize)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.GroupId == GroupId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGroupIdRDT(Guid GroupId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.GroupId == GroupId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGroupIdRDT_Paged(Guid GroupId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.GroupId == GroupId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectByDistrictIdLST(int DistrictId)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.DistrictId == DistrictId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, filter, 0, null);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return EntityCollection<CustomerCollectionEntity>
		public EntityCollection<CustomerCollectionEntity> SelectByDistrictIdLST_Paged(int DistrictId, int PageNumber, int PageSize)
		{
			EntityCollection<CustomerCollectionEntity> _CustomerCollectionCollection = new EntityCollection<CustomerCollectionEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.DistrictId == DistrictId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_CustomerCollectionCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _CustomerCollectionCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDistrictIdRDT(int DistrictId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.DistrictId == DistrictId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDistrictIdRDT_Paged(int DistrictId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _CustomerCollectionCollection = new EntityCollection(new CustomerCollectionEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(CustomerCollectionFields.DistrictId == DistrictId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_CustomerCollectionCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
