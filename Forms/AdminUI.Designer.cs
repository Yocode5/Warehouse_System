namespace Warehouse_System
{
    partial class AdminUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUI));
            this.BackToLogin = new System.Windows.Forms.Button();
            this.ManageEmployee = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ManageSuppliers = new System.Windows.Forms.Button();
            this.ManageBranches = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BackToLogin
            // 
            this.BackToLogin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackToLogin.ForeColor = System.Drawing.Color.White;
            this.BackToLogin.Location = new System.Drawing.Point(40, 10);
            this.BackToLogin.Name = "BackToLogin";
            this.BackToLogin.Size = new System.Drawing.Size(175, 48);
            this.BackToLogin.TabIndex = 0;
            this.BackToLogin.Text = "Back To Login";
            this.BackToLogin.UseVisualStyleBackColor = false;
            this.BackToLogin.Click += new System.EventHandler(this.BackToLogin_Click);
            // 
            // ManageEmployee
            // 
            this.ManageEmployee.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ManageEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageEmployee.ForeColor = System.Drawing.Color.White;
            this.ManageEmployee.Location = new System.Drawing.Point(34, 92);
            this.ManageEmployee.Name = "ManageEmployee";
            this.ManageEmployee.Size = new System.Drawing.Size(254, 83);
            this.ManageEmployee.TabIndex = 1;
            this.ManageEmployee.Text = "Add/Remove Employees";
            this.ManageEmployee.UseVisualStyleBackColor = false;
            this.ManageEmployee.Click += new System.EventHandler(this.ManageEmployee_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ManageSuppliers);
            this.panel1.Controls.Add(this.ManageBranches);
            this.panel1.Controls.Add(this.ManageEmployee);
            this.panel1.Location = new System.Drawing.Point(40, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 703);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ManageSuppliers
            // 
            this.ManageSuppliers.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ManageSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageSuppliers.ForeColor = System.Drawing.Color.White;
            this.ManageSuppliers.Location = new System.Drawing.Point(34, 508);
            this.ManageSuppliers.Name = "ManageSuppliers";
            this.ManageSuppliers.Size = new System.Drawing.Size(254, 83);
            this.ManageSuppliers.TabIndex = 3;
            this.ManageSuppliers.Text = "Add/Remove Suppliers";
            this.ManageSuppliers.UseVisualStyleBackColor = false;
            this.ManageSuppliers.Click += new System.EventHandler(this.ManageSuppliers_Click);
            // 
            // ManageBranches
            // 
            this.ManageBranches.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ManageBranches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageBranches.ForeColor = System.Drawing.Color.White;
            this.ManageBranches.Location = new System.Drawing.Point(34, 300);
            this.ManageBranches.Name = "ManageBranches";
            this.ManageBranches.Size = new System.Drawing.Size(254, 83);
            this.ManageBranches.TabIndex = 2;
            this.ManageBranches.Text = "Add/Remove Branches";
            this.ManageBranches.UseVisualStyleBackColor = false;
            this.ManageBranches.Click += new System.EventHandler(this.ManageBranches_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(773, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 703);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrator\'s Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Warehouse_System.Properties.Resources.pngtree_recruitment_job_for_social_media_admin_png_image_6478542;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(84, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 498);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Warehouse_System.Properties.Resources.Stock_Infinite___Logo_Main_2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1327, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 36);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1377, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Stock Infinite";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1395, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Warehouse";
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1542, 856);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackToLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard - Stock Infinite Warehouse";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToLogin;
        private System.Windows.Forms.Button ManageEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ManageSuppliers;
        private System.Windows.Forms.Button ManageBranches;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}