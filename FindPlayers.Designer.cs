namespace KKU_eSport_Simple
{
    partial class FindPlayers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridGameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridName,
            this.GridLastname,
            this.GridStudentID,
            this.GridMajor,
            this.GridGameName,
            this.GridEmail,
            this.GridPhone,
            this.GridAge});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(844, 350);
            this.dataGridView1.TabIndex = 1;
            // 
            // GridName
            // 
            this.GridName.HeaderText = "ชื่อ";
            this.GridName.Name = "GridName";
            this.GridName.ReadOnly = true;
            // 
            // GridLastname
            // 
            this.GridLastname.HeaderText = "นามสกุล";
            this.GridLastname.Name = "GridLastname";
            this.GridLastname.ReadOnly = true;
            // 
            // GridStudentID
            // 
            this.GridStudentID.HeaderText = "รหัสนักศึกษา";
            this.GridStudentID.Name = "GridStudentID";
            this.GridStudentID.ReadOnly = true;
            // 
            // GridMajor
            // 
            this.GridMajor.HeaderText = "สาขา";
            this.GridMajor.Name = "GridMajor";
            this.GridMajor.ReadOnly = true;
            // 
            // GridGameName
            // 
            this.GridGameName.HeaderText = "ชื่อในเกม";
            this.GridGameName.Name = "GridGameName";
            this.GridGameName.ReadOnly = true;
            // 
            // GridEmail
            // 
            this.GridEmail.HeaderText = "อีเมล";
            this.GridEmail.Name = "GridEmail";
            this.GridEmail.ReadOnly = true;
            // 
            // GridPhone
            // 
            this.GridPhone.HeaderText = "เบอร์โทรศัพท์";
            this.GridPhone.Name = "GridPhone";
            this.GridPhone.ReadOnly = true;
            // 
            // GridAge
            // 
            this.GridAge.HeaderText = "อายุ";
            this.GridAge.Name = "GridAge";
            this.GridAge.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FindPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FindPlayers";
            this.Text = "FindPlayers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn GridName;
        private DataGridViewTextBoxColumn GridLastname;
        private DataGridViewTextBoxColumn GridStudentID;
        private DataGridViewTextBoxColumn GridMajor;
        private DataGridViewTextBoxColumn GridGameName;
        private DataGridViewTextBoxColumn GridEmail;
        private DataGridViewTextBoxColumn GridPhone;
        private DataGridViewTextBoxColumn GridAge;
        private Button button1;
    }
}