using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;

namespace Interface
{
    public class AccessHelper
    {
        /// <summary>
        /// 执行查询语句
        /// </summary>
        /// <param name="sql">sql查询语句</param>
        /// <returns>查询集合</returns>
        public static string QuerybySql(string sql)
        {
            string ConnStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + "words.mdb";
            OleDbConnection conn = new OleDbConnection(ConnStr);
            conn.Open();
            OleDbDataAdapter Adapter = new OleDbDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            Adapter.Fill(ds);
            conn.Close();
            DataTable dt = new DataTable();
            Adapter.Fill(dt);
            string s = "";
            if (dt.Rows.Count >= 1)
            {
                List<string> list = new List<string>();
                foreach (DataRow row in dt.Rows)
                {
                    s = row[0].ToString();
                }
            }
            return s;
        }
        /// <summary>
        /// 执行添加、修改、删除sql语句
        /// </summary>
        /// <param name="sql">增删改sql语句</param>
        /// <returns>影响的行数</returns>
        public static int ExecuteSql(string sql)
        {
            string ConnStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=words.mdb";
            OleDbConnection conn = new OleDbConnection(ConnStr);
            conn.Open();
            OleDbCommand comm = new OleDbCommand(sql, conn);
            int iRet = comm.ExecuteNonQuery();
            conn.Close();
            return iRet;
        }
        

    }
}


