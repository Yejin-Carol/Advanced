using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iPhone_repairshop.model
{
    class IPhone
    { 

    //모델 혹은 데이터 클래스
    private string model;
    private string serial_num;
    private string capacity;
    private string year;

        public IPhone(string model, string serial_num, string capacity, string year)
        {
            this.model = model;
            this.serial_num = serial_num;
            this.capacity = capacity;
            this.year = year;
        }

        public string Model { get => model; set => model = value; }
        public string Serial_num { get => serial_num; set => serial_num = value; }
        public string Capacity { get => capacity; set => capacity = value; }
        public string Year { get => year; set => year = value; }
    }
}
