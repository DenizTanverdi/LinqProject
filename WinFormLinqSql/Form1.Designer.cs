namespace WinFormLinqSql
{
    partial class Form1
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
            this.CustomerGird = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OrderGrid = new System.Windows.Forms.DataGridView();
            this.OrderDGrid = new System.Windows.Forms.DataGridView();
            this.SALES = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGird)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SALES)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerGird
            // 
            this.CustomerGird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGird.Location = new System.Drawing.Point(12, 12);
            this.CustomerGird.Name = "CustomerGird";
            this.CustomerGird.Size = new System.Drawing.Size(262, 413);
            this.CustomerGird.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OrderDGrid);
            this.groupBox1.Controls.Add(this.OrderGrid);
            this.groupBox1.Location = new System.Drawing.Point(274, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 400);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Siparişler";
            // 
            // OrderGrid
            // 
            this.OrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGrid.Location = new System.Drawing.Point(6, 19);
            this.OrderGrid.Name = "OrderGrid";
            this.OrderGrid.Size = new System.Drawing.Size(375, 150);
            this.OrderGrid.TabIndex = 0;
            // 
            // OrderDGrid
            // 
            this.OrderDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDGrid.Location = new System.Drawing.Point(6, 206);
            this.OrderDGrid.Name = "OrderDGrid";
            this.OrderDGrid.Size = new System.Drawing.Size(375, 188);
            this.OrderDGrid.TabIndex = 1;
            // 
            // SALES
            // 
            this.SALES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SALES.Location = new System.Drawing.Point(661, 6);
            this.SALES.Name = "SALES";
            this.SALES.Size = new System.Drawing.Size(270, 413);
            this.SALES.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.SALES);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CustomerGird);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGird)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SALES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerGird;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView OrderDGrid;
        private System.Windows.Forms.DataGridView OrderGrid;
        private System.Windows.Forms.DataGridView SALES;
    }
}

