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

namespace CustomerTest
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WCFHotelBookingMan")]
	public partial class LinqtoSqlDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertRoom(Room instance);
    partial void UpdateRoom(Room instance);
    partial void DeleteRoom(Room instance);
    partial void InsertHotel(Hotel instance);
    partial void UpdateHotel(Hotel instance);
    partial void DeleteHotel(Hotel instance);
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertAddress(Address instance);
    partial void UpdateAddress(Address instance);
    partial void DeleteAddress(Address instance);
    #endregion
		
		public LinqtoSqlDataContext() : 
				base(global::CustomerTest.Properties.Settings.Default.WCFHotelBookingManConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LinqtoSqlDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqtoSqlDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqtoSqlDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqtoSqlDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Room> Rooms
		{
			get
			{
				return this.GetTable<Room>();
			}
		}
		
		public System.Data.Linq.Table<Hotel> Hotels
		{
			get
			{
				return this.GetTable<Hotel>();
			}
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<Amenity> Amenities
		{
			get
			{
				return this.GetTable<Amenity>();
			}
		}
		
		public System.Data.Linq.Table<Address> Addresses
		{
			get
			{
				return this.GetTable<Address>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spFilterByRating")]
		public ISingleResult<spFilterByRatingResult> spFilterByRating([global::System.Data.Linq.Mapping.ParameterAttribute(Name="City", DbType="NVarChar(50)")] string city, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Rating", DbType="Float")] System.Nullable<double> rating)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), city, rating);
			return ((ISingleResult<spFilterByRatingResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spSearchHotel")]
		public ISingleResult<spSearchHotelResult> spSearchHotel([global::System.Data.Linq.Mapping.ParameterAttribute(Name="City", DbType="NVarChar(50)")] string city)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), city);
			return ((ISingleResult<spSearchHotelResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spInsertCustomer")]
		public int spInsertCustomer([global::System.Data.Linq.Mapping.ParameterAttribute(Name="FirstName", DbType="NVarChar(20)")] string firstName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LastName", DbType="NVarChar(20)")] string lastName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="EmailId", DbType="NVarChar(50)")] string emailId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PhoneNumber", DbType="NVarChar(50)")] string phoneNumber, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> customerid)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), firstName, lastName, emailId, phoneNumber, customerid);
			customerid = ((System.Nullable<int>)(result.GetParameterValue(4)));
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Rooms")]
	public partial class Room : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _RoomId;
		
		private string _HotelId;
		
		private string _Type;
		
		private int _Rate;
		
		private EntityRef<Hotel> _Hotel;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRoomIdChanging(string value);
    partial void OnRoomIdChanged();
    partial void OnHotelIdChanging(string value);
    partial void OnHotelIdChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnRateChanging(int value);
    partial void OnRateChanged();
    #endregion
		
		public Room()
		{
			this._Hotel = default(EntityRef<Hotel>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomId", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string RoomId
		{
			get
			{
				return this._RoomId;
			}
			set
			{
				if ((this._RoomId != value))
				{
					this.OnRoomIdChanging(value);
					this.SendPropertyChanging();
					this._RoomId = value;
					this.SendPropertyChanged("RoomId");
					this.OnRoomIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelId", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HotelId
		{
			get
			{
				return this._HotelId;
			}
			set
			{
				if ((this._HotelId != value))
				{
					if (this._Hotel.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnHotelIdChanging(value);
					this.SendPropertyChanging();
					this._HotelId = value;
					this.SendPropertyChanged("HotelId");
					this.OnHotelIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rate", DbType="Int NOT NULL")]
		public int Rate
		{
			get
			{
				return this._Rate;
			}
			set
			{
				if ((this._Rate != value))
				{
					this.OnRateChanging(value);
					this.SendPropertyChanging();
					this._Rate = value;
					this.SendPropertyChanged("Rate");
					this.OnRateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Hotel_Room", Storage="_Hotel", ThisKey="HotelId", OtherKey="HotelId", IsForeignKey=true)]
		public Hotel Hotel
		{
			get
			{
				return this._Hotel.Entity;
			}
			set
			{
				Hotel previousValue = this._Hotel.Entity;
				if (((previousValue != value) 
							|| (this._Hotel.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Hotel.Entity = null;
						previousValue.Rooms.Remove(this);
					}
					this._Hotel.Entity = value;
					if ((value != null))
					{
						value.Rooms.Add(this);
						this._HotelId = value.HotelId;
					}
					else
					{
						this._HotelId = default(string);
					}
					this.SendPropertyChanged("Hotel");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Hotels")]
	public partial class Hotel : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _HotelId;
		
		private string _HotelName;
		
		private double _Rating;
		
		private EntitySet<Room> _Rooms;
		
		private EntitySet<Address> _Addresses;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHotelIdChanging(string value);
    partial void OnHotelIdChanged();
    partial void OnHotelNameChanging(string value);
    partial void OnHotelNameChanged();
    partial void OnRatingChanging(double value);
    partial void OnRatingChanged();
    #endregion
		
		public Hotel()
		{
			this._Rooms = new EntitySet<Room>(new Action<Room>(this.attach_Rooms), new Action<Room>(this.detach_Rooms));
			this._Addresses = new EntitySet<Address>(new Action<Address>(this.attach_Addresses), new Action<Address>(this.detach_Addresses));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelId", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string HotelId
		{
			get
			{
				return this._HotelId;
			}
			set
			{
				if ((this._HotelId != value))
				{
					this.OnHotelIdChanging(value);
					this.SendPropertyChanging();
					this._HotelId = value;
					this.SendPropertyChanged("HotelId");
					this.OnHotelIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HotelName
		{
			get
			{
				return this._HotelName;
			}
			set
			{
				if ((this._HotelName != value))
				{
					this.OnHotelNameChanging(value);
					this.SendPropertyChanging();
					this._HotelName = value;
					this.SendPropertyChanged("HotelName");
					this.OnHotelNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rating", DbType="Float NOT NULL")]
		public double Rating
		{
			get
			{
				return this._Rating;
			}
			set
			{
				if ((this._Rating != value))
				{
					this.OnRatingChanging(value);
					this.SendPropertyChanging();
					this._Rating = value;
					this.SendPropertyChanged("Rating");
					this.OnRatingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Hotel_Room", Storage="_Rooms", ThisKey="HotelId", OtherKey="HotelId")]
		public EntitySet<Room> Rooms
		{
			get
			{
				return this._Rooms;
			}
			set
			{
				this._Rooms.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Hotel_Address", Storage="_Addresses", ThisKey="HotelId", OtherKey="HotelId")]
		public EntitySet<Address> Addresses
		{
			get
			{
				return this._Addresses;
			}
			set
			{
				this._Addresses.Assign(value);
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
		
		private void attach_Rooms(Room entity)
		{
			this.SendPropertyChanging();
			entity.Hotel = this;
		}
		
		private void detach_Rooms(Room entity)
		{
			this.SendPropertyChanging();
			entity.Hotel = null;
		}
		
		private void attach_Addresses(Address entity)
		{
			this.SendPropertyChanging();
			entity.Hotel = this;
		}
		
		private void detach_Addresses(Address entity)
		{
			this.SendPropertyChanging();
			entity.Hotel = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CustomerId;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _EmailId;
		
		private string _PhoneNumber;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIdChanging(int value);
    partial void OnCustomerIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnEmailIdChanging(string value);
    partial void OnEmailIdChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    #endregion
		
		public Customer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CustomerId
		{
			get
			{
				return this._CustomerId;
			}
			set
			{
				if ((this._CustomerId != value))
				{
					this.OnCustomerIdChanging(value);
					this.SendPropertyChanging();
					this._CustomerId = value;
					this.SendPropertyChanged("CustomerId");
					this.OnCustomerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailId", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string EmailId
		{
			get
			{
				return this._EmailId;
			}
			set
			{
				if ((this._EmailId != value))
				{
					this.OnEmailIdChanging(value);
					this.SendPropertyChanging();
					this._EmailId = value;
					this.SendPropertyChanged("EmailId");
					this.OnEmailIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Amenities")]
	public partial class Amenity
	{
		
		private string _HotelId;
		
		private string _Amenity1;
		
		public Amenity()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelId", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HotelId
		{
			get
			{
				return this._HotelId;
			}
			set
			{
				if ((this._HotelId != value))
				{
					this._HotelId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Amenity", Storage="_Amenity1", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Amenity1
		{
			get
			{
				return this._Amenity1;
			}
			set
			{
				if ((this._Amenity1 != value))
				{
					this._Amenity1 = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Address")]
	public partial class Address : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _HotelId;
		
		private long _Id;
		
		private string _Locality;
		
		private string _PhoneNumber;
		
		private string _City;
		
		private EntityRef<Hotel> _Hotel;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHotelIdChanging(string value);
    partial void OnHotelIdChanged();
    partial void OnIdChanging(long value);
    partial void OnIdChanged();
    partial void OnLocalityChanging(string value);
    partial void OnLocalityChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    #endregion
		
		public Address()
		{
			this._Hotel = default(EntityRef<Hotel>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelId", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HotelId
		{
			get
			{
				return this._HotelId;
			}
			set
			{
				if ((this._HotelId != value))
				{
					if (this._Hotel.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnHotelIdChanging(value);
					this.SendPropertyChanging();
					this._HotelId = value;
					this.SendPropertyChanged("HotelId");
					this.OnHotelIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Locality", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Locality
		{
			get
			{
				return this._Locality;
			}
			set
			{
				if ((this._Locality != value))
				{
					this.OnLocalityChanging(value);
					this.SendPropertyChanging();
					this._Locality = value;
					this.SendPropertyChanged("Locality");
					this.OnLocalityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Hotel_Address", Storage="_Hotel", ThisKey="HotelId", OtherKey="HotelId", IsForeignKey=true)]
		public Hotel Hotel
		{
			get
			{
				return this._Hotel.Entity;
			}
			set
			{
				Hotel previousValue = this._Hotel.Entity;
				if (((previousValue != value) 
							|| (this._Hotel.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Hotel.Entity = null;
						previousValue.Addresses.Remove(this);
					}
					this._Hotel.Entity = value;
					if ((value != null))
					{
						value.Addresses.Add(this);
						this._HotelId = value.HotelId;
					}
					else
					{
						this._HotelId = default(string);
					}
					this.SendPropertyChanged("Hotel");
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
	
	public partial class spFilterByRatingResult
	{
		
		private string _HotelId;
		
		private string _HotelName;
		
		private double _Rating;
		
		private string _City;
		
		private string _Locality;
		
		private string _PhoneNumber;
		
		public spFilterByRatingResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelId", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HotelId
		{
			get
			{
				return this._HotelId;
			}
			set
			{
				if ((this._HotelId != value))
				{
					this._HotelId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HotelName
		{
			get
			{
				return this._HotelName;
			}
			set
			{
				if ((this._HotelName != value))
				{
					this._HotelName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rating", DbType="Float NOT NULL")]
		public double Rating
		{
			get
			{
				return this._Rating;
			}
			set
			{
				if ((this._Rating != value))
				{
					this._Rating = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this._City = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Locality", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Locality
		{
			get
			{
				return this._Locality;
			}
			set
			{
				if ((this._Locality != value))
				{
					this._Locality = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this._PhoneNumber = value;
				}
			}
		}
	}
	
	public partial class spSearchHotelResult
	{
		
		private string _HotelId;
		
		private string _HotelName;
		
		private double _Rating;
		
		private string _City;
		
		private string _Locality;
		
		private string _PhoneNumber;
		
		public spSearchHotelResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelId", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HotelId
		{
			get
			{
				return this._HotelId;
			}
			set
			{
				if ((this._HotelId != value))
				{
					this._HotelId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HotelName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HotelName
		{
			get
			{
				return this._HotelName;
			}
			set
			{
				if ((this._HotelName != value))
				{
					this._HotelName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rating", DbType="Float NOT NULL")]
		public double Rating
		{
			get
			{
				return this._Rating;
			}
			set
			{
				if ((this._Rating != value))
				{
					this._Rating = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this._City = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Locality", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string Locality
		{
			get
			{
				return this._Locality;
			}
			set
			{
				if ((this._Locality != value))
				{
					this._Locality = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this._PhoneNumber = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
