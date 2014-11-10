


/*
'===============================================================================
'  LayerHelper.ShopCake.BL.MenuManagerBase
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
	public class MenuManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public MenuManagerBase()
		{
			// Nothing for now.
		}
		
		public MenuEntity Insert(MenuEntity _MenuEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_MenuEntity, true);
			}
			return _MenuEntity;
		}

		
		public MenuEntity Insert(int Id, string Name, string MenuType, int ItemId, string Url, int SortOrder)
		{
			MenuEntity _MenuEntity = new MenuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_MenuEntity.Id = Id;
				_MenuEntity.Name = Name;
				_MenuEntity.MenuType = MenuType;
				_MenuEntity.ItemId = ItemId;
				_MenuEntity.Url = Url;
				_MenuEntity.SortOrder = SortOrder;
				adapter.SaveEntity(_MenuEntity, true);
			}
			return _MenuEntity;
		}

		public MenuEntity Insert(string Name, string MenuType, int ItemId, string Url, int SortOrder)
		{
			MenuEntity _MenuEntity = new MenuEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_MenuEntity.Name = Name;
				_MenuEntity.MenuType = MenuType;
				_MenuEntity.ItemId = ItemId;
				_MenuEntity.Url = Url;
				_MenuEntity.SortOrder = SortOrder;
				adapter.SaveEntity(_MenuEntity, true);
			}
			return _MenuEntity;
		}

		public bool Update(MenuEntity _MenuEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(MenuFields.Id == _MenuEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_MenuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(MenuEntity _MenuEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_MenuEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(int Id, string Name, string MenuType, int ItemId, string Url, int SortOrder)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				MenuEntity _MenuEntity = new MenuEntity(Id);
				if (adapter.FetchEntity(_MenuEntity))
				{
				
					_MenuEntity.Name = Name;
					_MenuEntity.MenuType = MenuType;
					_MenuEntity.ItemId = ItemId;
					_MenuEntity.Url = Url;
					_MenuEntity.SortOrder = SortOrder;
					adapter.SaveEntity(_MenuEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(int Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				MenuEntity _MenuEntity = new MenuEntity(Id);
				if (adapter.FetchEntity(_MenuEntity))
				{
					adapter.DeleteEntity(_MenuEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("MenuEntity", null);
			}
		}
		
		
		public int DeleteById(int Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MenuEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByName(string Name)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MenuEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMenuType(string MenuType)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.MenuType == MenuType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MenuEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByItemId(int ItemId)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.ItemId == ItemId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MenuEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUrl(string Url)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Url == Url);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MenuEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySortOrder(int SortOrder)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MenuEntity", filter);
			}
			return toReturn;
		}
		

		
		public MenuEntity SelectOne(int Id)
		{
			MenuEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				MenuEntity _MenuEntity = new MenuEntity(Id);
				if (adapter.FetchEntity(_MenuEntity))
				{
					toReturn = _MenuEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<MenuEntity>
		public EntityCollection<MenuEntity> SelectAllLST()
		{
			EntityCollection<MenuEntity> _MenuCollection = new EntityCollection<MenuEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, null, 0, null);
			}
			return _MenuCollection;
		}
		
		// Return EntityCollection<MenuEntity>
		public EntityCollection<MenuEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<MenuEntity> _MenuCollection = new EntityCollection<MenuEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _MenuCollection;
		}


		
		// Return EntityCollection<MenuEntity>
		public EntityCollection<MenuEntity> SelectByIdLST(int Id)
		{
			EntityCollection<MenuEntity> _MenuCollection = new EntityCollection<MenuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null);
			}
			return _MenuCollection;
		}
		
		// Return EntityCollection<MenuEntity>
		public EntityCollection<MenuEntity> SelectByIdLST_Paged(int Id, int PageNumber, int PageSize)
		{
			EntityCollection<MenuEntity> _MenuCollection = new EntityCollection<MenuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MenuCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(int Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(int Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<MenuEntity>
		public EntityCollection<MenuEntity> SelectByNameLST(string Name)
		{
			EntityCollection<MenuEntity> _MenuCollection = new EntityCollection<MenuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null);
			}
			return _MenuCollection;
		}
		
		// Return EntityCollection<MenuEntity>
		public EntityCollection<MenuEntity> SelectByNameLST_Paged(string Name, int PageNumber, int PageSize)
		{
			EntityCollection<MenuEntity> _MenuCollection = new EntityCollection<MenuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MenuCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNameRDT(string Name)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNameRDT_Paged(string Name, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<MenuEntity>
		public EntityCollection<MenuEntity> SelectByMenuTypeLST(string MenuType)
		{
			EntityCollection<MenuEntity> _MenuCollection = new EntityCollection<MenuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.MenuType == MenuType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null);
			}
			return _MenuCollection;
		}
		
		// Return EntityCollection<MenuEntity>
		public EntityCollection<MenuEntity> SelectByMenuTypeLST_Paged(string MenuType, int PageNumber, int PageSize)
		{
			EntityCollection<MenuEntity> _MenuCollection = new EntityCollection<MenuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.MenuType == MenuType);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MenuCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMenuTypeRDT(string MenuType)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.MenuType == MenuType);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMenuTypeRDT_Paged(string MenuType, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.MenuType == MenuType);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<MenuEntity>
		public EntityCollection<MenuEntity> SelectByItemIdLST(int ItemId)
		{
			EntityCollection<MenuEntity> _MenuCollection = new EntityCollection<MenuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.ItemId == ItemId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null);
			}
			return _MenuCollection;
		}
		
		// Return EntityCollection<MenuEntity>
		public EntityCollection<MenuEntity> SelectByItemIdLST_Paged(int ItemId, int PageNumber, int PageSize)
		{
			EntityCollection<MenuEntity> _MenuCollection = new EntityCollection<MenuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.ItemId == ItemId);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MenuCollection;
		}
		
		// Return DataTable
		public DataTable SelectByItemIdRDT(int ItemId)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.ItemId == ItemId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByItemIdRDT_Paged(int ItemId, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.ItemId == ItemId);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<MenuEntity>
		public EntityCollection<MenuEntity> SelectByUrlLST(string Url)
		{
			EntityCollection<MenuEntity> _MenuCollection = new EntityCollection<MenuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Url == Url);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null);
			}
			return _MenuCollection;
		}
		
		// Return EntityCollection<MenuEntity>
		public EntityCollection<MenuEntity> SelectByUrlLST_Paged(string Url, int PageNumber, int PageSize)
		{
			EntityCollection<MenuEntity> _MenuCollection = new EntityCollection<MenuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Url == Url);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MenuCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUrlRDT(string Url)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Url == Url);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUrlRDT_Paged(string Url, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.Url == Url);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<MenuEntity>
		public EntityCollection<MenuEntity> SelectBySortOrderLST(int SortOrder)
		{
			EntityCollection<MenuEntity> _MenuCollection = new EntityCollection<MenuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null);
			}
			return _MenuCollection;
		}
		
		// Return EntityCollection<MenuEntity>
		public EntityCollection<MenuEntity> SelectBySortOrderLST_Paged(int SortOrder, int PageNumber, int PageSize)
		{
			EntityCollection<MenuEntity> _MenuCollection = new EntityCollection<MenuEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MenuCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySortOrderRDT(int SortOrder)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySortOrderRDT_Paged(int SortOrder, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuCollection = new EntityCollection(new MenuEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
