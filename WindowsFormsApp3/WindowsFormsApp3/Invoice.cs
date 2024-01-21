using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class Invoice
    {
        private DataProvider dataProvider = new DataProvider();
        public int DonHangID { get; set; }
        public string NguoiDung_UserName { get; set; }
        public DateTime ThoiGian { get; set; }
        public int TongTien { get; set; }
        public List<Invoice> getList()
        {
            StringBuilder query = new StringBuilder("SELECT * FROM HoaDon");
            SqlDataReader reader = dataProvider.execReader(query.ToString());
            List<Invoice> list = new List<Invoice>();
            while (reader.Read())
            {
                Invoice hdon = new Invoice();
                hdon.DonHangID = Convert.ToInt32(reader["DonHangID"]);
                hdon.NguoiDung_UserName = reader["NguoiDung_UserName"].ToString();
                hdon.ThoiGian = DateTime.Parse(reader["ThoiGian"].ToString());
                hdon.TongTien = Convert.ToInt32(reader["TongTien"]);
                list.Add(hdon);
            }
            return list;
        } 
    }

}
