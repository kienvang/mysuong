


/*
'===============================================================================
'  LayerHelper.ShopCake.BL.BranchManagerBase
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
	public class BranchManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public BranchManagerBase()
		{
			// Nothing for now.
		}
		
		public BranchEntity Insert(BranchEntity _BranchEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_BranchEntity, true);
			}
			return _BranchEntity;
		}

		
		public BranchEntity Insert(Guid Id, string Name, string Address, string Phone, string Photo, double Longitude, double Latitude, bool IsDefault, int SortOrder)
		{
			BranchEntity _BranchEntity = new BranchEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_BranchEntity.Id = Id;
				_BranchEntity.Name = Name;
				_BranchEntity.Address = Address;
				_BranchEntity.Phone = Phone;
				_BranchEntity.Photo = Photo;
				_BranchEntity.Longitude = Longitude;
				_BranchEntity.Latitude = Latitude;
				_BranchEntity.IsDefault = IsDefault;
				_BranchEntity.SortOrder = SortOrder;
				adapter.SaveEntity(_BranchEntity, true);
			}
			return _BranchEntity;
		}

		public BranchEntity Insert(string Name, string Address, string Phone, string Photo, double Longitude, double Latitude, bool IsDefault, int SortOrder)
		{
			BranchEntity _BranchEntity = new BranchEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_BranchEntity.Name = Name;
				_BranchEntity.Address = Address;
				_BranchEntity.Phone = Phone;
				_BranchEntity.Photo = Photo;
				_BranchEntity.Longitude = Longitude;
				_BranchEntity.Latitude = Latitude;
				_BranchEntity.IsDefault = IsDefault;
				_BranchEntity.SortOrder = SortOrder;
				adapter.SaveEntity(_BranchEntity, true);
			}
			return _BranchEntity;
		}

		public bool Update(BranchEntity _BranchEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(BranchFields.Id == _BranchEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_BranchEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(BranchEntity _BranchEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_BranchEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, string Name, string Address, string Phone, string Photo, double Longitude, double Latitude, bool IsDefault, int SortOrder)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				BranchEntity _BranchEntity = new BranchEntity(Id);
				if (adapter.FetchEntity(_BranchEntity))
				{
				
					_BranchEntity.Name = Name;
					_BranchEntity.Address = Address;
					_BranchEntity.Phone = Phone;
					_BranchEntity.Photo = Photo;
					_BranchEntity.Longitude = Longitude;
					_BranchEntity.Latitude = Latitude;
					_BranchEntity.IsDefault = IsDefault;
					_BranchEntity.SortOrder = SortOrder;
					adapter.SaveEntity(_BranchEntity, true);
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
				BranchEntity _BranchEntity = new BranchEntity(Id);
				if (adapter.FetchEntity(_BranchEntity))
				{
					adapter.DeleteEntity(_BranchEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("BranchEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BranchEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByName(string Name)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BranchEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByAddress(string Address)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BranchEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPhone(string Phone)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BranchEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByPhoto(string Photo)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Photo == Photo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BranchEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLongitude(double Longitude)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Longitude == Longitude);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BranchEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLatitude(double Latitude)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Latitude == Latitude);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BranchEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIsDefault(bool IsDefault)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.IsDefault == IsDefault);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BranchEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySortOrder(int SortOrder)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("BranchEntity", filter);
			}
			return toReturn;
		}
		

		
		public BranchEntity SelectOne(Guid Id)
		{
			BranchEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				BranchEntity _BranchEntity = new BranchEntity(Id);
				if (adapter.FetchEntity(_BranchEntity))
				{
					toReturn = _BranchEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BranchCollection = new EntityCollection(new BranchEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BranchCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<BranchEntity>
		public EntityCollection<BranchEntity> SelectAllLST()
		{
			EntityCollection<BranchEntity> _BranchCollection = new EntityCollection<BranchEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BranchCollection, null, 0, null);
			}
			return _BranchCollection;
		}
		
		// Return EntityCollection<BranchEntity>
		public EntityCollection<BranchEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<BranchEntity> _BranchCollection = new EntityCollection<BranchEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BranchCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _BranchCollection;
		}


		
		// Return EntityCollection<BranchEntity>
		public EntityCollection<BranchEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<BranchEntity> _BranchCollection = new EntityCollection<BranchEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BranchCollection, filter, 0, null);
			}
			return _BranchCollection;
		}
		
		// Return EntityCollection<BranchEntity>
		public EntityCollection<BranchEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<BranchEntity> _BranchCollection = new EntityCollection<BranchEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BranchCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _BranchCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BranchCollection = new EntityCollection(new BranchEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BranchCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BranchCollection = new EntityCollection(new BranchEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BranchCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<BranchEntity>
		public EntityCollection<BranchEntity> SelectByNameLST(string Name)
		{
			EntityCollection<BranchEntity> _BranchCollection = new EntityCollection<BranchEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BranchCollection, filter, 0, null);
			}
			return _BranchCollection;
		}
		
		// Return EntityCollection<BranchEntity>
		public EntityCollection<BranchEntity> SelectByNameLST_Paged(string Name, int PageNumber, int PageSize)
		{
			EntityCollection<BranchEntity> _BranchCollection = new EntityCollection<BranchEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BranchCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _BranchCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNameRDT(string Name)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BranchCollection = new EntityCollection(new BranchEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BranchCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNameRDT_Paged(string Name, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BranchCollection = new EntityCollection(new BranchEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BranchCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<BranchEntity>
		public EntityCollection<BranchEntity> SelectByAddressLST(string Address)
		{
			EntityCollection<BranchEntity> _BranchCollection = new EntityCollection<BranchEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BranchCollection, filter, 0, null);
			}
			return _BranchCollection;
		}
		
		// Return EntityCollection<BranchEntity>
		public EntityCollection<BranchEntity> SelectByAddressLST_Paged(string Address, int PageNumber, int PageSize)
		{
			EntityCollection<BranchEntity> _BranchCollection = new EntityCollection<BranchEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BranchCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _BranchCollection;
		}
		
		// Return DataTable
		public DataTable SelectByAddressRDT(string Address)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BranchCollection = new EntityCollection(new BranchEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BranchCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByAddressRDT_Paged(string Address, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BranchCollection = new EntityCollection(new BranchEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Address == Address);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BranchCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<BranchEntity>
		public EntityCollection<BranchEntity> SelectByPhoneLST(string Phone)
		{
			EntityCollection<BranchEntity> _BranchCollection = new EntityCollection<BranchEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BranchCollection, filter, 0, null);
			}
			return _BranchCollection;
		}
		
		// Return EntityCollection<BranchEntity>
		public EntityCollection<BranchEntity> SelectByPhoneLST_Paged(string Phone, int PageNumber, int PageSize)
		{
			EntityCollection<BranchEntity> _BranchCollection = new EntityCollection<BranchEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BranchCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _BranchCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPhoneRDT(string Phone)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BranchCollection = new EntityCollection(new BranchEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BranchCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPhoneRDT_Paged(string Phone, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BranchCollection = new EntityCollection(new BranchEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Phone == Phone);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BranchCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<BranchEntity>
		public EntityCollection<BranchEntity> SelectByPhotoLST(string Photo)
		{
			EntityCollection<BranchEntity> _BranchCollection = new EntityCollection<BranchEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Photo == Photo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BranchCollection, filter, 0, null);
			}
			return _BranchCollection;
		}
		
		// Return EntityCollection<BranchEntity>
		public EntityCollection<BranchEntity> SelectByPhotoLST_Paged(string Photo, int PageNumber, int PageSize)
		{
			EntityCollection<BranchEntity> _BranchCollection = new EntityCollection<BranchEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Photo == Photo);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BranchCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _BranchCollection;
		}
		
		// Return DataTable
		public DataTable SelectByPhotoRDT(string Photo)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BranchCollection = new EntityCollection(new BranchEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Photo == Photo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BranchCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByPhotoRDT_Paged(string Photo, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BranchCollection = new EntityCollection(new BranchEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Photo == Photo);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BranchCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<BranchEntity>
		public EntityCollection<BranchEntity> SelectByLongitudeLST(double Longitude)
		{
			EntityCollection<BranchEntity> _BranchCollection = new EntityCollection<BranchEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Longitude == Longitude);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BranchCollection, filter, 0, null);
			}
			return _BranchCollection;
		}
		
		// Return EntityCollection<BranchEntity>
		public EntityCollection<BranchEntity> SelectByLongitudeLST_Paged(double Longitude, int PageNumber, int PageSize)
		{
			EntityCollection<BranchEntity> _BranchCollection = new EntityCollection<BranchEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Longitude == Longitude);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BranchCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _BranchCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLongitudeRDT(double Longitude)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BranchCollection = new EntityCollection(new BranchEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Longitude == Longitude);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BranchCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLongitudeRDT_Paged(double Longitude, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BranchCollection = new EntityCollection(new BranchEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Longitude == Longitude);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BranchCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<BranchEntity>
		public EntityCollection<BranchEntity> SelectByLatitudeLST(double Latitude)
		{
			EntityCollection<BranchEntity> _BranchCollection = new EntityCollection<BranchEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Latitude == Latitude);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BranchCollection, filter, 0, null);
			}
			return _BranchCollection;
		}
		
		// Return EntityCollection<BranchEntity>
		public EntityCollection<BranchEntity> SelectByLatitudeLST_Paged(double Latitude, int PageNumber, int PageSize)
		{
			EntityCollection<BranchEntity> _BranchCollection = new EntityCollection<BranchEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Latitude == Latitude);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BranchCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _BranchCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLatitudeRDT(double Latitude)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BranchCollection = new EntityCollection(new BranchEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Latitude == Latitude);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BranchCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLatitudeRDT_Paged(double Latitude, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BranchCollection = new EntityCollection(new BranchEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.Latitude == Latitude);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BranchCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<BranchEntity>
		public EntityCollection<BranchEntity> SelectByIsDefaultLST(bool IsDefault)
		{
			EntityCollection<BranchEntity> _BranchCollection = new EntityCollection<BranchEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.IsDefault == IsDefault);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BranchCollection, filter, 0, null);
			}
			return _BranchCollection;
		}
		
		// Return EntityCollection<BranchEntity>
		public EntityCollection<BranchEntity> SelectByIsDefaultLST_Paged(bool IsDefault, int PageNumber, int PageSize)
		{
			EntityCollection<BranchEntity> _BranchCollection = new EntityCollection<BranchEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.IsDefault == IsDefault);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BranchCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _BranchCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIsDefaultRDT(bool IsDefault)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BranchCollection = new EntityCollection(new BranchEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.IsDefault == IsDefault);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BranchCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIsDefaultRDT_Paged(bool IsDefault, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BranchCollection = new EntityCollection(new BranchEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.IsDefault == IsDefault);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BranchCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<BranchEntity>
		public EntityCollection<BranchEntity> SelectBySortOrderLST(int SortOrder)
		{
			EntityCollection<BranchEntity> _BranchCollection = new EntityCollection<BranchEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BranchCollection, filter, 0, null);
			}
			return _BranchCollection;
		}
		
		// Return EntityCollection<BranchEntity>
		public EntityCollection<BranchEntity> SelectBySortOrderLST_Paged(int SortOrder, int PageNumber, int PageSize)
		{
			EntityCollection<BranchEntity> _BranchCollection = new EntityCollection<BranchEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_BranchCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _BranchCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySortOrderRDT(int SortOrder)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BranchCollection = new EntityCollection(new BranchEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BranchCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySortOrderRDT_Paged(int SortOrder, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _BranchCollection = new EntityCollection(new BranchEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(BranchFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_BranchCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
