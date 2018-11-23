using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
namespace Grocery_App
{
    internal class DB
    {
        SqlConnection con=null;
        SqlCommand com;
        SqlDataAdapter read;
        SqlDataAdapter read1 =new SqlDataAdapter();
        SqlCommandBuilder reb;
        internal static DataSet DataSet1=new DataSet();

        public DB()
        {
            con = new SqlConnection(frmMain.mainquery);
        }

        public int command(string quary)
        {
            con.Open();
            com = new SqlCommand(quary, con);
            int state = com.ExecuteNonQuery();
            con.Close();
            return state;
        }

        public int command1(string query,params object[] data)
        {
            string para=null;
            con.Open();
            Console.WriteLine(data);
            com = new SqlCommand(query, con);
            for (int i = 0; i < data.Length; i++)
            {
                para = "@" + (i + 1);
                com.Parameters.AddWithValue(para, data[i]);
            }
            int state = com.ExecuteNonQuery();
            con.Close();
            return state;
        }

        public void reader1(string quary,string tablename)
        {
            con.Open();
            read = new SqlDataAdapter(quary, con);
            DataTable result = new DataTable(tablename);
            read.Fill(result);
            DataSet1.Tables.Add(result);
            result.Rows.Add();
            con.Close();
        }


        public List<object> reader2(string query)
        {
            con.Open();
            com = new SqlCommand(query, con);
            SqlDataReader sqlDataReader = com.ExecuteReader();
            List<object> data = new List<object>();
            while (sqlDataReader.Read())
            {
                data.Add(sqlDataReader[0].ToString());
            }
            con.Close();
            return data;
        }

        public void reader3(ref string query, string tablename,int index)
        {
            con.Open();
            if (index == 1)
            {
                read1.SelectCommand = new SqlCommand(query, con);
                reb = new SqlCommandBuilder(read1);
                read1.Fill(DataSet1, tablename);
                query = reb.GetInsertCommand().CommandText;
            }
            else
            {
                read1.UpdateCommand = new SqlCommand(query);
                read1.Update(DataSet1.Tables[tablename]);
            }
            con.Close();
        }

        public void reader4(string quary, string tablename)
        {
            con.Open();
            read = new SqlDataAdapter(quary, con);
            //
            if (DataSet1.Tables.Contains(tablename))
            {
                read.Fill(DataSet1.Tables[tablename]);
            }
            else
            {
                DataTable result = new DataTable(tablename);
                read.Fill(result);
                DataSet1.Tables.Add(result);
                result.Rows.Add();
            }

            con.Close();
        }
        public string[] reader5(string query)
        {
            con.Open();
            com = new SqlCommand(query, con);
            string[] data = new string[3];
            SqlDataReader sqlDataReader = com.ExecuteReader();            
            if (sqlDataReader.Read())
            {
                
                data[0] = sqlDataReader[0].ToString();
                data[1] = sqlDataReader[1].ToString();
            }
            else
                data = null;
            con.Close();
            return data;
        }
    }
}

