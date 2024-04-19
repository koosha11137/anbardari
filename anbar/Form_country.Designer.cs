namespace anbar
{
    partial class Form_country
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonX4 = new System.Windows.Forms.Button();
            this.dataGridViewX1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.buttonX3 = new System.Windows.Forms.Button();
            this.buttonX1 = new System.Windows.Forms.Button();
            this.buttonX2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonX4
            // 
            this.buttonX4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX4.Location = new System.Drawing.Point(247, 384);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(69, 31);
            this.buttonX4.TabIndex = 38;
            this.buttonX4.Text = "جستجو";
            this.buttonX4.UseVisualStyleBackColor = true;
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewX1.Size = new System.Drawing.Size(307, 337);
            this.dataGridViewX1.TabIndex = 41;
            this.dataGridViewX1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridViewX1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(244, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 40;
            this.label1.Text = "نام کشور";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(12, 15);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(226, 20);
            this.textBoxX1.TabIndex = 39;
            // 
            // buttonX3
            // 
            this.buttonX3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX3.Location = new System.Drawing.Point(171, 385);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(70, 32);
            this.buttonX3.TabIndex = 37;
            this.buttonX3.Text = "حذف";
            this.buttonX3.UseVisualStyleBackColor = true;
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonX1.Location = new System.Drawing.Point(21, 384);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(70, 35);
            this.buttonX1.TabIndex = 35;
            this.buttonX1.Text = "درج";
            this.buttonX1.UseVisualStyleBackColor = true;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX2.Location = new System.Drawing.Point(97, 384);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(68, 34);
            this.buttonX2.TabIndex = 36;
            this.buttonX2.Text = "ویرایش";
            this.buttonX2.UseVisualStyleBackColor = true;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // Form_country
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::anbar.Properties.Resources._31;
            this.ClientSize = new System.Drawing.Size(332, 431);
            this.Controls.Add(this.buttonX4);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.buttonX2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_country";
            this.Text = "کشورهای سازنده";
            this.Load += new System.EventHandler(this.Form_country_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonX4;
        private System.Windows.Forms.DataGridView dataGridViewX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Button buttonX3;
        private System.Windows.Forms.Button buttonX1;
        private System.Windows.Forms.Button buttonX2;
    }
}