using iPhone_repairshop.handler;
using iPhone_repairshop.model;
using System;
using System.Collections.Generic;

namespace iPhone_repairshop
{
    class ReceiptAdapter
    {
        private List<Receipt> receiptList = new List<Receipt>();
        private OraHandler ora;

        public ReceiptAdapter(OraHandler ora)
        {
            this.ora = ora;
        }

        public void addReceipt(Receipt receipt)
        {
            receiptList.Add(receipt);
        }

        public void addReceiptDb()
        {
            for (int i = 0; i < receiptList.Count; i++)
            {
                ora.insertDb(receiptList[i]);//오라클 객체에 있는 한개의 리스트
            }
            receiptList.Clear();
        }
        
        public void viewReceipt()
        {
            for (int i = 0; i < receiptList.Count; i++)
            {
                Customer cust = receiptList[i].Cust;
                Console.WriteLine("고객명: " + cust.Name);
                Console.WriteLine("고객전화: " + cust.Tel);
                Console.WriteLine("생년월일: " + cust.Birth);

                IPhone iphone = receiptList[i].Iphone;
                Console.WriteLine("모델명: " + iphone.Model);
                Console.WriteLine("차량번호: " + iphone.Serial_num);
                Console.WriteLine("배기량: " + iphone.Capacity);
                Console.WriteLine("차량연식: " + iphone.Year);
                Console.WriteLine("담당자: " + receiptList[i].StaffName);
                Console.WriteLine("접수날짜: " + receiptList[i].InDate);

                List<RepairItem> itemList =
                    receiptList[i].ItemList;
                for (int j = 0; j < itemList.Count; j++)
                {
                    Console.WriteLine("수리번호: " +
                        itemList[j].Idx);
                    Console.WriteLine("수리항목: " +
                     itemList[j].Repair);
                    Console.WriteLine("수리비용: " +
                     itemList[j].Price);
                }
            }
        }
        public void viewReceiptDb()
        {
            ora.showDb();
        }

        public List<ReceiptVO> getReceiptDb()
        {
            List<ReceiptVO> list = ora.getReceipt();
            return list;
        }

        public List<RepairItem> GetRepairItemsDb(string name)
        {
            return ora.getRepairItem(name);
        }
    }
}