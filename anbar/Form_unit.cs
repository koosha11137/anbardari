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
    public partial class Form_unit : Form
    {
        static SqlConnection con = new SqlConnection(Properties.Settings.Default.strcon);
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public Form_unit()
        {
            InitializeComponent();
        }
        string nam;

        private void Form_unit_Load(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("select * from  unit", con);
            con.Open();
            da.Fill(ds, "t1");
            con.Close();
            dataGridViewX1.DataSource = ds;
            dataGridViewX1.DataMember = "t1";
            DataTable dt = new DataTable();
            DataBase db = new DataBase();
            dt = db.MySelect("select * from unit");
            dataGridViewX1.DataSource = dt;
            dataGridViewX1.Columns[0].HeaderText = "عنوان واحد ";
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (textBoxX1.Text == "")
            {
                MessageBox.Show("نام واحد اندازه گیری را وارد کنید");
            }
            else
            {
                ds.Clear();
                da.SelectCommand.CommandText = "select name from unit where name='" + textBoxX1.Text + "'";
                da.Fill(ds, "d1");
                if (ds.Tables["d1"].Rows.Count > 0)
                {
                    DialogResult d = MessageBox.Show("این رکورد قبلا ثبت شده است ", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxX1.Clear();

                }
                else
                {
                    DataBase db = new DataBase();
                    db.DoCommand("insert into unit(name) values('" + textBoxX1.Text + "')");
                    Form_unit_Load(sender, e);
                    dataGridViewX1.CurrentCell = dataGridViewX1.Rows[dataGridViewX1.RowCount - 2].Cells[0];
                    MessageBox.Show("رکورد مورد نظر درج شد");
                }
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                DataBase db = new DataBase();
                db.DoCommand("delete from unit where name='" + textBoxX1.Text + "'");
                //'update datagrid
                Form_unit_Load(sender, e);
                MessageBox.Show("رکورد مورد نظر حذف شد");
            }
            else { }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            string str = "select * from unit where ";
            if (textBoxX1.Text != "") str += "name like '%" + textBoxX1.Text + "' and ";
            if (str == "select * from unit where ")
                str = "select * from unit";
            else
                str = str.Remove(str.Length - 4, 4);
            DataTable dt = new DataTable();
            DataBase db = new DataBase();
            dt = db.MySelect(str);
            MessageBox.Show(dt.Rows.Count.ToString() + " تعداد رکورد های یافت شده");
            dataGridViewX1.DataSource = dt;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            db.DoCommand("update unit set name='" + textBoxX1.Text + "' where name='" + nam + "'");
            //'UPDATE DATAGRID
            Form_unit_Load(sender, e);
            MessageBox.Show("رکورد مورد نظر ویرایش شد");
        }

        private void dataGridViewX1_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxX1.Text = dataGridViewX1[0, dataGridViewX1.CurrentRow.Index].Value.ToString();
            nam = textBoxX1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

       
       

        

      
      
    }
}
