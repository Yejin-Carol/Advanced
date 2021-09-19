using iPhone_repairshop.handler;
using iPhone_repairshop.model;
using iPhone_repairshop.util;
using MaterialSkin.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iPhone_repairshop.ui
{
    partial class ReceiptForm : MaterialForm
    {
        ReceiptAdapter adapter;
        public ReceiptForm()
        {
            InitializeComponent();
        }

        public ReceiptForm(ReceiptAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter; //adapter.add... 접근 가능해짐. 
        }

        private void receiptSave_Click(object sender, EventArgs e)
        {
            //DB 저장 정보
            string name = custName.Text;
            string telH = custTelH.SelectedText;
            string telB = custTelB.Text;
            string year = custYear.SelectedText;
            string month = custMonth.SelectedText;
            string day = custDay.SelectedText;
            string model = iphoneModel.SelectedText;
            string number = iphoneNum.Text;
            string capacity = iphoneCapacity.SelectedText;
            string iyear = iphoneYear.SelectedText;
            string staffname = staffName.SelectedText;

            string[] arrData = new string[]
               {
                name, telH, telB, year, month, day,
                model, number, capacity, iyear,staffname
               };
            //누락시 포커스 정보, 디자인 컨트롤러명(윈폼 변수명)
            object[] arrObj = new object[]
            {
                custName, custTelH, custTelB, custYear, custMonth, custDay,
                iphoneModel, iphoneNum, iphoneCapacity, iphoneYear, staffName
            };

            string[] arrMsg = new string[]
    {
                "이름을 입력하세요",
                "전화번호 앞자리를 선택하세요",
                "전화번호 뒷자리를 선택하세요",
                "년도를 선택하세요",
                "월을 선택하세요",
                "일을 선택하세요",
                "모델을 선택하세요",
                "일련번호를 입력하세요",
                "메모리용량을 선택하세요",
                "제조년도을 선택하세요",
                "담당자를 선택하세요",
    };

            Dictionary<object, string> dicInput =
                   new Dictionary<object, string>();
            for (int i = 0; i < arrData.Length; i++)
            {
                dicInput.Add(arrObj[i], arrData[i]);
            }

            int cnt = 0;
            foreach (KeyValuePair<object, string> item in
                dicInput)
            {
                if (item.Value.Equals("") ||
                    item.Value.Equals("선택"))
                {
                    setFocus(item.Key as Control, arrMsg[cnt]);
                    return;
                }
                cnt++;
            }

            UICheckBox[] checkBox = new UICheckBox[]
            {
            check1, check2, check3, check4, check5, check6
            };

            int sum = 0;
            List<RepairItem> itemList = new List<RepairItem>();
            for (int i = RepairTable.DISPLAY; i < RepairTable.CAMERA + 1; i++)//0~5 직관적으로 확인 가능
            {
                if (checkBox[i].Checked)//체크박스 체크되었으면
                {
                    Console.WriteLine("수리항목:" + checkBox[i].Text);
                    Console.WriteLine("수리비" + RepairTable.fixPrice[i]);
                    itemList.Add(new RepairItem(i, checkBox[i].Text, RepairTable.fixPrice[i]));
                    sum += RepairTable.fixPrice[i];
                }
            }

            if (itemList.Count == 0)//체크 박스 체크 안했으면
            {
                MessageBox.Show("수리항목을 체크하세요");
                return;//반복문 break
            }


            //한글 입력 체크
            Regex regex =
                    new Regex(@"^[가-힣]{2,4}$"); //Regex 정규표현식(서버 언어 모두 적용가능, 한글이 아니면 공백
            Match m = regex.Match(name);
            if (m.Success == false)
            {
                setFocus(custName, Properties.Resources.ERR_NAME_WRONG);
                return;
            }

            // 전화번호 체크
            string telAll = telH + telB;
            if (telAll.Length == 10 || telAll.Length == 11)//자리수 체크
            {
                Regex regex2 =
                    new Regex(@"01{1}[016]{1}[0-9]{7,8}");
                Match m2 = regex2.Match(telAll);
                if (m2.Success == false)
                {
                    MessageBox.Show("잘못된 전화번호");
                    return;
                }
            }
            else
            {
                MessageBox.Show("올바른 전화번호 자리수를 입력하세요");
                return;
            }


            adapter.addReceipt(new Receipt(
                new Customer(name, telH + telB, year + month + day),
                new IPhone(model, number, capacity, year),
                DateTime.Now.ToString("yyyy년MM월dd일"),
                staffname, itemList, sum));

            Close();
        }


        private void setFocus(Control cont, string msg)
        {
            MessageBox.Show(msg);
            ActiveControl = cont;
            ActiveControl.Focus();
            cont.Text = "";

        }

    }


}

