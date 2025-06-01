namespace Warehouse_System
{
    partial class WarehouseStaffUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseStaffUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonViewProducts = new System.Windows.Forms.Button();
            this.DispatchItems = new System.Windows.Forms.Button();
            this.RestockItems = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackToLogin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.buttonViewProducts);
            this.panel1.Controls.Add(this.DispatchItems);
            this.panel1.Controls.Add(this.RestockItems);
            this.panel1.Location = new System.Drawing.Point(40, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 703);
            this.panel1.TabIndex = 0;
            // 
            // buttonViewProducts
            // 
            this.buttonViewProducts.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonViewProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewProducts.ForeColor = System.Drawing.Color.White;
            this.buttonViewProducts.Location = new System.Drawing.Point(27, 83);
            this.buttonViewProducts.Name = "buttonViewProducts";
            this.buttonViewProducts.Size = new System.Drawing.Size(254, 83);
            this.buttonViewProducts.TabIndex = 4;
            this.buttonViewProducts.Text = "View Product Details";
            this.buttonViewProducts.UseVisualStyleBackColor = false;
            this.buttonViewProducts.Click += new System.EventHandler(this.buttonViewProducts_Click);
            // 
            // DispatchItems
            // 
            this.DispatchItems.BackColor = System.Drawing.Color.LightSeaGreen;
            this.DispatchItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DispatchItems.ForeColor = System.Drawing.Color.White;
            this.DispatchItems.Location = new System.Drawing.Point(27, 522);
            this.DispatchItems.Name = "DispatchItems";
            this.DispatchItems.Size = new System.Drawing.Size(254, 83);
            this.DispatchItems.TabIndex = 3;
            this.DispatchItems.Text = "Dispatch Items";
            this.DispatchItems.UseVisualStyleBackColor = false;
            this.DispatchItems.Click += new System.EventHandler(this.DispatchItems_Click);
            // 
            // RestockItems
            // 
            this.RestockItems.BackColor = System.Drawing.Color.LightSeaGreen;
            this.RestockItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestockItems.ForeColor = System.Drawing.Color.White;
            this.RestockItems.Location = new System.Drawing.Point(27, 298);
            this.RestockItems.Name = "RestockItems";
            this.RestockItems.Size = new System.Drawing.Size(254, 83);
            this.RestockItems.TabIndex = 2;
            this.RestockItems.Text = "Restock Items";
            this.RestockItems.UseVisualStyleBackColor = false;
            this.RestockItems.Click += new System.EventHandler(this.RestockItems_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(773, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 703);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "General Staff Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Warehouse_System.Properties.Resources._82648732_9950462;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(17, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(690, 498);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Warehouse_System.Properties.Resources.Stock_Infinite___Logo_Main_2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1327, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 36);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1377, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stock Infinite";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1395, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Warehouse";
            // 
            // WarehouseStaffUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1542, 856);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BackToLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WarehouseStaffUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse Staff Dashboard - Stock Infnite Warehouse";
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BackToLogin;
        private System.Windows.Forms.Button DispatchItems;
        private System.Windows.Forms.Button RestockItems;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonViewProducts;
    }
}