namespace lab_6
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Nhapa = new System.Windows.Forms.Label();
            this.lb_Nhapb = new System.Windows.Forms.Label();
            this.lb_KQ = new System.Windows.Forms.Label();
            this.textBox_Nhapa = new System.Windows.Forms.TextBox();
            this.textBox_KQ = new System.Windows.Forms.TextBox();
            this.textBox_Nhapb = new System.Windows.Forms.TextBox();
            this.button_Cong = new System.Windows.Forms.Button();
            this.button_Tru = new System.Windows.Forms.Button();
            this.button_Nhan = new System.Windows.Forms.Button();
            this.button_Chia = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Close);
            this.panel1.Controls.Add(this.button_C);
            this.panel1.Controls.Add(this.button_Chia);
            this.panel1.Controls.Add(this.button_Nhan);
            this.panel1.Controls.Add(this.button_Tru);
            this.panel1.Controls.Add(this.button_Cong);
            this.panel1.Controls.Add(this.textBox_Nhapb);
            this.panel1.Controls.Add(this.textBox_KQ);
            this.panel1.Controls.Add(this.textBox_Nhapa);
            this.panel1.Controls.Add(this.lb_KQ);
            this.panel1.Controls.Add(this.lb_Nhapb);
            this.panel1.Controls.Add(this.lb_Nhapa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 385);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(144, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÁC PHÉP TOÁN SỐ HỌC";
            // 
            // lb_Nhapa
            // 
            this.lb_Nhapa.AutoSize = true;
            this.lb_Nhapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nhapa.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lb_Nhapa.Location = new System.Drawing.Point(34, 112);
            this.lb_Nhapa.Name = "lb_Nhapa";
            this.lb_Nhapa.Size = new System.Drawing.Size(158, 25);
            this.lb_Nhapa.TabIndex = 1;
            this.lb_Nhapa.Text = "Nhập vào số a:";
            this.lb_Nhapa.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_Nhapb
            // 
            this.lb_Nhapb.AutoSize = true;
            this.lb_Nhapb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nhapb.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lb_Nhapb.Location = new System.Drawing.Point(34, 170);
            this.lb_Nhapb.Name = "lb_Nhapb";
            this.lb_Nhapb.Size = new System.Drawing.Size(158, 25);
            this.lb_Nhapb.TabIndex = 2;
            this.lb_Nhapb.Text = "Nhập vào số b:";
            // 
            // lb_KQ
            // 
            this.lb_KQ.AutoSize = true;
            this.lb_KQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_KQ.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lb_KQ.Location = new System.Drawing.Point(34, 225);
            this.lb_KQ.Name = "lb_KQ";
            this.lb_KQ.Size = new System.Drawing.Size(94, 25);
            this.lb_KQ.TabIndex = 3;
            this.lb_KQ.Text = "Kết quả:";
            // 
            // textBox_Nhapa
            // 
            this.textBox_Nhapa.AcceptsTab = true;
            this.textBox_Nhapa.Location = new System.Drawing.Point(261, 116);
            this.textBox_Nhapa.Name = "textBox_Nhapa";
            this.textBox_Nhapa.Size = new System.Drawing.Size(220, 22);
            this.textBox_Nhapa.TabIndex = 4;
            this.textBox_Nhapa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Nhapa.TextChanged += new System.EventHandler(this.textBox_Nhapa_TextChanged);
            // 
            // textBox_KQ
            // 
            this.textBox_KQ.Location = new System.Drawing.Point(261, 229);
            this.textBox_KQ.Name = "textBox_KQ";
            this.textBox_KQ.ReadOnly = true;
            this.textBox_KQ.Size = new System.Drawing.Size(220, 22);
            this.textBox_KQ.TabIndex = 6;
            this.textBox_KQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_KQ.TextChanged += new System.EventHandler(this.textBox_KQ_TextChanged);
            // 
            // textBox_Nhapb
            // 
            this.textBox_Nhapb.Location = new System.Drawing.Point(261, 170);
            this.textBox_Nhapb.Name = "textBox_Nhapb";
            this.textBox_Nhapb.Size = new System.Drawing.Size(220, 22);
            this.textBox_Nhapb.TabIndex = 5;
            this.textBox_Nhapb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Nhapb.TextChanged += new System.EventHandler(this.textBox_Nhapb_TextChanged);
            // 
            // button_Cong
            // 
            this.button_Cong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cong.Location = new System.Drawing.Point(68, 287);
            this.button_Cong.Name = "button_Cong";
            this.button_Cong.Size = new System.Drawing.Size(75, 33);
            this.button_Cong.TabIndex = 7;
            this.button_Cong.Text = "+";
            this.button_Cong.UseVisualStyleBackColor = true;
            this.button_Cong.Click += new System.EventHandler(this.button_Cong_Click);
            // 
            // button_Tru
            // 
            this.button_Tru.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Tru.Location = new System.Drawing.Point(178, 287);
            this.button_Tru.Name = "button_Tru";
            this.button_Tru.Size = new System.Drawing.Size(75, 33);
            this.button_Tru.TabIndex = 8;
            this.button_Tru.Text = "-";
            this.button_Tru.UseVisualStyleBackColor = true;
            this.button_Tru.Click += new System.EventHandler(this.button_Tru_Click);
            // 
            // button_Nhan
            // 
            this.button_Nhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Nhan.Location = new System.Drawing.Point(68, 326);
            this.button_Nhan.Name = "button_Nhan";
            this.button_Nhan.Size = new System.Drawing.Size(75, 30);
            this.button_Nhan.TabIndex = 9;
            this.button_Nhan.Text = "*";
            this.button_Nhan.UseVisualStyleBackColor = true;
            this.button_Nhan.Click += new System.EventHandler(this.button_Nhan_Click);
            // 
            // button_Chia
            // 
            this.button_Chia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Chia.Location = new System.Drawing.Point(178, 326);
            this.button_Chia.Name = "button_Chia";
            this.button_Chia.Size = new System.Drawing.Size(75, 30);
            this.button_Chia.TabIndex = 10;
            this.button_Chia.Text = "/";
            this.button_Chia.UseVisualStyleBackColor = true;
            this.button_Chia.Click += new System.EventHandler(this.button_Chia_Click);
            // 
            // button_C
            // 
            this.button_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_C.ForeColor = System.Drawing.Color.Red;
            this.button_C.Location = new System.Drawing.Point(339, 313);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(75, 43);
            this.button_C.TabIndex = 11;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // button_Close
            // 
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.Location = new System.Drawing.Point(455, 313);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 43);
            this.button_Close.TabIndex = 12;
            this.button_Close.Text = "Exit";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 409);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Nhapa;
        private System.Windows.Forms.Label lb_KQ;
        private System.Windows.Forms.Label lb_Nhapb;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_Chia;
        private System.Windows.Forms.Button button_Nhan;
        private System.Windows.Forms.Button button_Tru;
        private System.Windows.Forms.Button button_Cong;
        private System.Windows.Forms.TextBox textBox_Nhapb;
        private System.Windows.Forms.TextBox textBox_KQ;
        private System.Windows.Forms.TextBox textBox_Nhapa;
    }
}

