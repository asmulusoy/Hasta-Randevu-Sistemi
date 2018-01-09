namespace HastaneOtomasyon
{
    partial class frmRandevuEkleDoktorSec
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
            this.lstDoktorlar = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbServisler = new System.Windows.Forms.ComboBox();
            this.groupRandevuSaati = new System.Windows.Forms.GroupBox();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupRandevuSaati.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDoktorlar
            // 
            this.lstDoktorlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lstDoktorlar.FullRowSelect = true;
            this.lstDoktorlar.GridLines = true;
            this.lstDoktorlar.Location = new System.Drawing.Point(6, 58);
            this.lstDoktorlar.Name = "lstDoktorlar";
            this.lstDoktorlar.Size = new System.Drawing.Size(229, 258);
            this.lstDoktorlar.TabIndex = 10;
            this.lstDoktorlar.UseCompatibleStateImageBehavior = false;
            this.lstDoktorlar.View = System.Windows.Forms.View.Details;
            this.lstDoktorlar.SelectedIndexChanged += new System.EventHandler(this.lstDoktorlar_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ad";
            this.columnHeader3.Width = 109;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Soyad";
            this.columnHeader4.Width = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Servis :";
            // 
            // cmbServisler
            // 
            this.cmbServisler.FormattingEnabled = true;
            this.cmbServisler.Location = new System.Drawing.Point(57, 31);
            this.cmbServisler.Name = "cmbServisler";
            this.cmbServisler.Size = new System.Drawing.Size(178, 21);
            this.cmbServisler.TabIndex = 8;
            this.cmbServisler.SelectedIndexChanged += new System.EventHandler(this.cmbServisler_SelectedIndexChanged);
            // 
            // groupRandevuSaati
            // 
            this.groupRandevuSaati.Controls.Add(this.button21);
            this.groupRandevuSaati.Controls.Add(this.button22);
            this.groupRandevuSaati.Controls.Add(this.button23);
            this.groupRandevuSaati.Controls.Add(this.button18);
            this.groupRandevuSaati.Controls.Add(this.button19);
            this.groupRandevuSaati.Controls.Add(this.button20);
            this.groupRandevuSaati.Controls.Add(this.button15);
            this.groupRandevuSaati.Controls.Add(this.button16);
            this.groupRandevuSaati.Controls.Add(this.button17);
            this.groupRandevuSaati.Controls.Add(this.button12);
            this.groupRandevuSaati.Controls.Add(this.button13);
            this.groupRandevuSaati.Controls.Add(this.button14);
            this.groupRandevuSaati.Controls.Add(this.button11);
            this.groupRandevuSaati.Controls.Add(this.button10);
            this.groupRandevuSaati.Controls.Add(this.button9);
            this.groupRandevuSaati.Controls.Add(this.button5);
            this.groupRandevuSaati.Controls.Add(this.button4);
            this.groupRandevuSaati.Controls.Add(this.button3);
            this.groupRandevuSaati.Controls.Add(this.button2);
            this.groupRandevuSaati.Controls.Add(this.button1);
            this.groupRandevuSaati.Location = new System.Drawing.Point(270, 70);
            this.groupRandevuSaati.Name = "groupRandevuSaati";
            this.groupRandevuSaati.Size = new System.Drawing.Size(215, 188);
            this.groupRandevuSaati.TabIndex = 12;
            this.groupRandevuSaati.TabStop = false;
            this.groupRandevuSaati.Text = "Randevu Saati";
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(162, 154);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(46, 22);
            this.button21.TabIndex = 27;
            this.button21.Text = "14:45";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button1_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(110, 154);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(46, 22);
            this.button22.TabIndex = 26;
            this.button22.Text = "14:30";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button1_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(58, 154);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(46, 22);
            this.button23.TabIndex = 25;
            this.button23.Text = "14:15";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button1_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(162, 126);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(46, 22);
            this.button18.TabIndex = 24;
            this.button18.Text = "13:45";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button1_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(110, 126);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(46, 22);
            this.button19.TabIndex = 23;
            this.button19.Text = "13:30";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button1_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(58, 126);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(46, 22);
            this.button20.TabIndex = 22;
            this.button20.Text = "13:15";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button1_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(162, 75);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(46, 22);
            this.button15.TabIndex = 21;
            this.button15.Text = "11:45";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button1_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(110, 75);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(46, 22);
            this.button16.TabIndex = 20;
            this.button16.Text = "11:30";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button1_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(58, 75);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(46, 22);
            this.button17.TabIndex = 19;
            this.button17.Text = "11:15";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button1_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(162, 47);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(46, 22);
            this.button12.TabIndex = 18;
            this.button12.Text = "10:45";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button1_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(110, 47);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(46, 22);
            this.button13.TabIndex = 17;
            this.button13.Text = "10:30";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button1_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(58, 47);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(46, 22);
            this.button14.TabIndex = 16;
            this.button14.Text = "10:15";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button1_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(162, 19);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(46, 22);
            this.button11.TabIndex = 15;
            this.button11.Text = "09:45";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button1_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(110, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(46, 22);
            this.button10.TabIndex = 14;
            this.button10.Text = "09:30";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button1_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(58, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(46, 22);
            this.button9.TabIndex = 13;
            this.button9.Text = "09:15";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 154);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 22);
            this.button5.TabIndex = 9;
            this.button5.Text = "14:00";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 22);
            this.button4.TabIndex = 8;
            this.button4.Text = "13:00";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 22);
            this.button3.TabIndex = 7;
            this.button3.Text = "11:00";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 22);
            this.button2.TabIndex = 6;
            this.button2.Text = "10:00";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 22);
            this.button1.TabIndex = 5;
            this.button1.Tag = "";
            this.button1.Text = "09:00";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstDoktorlar);
            this.groupBox1.Controls.Add(this.cmbServisler);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 322);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Seçimi";
            // 
            // button6
            // 
            this.button6.Image = global::HastaneOtomasyon.Properties.Resources.randevu;
            this.button6.Location = new System.Drawing.Point(387, 307);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 27);
            this.button6.TabIndex = 14;
            this.button6.Text = "Randevu Al";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button7.Image = global::HastaneOtomasyon.Properties.Resources.iptal;
            this.button7.Location = new System.Drawing.Point(318, 307);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(63, 27);
            this.button7.TabIndex = 15;
            this.button7.Text = "İptal";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // frmRandevuEkleDoktorSec
            // 
            this.AcceptButton = this.button6;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.button7;
            this.ClientSize = new System.Drawing.Size(492, 343);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupRandevuSaati);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRandevuEkleDoktorSec";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Doktorunu ve Saatini Seçiniz";
            this.Load += new System.EventHandler(this.frmRandevuEkleDoktorSec_Load);
            this.groupRandevuSaati.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lstDoktorlar;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbServisler;
        private System.Windows.Forms.GroupBox groupRandevuSaati;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}