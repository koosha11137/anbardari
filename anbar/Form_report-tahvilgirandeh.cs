﻿using System;
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
    public partial class Form_report_tahvilgirandeh : Form
    {
        public Form_report_tahvilgirandeh()
        {
            InitializeComponent();
        }

        private void Form_report_tahvilgirandeh_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataBase db = new DataBase();
            dt = db.MySelect("select * from tahvilgirandeh");
            dataGridViewX1.DataSource = dt;
            dataGridViewX1.Columns[0].HeaderText = "کد";
            dataGridViewX1.Columns[1].HeaderText = "نام ";
            dataGridViewX1.Columns[2].HeaderText = "نام خانوادگی";
            dataGridViewX1.Columns[3].HeaderText = "تلفن";
            dataGridViewX1.Columns[4].HeaderText = "آدرس";
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            PrintDGV.Print_DataGridView(dataGridViewX1);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
