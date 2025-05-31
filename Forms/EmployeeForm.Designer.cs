namespace Warehouse_System.Forms
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonEUpdateSelected = new System.Windows.Forms.Button();
            this.panelEUpdate = new System.Windows.Forms.Panel();
            this.textBoxUEId = new System.Windows.Forms.TextBox();
            this.comboBoxUEPosition = new System.Windows.Forms.ComboBox();
            this.textBoxUEPw = new System.Windows.Forms.TextBox();
            this.textBoxUEUsername = new System.Windows.Forms.TextBox();
            this.labelUELName = new System.Windows.Forms.Label();
            this.labelUEPw = new System.Windows.Forms.Label();
            this.textBoxUEEmail = new System.Windows.Forms.TextBox();
            this.textBoxUELName = new System.Windows.Forms.TextBox();
            this.textBoxUEFName = new System.Windows.Forms.TextBox();
            this.labelUEUsername = new System.Windows.Forms.Label();
            this.labelUEEmail = new System.Windows.Forms.Label();
            this.labelUEPosition = new System.Windows.Forms.Label();
            this.labelUEFName = new System.Windows.Forms.Label();
            this.buttonEUpdate = new System.Windows.Forms.Button();
            this.buttonEDelete = new System.Windows.Forms.Button();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.panelEInsert = new System.Windows.Forms.Panel();
            this.comboBoxEPosition = new System.Windows.Forms.ComboBox();
            this.textBoxEPw = new System.Windows.Forms.TextBox();
            this.textBoxEUsername = new System.Windows.Forms.TextBox();
            this.labelELName = new System.Windows.Forms.Label();
            this.labelEPw = new System.Windows.Forms.Label();
            this.buttonEInsert = new System.Windows.Forms.Button();
            this.textBoxEEmail = new System.Windows.Forms.TextBox();
            this.textBoxELName = new System.Windows.Forms.TextBox();
            this.textBoxEFName = new System.Windows.Forms.TextBox();
            this.textBoxEId = new System.Windows.Forms.TextBox();
            this.labelEUsername = new System.Windows.Forms.Label();
            this.labelEEmail = new System.Windows.Forms.Label();
            this.labelEPosition = new System.Windows.Forms.Label();
            this.labelEFName = new System.Windows.Forms.Label();
            this.labelEId = new System.Windows.Forms.Label();
            this.BackToDashboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelEUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.panelEInsert.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(659, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(292, 36);
            this.labelTitle.TabIndex = 21;
            this.labelTitle.Text = "Manage Employees";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonEUpdateSelected
            // 
            this.buttonEUpdateSelected.BackColor = System.Drawing.Color.Teal;
            this.buttonEUpdateSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEUpdateSelected.ForeColor = System.Drawing.Color.White;
            this.buttonEUpdateSelected.Location = new System.Drawing.Point(779, 465);
            this.buttonEUpdateSelected.Name = "buttonEUpdateSelected";
            this.buttonEUpdateSelected.Size = new System.Drawing.Size(284, 43);
            this.buttonEUpdateSelected.TabIndex = 24;
            this.buttonEUpdateSelected.Text = "Update Selected Supplier";
            this.buttonEUpdateSelected.UseVisualStyleBackColor = false;
            this.buttonEUpdateSelected.Click += new System.EventHandler(this.buttonEUpdateSelected_Click);
            // 
            // panelEUpdate
            // 
            this.panelEUpdate.BackColor = System.Drawing.Color.LightBlue;
            this.panelEUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEUpdate.Controls.Add(this.textBoxUEId);
            this.panelEUpdate.Controls.Add(this.comboBoxUEPosition);
            this.panelEUpdate.Controls.Add(this.textBoxUEPw);
            this.panelEUpdate.Controls.Add(this.textBoxUEUsername);
            this.panelEUpdate.Controls.Add(this.labelUELName);
            this.panelEUpdate.Controls.Add(this.labelUEPw);
            this.panelEUpdate.Controls.Add(this.textBoxUEEmail);
            this.panelEUpdate.Controls.Add(this.textBoxUELName);
            this.panelEUpdate.Controls.Add(this.textBoxUEFName);
            this.panelEUpdate.Controls.Add(this.labelUEUsername);
            this.panelEUpdate.Controls.Add(this.labelUEEmail);
            this.panelEUpdate.Controls.Add(this.labelUEPosition);
            this.panelEUpdate.Controls.Add(this.labelUEFName);
            this.panelEUpdate.Controls.Add(this.buttonEUpdate);
            this.panelEUpdate.Location = new System.Drawing.Point(72, 491);
            this.panelEUpdate.Name = "panelEUpdate";
            this.panelEUpdate.Size = new System.Drawing.Size(570, 326);
            this.panelEUpdate.TabIndex = 22;
            // 
            // textBoxUEId
            // 
            this.textBoxUEId.Location = new System.Drawing.Point(247, 3);
            this.textBoxUEId.Name = "textBoxUEId";
            this.textBoxUEId.Size = new System.Drawing.Size(150, 22);
            this.textBoxUEId.TabIndex = 16;
            this.textBoxUEId.Visible = false;
            // 
            // comboBoxUEPosition
            // 
            this.comboBoxUEPosition.FormattingEnabled = true;
            this.comboBoxUEPosition.Location = new System.Drawing.Point(247, 108);
            this.comboBoxUEPosition.Name = "comboBoxUEPosition";
            this.comboBoxUEPosition.Size = new System.Drawing.Size(237, 24);
            this.comboBoxUEPosition.TabIndex = 16;
            // 
            // textBoxUEPw
            // 
            this.textBoxUEPw.Location = new System.Drawing.Point(247, 212);
            this.textBoxUEPw.Name = "textBoxUEPw";
            this.textBoxUEPw.Size = new System.Drawing.Size(205, 22);
            this.textBoxUEPw.TabIndex = 26;
            // 
            // textBoxUEUsername
            // 
            this.textBoxUEUsername.Location = new System.Drawing.Point(247, 178);
            this.textBoxUEUsername.Name = "textBoxUEUsername";
            this.textBoxUEUsername.Size = new System.Drawing.Size(205, 22);
            this.textBoxUEUsername.TabIndex = 25;
            // 
            // labelUELName
            // 
            this.labelUELName.AutoSize = true;
            this.labelUELName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUELName.Location = new System.Drawing.Point(29, 66);
            this.labelUELName.Name = "labelUELName";
            this.labelUELName.Size = new System.Drawing.Size(122, 25);
            this.labelUELName.TabIndex = 24;
            this.labelUELName.Text = "Last Name:";
            // 
            // labelUEPw
            // 
            this.labelUEPw.AutoSize = true;
            this.labelUEPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUEPw.Location = new System.Drawing.Point(29, 208);
            this.labelUEPw.Name = "labelUEPw";
            this.labelUEPw.Size = new System.Drawing.Size(113, 25);
            this.labelUEPw.TabIndex = 23;
            this.labelUEPw.Text = "Password:";
            // 
            // textBoxUEEmail
            // 
            this.textBoxUEEmail.Location = new System.Drawing.Point(247, 142);
            this.textBoxUEEmail.Name = "textBoxUEEmail";
            this.textBoxUEEmail.Size = new System.Drawing.Size(296, 22);
            this.textBoxUEEmail.TabIndex = 22;
            // 
            // textBoxUELName
            // 
            this.textBoxUELName.Location = new System.Drawing.Point(247, 70);
            this.textBoxUELName.Name = "textBoxUELName";
            this.textBoxUELName.Size = new System.Drawing.Size(205, 22);
            this.textBoxUELName.TabIndex = 20;
            // 
            // textBoxUEFName
            // 
            this.textBoxUEFName.Location = new System.Drawing.Point(247, 31);
            this.textBoxUEFName.Name = "textBoxUEFName";
            this.textBoxUEFName.Size = new System.Drawing.Size(205, 22);
            this.textBoxUEFName.TabIndex = 19;
            // 
            // labelUEUsername
            // 
            this.labelUEUsername.AutoSize = true;
            this.labelUEUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUEUsername.Location = new System.Drawing.Point(29, 174);
            this.labelUEUsername.Name = "labelUEUsername";
            this.labelUEUsername.Size = new System.Drawing.Size(116, 25);
            this.labelUEUsername.TabIndex = 18;
            this.labelUEUsername.Text = "Username.";
            // 
            // labelUEEmail
            // 
            this.labelUEEmail.AutoSize = true;
            this.labelUEEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUEEmail.Location = new System.Drawing.Point(29, 138);
            this.labelUEEmail.Name = "labelUEEmail";
            this.labelUEEmail.Size = new System.Drawing.Size(72, 25);
            this.labelUEEmail.TabIndex = 17;
            this.labelUEEmail.Text = "Email:";
            // 
            // labelUEPosition
            // 
            this.labelUEPosition.AutoSize = true;
            this.labelUEPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUEPosition.Location = new System.Drawing.Point(29, 104);
            this.labelUEPosition.Name = "labelUEPosition";
            this.labelUEPosition.Size = new System.Drawing.Size(96, 25);
            this.labelUEPosition.TabIndex = 16;
            this.labelUEPosition.Text = "Position:";
            // 
            // labelUEFName
            // 
            this.labelUEFName.AutoSize = true;
            this.labelUEFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUEFName.Location = new System.Drawing.Point(29, 31);
            this.labelUEFName.Name = "labelUEFName";
            this.labelUEFName.Size = new System.Drawing.Size(123, 25);
            this.labelUEFName.TabIndex = 15;
            this.labelUEFName.Text = "First Name:";
            // 
            // buttonEUpdate
            // 
            this.buttonEUpdate.BackColor = System.Drawing.Color.Teal;
            this.buttonEUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonEUpdate.Location = new System.Drawing.Point(146, 261);
            this.buttonEUpdate.Name = "buttonEUpdate";
            this.buttonEUpdate.Size = new System.Drawing.Size(251, 43);
            this.buttonEUpdate.TabIndex = 10;
            this.buttonEUpdate.Text = "Update Supplier";
            this.buttonEUpdate.UseVisualStyleBackColor = false;
            this.buttonEUpdate.Click += new System.EventHandler(this.buttonEUpdate_Click);
            // 
            // buttonEDelete
            // 
            this.buttonEDelete.BackColor = System.Drawing.Color.Teal;
            this.buttonEDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEDelete.ForeColor = System.Drawing.Color.White;
            this.buttonEDelete.Location = new System.Drawing.Point(1132, 465);
            this.buttonEDelete.Name = "buttonEDelete";
            this.buttonEDelete.Size = new System.Drawing.Size(266, 43);
            this.buttonEDelete.TabIndex = 23;
            this.buttonEDelete.Text = "Delete Selected Supplier";
            this.buttonEDelete.UseVisualStyleBackColor = false;
            this.buttonEDelete.Click += new System.EventHandler(this.buttonEDelete_Click);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(728, 102);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(742, 337);
            this.dataGridViewEmployee.TabIndex = 20;
            // 
            // panelEInsert
            // 
            this.panelEInsert.BackColor = System.Drawing.Color.LightBlue;
            this.panelEInsert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEInsert.Controls.Add(this.comboBoxEPosition);
            this.panelEInsert.Controls.Add(this.textBoxEPw);
            this.panelEInsert.Controls.Add(this.textBoxEUsername);
            this.panelEInsert.Controls.Add(this.labelELName);
            this.panelEInsert.Controls.Add(this.labelEPw);
            this.panelEInsert.Controls.Add(this.buttonEInsert);
            this.panelEInsert.Controls.Add(this.textBoxEEmail);
            this.panelEInsert.Controls.Add(this.textBoxELName);
            this.panelEInsert.Controls.Add(this.textBoxEFName);
            this.panelEInsert.Controls.Add(this.textBoxEId);
            this.panelEInsert.Controls.Add(this.labelEUsername);
            this.panelEInsert.Controls.Add(this.labelEEmail);
            this.panelEInsert.Controls.Add(this.labelEPosition);
            this.panelEInsert.Controls.Add(this.labelEFName);
            this.panelEInsert.Controls.Add(this.labelEId);
            this.panelEInsert.Location = new System.Drawing.Point(72, 102);
            this.panelEInsert.Name = "panelEInsert";
            this.panelEInsert.Size = new System.Drawing.Size(570, 381);
            this.panelEInsert.TabIndex = 19;
            // 
            // comboBoxEPosition
            // 
            this.comboBoxEPosition.FormattingEnabled = true;
            this.comboBoxEPosition.Location = new System.Drawing.Point(247, 135);
            this.comboBoxEPosition.Name = "comboBoxEPosition";
            this.comboBoxEPosition.Size = new System.Drawing.Size(237, 24);
            this.comboBoxEPosition.TabIndex = 15;
            // 
            // textBoxEPw
            // 
            this.textBoxEPw.Location = new System.Drawing.Point(247, 242);
            this.textBoxEPw.Name = "textBoxEPw";
            this.textBoxEPw.Size = new System.Drawing.Size(205, 22);
            this.textBoxEPw.TabIndex = 14;
            // 
            // textBoxEUsername
            // 
            this.textBoxEUsername.Location = new System.Drawing.Point(247, 208);
            this.textBoxEUsername.Name = "textBoxEUsername";
            this.textBoxEUsername.Size = new System.Drawing.Size(205, 22);
            this.textBoxEUsername.TabIndex = 13;
            // 
            // labelELName
            // 
            this.labelELName.AutoSize = true;
            this.labelELName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelELName.Location = new System.Drawing.Point(29, 96);
            this.labelELName.Name = "labelELName";
            this.labelELName.Size = new System.Drawing.Size(122, 25);
            this.labelELName.TabIndex = 12;
            this.labelELName.Text = "Last Name:";
            // 
            // labelEPw
            // 
            this.labelEPw.AutoSize = true;
            this.labelEPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEPw.Location = new System.Drawing.Point(29, 238);
            this.labelEPw.Name = "labelEPw";
            this.labelEPw.Size = new System.Drawing.Size(113, 25);
            this.labelEPw.TabIndex = 11;
            this.labelEPw.Text = "Password:";
            // 
            // buttonEInsert
            // 
            this.buttonEInsert.BackColor = System.Drawing.Color.Teal;
            this.buttonEInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEInsert.ForeColor = System.Drawing.Color.White;
            this.buttonEInsert.Location = new System.Drawing.Point(146, 294);
            this.buttonEInsert.Name = "buttonEInsert";
            this.buttonEInsert.Size = new System.Drawing.Size(251, 43);
            this.buttonEInsert.TabIndex = 10;
            this.buttonEInsert.Text = "Insert New Employee";
            this.buttonEInsert.UseVisualStyleBackColor = false;
            this.buttonEInsert.Click += new System.EventHandler(this.buttonEInsert_Click);
            // 
            // textBoxEEmail
            // 
            this.textBoxEEmail.Location = new System.Drawing.Point(247, 172);
            this.textBoxEEmail.Name = "textBoxEEmail";
            this.textBoxEEmail.Size = new System.Drawing.Size(296, 22);
            this.textBoxEEmail.TabIndex = 9;
            // 
            // textBoxELName
            // 
            this.textBoxELName.Location = new System.Drawing.Point(247, 100);
            this.textBoxELName.Name = "textBoxELName";
            this.textBoxELName.Size = new System.Drawing.Size(205, 22);
            this.textBoxELName.TabIndex = 7;
            // 
            // textBoxEFName
            // 
            this.textBoxEFName.Location = new System.Drawing.Point(247, 61);
            this.textBoxEFName.Name = "textBoxEFName";
            this.textBoxEFName.Size = new System.Drawing.Size(205, 22);
            this.textBoxEFName.TabIndex = 6;
            // 
            // textBoxEId
            // 
            this.textBoxEId.Location = new System.Drawing.Point(247, 24);
            this.textBoxEId.Name = "textBoxEId";
            this.textBoxEId.Size = new System.Drawing.Size(150, 22);
            this.textBoxEId.TabIndex = 5;
            // 
            // labelEUsername
            // 
            this.labelEUsername.AutoSize = true;
            this.labelEUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEUsername.Location = new System.Drawing.Point(29, 204);
            this.labelEUsername.Name = "labelEUsername";
            this.labelEUsername.Size = new System.Drawing.Size(116, 25);
            this.labelEUsername.TabIndex = 4;
            this.labelEUsername.Text = "Username.";
            // 
            // labelEEmail
            // 
            this.labelEEmail.AutoSize = true;
            this.labelEEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEEmail.Location = new System.Drawing.Point(29, 168);
            this.labelEEmail.Name = "labelEEmail";
            this.labelEEmail.Size = new System.Drawing.Size(72, 25);
            this.labelEEmail.TabIndex = 3;
            this.labelEEmail.Text = "Email:";
            // 
            // labelEPosition
            // 
            this.labelEPosition.AutoSize = true;
            this.labelEPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEPosition.Location = new System.Drawing.Point(29, 134);
            this.labelEPosition.Name = "labelEPosition";
            this.labelEPosition.Size = new System.Drawing.Size(96, 25);
            this.labelEPosition.TabIndex = 2;
            this.labelEPosition.Text = "Position:";
            // 
            // labelEFName
            // 
            this.labelEFName.AutoSize = true;
            this.labelEFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEFName.Location = new System.Drawing.Point(29, 61);
            this.labelEFName.Name = "labelEFName";
            this.labelEFName.Size = new System.Drawing.Size(123, 25);
            this.labelEFName.TabIndex = 1;
            this.labelEFName.Text = "First Name:";
            // 
            // labelEId
            // 
            this.labelEId.AutoSize = true;
            this.labelEId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEId.Location = new System.Drawing.Point(29, 24);
            this.labelEId.Name = "labelEId";
            this.labelEId.Size = new System.Drawing.Size(141, 25);
            this.labelEId.TabIndex = 0;
            this.labelEId.Text = "Employee ID:";
            // 
            // BackToDashboard
            // 
            this.BackToDashboard.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackToDashboard.ForeColor = System.Drawing.Color.White;
            this.BackToDashboard.Location = new System.Drawing.Point(36, 11);
            this.BackToDashboard.Name = "BackToDashboard";
            this.BackToDashboard.Size = new System.Drawing.Size(175, 48);
            this.BackToDashboard.TabIndex = 25;
            this.BackToDashboard.Text = "Back To Dashboard";
            this.BackToDashboard.UseVisualStyleBackColor = false;
            this.BackToDashboard.Click += new System.EventHandler(this.BackToDashboard_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(36, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1477, 764);
            this.panel1.TabIndex = 26;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1542, 856);
            this.Controls.Add(this.BackToDashboard);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonEUpdateSelected);
            this.Controls.Add(this.panelEUpdate);
            this.Controls.Add(this.buttonEDelete);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.panelEInsert);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Managment - Stock Infinite Warehouse";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.panelEUpdate.ResumeLayout(false);
            this.panelEUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.panelEInsert.ResumeLayout(false);
            this.panelEInsert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonEUpdateSelected;
        private System.Windows.Forms.Panel panelEUpdate;
        private System.Windows.Forms.TextBox textBoxUEId;
        private System.Windows.Forms.ComboBox comboBoxUEPosition;
        private System.Windows.Forms.TextBox textBoxUEPw;
        private System.Windows.Forms.TextBox textBoxUEUsername;
        private System.Windows.Forms.Label labelUELName;
        private System.Windows.Forms.Label labelUEPw;
        private System.Windows.Forms.TextBox textBoxUEEmail;
        private System.Windows.Forms.TextBox textBoxUELName;
        private System.Windows.Forms.TextBox textBoxUEFName;
        private System.Windows.Forms.Label labelUEUsername;
        private System.Windows.Forms.Label labelUEEmail;
        private System.Windows.Forms.Label labelUEPosition;
        private System.Windows.Forms.Label labelUEFName;
        private System.Windows.Forms.Button buttonEUpdate;
        private System.Windows.Forms.Button buttonEDelete;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Panel panelEInsert;
        private System.Windows.Forms.ComboBox comboBoxEPosition;
        private System.Windows.Forms.TextBox textBoxEPw;
        private System.Windows.Forms.TextBox textBoxEUsername;
        private System.Windows.Forms.Label labelELName;
        private System.Windows.Forms.Label labelEPw;
        private System.Windows.Forms.Button buttonEInsert;
        private System.Windows.Forms.TextBox textBoxEEmail;
        private System.Windows.Forms.TextBox textBoxELName;
        private System.Windows.Forms.TextBox textBoxEFName;
        private System.Windows.Forms.TextBox textBoxEId;
        private System.Windows.Forms.Label labelEUsername;
        private System.Windows.Forms.Label labelEEmail;
        private System.Windows.Forms.Label labelEPosition;
        private System.Windows.Forms.Label labelEFName;
        private System.Windows.Forms.Label labelEId;
        private System.Windows.Forms.Button BackToDashboard;
        private System.Windows.Forms.Panel panel1;
    }
}