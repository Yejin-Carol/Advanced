using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace API_Practice
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("address", "주소");
            dataGridView1.Columns.Add("attractname", "주소");
            dataGridView1.Columns.Add("tel", "전화번호");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string key = "aFTES%252FiJ4U2qhg%252F4hmiv7nPR0ax5Er6tzQ5b0lqcjJ3EVvmcSgWsnhRlA2GLBD6v3AXYKnQUtVu5T%252FrjeXYsFQ%253D%253D";
            string pageNo = "1";
            string numOfRows = "10";
            string url = $"https://tour.daegu.go.kr/openapi-data/service/rest/getTourKorAttract/svTourKorAttract.do?serviceKey={key}&pageNo={pageNo}&numOfRows={numOfRows}&SG_APIM=2ug8Dm9qNBfD32JLZGPN64f3EoTlkpD8kSOHWfXpyrY";

            XElement api = XElement.Load(url);

            dataGridView1.DataSource = null;

            foreach (var item in api.Descendants("item"))
            {
                string address = item.Element("address").Value;
                string attractname = item.Element("attractname").Value;
                string tel = item.Element("tel").Value;
                //인스턴스화 Daegu temp = new Daegu(address, attractment, tel) 
                //new랑 같이 있는것을 인스턴스, 즉 하나의 예시, 클래스를 선언하고 
               dataGridView1.Rows.Add(address, attractname, tel);
            }

        }
    }
}
