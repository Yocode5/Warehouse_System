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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAccName = new System.Windows.Forms.TextBox();
            this.buttonAddAcc = new System.Windows.Forms.Button();
            this.buttonDelAcc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView1.Location = new System.Drawing.Point(29, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(341, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Accessories";
            // 
            // textBoxAccName
            // 
            this.textBoxAccName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAccName.Location = new System.Drawing.Point(181, 96);
            this.textBoxAccName.Name = "textBoxAccName";
            this.textBoxAccName.Size = new System.Drawing.Size(224, 28);
            this.textBoxAccName.TabIndex = 2;
            // 
            // buttonAddAcc
            // 
            this.buttonAddAcc.BackColor = System.Drawing.Color.Teal;
            this.buttonAddAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAcc.ForeColor = System.Drawing.Color.White;
            this.buttonAddAcc.Location = new System.Drawing.Point(109, 200);
            this.buttonAddAcc.Name = "buttonAddAcc";
            this.buttonAddAcc.Size = new System.Drawing.Size(225, 69);
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
            this.buttonDelAcc.Location = new System.Drawing.Point(53, 15);
            this.buttonDelAcc.Name = "buttonDelAcc";
            this.buttonDelAcc.Size = new System.Drawing.Size(211, 66);
            this.buttonDelAcc.TabIndex = 4;
            this.buttonDelAcc.Text = "Delete accessories";
            this.buttonDelAcc.UseVisualStyleBackColor = false;
            this.buttonDelAcc.Click += new System.EventHandler(this.buttonDelAcc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(552, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adding Accessories";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAddAcc);
            this.panel1.Controls.Add(this.textBoxAccName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 370);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(487, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 403);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonDelAcc);
            this.panel3.Location = new System.Drawing.Point(903, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 98);
            this.panel3.TabIndex = 8;
            // 
            // AccessoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1268, 730);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "AccessoryForm";
            this.Text = "Accessories";
            this.Load += new System.EventHandler(this.AccessoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel3;
    }
}