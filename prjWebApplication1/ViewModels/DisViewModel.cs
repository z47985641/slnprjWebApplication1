﻿using prjWebApplication1.Models;

namespace prjWebApplication1.ViewModels
{
    public class DisViewModel
    {
        private Discount _discount;
        public Discount discount
        {
            get { return _discount; }
            set { _discount = value; }
        }
        public DisViewModel() {
            _discount = new Discount();
        }
        public string txtKey { get; set; }
        public int Id { 
            get { return _discount.RoomDiscountId; }
            set { _discount.RoomDiscountId = value; }
        }
        public string DiscountInfo {
            get { return _discount.DiscountInfo; }
            set { _discount.DiscountInfo = value; }
        }
        public string DiscountName {
            get { return _discount.DiscountName; }
            set { _discount.DiscountName = value; }
        }
    }
}
