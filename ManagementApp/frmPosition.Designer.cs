namespace ManagementApp
{
    partial class frmPosition
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
            this.txtIdPosition = new System.Windows.Forms.TextBox();
            this.txtPosName = new System.Windows.Forms.TextBox();
            this.txtPosDescription = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvPosition = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.cboTypee = new System.Windows.Forms.ComboBox();
            this.txtSearchh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(310, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position Management";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(381, 362);
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
            this.label2.Location = new System.Drawing.Point(80, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(390, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Position name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(80, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description";
            // 
            // txtIdPosition
            // 
            this.txtIdPosition.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtIdPosition.Location = new System.Drawing.Point(211, 65);
            this.txtIdPosition.Name = "txtIdPosition";
            this.txtIdPosition.Size = new System.Drawing.Size(148, 21);
            this.txtIdPosition.TabIndex = 5;
            // 
            // txtPosName
            // 
            this.txtPosName.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPosName.Location = new System.Drawing.Point(521, 65);
            this.txtPosName.Name = "txtPosName";
            this.txtPosName.Size = new System.Drawing.Size(148, 21);
            this.txtPosName.TabIndex = 6;
            // 
            // txtPosDescription
            // 
            this.txtPosDescription.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPosDescription.Location = new System.Drawing.Point(211, 102);
            this.txtPosDescription.Name = "txtPosDescription";
            this.txtPosDescription.Size = new System.Drawing.Size(148, 21);
            this.txtPosDescription.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(455, 188);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(330, 188);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
            // 
            // dgvPosition
            // 
            this.dgvPosition.AllowUserToAddRows = false;
            this.dgvPosition.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPosition.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPosition.Location = new System.Drawing.Point(234, 215);
            this.dgvPosition.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPosition.Name = "dgvPosition";
            this.dgvPosition.ReadOnly = true;
            this.dgvPosition.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dgvPosition.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPosition.RowTemplate.Height = 25;
            this.dgvPosition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosition.Size = new System.Drawing.Size(365, 129);
            this.dgvPosition.TabIndex = 11;
            this.dgvPosition.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPosition_CellDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 23);
            this.txtSearch.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Search.Location = new System.Drawing.Point(296, 151);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(51, 14);
            this.Search.TabIndex = 13;
            this.Search.Text = "Search";
            // 
            // cboType
            // 
            this.cboType.Location = new System.Drawing.Point(0, 0);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 23);
            this.cboType.TabIndex = 0;
            // 
            // cboTypee
            // 
            this.cboTypee.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboTypee.FormattingEnabled = true;
            this.cboTypee.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.cboTypee.Location = new System.Drawing.Point(211, 155);
            this.cboTypee.Name = "cboTypee";
            this.cboTypee.Size = new System.Drawing.Size(121, 22);
            this.cboTypee.TabIndex = 12;
            this.cboTypee.Text = "ID";
            // 
            // txtSearchh
            // 
            this.txtSearchh.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSearchh.Location = new System.Drawing.Point(338, 155);
            this.txtSearchh.Name = "txtSearchh";
            this.txtSearchh.Size = new System.Drawing.Size(100, 21);
            this.txtSearchh.TabIndex = 13;
            this.txtSearchh.TextChanged += new System.EventHandler(this.txtSearchh_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(80, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 14);
            this.label5.TabIndex = 14;
            this.label5.Text = "Search";
            // 
            // frmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 393);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearchh);
            this.Controls.Add(this.cboTypee);
            this.Controls.Add(this.dgvPosition);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtPosDescription);
            this.Controls.Add(this.txtPosName);
            this.Controls.Add(this.txtIdPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPosition";
            this.Text = "frmPosition";
            this.Load += new System.EventHandler(this.frmPosition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdPosition;
        private System.Windows.Forms.TextBox txtPosName;
        private System.Windows.Forms.TextBox txtPosDescription;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvPosition;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.ComboBox cboTypee;
        private System.Windows.Forms.TextBox txtSearchh;
        private System.Windows.Forms.Label label5;
    }
}