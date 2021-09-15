using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace KakaoApiMapView
{
    //system.web.extensions
    public class KakaoAPI
    {
       //ListBox에 있는 지명 클릭해서
       //그 지명을 검색하게
       //그 지명을 연관된 지역들을 반환하는 함수
        public static List<MyLocale> Search(string qstr)
        {
            List<MyLocale> mls = new List<MyLocale>();

            string site = "https://dapi.kakao.com/v2/local/search/keyword.json";
            string query = $"{site}?query={qstr}";

            //주어진 주소에 따라서
            //자료들을 요청함
            WebRequest request = WebRequest.Create(query);

            string rkey = "bf2d9957a4b29b08f4856426a33264aa";
            string header = "KakaoAK " + rkey;
            request.Headers.Add("Authorization", header); //headers에 넣어서 

            //응답된 걸 읽어들이는 작업(카카오에서 보내온 응답을 읽는 과정)
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);//UTF8 형태로 읽음(인코딩 잘못하면 한글 깨짐)

            string json = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();

            //공통점: 셋 다 임시변수 
            //var test1 = 1; var test2 = "2"; var는 선언이 되면서 값이랑 타입이 바로 정해짐(int, string)
            //인텔리센스를 호출 가능 (. 찍으면 나오는 자동완성 기능 가능) int length2 = test2.Length;
            //dynamic test3=1;, dynmaic test4="2"; 프로그램이 실행 되어야지만 그 때 타입 결정됨. 인텔리센스 사용 안됨
            //object test5=1;, object test6 - "2"; var와 유사하나 선언하고나서 해당 타입 인텔리센스 쓰려면 형변환 필요
            //int mylength = (test6 as string).Length;
            //as 를 쓰게 되면, 형변환 실패시 해당 변수를 null값으로 바꿈. is키워드로 

            //이렇게 객체형태로 받아들이는 이유는
            //json이 객체라서 임의의 객체 변수는 값을 바다오는 것
            //1. 그냥 텍스트, 2. deserialization한 뒤 json으로 받아짐
            //var써도 되지만 dynamic 쓰는 이유는 var는 오른쪽에 쓰는 변수가 타입이 있어야 하나
            //json에서 읽어오는 js는 어떤 "타입"이 정해지지 않음. 
            dynamic dob = js.Deserialize<dynamic>(json); //var랑 비슷한거

            //json 객체에서 document 속성의 값들을 받아옴.
            dynamic docs = dob["documents"];//객체에서  documents 속성을 가져오고

            object[] buf = docs; //buf라는 배열에 넣고
            int length = buf.Length; //buf 길이만큼 length에 

            
            //장소이름, 위도, 경도 
            for(int i=0; i<length; i++) 
            {
                string local_name = docs[i]["place_name"];
                double x = double.Parse(docs[i]["x"]);
                double y = double.Parse(docs[i]["y"]);
                mls.Add(new MyLocale(local_name, y, x));//MyLocale 인스턴스 생성

            }

            return mls;
        }
    }
}
