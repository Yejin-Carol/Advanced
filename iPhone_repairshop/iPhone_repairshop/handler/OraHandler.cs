using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using iPhone_repairshop.model;
using System;

namespace iPhone_repairshop.handler
{
    class OraHandler
    {
        const string ORADB =
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
            "(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)" +
            "(SERVICE_NAME=xe)));" +
            "User Id=SQLDB;Password=1234;";
        OracleConnection conn;//Reference System.Data.OracleClient 추가
        OracleCommand cmd;
    
         public OraHandler()
        {
            Console.WriteLine("객체 생성");
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            dbConnect();
        }

        ~OraHandler()//소멸자
        {
            Console.WriteLine("객체 소멸");
            dbClose();
        }

        public void dbConnect()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공!");
            }
            catch (OracleException e)
            {
                errMsg(e);
            }
        }

        public void errMsg(OracleException e)
        {
            Console.WriteLine("에러번호: " + e.Number);
            Console.WriteLine(e.StackTrace);
        }

        public void dbClose()
        {
            try
            {
                conn.Close();
                Console.WriteLine("오라클 접속 해제!");
            }
            catch (OracleException e)
            {
                errMsg(e);
            }
        }

        public void insertDb()
        {
            string model = "iphone12";
            string serial_num = "12345";
            string capacity = "256GB";
            string year = "2020년";

            string query = string.Format("insert into iphone_t values " +
                "(iphone_T_SEQ.NEXTVAL, '{0}', '{1}', '{2}', '{3}')",
                model, serial_num, capacity, year);

            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }

        public void insertDb(Receipt receipt)
        {
            try
            {
                //한 트랜잭션
                string query =
                    string.Format("insert all " + "INTO iphone_T VALUES(iphone_T_SEQ.NEXTVAL, '{0}', "
                                   + "'{1}', '{2}', '{3}')",
                                   receipt.Iphone.Model, receipt.Iphone.Serial_num, receipt.Iphone.Capacity, receipt.Iphone.Year);

                query += string.Format("INTO CUSTOMER_T VALUES(CUSTOMER_T_SEQ.NEXTVAL, '{0}', "
                                        + "'{1}', '{2}', "
                                        + "iPhone_T_SEQ.CURRVAL)",
                                        receipt.Cust.Name, receipt.Cust.Tel, receipt.Cust.Birth);

                query += "select * from dual";//insert all 쓰는 경우 반드시 select 필요
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();



                List<RepairItem> itemList =
                    receipt.ItemList;
                for (int i = 0; i < itemList.Count; i++)
                {
                    RepairItem item = itemList[i];
                    string queryItem = string.Format("INSERT INTO REPAIR_ITEM_T VALUES "
                        + "(REPAIR_ITEM_T_SEQ.NEXTVAL, '{0}', '{1}', '{2}', iPhone_T_SEQ.CURRVAL)",
                            item.Idx, item.Repair, item.Price);
                    cmd.CommandText = queryItem;
                    cmd.ExecuteNonQuery();
                }

                string queryReceipt = string.Format("INSERT INTO RECEIPT_T VALUES (RECEIPT_T_SEQ.NEXTVAL, "
                    + "CUSTOMER_T_SEQ.CURRVAL, '{0}', "
                    + "(SELECT STAFF_T.STAFF_ID FROM STAFF_T WHERE STAFF_T.NAME = '{1}'), "
                    + "CAR_T_SEQ.CURRVAL, '{2}')", receipt.InDate, receipt.StaffName, receipt.TotalPrice);
                cmd.CommandText = queryReceipt;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException e)
            {
                errMsg(e);
            }
        }
        public void showDb()
        {
            string query = "SELECT INDATE AS 접수일, TOTAL_PRICE AS 총결제금액, "
                            + "(SELECT CUSTOMER_T.NAME FROM CUSTOMER_T WHERE "
                            + "CUSTOMER_T.CUST_ID = RECEIPT_T.CUST_ID) AS 고객명, "
                            + "(SELECT STAFF_T.NAME FROM STAFF_T WHERE "
                            + "STAFF_T.STAFF_ID = RECEIPT_T.STAFF_ID) AS 담당자 FROM RECEIPT_T";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 1;
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine("번호: " + count);
                    Console.WriteLine("접수날짜: " + dr["접수일"]);//Alias명 혹은 컬럼명 둘 다 가능
                    Console.WriteLine("결제금액: " + dr["총결제금액"]);
                    Console.WriteLine("고객명: " + dr["고객명"]);
                    Console.WriteLine("담당자: " + dr["담당자"]);
                    Console.WriteLine("-----------------------------");
                    count++;
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }

            string query2 = "SELECT REPAIR AS 수리항목, PRICE AS 수리비 FROM REPAIR_ITEM_T "
                            + "WHERE iPhone_ID = (SELECT CUSTOMER_T.CUST_ID FROM CUSTOMER_T "
                            + "WHERE CUSTOMER_T.NAME = '박보검')";
            cmd.CommandText = query2;
            cmd.CommandType = System.Data.CommandType.Text;
            dr = cmd.ExecuteReader();
            count = 1;

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine("번호: " + count);
                    Console.WriteLine("수리항목: " + dr["수리항목"]);//Alias명 혹은 컬럼명 둘 다 가능
                    Console.WriteLine("수리비: " + dr["수리비"]);
                    Console.WriteLine("-----------------------------");
                    count++;
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            dr.Close();
        }

        public List<ReceiptVO> getReceipt()
        {
            string query = "SELECT INDATE AS 접수일, TOTAL_PRICE AS 총결제금액, "
                            + "(SELECT CUSTOMER_T.NAME FROM CUSTOMER_T WHERE "
                            + "CUSTOMER_T.CUST_ID = RECEIPT_T.CUST_ID) AS 고객명, "
                            + "(SELECT STAFF_T.NAME FROM STAFF_T WHERE "
                            + "STAFF_T.STAFF_ID = RECEIPT_T.STAFF_ID) AS 담당자 FROM RECEIPT_T";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 1;
            List<ReceiptVO> list = new List<ReceiptVO>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine("번호: " + count);
                    Console.WriteLine("접수날짜: " + dr["접수일"]);//Alias명 혹은 컬럼명 둘 다 가능
                    Console.WriteLine("결제금액: " + dr["총결제금액"]);
                    Console.WriteLine("고객명: " + dr["고객명"]);
                    Console.WriteLine("담당자: " + dr["담당자"]);
                    Console.WriteLine("-----------------------------");


                    ReceiptVO receiptVo =
                             new ReceiptVO(
                             dr["접수일"].ToString(), Convert.ToInt32(dr["총결제금액"]),
                             dr["고객명"].ToString(), dr["담당자"].ToString());

                    list.Add(receiptVo);
                    count++;
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            dr.Close();
            return list;
        }

        public List<RepairItem> getRepairItem(string name)
        {
            string query2 = string.Format("SELECT REPAIR AS 수리항목, PRICE AS 수리비 FROM REPAIR_ITEM_T "
                            + "WHERE iPhone_ID = (SELECT CUSTOMER_T.CUST_ID FROM CUSTOMER_T "
                            + "WHERE CUSTOMER_T.NAME = '박보검')");
            cmd.CommandText = query2;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 1;
            List<RepairItem> list = new List<RepairItem>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine("번호: " + count);
                    Console.WriteLine("수리항목: " + dr["수리항목"]);//Alias명 혹은 컬럼명 둘 다 가능
                    Console.WriteLine("수리비: " + dr["수리비"]);
                    Console.WriteLine("-----------------------------");

                    list.Add(new RepairItem(0, dr["수리항목"].ToString(), Convert.ToInt32(dr["수리비"].ToString())));
                    count++;
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            dr.Close();
            return list;
        }
    }


    }

