namespace ManagementApp
{
    partial class frmRwAndPt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDRP = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtTimes = new System.Windows.Forms.TextBox();
            this.txtIDRegulation = new System.Windows.Forms.TextBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvRP = new System.Windows.Forms.DataGridView();
            this.dtpAppDate = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(279, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reward And Penalty Management";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(394, 330);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 20);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID RP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reason";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Applicable Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(411, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Times";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(411, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID regulation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(411, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "ID employee";
            // 
            // txtIDRP
            // 
            this.txtIDRP.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtIDRP.Location = new System.Drawing.Point(239, 46);
            this.txtIDRP.Name = "txtIDRP";
            this.txtIDRP.Size = new System.Drawing.Size(100, 21);
            this.txtIDRP.TabIndex = 8;
            // 
            // txtReason
            // 
            this.txtReason.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtReason.Location = new System.Drawing.Point(239, 80);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(100, 21);
            this.txtReason.TabIndex = 9;
            // 
            // txtTimes
            // 
            this.txtTimes.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTimes.Location = new System.Drawing.Point(638, 46);
            this.txtTimes.Name = "txtTimes";
            this.txtTimes.Size = new System.Drawing.Size(100, 21);
            this.txtTimes.TabIndex = 11;
            // 
            // txtIDRegulation
            // 
            this.txtIDRegulation.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtIDRegulation.Location = new System.Drawing.Point(638, 81);
            this.txtIDRegulation.Name = "txtIDRegulation";
            this.txtIDRegulation.Size = new System.Drawing.Size(100, 21);
            this.txtIDRegulation.TabIndex = 12;
            // 
            // txtEmployee
            // 
            this.txtEmployee.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmployee.Location = new System.Drawing.Point(638, 113);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(100, 21);
            this.txtEmployee.TabIndex = 13;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(729, 252);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(729, 294);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvRP
            // 
            this.dgvRP.AllowUserToAddRows = false;
            this.dgvRP.AllowUserToDeleteRows = false;
            this.dgvRP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRP.Location = new System.Drawing.Point(22, 175);
            this.dgvRP.MultiSelect = false;
            this.dgvRP.Name = "dgvRP";
            this.dgvRP.ReadOnly = true;
            this.dgvRP.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgvRP.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRP.RowTemplate.Height = 25;
            this.dgvRP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRP.Size = new System.Drawing.Size(684, 150);
            this.dgvRP.TabIndex = 17;
            this.dgvRP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRP_CellDoubleClick);
            // 
            // dtpAppDate
            // 
            this.dtpAppDate.CustomFormat = "MM-dd-yyyy";
            this.dtpAppDate.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpAppDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppDate.Location = new System.Drawing.Point(239, 118);
            this.dtpAppDate.Name = "dtpAppDate";
            this.dtpAppDate.Size = new System.Drawing.Size(100, 21);
            this.dtpAppDate.TabIndex = 18;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(540, 146);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(71, 21);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cboType
            // 
            this.cboType.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "ID"});
            this.cboType.Location = new System.Drawing.Point(477, 145);
            this.cboType.Margin = new System.Windows.Forms.Padding(2);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(50, 22);
            this.cboType.TabIndex = 20;
            this.cboType.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(411, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 14);
            this.label8.TabIndex = 21;
            this.label8.Text = "Search";
            // 
            // frmRwAndPt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 358);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtpAppDate);
            this.Controls.Add(this.dgvRP);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.txtIDRegulation);
            this.Controls.Add(this.txtTimes);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.txtIDRP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRwAndPt";
            this.Text = "frmRwAndPt";
            this.Load += new System.EventHandler(this.frmRwAndPt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDRP;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.TextBox txtTimes;
        private System.Windows.Forms.TextBox txtIDRegulation;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvRP;
        private System.Windows.Forms.DateTimePicker dtpAppDate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label8;
    }
}