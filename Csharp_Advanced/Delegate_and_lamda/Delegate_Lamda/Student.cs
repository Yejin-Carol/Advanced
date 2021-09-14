using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Lamda
{
    //C# 상속 : 넣으면 끝 Student는 Person 상속 받음
    class Student : Person 
    {
        public string stuNum { get; set; }
        //sleep 기능에 이어서 study 기능도 추가된 class
        public void study()
        {
            System.Windows.Forms.MessageBox.Show("Studying...");
        }
    }
}
