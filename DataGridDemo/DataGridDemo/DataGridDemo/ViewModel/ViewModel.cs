using Syncfusion.SfDataGrid.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace DataGridDemo
{
    public class ViewModel : NotificationObject
    {
        internal OrderInfoRepository order;

        public bool Enabled { get; set; }

        public ViewModel()
        {
            order = new OrderInfoRepository();

            SetRowstoGenerate(50);
            this.GridColumns = new Columns
            {
                new GridNumericColumn(){ MappingName = "EmployeeID"},
                new GridTextColumn(){ MappingName = "FirstName"},
                new GridTextColumn(){ MappingName = "LastName"},
                new GridTextColumn(){ MappingName = "ShipCity"},
            };
        }

        private Columns gridColumns;

        public Columns GridColumns
        {
            get { return gridColumns; }
            set
            {
                gridColumns = value;
                this.RaisePropertyChanged("GridColumns");
            }
        }

        #region ItemsSource

        private ObservableCollection<OrderInfo> ordersInfo;
        public ObservableCollection<OrderInfo> OrdersInfo
        {
            get { return ordersInfo; }
            set
            {
                this.ordersInfo = value;
                RaiseCollectionChanged("OrdersInfo");
            }
        }

        #endregion

        #region ItemSource Generator

        public void SetRowstoGenerate(int count)
        {
            OrdersInfo = order.GetOrderDetails(count);
        }

        #endregion
    }

    public class NotificationObject : INotifyPropertyChanged, INotifyCollectionChanged
    {
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaiseCollectionChanged(string propName)
        {
            if (this.CollectionChanged != null)
                this.CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }
        public event NotifyCollectionChangedEventHandler CollectionChanged;
    }
}
