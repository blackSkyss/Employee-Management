namespace ManagementApp
{
    partial class frmEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvemp = new System.Windows.Forms.DataGridView();
            this.gfg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dfgd = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fdgdfg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.dtpjoindate = new System.Windows.Forms.DateTimePicker();
            this.txtiddep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtrole = new System.Windows.Forms.TextBox();
            this.txtidpos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbofilterdep = new System.Windows.Forms.ComboBox();
            this.cbotype = new System.Windows.Forms.ComboBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.cbofilterpos = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(422, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management";
            // 
            // dgvemp
            // 
            this.dgvemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvemp.Location = new System.Drawing.Point(54, 349);
            this.dgvemp.Name = "dgvemp";
            this.dgvemp.RowHeadersWidth = 62;
            this.dgvemp.RowTemplate.Height = 33;
            this.dgvemp.Size = new System.Drawing.Size(998, 195);
            this.dgvemp.TabIndex = 1;
            // 
            // gfg
            // 
            this.gfg.AutoSize = true;
            this.gfg.Location = new System.Drawing.Point(65, 60);
            this.gfg.Name = "gfg";
            this.gfg.Size = new System.Drawing.Size(32, 21);
            this.gfg.TabIndex = 2;
            this.gfg.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Join date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(171, 57);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(172, 28);
            this.txtid.TabIndex = 5;
            // 
            // txtgender
            // 
            this.txtgender.Location = new System.Drawing.Point(171, 112);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(172, 28);
            this.txtgender.TabIndex = 6;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(526, 160);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(172, 28);
            this.txtemail.TabIndex = 13;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(526, 108);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(172, 28);
            this.txtphone.TabIndex = 12;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(526, 53);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(172, 28);
            this.txtname.TabIndex = 11;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(420, 115);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(69, 21);
            this.txt.TabIndex = 10;
            this.txt.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email";
            // 
            // dfgd
            // 
            this.dfgd.AutoSize = true;
            this.dfgd.Location = new System.Drawing.Point(420, 56);
            this.dfgd.Name = "dfgd";
            this.dfgd.Size = new System.Drawing.Size(63, 21);
            this.dfgd.TabIndex = 8;
            this.dfgd.Text = "Name";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(880, 160);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(172, 28);
            this.txtpassword.TabIndex = 19;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(880, 53);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(172, 28);
            this.txtaddress.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(774, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Dob";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(774, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Password";
            // 
            // fdgdfg
            // 
            this.fdgdfg.AutoSize = true;
            this.fdgdfg.Location = new System.Drawing.Point(774, 56);
            this.fdgdfg.Name = "fdgdfg";
            this.fdgdfg.Size = new System.Drawing.Size(87, 21);
            this.fdgdfg.TabIndex = 14;
            this.fdgdfg.Text = "Address";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1058, 349);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(112, 34);
            this.btnLoad.TabIndex = 21;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(1058, 406);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(112, 34);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1058, 464);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dtpdob
            // 
            this.dtpdob.CustomFormat = "MM-dd-yyyy";
            this.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdob.Location = new System.Drawing.Point(880, 112);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(172, 28);
            this.dtpdob.TabIndex = 25;
            // 
            // dtpjoindate
            // 
            this.dtpjoindate.CustomFormat = "MM-dd-yyyy";
            this.dtpjoindate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpjoindate.Location = new System.Drawing.Point(171, 165);
            this.dtpjoindate.Name = "dtpjoindate";
            this.dtpjoindate.Size = new System.Drawing.Size(172, 28);
            this.dtpjoindate.TabIndex = 26;
            // 
            // txtiddep
            // 
            this.txtiddep.Location = new System.Drawing.Point(880, 211);
            this.txtiddep.Name = "txtiddep";
            this.txtiddep.Size = new System.Drawing.Size(172, 28);
            this.txtiddep.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(774, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "ID dep";
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(526, 211);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(172, 28);
            this.txtsalary.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Role";
            // 
            // txtrole
            // 
            this.txtrole.Location = new System.Drawing.Point(172, 211);
            this.txtrole.Name = "txtrole";
            this.txtrole.Size = new System.Drawing.Size(172, 28);
            this.txtrole.TabIndex = 32;
            // 
            // txtidpos
            // 
            this.txtidpos.Location = new System.Drawing.Point(171, 260);
            this.txtidpos.Name = "txtidpos";
            this.txtidpos.Size = new System.Drawing.Size(173, 28);
            this.txtidpos.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 21);
            this.label10.TabIndex = 33;
            this.label10.Text = "ID Pos";
            // 
            // cbofilterdep
            // 
            this.cbofilterdep.FormattingEnabled = true;
            this.cbofilterdep.Location = new System.Drawing.Point(526, 259);
            this.cbofilterdep.Name = "cbofilterdep";
            this.cbofilterdep.Size = new System.Drawing.Size(176, 29);
            this.cbofilterdep.TabIndex = 35;
            this.cbofilterdep.Text = "Department";
            // 
            // cbotype
            // 
            this.cbotype.FormattingEnabled = true;
            this.cbotype.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Email"});
            this.cbotype.Location = new System.Drawing.Point(526, 306);
            this.cbotype.Name = "cbotype";
            this.cbotype.Size = new System.Drawing.Size(176, 29);
            this.cbotype.TabIndex = 36;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(721, 307);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(161, 28);
            this.txtsearch.TabIndex = 37;
            // 
            // cbofilterpos
            // 
            this.cbofilterpos.FormattingEnabled = true;
            this.cbofilterpos.Location = new System.Drawing.Point(721, 259);
            this.cbofilterpos.Name = "cbofilterpos";
            this.cbofilterpos.Size = new System.Drawing.Size(161, 29);
            this.cbofilterpos.TabIndex = 38;
            this.cbofilterpos.Text = "Position";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(422, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 21);
            this.label11.TabIndex = 39;
            this.label11.Text = "Filter";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(422, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 21);
            this.label12.TabIndex = 40;
            this.label12.Text = "Search";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 596);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbofilterpos);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.cbotype);
            this.Controls.Add(this.cbofilterdep);
            this.Controls.Add(this.txtidpos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtrole);
            this.Controls.Add(this.txtiddep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpjoindate);
            this.Controls.Add(this.dtpdob);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fdgdfg);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dfgd);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gfg);
            this.Controls.Add(this.dgvemp);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvemp;
        private System.Windows.Forms.Label gfg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label dfgd;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label fdgdfg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.DateTimePicker dtpjoindate;
        private System.Windows.Forms.TextBox txtiddep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtrole;
        private System.Windows.Forms.TextBox txtidpos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbofilterdep;
        private System.Windows.Forms.ComboBox cbotype;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox cbofilterpos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}