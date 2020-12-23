using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_HangHoa
{
    public static class MyPublics
    {
        public static SqlConnection conMyConnection;
        public static string strMaNV, strQuyenSD, strTen;
        public static void ConnectDatabase()
        {
            string strConn = "Server = localhost; Database = QL_HangHoa; Integrated Security = false; UID = TN207User; PWD = TN207User";
            conMyConnection = new SqlConnection();
            conMyConnection.ConnectionString = strConn;
            try
            {
                conMyConnection.Open();
            }
            catch (Exception) { }
        }
        public static void OpenData(string strSelect, DataSet dsDatabase, string strTableName)
        {
            SqlDataAdapter daDataAdapter = new SqlDataAdapter();
            try
            {
                if (conMyConnection.State == ConnectionState.Closed)
                    conMyConnection.Open();
                daDataAdapter.SelectCommand = new SqlCommand(strSelect, conMyConnection);
                daDataAdapter.Fill(dsDatabase, strTableName);
                conMyConnection.Close();
            }
            catch (Exception) { }
        }
        public static bool TonTaiKhoaChinh(string strGiaTri, string strTenTruong, string strTable)
        {
            bool blnResult = false;
            try
            {
                string strSelect = "SELECT 1 FROM " + strTable + " WHERE " + strTenTruong + "='" + strGiaTri + "'";
                if (conMyConnection.State == ConnectionState.Closed)
                    conMyConnection.Open();
                SqlCommand cmdCommand = new SqlCommand(strSelect, conMyConnection);
                SqlDataReader daReader = cmdCommand.ExecuteReader();
                if (daReader.HasRows)
                    blnResult = true;
                daReader.Close();
                conMyConnection.Close();
            }
            catch (Exception) { }
            return blnResult;
        }
    }
}
