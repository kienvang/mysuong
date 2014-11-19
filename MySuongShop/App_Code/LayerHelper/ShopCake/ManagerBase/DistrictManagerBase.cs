


/*
'===============================================================================
'  LayerHelper.ShopCake.BL.DistrictManagerBase
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
	public class DistrictManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DistrictManagerBase()
		{
			// Nothing for now.
		}
		
		public DistrictEntity Insert(DistrictEntity _DistrictEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_DistrictEntity, true);
			}
			return _DistrictEntity;
		}

		
		public DistrictEntity Insert(int Id, string Name, int SortOrder)
		{
			DistrictEntity _DistrictEntity = new DistrictEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DistrictEntity.Id = Id;
				_DistrictEntity.Name = Name;
				_DistrictEntity.SortOrder = SortOrder;
				adapter.SaveEntity(_DistrictEntity, true);
			}
			return _DistrictEntity;
		}

		public DistrictEntity Insert(string Name, int SortOrder)
		{
			DistrictEntity _DistrictEntity = new DistrictEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DistrictEntity.Name = Name;
				_DistrictEntity.SortOrder = SortOrder;
				adapter.SaveEntity(_DistrictEntity, true);
			}
			return _DistrictEntity;
		}

		public bool Update(DistrictEntity _DistrictEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(DistrictFields.Id == _DistrictEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DistrictEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DistrictEntity _DistrictEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DistrictEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(int Id, string Name, int SortOrder)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DistrictEntity _DistrictEntity = new DistrictEntity(Id);
				if (adapter.FetchEntity(_DistrictEntity))
				{
				
					_DistrictEntity.Name = Name;
					_DistrictEntity.SortOrder = SortOrder;
					adapter.SaveEntity(_DistrictEntity, true);
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
				DistrictEntity _DistrictEntity = new DistrictEntity(Id);
				if (adapter.FetchEntity(_DistrictEntity))
				{
					adapter.DeleteEntity(_DistrictEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DistrictEntity", null);
			}
		}
		
		
		public int DeleteById(int Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DistrictFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DistrictEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByName(string Name)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DistrictFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DistrictEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySortOrder(int SortOrder)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DistrictFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DistrictEntity", filter);
			}
			return toReturn;
		}
		

		
		public DistrictEntity SelectOne(int Id)
		{
			DistrictEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DistrictEntity _DistrictEntity = new DistrictEntity(Id);
				if (adapter.FetchEntity(_DistrictEntity))
				{
					toReturn = _DistrictEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DistrictCollection = new EntityCollection(new DistrictEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DistrictCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<DistrictEntity>
		public EntityCollection<DistrictEntity> SelectAllLST()
		{
			EntityCollection<DistrictEntity> _DistrictCollection = new EntityCollection<DistrictEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DistrictCollection, null, 0, null);
			}
			return _DistrictCollection;
		}
		
		// Return EntityCollection<DistrictEntity>
		public EntityCollection<DistrictEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<DistrictEntity> _DistrictCollection = new EntityCollection<DistrictEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DistrictCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _DistrictCollection;
		}


		
		// Return EntityCollection<DistrictEntity>
		public EntityCollection<DistrictEntity> SelectByIdLST(int Id)
		{
			EntityCollection<DistrictEntity> _DistrictCollection = new EntityCollection<DistrictEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DistrictFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DistrictCollection, filter, 0, null);
			}
			return _DistrictCollection;
		}
		
		// Return EntityCollection<DistrictEntity>
		public EntityCollection<DistrictEntity> SelectByIdLST_Paged(int Id, int PageNumber, int PageSize)
		{
			EntityCollection<DistrictEntity> _DistrictCollection = new EntityCollection<DistrictEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DistrictFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DistrictCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DistrictCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(int Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DistrictCollection = new EntityCollection(new DistrictEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DistrictFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DistrictCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(int Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DistrictCollection = new EntityCollection(new DistrictEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DistrictFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DistrictCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DistrictEntity>
		public EntityCollection<DistrictEntity> SelectByNameLST(string Name)
		{
			EntityCollection<DistrictEntity> _DistrictCollection = new EntityCollection<DistrictEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DistrictFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DistrictCollection, filter, 0, null);
			}
			return _DistrictCollection;
		}
		
		// Return EntityCollection<DistrictEntity>
		public EntityCollection<DistrictEntity> SelectByNameLST_Paged(string Name, int PageNumber, int PageSize)
		{
			EntityCollection<DistrictEntity> _DistrictCollection = new EntityCollection<DistrictEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DistrictFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DistrictCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DistrictCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNameRDT(string Name)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DistrictCollection = new EntityCollection(new DistrictEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DistrictFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DistrictCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNameRDT_Paged(string Name, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DistrictCollection = new EntityCollection(new DistrictEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DistrictFields.Name == Name);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DistrictCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DistrictEntity>
		public EntityCollection<DistrictEntity> SelectBySortOrderLST(int SortOrder)
		{
			EntityCollection<DistrictEntity> _DistrictCollection = new EntityCollection<DistrictEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DistrictFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DistrictCollection, filter, 0, null);
			}
			return _DistrictCollection;
		}
		
		// Return EntityCollection<DistrictEntity>
		public EntityCollection<DistrictEntity> SelectBySortOrderLST_Paged(int SortOrder, int PageNumber, int PageSize)
		{
			EntityCollection<DistrictEntity> _DistrictCollection = new EntityCollection<DistrictEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DistrictFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DistrictCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DistrictCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySortOrderRDT(int SortOrder)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DistrictCollection = new EntityCollection(new DistrictEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DistrictFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DistrictCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySortOrderRDT_Paged(int SortOrder, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DistrictCollection = new EntityCollection(new DistrictEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DistrictFields.SortOrder == SortOrder);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DistrictCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
