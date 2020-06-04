﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KassaApp
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BlackTulipDB")]
	public partial class DataBaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertbestellingen(bestellingen instance);
    partial void Updatebestellingen(bestellingen instance);
    partial void Deletebestellingen(bestellingen instance);
    partial void InsertItem(Item instance);
    partial void UpdateItem(Item instance);
    partial void DeleteItem(Item instance);
    partial void Insertklant(klant instance);
    partial void Updateklant(klant instance);
    partial void Deleteklant(klant instance);
    partial void Insertproducttypen(producttypen instance);
    partial void Updateproducttypen(producttypen instance);
    partial void Deleteproducttypen(producttypen instance);
    partial void Insertproduct(product instance);
    partial void Updateproduct(product instance);
    partial void Deleteproduct(product instance);
    #endregion
		
		public DataBaseDataContext() : 
				base(global::KassaApp.Properties.Settings.Default.BlackTulipDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<bestellingen> bestellingens
		{
			get
			{
				return this.GetTable<bestellingen>();
			}
		}
		
		public System.Data.Linq.Table<Item> Items
		{
			get
			{
				return this.GetTable<Item>();
			}
		}
		
		public System.Data.Linq.Table<klant> klants
		{
			get
			{
				return this.GetTable<klant>();
			}
		}
		
		public System.Data.Linq.Table<producttypen> producttypens
		{
			get
			{
				return this.GetTable<producttypen>();
			}
		}
		
		public System.Data.Linq.Table<product> products
		{
			get
			{
				return this.GetTable<product>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.bestellingen")]
	public partial class bestellingen : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BID;
		
		private string _Datum;
		
		private int _KID;
		
		private EntitySet<Item> _Items;
		
		private EntityRef<klant> _klant;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBIDChanging(int value);
    partial void OnBIDChanged();
    partial void OnDatumChanging(string value);
    partial void OnDatumChanged();
    partial void OnKIDChanging(int value);
    partial void OnKIDChanged();
    #endregion
		
		public bestellingen()
		{
			this._Items = new EntitySet<Item>(new Action<Item>(this.attach_Items), new Action<Item>(this.detach_Items));
			this._klant = default(EntityRef<klant>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int BID
		{
			get
			{
				return this._BID;
			}
			set
			{
				if ((this._BID != value))
				{
					this.OnBIDChanging(value);
					this.SendPropertyChanging();
					this._BID = value;
					this.SendPropertyChanged("BID");
					this.OnBIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Datum", DbType="VarChar(50)")]
		public string Datum
		{
			get
			{
				return this._Datum;
			}
			set
			{
				if ((this._Datum != value))
				{
					this.OnDatumChanging(value);
					this.SendPropertyChanging();
					this._Datum = value;
					this.SendPropertyChanged("Datum");
					this.OnDatumChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KID", DbType="Int NOT NULL")]
		public int KID
		{
			get
			{
				return this._KID;
			}
			set
			{
				if ((this._KID != value))
				{
					if (this._klant.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnKIDChanging(value);
					this.SendPropertyChanging();
					this._KID = value;
					this.SendPropertyChanged("KID");
					this.OnKIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="bestellingen_Item", Storage="_Items", ThisKey="BID", OtherKey="BID")]
		public EntitySet<Item> Items
		{
			get
			{
				return this._Items;
			}
			set
			{
				this._Items.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="klant_bestellingen", Storage="_klant", ThisKey="KID", OtherKey="KID", IsForeignKey=true)]
		public klant klant
		{
			get
			{
				return this._klant.Entity;
			}
			set
			{
				klant previousValue = this._klant.Entity;
				if (((previousValue != value) 
							|| (this._klant.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._klant.Entity = null;
						previousValue.bestellingens.Remove(this);
					}
					this._klant.Entity = value;
					if ((value != null))
					{
						value.bestellingens.Add(this);
						this._KID = value.KID;
					}
					else
					{
						this._KID = default(int);
					}
					this.SendPropertyChanged("klant");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Items(Item entity)
		{
			this.SendPropertyChanging();
			entity.bestellingen = this;
		}
		
		private void detach_Items(Item entity)
		{
			this.SendPropertyChanging();
			entity.bestellingen = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Item")]
	public partial class Item : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IID;
		
		private string _Hoeveelheid;
		
		private int _BID;
		
		private int _PID;
		
		private EntityRef<bestellingen> _bestellingen;
		
		private EntityRef<product> _product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIIDChanging(int value);
    partial void OnIIDChanged();
    partial void OnHoeveelheidChanging(string value);
    partial void OnHoeveelheidChanged();
    partial void OnBIDChanging(int value);
    partial void OnBIDChanged();
    partial void OnPIDChanging(int value);
    partial void OnPIDChanged();
    #endregion
		
		public Item()
		{
			this._bestellingen = default(EntityRef<bestellingen>);
			this._product = default(EntityRef<product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IID
		{
			get
			{
				return this._IID;
			}
			set
			{
				if ((this._IID != value))
				{
					this.OnIIDChanging(value);
					this.SendPropertyChanging();
					this._IID = value;
					this.SendPropertyChanged("IID");
					this.OnIIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hoeveelheid", DbType="VarChar(50)")]
		public string Hoeveelheid
		{
			get
			{
				return this._Hoeveelheid;
			}
			set
			{
				if ((this._Hoeveelheid != value))
				{
					this.OnHoeveelheidChanging(value);
					this.SendPropertyChanging();
					this._Hoeveelheid = value;
					this.SendPropertyChanged("Hoeveelheid");
					this.OnHoeveelheidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BID", DbType="Int NOT NULL")]
		public int BID
		{
			get
			{
				return this._BID;
			}
			set
			{
				if ((this._BID != value))
				{
					if (this._bestellingen.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBIDChanging(value);
					this.SendPropertyChanging();
					this._BID = value;
					this.SendPropertyChanged("BID");
					this.OnBIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PID", DbType="Int NOT NULL")]
		public int PID
		{
			get
			{
				return this._PID;
			}
			set
			{
				if ((this._PID != value))
				{
					if (this._product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPIDChanging(value);
					this.SendPropertyChanging();
					this._PID = value;
					this.SendPropertyChanged("PID");
					this.OnPIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="bestellingen_Item", Storage="_bestellingen", ThisKey="BID", OtherKey="BID", IsForeignKey=true)]
		public bestellingen bestellingen
		{
			get
			{
				return this._bestellingen.Entity;
			}
			set
			{
				bestellingen previousValue = this._bestellingen.Entity;
				if (((previousValue != value) 
							|| (this._bestellingen.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._bestellingen.Entity = null;
						previousValue.Items.Remove(this);
					}
					this._bestellingen.Entity = value;
					if ((value != null))
					{
						value.Items.Add(this);
						this._BID = value.BID;
					}
					else
					{
						this._BID = default(int);
					}
					this.SendPropertyChanged("bestellingen");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="product_Item", Storage="_product", ThisKey="PID", OtherKey="PID", IsForeignKey=true)]
		public product product
		{
			get
			{
				return this._product.Entity;
			}
			set
			{
				product previousValue = this._product.Entity;
				if (((previousValue != value) 
							|| (this._product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._product.Entity = null;
						previousValue.Items.Remove(this);
					}
					this._product.Entity = value;
					if ((value != null))
					{
						value.Items.Add(this);
						this._PID = value.PID;
					}
					else
					{
						this._PID = default(int);
					}
					this.SendPropertyChanged("product");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.klant")]
	public partial class klant : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _KID;
		
		private string _Naam;
		
		private string _Stad;
		
		private string _MobielNummer;
		
		private string _EMail;
		
		private EntitySet<bestellingen> _bestellingens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnKIDChanging(int value);
    partial void OnKIDChanged();
    partial void OnNaamChanging(string value);
    partial void OnNaamChanged();
    partial void OnStadChanging(string value);
    partial void OnStadChanged();
    partial void OnMobielNummerChanging(string value);
    partial void OnMobielNummerChanged();
    partial void OnEMailChanging(string value);
    partial void OnEMailChanged();
    #endregion
		
		public klant()
		{
			this._bestellingens = new EntitySet<bestellingen>(new Action<bestellingen>(this.attach_bestellingens), new Action<bestellingen>(this.detach_bestellingens));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int KID
		{
			get
			{
				return this._KID;
			}
			set
			{
				if ((this._KID != value))
				{
					this.OnKIDChanging(value);
					this.SendPropertyChanging();
					this._KID = value;
					this.SendPropertyChanged("KID");
					this.OnKIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Naam", DbType="VarChar(50)")]
		public string Naam
		{
			get
			{
				return this._Naam;
			}
			set
			{
				if ((this._Naam != value))
				{
					this.OnNaamChanging(value);
					this.SendPropertyChanging();
					this._Naam = value;
					this.SendPropertyChanged("Naam");
					this.OnNaamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Stad", DbType="VarChar(50)")]
		public string Stad
		{
			get
			{
				return this._Stad;
			}
			set
			{
				if ((this._Stad != value))
				{
					this.OnStadChanging(value);
					this.SendPropertyChanging();
					this._Stad = value;
					this.SendPropertyChanged("Stad");
					this.OnStadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MobielNummer", DbType="VarChar(50)")]
		public string MobielNummer
		{
			get
			{
				return this._MobielNummer;
			}
			set
			{
				if ((this._MobielNummer != value))
				{
					this.OnMobielNummerChanging(value);
					this.SendPropertyChanging();
					this._MobielNummer = value;
					this.SendPropertyChanged("MobielNummer");
					this.OnMobielNummerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EMail", DbType="VarChar(50)")]
		public string EMail
		{
			get
			{
				return this._EMail;
			}
			set
			{
				if ((this._EMail != value))
				{
					this.OnEMailChanging(value);
					this.SendPropertyChanging();
					this._EMail = value;
					this.SendPropertyChanged("EMail");
					this.OnEMailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="klant_bestellingen", Storage="_bestellingens", ThisKey="KID", OtherKey="KID")]
		public EntitySet<bestellingen> bestellingens
		{
			get
			{
				return this._bestellingens;
			}
			set
			{
				this._bestellingens.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_bestellingens(bestellingen entity)
		{
			this.SendPropertyChanging();
			entity.klant = this;
		}
		
		private void detach_bestellingens(bestellingen entity)
		{
			this.SendPropertyChanging();
			entity.klant = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.producttypen")]
	public partial class producttypen : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PtID;
		
		private string _Omschrijving;
		
		private EntitySet<product> _products;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPtIDChanging(int value);
    partial void OnPtIDChanged();
    partial void OnOmschrijvingChanging(string value);
    partial void OnOmschrijvingChanged();
    #endregion
		
		public producttypen()
		{
			this._products = new EntitySet<product>(new Action<product>(this.attach_products), new Action<product>(this.detach_products));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PtID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PtID
		{
			get
			{
				return this._PtID;
			}
			set
			{
				if ((this._PtID != value))
				{
					this.OnPtIDChanging(value);
					this.SendPropertyChanging();
					this._PtID = value;
					this.SendPropertyChanged("PtID");
					this.OnPtIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Omschrijving", DbType="VarChar(50)")]
		public string Omschrijving
		{
			get
			{
				return this._Omschrijving;
			}
			set
			{
				if ((this._Omschrijving != value))
				{
					this.OnOmschrijvingChanging(value);
					this.SendPropertyChanging();
					this._Omschrijving = value;
					this.SendPropertyChanged("Omschrijving");
					this.OnOmschrijvingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="producttypen_product", Storage="_products", ThisKey="PtID", OtherKey="PtID")]
		public EntitySet<product> products
		{
			get
			{
				return this._products;
			}
			set
			{
				this._products.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_products(product entity)
		{
			this.SendPropertyChanging();
			entity.producttypen = this;
		}
		
		private void detach_products(product entity)
		{
			this.SendPropertyChanging();
			entity.producttypen = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.product")]
	public partial class product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PID;
		
		private string _ProductNaam;
		
		private int _PtID;
		
		private decimal _Prijs;
		
		private string _Afbeelding;
		
		private EntitySet<Item> _Items;
		
		private EntityRef<producttypen> _producttypen;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPIDChanging(int value);
    partial void OnPIDChanged();
    partial void OnProductNaamChanging(string value);
    partial void OnProductNaamChanged();
    partial void OnPtIDChanging(int value);
    partial void OnPtIDChanged();
    partial void OnPrijsChanging(decimal value);
    partial void OnPrijsChanged();
    partial void OnAfbeeldingChanging(string value);
    partial void OnAfbeeldingChanged();
    #endregion
		
		public product()
		{
			this._Items = new EntitySet<Item>(new Action<Item>(this.attach_Items), new Action<Item>(this.detach_Items));
			this._producttypen = default(EntityRef<producttypen>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PID
		{
			get
			{
				return this._PID;
			}
			set
			{
				if ((this._PID != value))
				{
					this.OnPIDChanging(value);
					this.SendPropertyChanging();
					this._PID = value;
					this.SendPropertyChanged("PID");
					this.OnPIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductNaam", DbType="VarChar(50)")]
		public string ProductNaam
		{
			get
			{
				return this._ProductNaam;
			}
			set
			{
				if ((this._ProductNaam != value))
				{
					this.OnProductNaamChanging(value);
					this.SendPropertyChanging();
					this._ProductNaam = value;
					this.SendPropertyChanged("ProductNaam");
					this.OnProductNaamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PtID", DbType="Int NOT NULL")]
		public int PtID
		{
			get
			{
				return this._PtID;
			}
			set
			{
				if ((this._PtID != value))
				{
					if (this._producttypen.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPtIDChanging(value);
					this.SendPropertyChanging();
					this._PtID = value;
					this.SendPropertyChanged("PtID");
					this.OnPtIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prijs", DbType="Money NOT NULL")]
		public decimal Prijs
		{
			get
			{
				return this._Prijs;
			}
			set
			{
				if ((this._Prijs != value))
				{
					this.OnPrijsChanging(value);
					this.SendPropertyChanging();
					this._Prijs = value;
					this.SendPropertyChanged("Prijs");
					this.OnPrijsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Afbeelding", DbType="VarChar(50)")]
		public string Afbeelding
		{
			get
			{
				return this._Afbeelding;
			}
			set
			{
				if ((this._Afbeelding != value))
				{
					this.OnAfbeeldingChanging(value);
					this.SendPropertyChanging();
					this._Afbeelding = value;
					this.SendPropertyChanged("Afbeelding");
					this.OnAfbeeldingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="product_Item", Storage="_Items", ThisKey="PID", OtherKey="PID")]
		public EntitySet<Item> Items
		{
			get
			{
				return this._Items;
			}
			set
			{
				this._Items.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="producttypen_product", Storage="_producttypen", ThisKey="PtID", OtherKey="PtID", IsForeignKey=true)]
		public producttypen producttypen
		{
			get
			{
				return this._producttypen.Entity;
			}
			set
			{
				producttypen previousValue = this._producttypen.Entity;
				if (((previousValue != value) 
							|| (this._producttypen.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._producttypen.Entity = null;
						previousValue.products.Remove(this);
					}
					this._producttypen.Entity = value;
					if ((value != null))
					{
						value.products.Add(this);
						this._PtID = value.PtID;
					}
					else
					{
						this._PtID = default(int);
					}
					this.SendPropertyChanged("producttypen");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Items(Item entity)
		{
			this.SendPropertyChanging();
			entity.product = this;
		}
		
		private void detach_Items(Item entity)
		{
			this.SendPropertyChanging();
			entity.product = null;
		}
	}
}
#pragma warning restore 1591
