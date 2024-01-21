using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormDashboard : Form
    {

        private DataProvider dataProvider = new DataProvider();
        public FormDashboard()
        {
            InitializeComponent();
            load();
        }


        public void load()
        {
            


            Dictionary<DateTime, int> ThongKe = new Dictionary<DateTime, int>();
            Dictionary<string, int> topUser = new Dictionary<string, int>();

            Invoice listHD = new Invoice();
            List<Invoice> lHD =  listHD.getList();

            for (int i = 0; i < lHD.Count; i++)
            {
                
                DateTime datetime = lHD[i].ThoiGian;
                DateTime date = datetime.Date;

                string temp1 =lHD[i].NguoiDung_UserName;


                int money = Convert.ToInt32(lHD[i].TongTien);
                if (!ThongKe.ContainsKey(date)) ThongKe.Add(date, 0);
                ThongKe[date] += money;

                if (!topUser.ContainsKey(temp1)) topUser.Add(temp1, 0);
                topUser[temp1] += money;

            }

            foreach (KeyValuePair<DateTime, int> product in ThongKe)
                doanhThuChart.Series["Series1"].Points.AddXY(product.Key, product.Value);

            foreach (KeyValuePair<string, int> product in topUser)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(guna2DataGridView1);
                newRow.Cells[0].Value = product.Key;  // Điều chỉnh tên cột phù hợp
                newRow.Cells[1].Value = product.Value;
                guna2DataGridView1.Rows.Add(newRow);
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleProgressBar2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
