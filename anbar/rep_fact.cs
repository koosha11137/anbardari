using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace anbar
{
    public partial class rep_fact : Form
    {
        static SqlConnection con = new SqlConnection(Properties.Settings.Default.strcon);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet1 ds1 = new DataSet1();
        public rep_fact()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void rep_fact_Load(object sender, EventArgs e)
        {


            


        }

        private void button1_Click(object sender, EventArgs e)
        {

        } 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CrystalReport1 cr = new CrystalReport1();

            da.SelectCommand = new SqlCommand("select shfact,name,country,anbar,cter,unit,unitprice,totalprice,tarikh from aghlam where shfact='" + textBox1.Text + "'", con);
            //da.SelectCommand = new SqlCommand("select id,seller,custumer from factor where Id='" + textBox1.Text + "'", con);
            con.Open();
            da.Fill(ds1, "tbl_fact");
            cr.SetDataSource(ds1.Tables["tbl_fact"]);
            crystalReportViewer1.ReportSource = cr;

            con.Close();
            da.SelectCommand = new SqlCommand("select id,seller,custumer from factor where Id='" + textBox1.Text + "'", con);

            con.Open();
            cr.SetDataSource(ds1.Tables["tbl_fact"]);
            crystalReportViewer1.ReportSource = cr;
            con.Close();                 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.PrintReport();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                return;
            }
            if (!System.Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("لطفا عدد وارد کنید", "هشدار", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
