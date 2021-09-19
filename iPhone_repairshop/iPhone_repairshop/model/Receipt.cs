using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iPhone_repairshop.model
{
    class Receipt
    {
        private Customer cust;
        private IPhone iphone;
        //접수날짜
        private string inDate;
        private string staffName;
        //크기가 가변적일 때 리스트 사용
        private List<RepairItem> itemList;
        private int totalPrice;

        public Receipt(Customer cust, IPhone iphone, string inDate, string staffName, List<RepairItem> itemList, int totalPrice)
        {
            this.cust = cust;
            this.iphone = iphone;
            this.inDate = inDate;
            this.staffName = staffName;
            this.itemList = itemList;
            this.totalPrice = totalPrice;
        }

        public string InDate { get => inDate; set => inDate = value; }
        public string StaffName { get => staffName; set => staffName = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
        internal Customer Cust { get => cust; set => cust = value; }
        internal IPhone Iphone { get => iphone; set => iphone = value; }
        internal List<RepairItem> ItemList { get => itemList; set => itemList = value; }
    }
}
