using iPhone_repairshop.common;
using iPhone_repairshop.model;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iPhone_repairshop.ui
{
    //public 지움. (Adapter 일관성 없는 것으로 나와)
    partial class ReceiptView : MaterialForm
    {
        ReceiptAdapter adapter;
        public ReceiptView()
        {
            InitializeComponent();
        }
        public ReceiptView(ReceiptAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        public void initList(List<ReceiptVO> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                string strPrice =
                string.Format("{0:#,0}원", list[i].TotalPrice);
                viewList.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+1).ToString(),
                        list[i].Indate,
                        strPrice,
                        list[i].StaffName,
                        list[i].CustName
                    }
                    ));

            }
            CommUtil.setRowColor(viewList, Color.White, Color.LightYellow);
            //스크롤 자동으로 
            int index = viewList.Items.Count - 1;
            viewList.Items[index].Selected = true;
            viewList.Items[index].Focused = true;
            viewList.EnsureVisible(index);//삭제시 충돌 발생가능
        }

        public void initGrid()
        {
            string strPrice =
            string.Format("{0:#,0}원", 30000);
            string[] data = { "1", "액정", strPrice };
            viewGrid.Rows.Add(data);

            for (int i = 0; i < 50; i++)
            {
                viewGrid.Rows.Add(new string[]
               {
                        (i+2).ToString(), "카메라",
               });
            }
            int count = viewGrid.Rows.Count - 1;
            viewGrid.FirstDisplayedScrollingRowIndex = count;
            viewGrid.CurrentCell =
                viewGrid.Rows[count - 1].Cells[0];

        }

        private void ReceiptView_Load(object sender, EventArgs e)
        {
            CommUtil.colorListViewHeader(ref viewList, Color.DarkBlue, Color.AntiqueWhite);
            List<ReceiptVO> list = adapter.getReceiptDb();
            initList(list);
            initGrid();

        }

        private void viewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewList.SelectedItems.Count != 0)
            {
                int n = viewList.SelectedItems[0].Index;
                string num = viewList.Items[n].SubItems[0].Text;
                string date = viewList.Items[n].SubItems[1].Text;
                string price = viewList.Items[n].SubItems[2].Text;
                string staff = viewList.Items[n].SubItems[3].Text;
                string cust = viewList.Items[n].SubItems[4].Text;
                Console.WriteLine("번호: " + num);
                Console.WriteLine("접수날짜: " + date);
                Console.WriteLine("총결제금액: " + price);
                Console.WriteLine("담당자: " + staff);
                Console.WriteLine("고객명: " + cust);

                List<RepairItem> list = adapter.GetRepairItemsDb(cust);
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine("수리항목: " + list[i].Repair);
                    Console.WriteLine("수리비: " + list[i].Price);
                }

            }
        }
    }
}
