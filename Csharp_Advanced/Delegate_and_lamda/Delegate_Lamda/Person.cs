using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Lamda
{
    class Person
    {
        //자바나 c++, C# String/string 둘 다 씀.
        private string name_;
        public string getName() { return name_; }
        public void setName(string name) { name_ = name; }
        
        //C#에서의 get set (Data grid view 컬럼 사용시 get/set 필요함)
        private string name;
        public string Name { get => name; set => name = value; }
        
        //최종적인 축약형태
        public string name2 { get; set; }
        public void Sleep()
        {
            System.Windows.Forms.MessageBox.Show("zzzZZZ");
        }    
    }
}
