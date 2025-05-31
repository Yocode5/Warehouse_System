namespace Warehouse_System
{
    partial class WarehouseManagerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseManagerUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.GenerateReport = new System.Windows.Forms.Button();
            this.DispatchProducts = new System.Windows.Forms.Button();
            this.RestockProducts = new System.Windows.Forms.Button();
            this.ManageProducts = new System.Windows.Forms.Button();
            this.ManageAccessories = new System.Windows.Forms.Button();
            this.BackToLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.GenerateReport);
            this.panel1.Controls.Add(this.DispatchProducts);
            this.panel1.Controls.Add(this.RestockProducts);
            this.panel1.Controls.Add(this.ManageProducts);
            this.panel1.Controls.Add(this.ManageAccessories);
            this.panel1.Location = new System.Drawing.Point(40, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 703);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(296, 612);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // GenerateReport
            // 
            this.GenerateReport.BackColor = System.Drawing.Color.LightSeaGreen;
            this.GenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateReport.ForeColor = System.Drawing.Color.White;
            this.GenerateReport.Location = new System.Drawing.Point(15, 582);
            this.GenerateReport.Name = "GenerateReport";
            this.GenerateReport.Size = new System.Drawing.Size(254, 83);
            this.GenerateReport.TabIndex = 6;
            this.GenerateReport.Text = "Generate Status Report";
            this.GenerateReport.UseVisualStyleBackColor = false;
            this.GenerateReport.Click += new System.EventHandler(this.GenerateReport_Click);
            // 
            // DispatchProducts
            // 
            this.DispatchProducts.BackColor = System.Drawing.Color.LightSeaGreen;
            this.DispatchProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DispatchProducts.ForeColor = System.Drawing.Color.White;
            this.DispatchProducts.Location = new System.Drawing.Point(15, 449);
            this.DispatchProducts.Name = "DispatchProducts";
            this.DispatchProducts.Size = new System.Drawing.Size(254, 83);
            this.DispatchProducts.TabIndex = 5;
            this.DispatchProducts.Text = "Dispatch Products";
            this.DispatchProducts.UseVisualStyleBackColor = false;
            this.DispatchProducts.Click += new System.EventHandler(this.DispatchProducts_Click);
            // 
            // RestockProducts
            // 
            this.RestockProducts.BackColor = System.Drawing.Color.LightSeaGreen;
            this.RestockProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestockProducts.ForeColor = System.Drawing.Color.White;
            this.RestockProducts.Location = new System.Drawing.Point(15, 314);
            this.RestockProducts.Name = "RestockProducts";
            this.RestockProducts.Size = new System.Drawing.Size(254, 83);
            this.RestockProducts.TabIndex = 4;
            this.RestockProducts.Text = "Restock Products";
            this.RestockProducts.UseVisualStyleBackColor = false;
            this.RestockProducts.Click += new System.EventHandler(this.RestockProducts_Click);
            // 
            // ManageProducts
            // 
            this.ManageProducts.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ManageProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageProducts.ForeColor = System.Drawing.Color.White;
            this.ManageProducts.Location = new System.Drawing.Point(15, 175);
            this.ManageProducts.Name = "ManageProducts";
            this.ManageProducts.Size = new System.Drawing.Size(254, 83);
            this.ManageProducts.TabIndex = 3;
            this.ManageProducts.Text = "Add/Remove Products";
            this.ManageProducts.UseVisualStyleBackColor = false;
            this.ManageProducts.Click += new System.EventHandler(this.ManageProducts_Click);
            // 
            // ManageAccessories
            // 
            this.ManageAccessories.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ManageAccessories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageAccessories.ForeColor = System.Drawing.Color.White;
            this.ManageAccessories.Location = new System.Drawing.Point(15, 34);
            this.ManageAccessories.Name = "ManageAccessories";
            this.ManageAccessories.Size = new System.Drawing.Size(254, 83);
            this.ManageAccessories.TabIndex = 2;
            this.ManageAccessories.Text = "Add/Remove Accessories";
            this.ManageAccessories.UseVisualStyleBackColor = false;
            this.ManageAccessories.Click += new System.EventHandler(this.ManageAccessories_Click);
            // 
            // BackToLogin
            // 
            this.BackToLogin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackToLogin.ForeColor = System.Drawing.Color.White;
            this.BackToLogin.Location = new System.Drawing.Point(40, 10);
            this.BackToLogin.Name = "BackToLogin";
            this.BackToLogin.Size = new System.Drawing.Size(175, 48);
            this.BackToLogin.TabIndex = 1;
            this.BackToLogin.Text = "Back To Login";
            this.BackToLogin.UseVisualStyleBackColor = false;
            this.BackToLogin.Click += new System.EventHandler(this.BackToLogin_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(773, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 703);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manager\'s Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Warehouse_System.Properties.Resources.inventory_control_by_online_system_inventory_management_with_goods_demand_professional_worker_is_checking_goods_and_stock_supply_vector1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(17, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(690, 498);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1377, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stock Infinite";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1395, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Warehouse";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Warehouse_System.Properties.Resources.Stock_Infinite___Logo_Main_2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1327, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 36);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // WarehouseManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1542, 856);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BackToLogin);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WarehouseManagerUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse Manager Dashboard - Stock Infnite Warehouse";
            this.Load += new System.EventHandler(this.WarehouseManagerUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackToLogin;
        private System.Windows.Forms.Button DispatchProducts;
        private System.Windows.Forms.Button RestockProducts;
        private System.Windows.Forms.Button ManageProducts;
        private System.Windows.Forms.Button ManageAccessories;
        private System.Windows.Forms.Button GenerateReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}