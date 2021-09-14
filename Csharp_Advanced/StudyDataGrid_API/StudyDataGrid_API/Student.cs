using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDataGrid_API
{
    public class Student : IComparable
    {
        public string name { get; set; }
        public int age { get; set; }
        public string stuNum { get; set; }

        public Student(string name, int age, string stuNum)
        {
            this.name = name;
            this.age = age;
            this.stuNum = stuNum;
        }

        //조상에 있는 원래 함수(=메소드)
        public virtual void Study()
        {
            System.Windows.Forms.MessageBox.Show("겅부겅부");
        }


        //값을 3가지 반환함
        //음수: obj의 값보다 작은 경우, 0: 같은 경우, 양수: 더 큰 경우
        public int CompareTo(object obj)
        {
            return -1*this.age.CompareTo((obj as Student).age);
            //CompreTo는 이미 구현되어있는거고 정수인 age를 기준으로 compare 매개변수인
            //obj는 임시객체로 as로 Student를 형변환하여 비교함. 
            //Sort -> Compare -> IComparable이 이미 구현 되어 있어야 함. 

        }

        public override string ToString()
        {
            //base 조상은 Objet임
            //return base.ToString();
            return $"이름:{name}, 나이:{age}, 학번:{stuNum}";
        }

    }
}
