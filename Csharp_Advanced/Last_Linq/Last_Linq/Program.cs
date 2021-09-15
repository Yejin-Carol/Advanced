using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Last_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
            XElement xxElement = XElement.Load(url);


            //1과 2는 동일함. 1은 xml에 있는거 다 긁어오지만, 2는 hour값과 day값만 가져옴 
            //1. linq 쓴 버전
            var xmlQuery = from item in xxElement.Descendants("data") select item;
            
            //2. linq 안 쓴 버전
            List<string> ttt = new List<string>();
            foreach(var item in xxElement.Descendants("data"))
            {
                ttt.Add(item.Element("hour").Value + item.Element("day").Value);
            }

            foreach (var item in xmlQuery)
            {
                System.Console.WriteLine(item);
            }

            //필요한 것만 정렬해서 출력
            foreach (var item in xmlQuery)
            {
                Console.Write(item.Element("hour").Value + "\t");
                Console.Write(item.Element("day").Value+ "\t");
                Console.Write(item.Element("temp").Value + "\t");
                //cw tab tab
                Console.WriteLine();
            }

            var xmlQuery2 = from item in xxElement.Descendants("data") 
                            select 
                            new
                            {
                                Hour = item.Element("hour").Value,
                                Day = item.Element("day").Value,
                                Temp = item.Element("temp").Value
                            };//익명 객체

            //필요한 것만 정렬해서 출력
            foreach (var item in xmlQuery2)
            {
                Console.Write(item.Hour + "\t");
                Console.Write(item.Day + "\t");
                Console.Write(item.Temp + "\t");
                //cw tab tab
                Console.WriteLine();
            }



        }
    }
}
