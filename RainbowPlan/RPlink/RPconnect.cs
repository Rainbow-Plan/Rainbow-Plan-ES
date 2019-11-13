using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;


namespace RPlink
{  
     public class RPconnect
    {
         Random rad = new Random();//随机数实例
         RPobject OBconncet = new RPobject();    //连接对象实例，接受传来的对象（带数据）
         public RPconnect(RPobject OBconncet)
         {
             this.OBconncet = OBconncet;
             Connect();
         }  

         SqlConnection conn = new SqlConnection();   //一系列的连接实例和表实例
         SqlCommand Com = new SqlCommand();
         SqlDataAdapter Da = null;
         DataTable DtableWord = new DataTable();
         DataTable DtableCollect = new DataTable();
         int Count = 0;//记录数据表条数
         int I = 1;//计数
         public void Connect()  //连接，获取两张表
         {
             String connectionString = "Data Source=F-VER;database=RainbowPlan;Integrated security = SSPI";
             conn.ConnectionString = connectionString;
             conn.Open();

             Com.Connection = conn;
             Com.CommandText = "select * from Word";
             Da = new SqlDataAdapter(Com);
             Da.Fill(DtableWord);

             Com.CommandText = "select * from Collect";
             Da = new SqlDataAdapter(Com);
             Da.Fill(DtableCollect);

         }

         //public void InsChank() //检查对象ins命令，判断是哪个窗体传来的，该执行什么方法
         //{
             //if(OBconncet.ins == 1 || OBconncet.ins == 2) 
             //{
             //    captureWord();
             //    conn.Close();
             //}
         //    if(OBconncet.ins == 32)
         //    {
         //        ToRecordSave();
         //    }

         //}
         public RPobject captureWord()  //返回捕捉到的Word数据，给对应窗口
         {
             Count = (int)DtableWord.Compute("Count([ID])", "");
             int i = rad.Next(0, Count);
             OBconncet.id = DtableWord.Rows[i][0].ToString();
             OBconncet.eng = DtableWord.Rows[i][1].ToString();
             OBconncet.cn = DtableWord.Rows[i][2].ToString();
             return OBconncet;
         }

         public RPobject captureCollect()  //返回捕捉到的Collect数据，给对应窗口
         {
             Count = (int)DtableCollect.Compute("Count([ID])", "");
             if (Count >= 0)
             {
                 OBconncet.id = DtableCollect.Rows[Count - I][0].ToString();
                 OBconncet.cn = DtableCollect.Rows[Count - I][1].ToString();
                 I++;
             }
             return OBconncet;
         }

         public int ToRecordSave()  //保存用户输入的数据
         {
             //更新已有表
             Count = (int)DtableCollect.Compute("Count([ID])", "");
             int i = Count;
             DataRow dr = DtableCollect.NewRow();
             dr["id"] = OBconncet.id;
             dr["Record"] = OBconncet.cn;
             DtableCollect.Rows.Add(dr);
             //保存到数据库
             Com.CommandText = "insert into Collect values(@id,@record)";
             Com.Parameters.AddWithValue("@id", OBconncet.id);
             Com.Parameters.AddWithValue("@record", OBconncet.cn);
             int T_F = (int)Com.ExecuteNonQuery();
             return T_F;
         }
    }
}
