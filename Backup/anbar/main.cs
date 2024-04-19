using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace anbar
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_foroshandeh x = new Form_foroshandeh();
            x.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_tahvilgirandeh x = new Form_tahvilgirandeh();
            x.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_kala x = new Form_kala();
            x.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_anbar x = new Form_anbar();
            x.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_unit  x = new Form_unit();
            x.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_country x = new Form_country();
            x.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form_report_mojodi x = new Form_report_mojodi();
            x.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form_report_kala x = new Form_report_kala();
            x.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form_report_foroshandeh x = new Form_report_foroshandeh();
            x.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form_report_tahvilgirandeh x = new Form_report_tahvilgirandeh();
            x.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form_factor x = new Form_factor();
            x.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form_user_settings x = new Form_user_settings();
            x.ShowDialog();
        }

        private void main_Load(object sender, EventArgs e)
        {
            if (variable.i == 2)
            {
                labelX1.Text = "کاربر عادی";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button7.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
            }
            else
                labelX1.Text = "مدیر";

            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "درج و حذف و ویرایش فروشندگان";
        }

        private void main_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "درج و حذف و ویرایش تجویل گیرندگان";
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
 label2.Text = "درج و حذف و ویرایش کالا";
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "درج و حذف و ویرایش انبار";

        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "درج و حذف و ویرایش واحدهای اندازه گیری";

        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "درج و حذف و ویرایش کشورهای سازنده ی کالا";

        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "گزارش موجودی های انبارها";

        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "گزارش کالاهای موجود در انبار";

        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "گزارش فروشندگان";

        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "گزارش تحویل گیرنده ها";

        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "صادر کردن فاکتور فروش کالا";

        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            label2.Text = "حذف و ویرایش و اضافه کردن کاربر";

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
          
            if ( MessageBox.Show("آیا می خواهید خارج شوید؟", "خروج",  MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            rep_fact x = new rep_fact();
            x.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            form_about x=new form_about();
            x.ShowDialog();

        }

        
    }
}
