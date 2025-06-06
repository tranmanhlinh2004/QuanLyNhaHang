using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    internal class DataService
    {
        private static SqlConnection mySqlConnection;
        private SqlDataAdapter myDataAdapter;

        // Cho phép truy cập connection từ ngoài (ví dụ DisplayTable dùng)
        public SqlConnection MyConnection => mySqlConnection;

        // Hàm kết nối CSDL
        public bool OpenDataBase()
        {
            string conStr = "Data Source=(local);Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            try
            {
                mySqlConnection = new SqlConnection(conStr);
                mySqlConnection.Open();
            }
            catch (SqlException ex)
            {
                DisplayError(ex);
                mySqlConnection = null;
                return false;
            }
            return true;
        }

        // Hàm đóng kết nối
        public void CloseDatabase()
        {
            if (mySqlConnection != null && mySqlConnection.State == ConnectionState.Open)
            {
                mySqlConnection.Close();
            }
        }

        // Truy vấn dữ liệu
        public DataTable RunQuery(string sSql)
        {
            DataTable myDataTable = new DataTable();
            try
            {
                myDataAdapter = new SqlDataAdapter(sSql, mySqlConnection);
                SqlCommandBuilder mySqlCommandBuilder = new SqlCommandBuilder(myDataAdapter);
                myDataAdapter.Fill(myDataTable);
            }
            catch (SqlException ex)
            {
                DisplayError(ex);
                return null;
            }
            return myDataTable;
        }

        // Cập nhật bảng
        public void Update(DataTable myDataTable)
        {
            try
            {
                myDataAdapter.Update(myDataTable);
            }
            catch (SqlException ex)
            {
                DisplayError(ex);
            }
        }

        // Thực thi câu lệnh SQL
        public void ExecuteNonQuery(string sSql)
        {
            SqlCommand mySqlCommand = new SqlCommand(sSql, mySqlConnection);
            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                DisplayError(ex);
            }
        }

        // Hiển thị lỗi
        public void DisplayError(SqlException ex)
        {
            string sSql = "SELECT * FROM Errors WHERE Number = " + ex.Number;
            DataTable dtError = RunQuery(sSql);
            if (dtError != null && dtError.Rows.Count > 0)
            {
                MessageBox.Show(dtError.Rows[0][1].ToString().Trim(), "Lỗi " + ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(ex.Message, "Error " + ex.Number.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
