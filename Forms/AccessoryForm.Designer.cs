namespace Warehouse_System
{
    partial class AccessoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccessoryForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAccName = new System.Windows.Forms.TextBox();
            this.buttonAddAcc = new System.Windows.Forms.Button();
            this.buttonDelAcc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BackToDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView1.Location = new System.Drawing.Point(29, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(341, 668);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Accessory Name";
            // 
            // textBoxAccName
            // 
            this.textBoxAccName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAccName.Location = new System.Drawing.Point(291, 192);
            this.textBoxAccName.Name = "textBoxAccName";
            this.textBoxAccName.Size = new System.Drawing.Size(224, 28);
            this.textBoxAccName.TabIndex = 2;
            // 
            // buttonAddAcc
            // 
            this.buttonAddAcc.BackColor = System.Drawing.Color.Teal;
            this.buttonAddAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAcc.ForeColor = System.Drawing.Color.White;
            this.buttonAddAcc.Location = new System.Drawing.Point(111, 296);
            this.buttonAddAcc.Name = "buttonAddAcc";
            this.buttonAddAcc.Size = new System.Drawing.Size(394, 69);
            this.buttonAddAcc.TabIndex = 3;
            this.buttonAddAcc.Text = "Add accessories";
            this.buttonAddAcc.UseVisualStyleBackColor = false;
            this.buttonAddAcc.Click += new System.EventHandler(this.buttonAddAcc_Click);
            // 
            // buttonDelAcc
            // 
            this.buttonDelAcc.BackColor = System.Drawing.Color.Teal;
            this.buttonDelAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelAcc.ForeColor = System.Drawing.Color.White;
            this.buttonDelAcc.Location = new System.Drawing.Point(111, 446);
            this.buttonDelAcc.Name = "buttonDelAcc";
            this.buttonDelAcc.Size = new System.Drawing.Size(394, 66);
            this.buttonDelAcc.TabIndex = 4;
            this.buttonDelAcc.Text = "Delete accessories";
            this.buttonDelAcc.UseVisualStyleBackColor = false;
            this.buttonDelAcc.Click += new System.EventHandler(this.buttonDelAcc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(702, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Accessories";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonDelAcc);
            this.panel1.Controls.Add(this.buttonAddAcc);
            this.panel1.Controls.Add(this.textBoxAccName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(192, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 694);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(941, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 694);
            this.panel2.TabIndex = 7;
            // 
            // BackToDashboard
            // 
            this.BackToDashboard.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackToDashboard.ForeColor = System.Drawing.Color.White;
            this.BackToDashboard.Location = new System.Drawing.Point(26, 25);
            this.BackToDashboard.Name = "BackToDashboard";
            this.BackToDashboard.Size = new System.Drawing.Size(175, 48);
            this.BackToDashboard.TabIndex = 26;
            this.BackToDashboard.Text = "Back To Dashboard";
            this.BackToDashboard.UseVisualStyleBackColor = false;
            this.BackToDashboard.Click += new System.EventHandler(this.BackToDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(26, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1488, 743);
            this.panel3.TabIndex = 27;
            // 
            // AccessoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1542, 856);
            this.Controls.Add(this.BackToDashboard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccessoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accessory Managment - Stock Infinite Warehouse";
            this.Load += new System.EventHandler(this.AccessoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAccName;
        private System.Windows.Forms.Button buttonAddAcc;
        private System.Windows.Forms.Button buttonDelAcc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BackToDashboard;
        private System.Windows.Forms.Panel panel3;
    }
}