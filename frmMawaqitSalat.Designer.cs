namespace روح_وريحان
{
    partial class frmMawaqitSalat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMawaqitSalat));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNextAdan = new System.Windows.Forms.Label();
            this.lbAdanTime = new System.Windows.Forms.Label();
            this.lbTimerNextAdan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDateHijri = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDateMiladi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1232, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbCountry
            // 
            this.cbCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Items.AddRange(new object[] {
            "المغرب ",
            "الاردن",
            "السعودية",
            "الجزائر",
            "الإمارات العربية",
            "عمان",
            "مصر",
            "فلسطين",
            "البحرين",
            "قطر",
            "الكويت",
            "السودان",
            "موريتانيا",
            "ليبيا",
            "العراق",
            "تونس",
            "تركيا",
            "اليمن",
            "سوريا",
            "لبنان"});
            this.cbCountry.Location = new System.Drawing.Point(13, 230);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbCountry.Size = new System.Drawing.Size(253, 37);
            this.cbCountry.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(272, 233);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "اختر البلد:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(1014, 238);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(198, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "الوقت الأن في بلدك";
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateTime.ForeColor = System.Drawing.Color.White;
            this.lbDateTime.Location = new System.Drawing.Point(790, 235);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbDateTime.Size = new System.Drawing.Size(0, 27);
            this.lbDateTime.TabIndex = 5;
            this.lbDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 410);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1202, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(518, 343);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(246, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "الوقت المتبقي لاذان ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(607, 233);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(157, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "الاذان القادم:";
            // 
            // lbNextAdan
            // 
            this.lbNextAdan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNextAdan.AutoSize = true;
            this.lbNextAdan.BackColor = System.Drawing.Color.Transparent;
            this.lbNextAdan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNextAdan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbNextAdan.Location = new System.Drawing.Point(514, 234);
            this.lbNextAdan.Name = "lbNextAdan";
            this.lbNextAdan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbNextAdan.Size = new System.Drawing.Size(0, 29);
            this.lbNextAdan.TabIndex = 9;
            this.lbNextAdan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAdanTime
            // 
            this.lbAdanTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAdanTime.AutoSize = true;
            this.lbAdanTime.BackColor = System.Drawing.Color.Transparent;
            this.lbAdanTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdanTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbAdanTime.Location = new System.Drawing.Point(443, 343);
            this.lbAdanTime.Name = "lbAdanTime";
            this.lbAdanTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbAdanTime.Size = new System.Drawing.Size(0, 29);
            this.lbAdanTime.TabIndex = 10;
            // 
            // lbTimerNextAdan
            // 
            this.lbTimerNextAdan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTimerNextAdan.AutoSize = true;
            this.lbTimerNextAdan.BackColor = System.Drawing.Color.Transparent;
            this.lbTimerNextAdan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTimerNextAdan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTimerNextAdan.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimerNextAdan.ForeColor = System.Drawing.Color.White;
            this.lbTimerNextAdan.Location = new System.Drawing.Point(323, 345);
            this.lbTimerNextAdan.Name = "lbTimerNextAdan";
            this.lbTimerNextAdan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTimerNextAdan.Size = new System.Drawing.Size(114, 29);
            this.lbTimerNextAdan.TabIndex = 11;
            this.lbTimerNextAdan.Text = "00:00:00";
            this.lbTimerNextAdan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(1038, 598);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(184, 39);
            this.label5.TabIndex = 12;
            this.label5.Text = "تاريخ اليوم:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDateHijri
            // 
            this.lbDateHijri.AutoSize = true;
            this.lbDateHijri.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateHijri.ForeColor = System.Drawing.Color.White;
            this.lbDateHijri.Location = new System.Drawing.Point(32, 604);
            this.lbDateHijri.Name = "lbDateHijri";
            this.lbDateHijri.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbDateHijri.Size = new System.Drawing.Size(0, 34);
            this.lbDateHijri.TabIndex = 13;
            this.lbDateHijri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(890, 608);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(99, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "ميلادي:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDateMiladi
            // 
            this.lbDateMiladi.AutoSize = true;
            this.lbDateMiladi.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateMiladi.ForeColor = System.Drawing.Color.White;
            this.lbDateMiladi.Location = new System.Drawing.Point(545, 604);
            this.lbDateMiladi.Name = "lbDateMiladi";
            this.lbDateMiladi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbDateMiladi.Size = new System.Drawing.Size(0, 34);
            this.lbDateMiladi.TabIndex = 15;
            this.lbDateMiladi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(423, 608);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(94, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "هجري:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Visible = true;
            // 
            // frmMawaqitSalat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1231, 685);
            this.Controls.Add(this.lbAdanTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbDateMiladi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbDateHijri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTimerNextAdan);
            this.Controls.Add(this.lbNextAdan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMawaqitSalat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMawaqitSalat";
            this.Load += new System.EventHandler(this.frmMawaqitSalat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNextAdan;
        private System.Windows.Forms.Label lbAdanTime;
        private System.Windows.Forms.Label lbTimerNextAdan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDateHijri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDateMiladi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}