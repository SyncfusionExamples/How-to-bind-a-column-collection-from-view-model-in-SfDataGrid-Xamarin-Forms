using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataGridDemo
{
    public class OrderInfo : INotifyPropertyChanged
    {
        public OrderInfo()
        {

        }

        #region private variables

        private int _orderID;
        private double _employeeID;
        private string _customerID;
        private string _firstname;
        private string _lastname;
        private string _gender;
        private string _shipCity;
        private string _shipCountry;
        private double _freight;
        private DateTime? _shippingDate;
        private string _isClosed;

        #endregion

        #region Public Properties

        public int OrderID
        {
            get
            {
                return _orderID;
            }
            set
            {
                this._orderID = value;
                RaisePropertyChanged("OrderID");
            }
        }

        public double EmployeeID
        {
            get
            {
                return _employeeID;
            }
            set
            {
                this._employeeID = value;
                RaisePropertyChanged("EmployeeID");
            }
        }

        public string CustomerID
        {
            get
            {
                return _customerID;
            }
            set
            {
                this._customerID = value;
                RaisePropertyChanged("CustomerID");
            }
        }

        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                this._firstname = value;
                RaisePropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                this._lastname = value;
                RaisePropertyChanged("LastName");
            }
        }

        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                this._gender = value;
                RaisePropertyChanged("Gender");
            }
        }

        public string ShipCity
        {
            get
            {
                return _shipCity;
            }
            set
            {
                this._shipCity = value;
                RaisePropertyChanged("ShipCity");
            }
        }

        public string ShipCountry
        {
            get
            {
                return _shipCountry;
            }
            set
            {
                this._shipCountry = value;
                RaisePropertyChanged("ShipCountry");
            }
        }

        public double Freight
        {
            get
            {
                return _freight;
            }
            set
            {
                this._freight = value;
                RaisePropertyChanged("Freight");
            }
        }

        public string IsClosed
        {
            get
            {
                return _isClosed;
            }
            set
            {
                this._isClosed = value;
                RaisePropertyChanged("IsClosed");
            }
        }

        public DateTime? ShippingDate
        {
            get
            {
                return _shippingDate;
            }
            set
            {
                this._shippingDate = value;
                RaisePropertyChanged("ShippingDate");
            }
        }

        #endregion

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(String Name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(Name));
        }

        #endregion
    }
}
