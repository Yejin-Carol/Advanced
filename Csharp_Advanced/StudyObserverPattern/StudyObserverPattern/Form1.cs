using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyObserverPattern
{
    public partial class Form1 : Form, ISubject
    {
        //IList 인터페이스가 적용되어 있는 리스트
        IList _observers = new ArrayList();
        
        //java로 치면 ArrayList<IObserer> 
        List<IObserver> obs = new List<IObserver>();

        Form2 frm2 = null;
        Form3 frm3 = null;
        Form4 frm4 = null;
        
        
        public Form1()
        {
            InitializeComponent();

            ArrayList example = new ArrayList();
            example.Add(1);
            example.Add("aaaa");

            //C#에서의 List와 자바에서의 ArrayList가 똑같음
            frm2 = new Form2(this);//인스턴스 생성과 동시에 sub의 register 호출함 ->
            //ISubject 인터페이스를 구현하고 있는 객체의 register를 호출함.
            frm2.TopLevel = false;
            frm2.FormBorderStyle = FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            panel1.Controls.Add(frm2);
            frm2.Show();

            frm3 = new Form3(this);
            frm3.TopLevel = false;
            frm3.FormBorderStyle = FormBorderStyle.None;
            frm3.Dock = DockStyle.Fill;
            panel2.Controls.Add(frm3);
            frm3.Show();

            frm4 = new Form4(this, frm2, frm3);
            frm4.TopLevel = false;
            frm4.FormBorderStyle = FormBorderStyle.None;
            frm4.Dock = DockStyle.Fill;
            panel3.Controls.Add(frm4);
            frm4.Show();

        }

        public void notify()
        {
            //throw new NotImplementedException();
            foreach (IObserver item in _observers)
            {
                item.update(textBox1.Text);
            }
        }

        public void register(IObserver o)//IObserver에 public 붙이기
        {
            //이 함수를 구현하지 않았다고 에러 메세지 주면서 프로그램 꺼지게 함
            // throw new NotImplementedException();
            _observers.Add(o);
        }

        public void remove(IObserver o)
        {
            //throw new NotImplementedException();
            _observers.Remove(o);
        }

        //이벤트에서 KeyDown 더블 클릭!
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //엔터키를 칠 때 마다, notify를 호출해서 
            //IObserver 인터페이스 구현되어 있는 객체들의 update 함수를 일괄적으로 호출함

            if (e.KeyCode == Keys.Enter)
                notify();
        }
    }
}
