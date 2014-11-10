




/*
'===============================================================================
'  LayerHelper.ShopCake.BL.MenuDefaultManagerBase
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
	public class MenuDefaultManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public MenuDefaultManagerBase()
		{
			// Nothing for now.
		}
		
		public MenuDefaultEntity Insert(MenuDefaultEntity _MenuDefaultEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_MenuDefaultEntity, true);
			}
			return _MenuDefaultEntity;
		}

		
		public MenuDefaultEntity Insert(int Id, string Name, string Url)
		{
			MenuDefaultEntity _MenuDefaultEntity = new MenuDefaultEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_MenuDefaultEntity.Id = Id;
				_MenuDefaultEntity.Name = Name;
				_MenuDefaultEntity.Url = Url;
				adapter.SaveEntity(_MenuDefaultEntity, true);
			}
			return _MenuDefaultEntity;
		}

		public MenuDefaultEntity Insert(string Name, string Url)
		{
			MenuDefaultEntity _MenuDefaultEntity = new MenuDefaultEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_MenuDefaultEntity.Name = Name;
				_MenuDefaultEntity.Url = Url;
				adapter.SaveEntity(_MenuDefaultEntity, true);
			}
			return _MenuDefaultEntity;
		}

		public bool Update(MenuDefaultEntity _MenuDefaultEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(MenuDefaultFields.Id == _MenuDefaultEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_MenuDefaultEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(MenuDefaultEntity _MenuDefaultEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_MenuDefaultEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(int Id, string Name, string Url)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				MenuDefaultEntity _MenuDefaultEntity = new MenuDefaultEntity(Id);
				if (adapter.FetchEntity(_MenuDefaultEntity))
				{
				
					_MenuDefaultEntity.Name = Name;
					_MenuDefaultEntity.Url = Url;
					adapter.SaveEntity(_MenuDefaultEntity, true);
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
				MenuDefaultEntity _MenuDefaultEntity = new MenuDefaultEntity(Id);
				if (adapter.FetchEntity(_MenuDefaultEntity))
				{
					adapter.DeleteEntity(_MenuDefaultEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("MenuDefaultEntity", null);
			}
		}
		
		
		public int DeleteById(int Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuDefaultFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MenuDefaultEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByName(string Name)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuDefaultFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MenuDefaultEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByUrl(string Url)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuDefaultFields.Url == Url);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("MenuDefaultEntity", filter);
			}
			return toReturn;
		}
		

		
		public MenuDefaultEntity SelectOne(int Id)
		{
			MenuDefaultEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				MenuDefaultEntity _MenuDefaultEntity = new MenuDefaultEntity(Id);
				if (adapter.FetchEntity(_MenuDefaultEntity))
				{
					toReturn = _MenuDefaultEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuDefaultCollection = new EntityCollection(new MenuDefaultEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuDefaultCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<MenuDefaultEntity>
		public EntityCollection<MenuDefaultEntity> SelectAllLST()
		{
			EntityCollection<MenuDefaultEntity> _MenuDefaultCollection = new EntityCollection<MenuDefaultEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuDefaultCollection, null, 0, null);
			}
			return _MenuDefaultCollection;
		}
		
		// Return EntityCollection<MenuDefaultEntity>
		public EntityCollection<MenuDefaultEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<MenuDefaultEntity> _MenuDefaultCollection = new EntityCollection<MenuDefaultEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuDefaultCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _MenuDefaultCollection;
		}


		
		// Return EntityCollection<MenuDefaultEntity>
		public EntityCollection<MenuDefaultEntity> SelectByIdLST(int Id)
		{
			EntityCollection<MenuDefaultEntity> _MenuDefaultCollection = new EntityCollection<MenuDefaultEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuDefaultFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuDefaultCollection, filter, 0, null);
			}
			return _MenuDefaultCollection;
		}
		
		// Return EntityCollection<MenuDefaultEntity>
		public EntityCollection<MenuDefaultEntity> SelectByIdLST_Paged(int Id, int PageNumber, int PageSize)
		{
			EntityCollection<MenuDefaultEntity> _MenuDefaultCollection = new EntityCollection<MenuDefaultEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuDefaultFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuDefaultCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MenuDefaultCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(int Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuDefaultCollection = new EntityCollection(new MenuDefaultEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuDefaultFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuDefaultCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(int Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuDefaultCollection = new EntityCollection(new MenuDefaultEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuDefaultFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuDefaultCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<MenuDefaultEntity>
		public EntityCollection<MenuDefaultEntity> SelectByNameLST(string Name)
		{
			EntityCollection<MenuDefaultEntity> _MenuDefaultCollection = new EntityCollection<MenuDefaultEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuDefaultFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuDefaultCollection, filter, 0, null);
			}
			return _MenuDefaultCollection;
		}
		
		// Return EntityCollection<MenuDefaultEntity>
		public EntityCollection<MenuDefaultEntity> SelectByNameLST_Paged(string Name, int PageNumber, int PageSize)
		{
			EntityCollection<MenuDefaultEntity> _MenuDefaultCollection = new EntityCollection<MenuDefaultEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuDefaultFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuDefaultCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MenuDefaultCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNameRDT(string Name)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuDefaultCollection = new EntityCollection(new MenuDefaultEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuDefaultFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuDefaultCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNameRDT_Paged(string Name, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuDefaultCollection = new EntityCollection(new MenuDefaultEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuDefaultFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuDefaultCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<MenuDefaultEntity>
		public EntityCollection<MenuDefaultEntity> SelectByUrlLST(string Url)
		{
			EntityCollection<MenuDefaultEntity> _MenuDefaultCollection = new EntityCollection<MenuDefaultEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuDefaultFields.Url == Url);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuDefaultCollection, filter, 0, null);
			}
			return _MenuDefaultCollection;
		}
		
		// Return EntityCollection<MenuDefaultEntity>
		public EntityCollection<MenuDefaultEntity> SelectByUrlLST_Paged(string Url, int PageNumber, int PageSize)
		{
			EntityCollection<MenuDefaultEntity> _MenuDefaultCollection = new EntityCollection<MenuDefaultEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuDefaultFields.Url == Url);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_MenuDefaultCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _MenuDefaultCollection;
		}
		
		// Return DataTable
		public DataTable SelectByUrlRDT(string Url)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuDefaultCollection = new EntityCollection(new MenuDefaultEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuDefaultFields.Url == Url);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuDefaultCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByUrlRDT_Paged(string Url, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _MenuDefaultCollection = new EntityCollection(new MenuDefaultEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(MenuDefaultFields.Url == Url);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_MenuDefaultCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
