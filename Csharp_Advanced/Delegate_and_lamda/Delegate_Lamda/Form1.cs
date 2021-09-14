using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_Lamda
{
    public partial class Form1 : Form
    {
        //일종의 자료형을 하나 선언한 것으로 함수를 저장하는 자료형
        //TempFunc myFunc을  ttt에 집어넣고 매개변수로 사용함.
        //함수 안에 함수를 매개변수로 사용 => Callback 함수
        //delegate가 밑작업
        public delegate void TempFunc();

        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("안녕");//Properties에서 Output Console로 변경 :)
            button1.Click -= button1_Click; //이벤트 빼는 것도 됨
            button1.Click += Button1_Click; //델리게이트
            button1.Click += (object s, EventArgs e) =>
            {
                MessageBox.Show("Message Box");
            };
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button");
        }

        public void myFunc()
        {
            MessageBox.Show("Test");
        }
        public void iteratorFunction(TempFunc t, int count)
        {
            for (int i = 0; i < count; i++)
                t();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Person p = new Person();
            p.Name = "Carol";
            MessageBox.Show(p.Name);
            p.Sleep();

            Student s = new Student();
            s.Name = "Alexis";
            s.study();
            s.Sleep();

            TempFunc ttt = myFunc;
            iteratorFunction(ttt, 3);

            TempFunc ttt2 = () => { MessageBox.Show("aaa"); };
            iteratorFunction(ttt2, 3);
            iteratorFunction(() => { MessageBox.Show("lamda"); }, 1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(() => {
                for(int i = 0; i<50; i++)
                Console.Write("A"); 
            });
            Thread t2 = new Thread(() => {
                for (int i = 0; i < 50; i++) 
                Console.Write("B"); 
            });
            
            t1.Start();
            t2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //new Form2().Show(); //Modaless

            //Modal(모달)
            new Form2().ShowDialog(); //Message Box처럼 뒤에꺼 선택 x
        }
    }
}
