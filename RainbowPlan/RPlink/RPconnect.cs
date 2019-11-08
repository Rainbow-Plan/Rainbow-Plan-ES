using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace RPlink
{  
     public class RPconnect
    {
        RPobject OBconncet = new RPobject();    
        public RPconnect(RPobject OBconncet)
        {
            this.OBconncet = OBconncet;
            Connect();
        }  

        SqlConnection conn = new SqlConnection();   
        SqlCommand Com = new SqlCommand();
        DataTable Dtable = new DataTable();
        public void Connect()
        {
            String connectionString = "Data Source=F-VER;database=RainbowPlan;Integrated security = SSPI";
            conn.ConnectionString = connectionString;
            conn.Open();

            Com.CommandText = "select * from Word";
            Com.Connection = conn;

            SqlDataAdapter Da = new SqlDataAdapter(Com);
            Da.Fill(Dtable);
        }

        public void InsChank()
        {
            if (OBconncet.ins == 1 || OBconncet.ins == 2) 
            {
                captureWord();
                conn.Close();
            }

        }
        public RPobject captureWord()
        {
            OBconncet.id = Dtable.Rows[0][0].ToString();
            OBconncet.eng = Dtable.Rows[0][1].ToString();
            OBconncet.cn = Dtable.Rows[0][2].ToString();
            return OBconncet;
            //OBconncet.id = Com.ExecuteScalar().ToString();
        }

    }
}
