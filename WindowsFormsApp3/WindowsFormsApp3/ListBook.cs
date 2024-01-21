using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class ListBook
    {
        private DataProvider dataProvider = new DataProvider();
        public List<Book> GetAll()
        {
            //string constr = "server=.; database=QuanLyDVKS; Integrated Security = true;";


            StringBuilder query = new StringBuilder("SELECT * FROM Sach");
            SqlDataReader reader = dataProvider.execReader(query.ToString());
            List<Book> list = new List<Book>();
            while (reader.Read())
            {
                Book sach = new Book();
                sach.ID = Convert.ToInt32(reader["ID"]);
                sach.Ten = reader["Ten"].ToString();
                sach.TacGia = reader["TacGia"].ToString();
                sach.Gia = Convert.ToInt32(reader["Gia"]);
                sach.SoLuong = Convert.ToInt32(reader["SoLuong"]);
                list.Add(sach);
            }
            return list;
        }
    }
}
