namespace DMC
{
    partial class ManageStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStudents));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addStudent = new System.Windows.Forms.Panel();
            this.AddStudentButton = new System.Windows.Forms.Label();
            this.manageStudent = new System.Windows.Forms.Panel();
            this.ManageButton = new System.Windows.Forms.Label();
            this.DMCGeneration = new System.Windows.Forms.Panel();
            this.DMCButton = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deletePanel = new System.Windows.Forms.Panel();
            this.ManageStudentsButton = new System.Windows.Forms.Button();
            this.viewGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.addStudent.SuspendLayout();
            this.manageStudent.SuspendLayout();
            this.DMCGeneration.SuspendLayout();
            this.Header.SuspendLayout();
            this.deletePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.addStudent);
            this.panel1.Controls.Add(this.manageStudent);
            this.panel1.Controls.Add(this.DMCGeneration);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 784);
            this.panel1.TabIndex = 44;
            // 
            // addStudent
            // 
            this.addStudent.BackColor = System.Drawing.Color.Transparent;
            this.addStudent.Controls.Add(this.AddStudentButton);
            this.addStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addStudent.Location = new System.Drawing.Point(0, 422);
            this.addStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(225, 115);
            this.addStudent.TabIndex = 41;
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.AutoSize = true;
            this.AddStudentButton.BackColor = System.Drawing.Color.Transparent;
            this.AddStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudentButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentButton.ForeColor = System.Drawing.Color.White;
            this.AddStudentButton.Location = new System.Drawing.Point(45, 32);
            this.AddStudentButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(120, 54);
            this.AddStudentButton.TabIndex = 30;
            this.AddStudentButton.Text = "Add\r\nStudents\r\n";
            this.AddStudentButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manageStudent
            // 
            this.manageStudent.BackColor = System.Drawing.Color.Transparent;
            this.manageStudent.Controls.Add(this.ManageButton);
            this.manageStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageStudent.Location = new System.Drawing.Point(0, 315);
            this.manageStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.manageStudent.Name = "manageStudent";
            this.manageStudent.Size = new System.Drawing.Size(225, 109);
            this.manageStudent.TabIndex = 40;
            // 
            // ManageButton
            // 
            this.ManageButton.AutoSize = true;
            this.ManageButton.BackColor = System.Drawing.Color.Transparent;
            this.ManageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageButton.ForeColor = System.Drawing.Color.White;
            this.ManageButton.Location = new System.Drawing.Point(45, 24);
            this.ManageButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManageButton.Name = "ManageButton";
            this.ManageButton.Size = new System.Drawing.Size(120, 54);
            this.ManageButton.TabIndex = 30;
            this.ManageButton.Text = "Manage\r\nStudents";
            this.ManageButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DMCGeneration
            // 
            this.DMCGeneration.BackColor = System.Drawing.Color.Transparent;
            this.DMCGeneration.Controls.Add(this.DMCButton);
            this.DMCGeneration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DMCGeneration.Location = new System.Drawing.Point(0, 205);
            this.DMCGeneration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DMCGeneration.Name = "DMCGeneration";
            this.DMCGeneration.Size = new System.Drawing.Size(225, 115);
            this.DMCGeneration.TabIndex = 39;
            // 
            // DMCButton
            // 
            this.DMCButton.AutoSize = true;
            this.DMCButton.BackColor = System.Drawing.Color.Transparent;
            this.DMCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DMCButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DMCButton.ForeColor = System.Drawing.Color.White;
            this.DMCButton.Location = new System.Drawing.Point(37, 25);
            this.DMCButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DMCButton.Name = "DMCButton";
            this.DMCButton.Size = new System.Drawing.Size(147, 54);
            this.DMCButton.TabIndex = 30;
            this.DMCButton.Text = " DMC \r\nGeneration";
            this.DMCButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(225, 206);
            this.backBtn.TabIndex = 36;
            this.backBtn.UseVisualStyleBackColor = false;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.label2);
            this.Header.Controls.Add(this.label3);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(225, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1276, 206);
            this.Header.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 15.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(515, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 37);
            this.label2.TabIndex = 28;
            this.label2.Text = "Manage Students";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LEMON MILK Bold", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(391, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(483, 46);
            this.label3.TabIndex = 1;
            this.label3.Text = "DMC Generation System";
            // 
            // deletePanel
            // 
            this.deletePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.deletePanel.Controls.Add(this.ManageStudentsButton);
            this.deletePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.deletePanel.Location = new System.Drawing.Point(225, 206);
            this.deletePanel.Name = "deletePanel";
            this.deletePanel.Size = new System.Drawing.Size(1276, 78);
            this.deletePanel.TabIndex = 72;
            // 
            // ManageStudentsButton
            // 
            this.ManageStudentsButton.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.ManageStudentsButton.ForeColor = System.Drawing.Color.Black;
            this.ManageStudentsButton.Location = new System.Drawing.Point(527, 20);
            this.ManageStudentsButton.Name = "ManageStudentsButton";
            this.ManageStudentsButton.Size = new System.Drawing.Size(223, 39);
            this.ManageStudentsButton.TabIndex = 114;
            this.ManageStudentsButton.Text = "Add Student";
            this.ManageStudentsButton.UseVisualStyleBackColor = true;
            this.ManageStudentsButton.Click += new System.EventHandler(this.ManageStudentsButton_Click);
            // 
            // viewGrid
            // 
            this.viewGrid.AllowUserToAddRows = false;
            this.viewGrid.AllowUserToDeleteRows = false;
            this.viewGrid.AllowUserToResizeColumns = false;
            this.viewGrid.AllowUserToResizeRows = false;
            this.viewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewGrid.BackgroundColor = System.Drawing.Color.White;
            this.viewGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.viewGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameCol,
            this.City,
            this.Country});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.viewGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewGrid.EnableHeadersVisualStyles = false;
            this.viewGrid.GridColor = System.Drawing.Color.White;
            this.viewGrid.Location = new System.Drawing.Point(225, 284);
            this.viewGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewGrid.Name = "viewGrid";
            this.viewGrid.ReadOnly = true;
            this.viewGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.viewGrid.RowHeadersVisible = false;
            this.viewGrid.RowHeadersWidth = 62;
            this.viewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewGrid.Size = new System.Drawing.Size(1276, 447);
            this.viewGrid.TabIndex = 73;
            // 
            // ID
            // 
            this.ID.HeaderText = "Reg Number";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NameCol
            // 
            this.NameCol.HeaderText = "Name";
            this.NameCol.MinimumWidth = 8;
            this.NameCol.Name = "NameCol";
            this.NameCol.ReadOnly = true;
            // 
            // City
            // 
            this.City.HeaderText = "Degree";
            this.City.MinimumWidth = 8;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.HeaderText = "Courses";
            this.Country.MinimumWidth = 8;
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // ManageStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 784);
            this.Controls.Add(this.viewGrid);
            this.Controls.Add(this.deletePanel);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.panel1);
            this.Name = "ManageStudents";
            this.Text = "ManageStudents";
            this.panel1.ResumeLayout(false);
            this.addStudent.ResumeLayout(false);
            this.addStudent.PerformLayout();
            this.manageStudent.ResumeLayout(false);
            this.manageStudent.PerformLayout();
            this.DMCGeneration.ResumeLayout(false);
            this.DMCGeneration.PerformLayout();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.deletePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel addStudent;
        private System.Windows.Forms.Label AddStudentButton;
        private System.Windows.Forms.Panel manageStudent;
        private System.Windows.Forms.Label ManageButton;
        private System.Windows.Forms.Panel DMCGeneration;
        private System.Windows.Forms.Label DMCButton;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel deletePanel;
        private System.Windows.Forms.Button ManageStudentsButton;
        private System.Windows.Forms.DataGridView viewGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
    }
}