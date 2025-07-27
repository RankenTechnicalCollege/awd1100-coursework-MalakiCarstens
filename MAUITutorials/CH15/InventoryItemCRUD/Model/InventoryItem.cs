using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryItemCRUD.Model
{
    public class InventoryItem(int itemNo, string description, decimal price) : INotifyCollectionChanged
    {
        private int _itemNo=itemNo;
        private string _description=description;
        private decimal _price=price;

        private int ItemNo
        {
            get => _itemNo;
            set
            {
                _itemNo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemNo"));
            }
        }
        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PriceDisplay"));
            }
        }
        public string PriceDisplay => _price.ToString("C");


        //public string PriceDisplay => _price.ToString("C");
        
        //public string Description { get; set; }
        //public decimal Price { get; set; }

        //public InventoryItem(int itemNo, string description, decimal price)
        //{
        //    ItemNo = itemNo;
        //    Description = description;
        //    Price = price;
        //}

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
