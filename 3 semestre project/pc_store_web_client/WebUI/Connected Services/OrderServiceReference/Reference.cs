﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebUI.OrderServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/Domain")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebUI.OrderServiceReference.Customer _customerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool _deliveryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int _idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] _lastChangedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool _processedField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebUI.OrderServiceReference.Customer _customer {
            get {
                return this._customerField;
            }
            set {
                if ((object.ReferenceEquals(this._customerField, value) != true)) {
                    this._customerField = value;
                    this.RaisePropertyChanged("_customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool _delivery {
            get {
                return this._deliveryField;
            }
            set {
                if ((this._deliveryField.Equals(value) != true)) {
                    this._deliveryField = value;
                    this.RaisePropertyChanged("_delivery");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _id {
            get {
                return this._idField;
            }
            set {
                if ((this._idField.Equals(value) != true)) {
                    this._idField = value;
                    this.RaisePropertyChanged("_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] _lastChanged {
            get {
                return this._lastChangedField;
            }
            set {
                if ((object.ReferenceEquals(this._lastChangedField, value) != true)) {
                    this._lastChangedField = value;
                    this.RaisePropertyChanged("_lastChanged");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool _processed {
            get {
                return this._processedField;
            }
            set {
                if ((this._processedField.Equals(value) != true)) {
                    this._processedField = value;
                    this.RaisePropertyChanged("_processed");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/Domain")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _fNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int _idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _lNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _phoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebUI.OrderServiceReference.ZipCity _zipCityField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _address {
            get {
                return this._addressField;
            }
            set {
                if ((object.ReferenceEquals(this._addressField, value) != true)) {
                    this._addressField = value;
                    this.RaisePropertyChanged("_address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _email {
            get {
                return this._emailField;
            }
            set {
                if ((object.ReferenceEquals(this._emailField, value) != true)) {
                    this._emailField = value;
                    this.RaisePropertyChanged("_email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _fName {
            get {
                return this._fNameField;
            }
            set {
                if ((object.ReferenceEquals(this._fNameField, value) != true)) {
                    this._fNameField = value;
                    this.RaisePropertyChanged("_fName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _id {
            get {
                return this._idField;
            }
            set {
                if ((this._idField.Equals(value) != true)) {
                    this._idField = value;
                    this.RaisePropertyChanged("_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _lName {
            get {
                return this._lNameField;
            }
            set {
                if ((object.ReferenceEquals(this._lNameField, value) != true)) {
                    this._lNameField = value;
                    this.RaisePropertyChanged("_lName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _phone {
            get {
                return this._phoneField;
            }
            set {
                if ((object.ReferenceEquals(this._phoneField, value) != true)) {
                    this._phoneField = value;
                    this.RaisePropertyChanged("_phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebUI.OrderServiceReference.ZipCity _zipCity {
            get {
                return this._zipCityField;
            }
            set {
                if ((object.ReferenceEquals(this._zipCityField, value) != true)) {
                    this._zipCityField = value;
                    this.RaisePropertyChanged("_zipCity");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ZipCity", Namespace="http://schemas.datacontract.org/2004/07/Domain")]
    [System.SerializableAttribute()]
    public partial class ZipCity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _cityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int _idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int _zipCodeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _city {
            get {
                return this._cityField;
            }
            set {
                if ((object.ReferenceEquals(this._cityField, value) != true)) {
                    this._cityField = value;
                    this.RaisePropertyChanged("_city");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _id {
            get {
                return this._idField;
            }
            set {
                if ((this._idField.Equals(value) != true)) {
                    this._idField = value;
                    this.RaisePropertyChanged("_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _zipCode {
            get {
                return this._zipCodeField;
            }
            set {
                if ((this._zipCodeField.Equals(value) != true)) {
                    this._zipCodeField = value;
                    this.RaisePropertyChanged("_zipCode");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UniqueProduct", Namespace="http://schemas.datacontract.org/2004/07/Domain")]
    [System.SerializableAttribute()]
    public partial class UniqueProduct : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int _idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebUI.OrderServiceReference.Product _productField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _serialNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _warrantyField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _id {
            get {
                return this._idField;
            }
            set {
                if ((this._idField.Equals(value) != true)) {
                    this._idField = value;
                    this.RaisePropertyChanged("_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebUI.OrderServiceReference.Product _product {
            get {
                return this._productField;
            }
            set {
                if ((object.ReferenceEquals(this._productField, value) != true)) {
                    this._productField = value;
                    this.RaisePropertyChanged("_product");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _serialNo {
            get {
                return this._serialNoField;
            }
            set {
                if ((object.ReferenceEquals(this._serialNoField, value) != true)) {
                    this._serialNoField = value;
                    this.RaisePropertyChanged("_serialNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _warranty {
            get {
                return this._warrantyField;
            }
            set {
                if ((object.ReferenceEquals(this._warrantyField, value) != true)) {
                    this._warrantyField = value;
                    this.RaisePropertyChanged("_warranty");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/Domain")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int _categoryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int _idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal _priceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int _supplierIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _categoryId {
            get {
                return this._categoryIdField;
            }
            set {
                if ((this._categoryIdField.Equals(value) != true)) {
                    this._categoryIdField = value;
                    this.RaisePropertyChanged("_categoryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _description {
            get {
                return this._descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this._descriptionField, value) != true)) {
                    this._descriptionField = value;
                    this.RaisePropertyChanged("_description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _id {
            get {
                return this._idField;
            }
            set {
                if ((this._idField.Equals(value) != true)) {
                    this._idField = value;
                    this.RaisePropertyChanged("_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _name {
            get {
                return this._nameField;
            }
            set {
                if ((object.ReferenceEquals(this._nameField, value) != true)) {
                    this._nameField = value;
                    this.RaisePropertyChanged("_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal _price {
            get {
                return this._priceField;
            }
            set {
                if ((this._priceField.Equals(value) != true)) {
                    this._priceField = value;
                    this.RaisePropertyChanged("_price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int _supplierId {
            get {
                return this._supplierIdField;
            }
            set {
                if ((this._supplierIdField.Equals(value) != true)) {
                    this._supplierIdField = value;
                    this.RaisePropertyChanged("_supplierId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerNotExistException", Namespace="http://schemas.datacontract.org/2004/07/Exceptions")]
    [System.SerializableAttribute()]
    public partial class CustomerNotExistException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrderServiceReference.IOrderService")]
    public interface IOrderService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/Create", ReplyAction="http://tempuri.org/IOrderService/CreateResponse")]
        int Create();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/Create", ReplyAction="http://tempuri.org/IOrderService/CreateResponse")]
        System.Threading.Tasks.Task<int> CreateAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/Read", ReplyAction="http://tempuri.org/IOrderService/ReadResponse")]
        WebUI.OrderServiceReference.Order Read(int orderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/Read", ReplyAction="http://tempuri.org/IOrderService/ReadResponse")]
        System.Threading.Tasks.Task<WebUI.OrderServiceReference.Order> ReadAsync(int orderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/AddProduct", ReplyAction="http://tempuri.org/IOrderService/AddProductResponse")]
        WebUI.OrderServiceReference.UniqueProduct[] AddProduct(int orderId, int productId, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/AddProduct", ReplyAction="http://tempuri.org/IOrderService/AddProductResponse")]
        System.Threading.Tasks.Task<WebUI.OrderServiceReference.UniqueProduct[]> AddProductAsync(int orderId, int productId, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/AddCustomer", ReplyAction="http://tempuri.org/IOrderService/AddCustomerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WebUI.OrderServiceReference.CustomerNotExistException), Action="http://tempuri.org/IOrderService/AddCustomerCustomerNotExistExceptionFault", Name="CustomerNotExistException", Namespace="http://schemas.datacontract.org/2004/07/Exceptions")]
        void AddCustomer(int orderId, int customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/AddCustomer", ReplyAction="http://tempuri.org/IOrderService/AddCustomerResponse")]
        System.Threading.Tasks.Task AddCustomerAsync(int orderId, int customerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/SetProcessed", ReplyAction="http://tempuri.org/IOrderService/SetProcessedResponse")]
        bool SetProcessed(int orderId, bool status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/SetProcessed", ReplyAction="http://tempuri.org/IOrderService/SetProcessedResponse")]
        System.Threading.Tasks.Task<bool> SetProcessedAsync(int orderId, bool status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetAllProductsByOrderId", ReplyAction="http://tempuri.org/IOrderService/GetAllProductsByOrderIdResponse")]
        WebUI.OrderServiceReference.UniqueProduct[] GetAllProductsByOrderId(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetAllProductsByOrderId", ReplyAction="http://tempuri.org/IOrderService/GetAllProductsByOrderIdResponse")]
        System.Threading.Tasks.Task<WebUI.OrderServiceReference.UniqueProduct[]> GetAllProductsByOrderIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetAll", ReplyAction="http://tempuri.org/IOrderService/GetAllResponse")]
        WebUI.OrderServiceReference.Order[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetAll", ReplyAction="http://tempuri.org/IOrderService/GetAllResponse")]
        System.Threading.Tasks.Task<WebUI.OrderServiceReference.Order[]> GetAllAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrderServiceChannel : WebUI.OrderServiceReference.IOrderService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrderServiceClient : System.ServiceModel.ClientBase<WebUI.OrderServiceReference.IOrderService>, WebUI.OrderServiceReference.IOrderService {
        
        public OrderServiceClient() {
        }
        
        public OrderServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Create() {
            return base.Channel.Create();
        }
        
        public System.Threading.Tasks.Task<int> CreateAsync() {
            return base.Channel.CreateAsync();
        }
        
        public WebUI.OrderServiceReference.Order Read(int orderId) {
            return base.Channel.Read(orderId);
        }
        
        public System.Threading.Tasks.Task<WebUI.OrderServiceReference.Order> ReadAsync(int orderId) {
            return base.Channel.ReadAsync(orderId);
        }
        
        public WebUI.OrderServiceReference.UniqueProduct[] AddProduct(int orderId, int productId, int amount) {
            return base.Channel.AddProduct(orderId, productId, amount);
        }
        
        public System.Threading.Tasks.Task<WebUI.OrderServiceReference.UniqueProduct[]> AddProductAsync(int orderId, int productId, int amount) {
            return base.Channel.AddProductAsync(orderId, productId, amount);
        }
        
        public void AddCustomer(int orderId, int customerId) {
            base.Channel.AddCustomer(orderId, customerId);
        }
        
        public System.Threading.Tasks.Task AddCustomerAsync(int orderId, int customerId) {
            return base.Channel.AddCustomerAsync(orderId, customerId);
        }
        
        public bool SetProcessed(int orderId, bool status) {
            return base.Channel.SetProcessed(orderId, status);
        }
        
        public System.Threading.Tasks.Task<bool> SetProcessedAsync(int orderId, bool status) {
            return base.Channel.SetProcessedAsync(orderId, status);
        }
        
        public WebUI.OrderServiceReference.UniqueProduct[] GetAllProductsByOrderId(int id) {
            return base.Channel.GetAllProductsByOrderId(id);
        }
        
        public System.Threading.Tasks.Task<WebUI.OrderServiceReference.UniqueProduct[]> GetAllProductsByOrderIdAsync(int id) {
            return base.Channel.GetAllProductsByOrderIdAsync(id);
        }
        
        public WebUI.OrderServiceReference.Order[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<WebUI.OrderServiceReference.Order[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
    }
}
