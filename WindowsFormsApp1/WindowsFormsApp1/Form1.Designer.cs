namespace WindowsFormsApp1
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
            this.lblName = new System.Windows.Forms.Label();
            this.unitprice = new System.Windows.Forms.Label();
            this.lblstockAmount = new System.Windows.Forms.Label();
            this.gbx = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.tbxUnitprice = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // unitprice
            // 
            this.unitprice.AutoSize = true;
            this.unitprice.Location = new System.Drawing.Point(21, 107);
            this.unitprice.Name = "unitprice";
            this.unitprice.Size = new System.Drawing.Size(52, 13);
            this.unitprice.TabIndex = 1;
            this.unitprice.Text = "Unit price";
            // 
            // lblstockAmount
            // 
            this.lblstockAmount.AutoSize = true;
            this.lblstockAmount.Location = new System.Drawing.Point(6, 143);
            this.lblstockAmount.Name = "lblstockAmount";
            this.lblstockAmount.Size = new System.Drawing.Size(73, 13);
            this.lblstockAmount.TabIndex = 2;
            this.lblstockAmount.Text = "Stock Amount";
            this.lblstockAmount.Click += new System.EventHandler(this.label3_Click);
            // 
            // gbx
            // 
            this.gbx.Controls.Add(this.btnAdd);
            this.gbx.Controls.Add(this.tbxStockAmount);
            this.gbx.Controls.Add(this.lblName);
            this.gbx.Controls.Add(this.unitprice);
            this.gbx.Controls.Add(this.lblstockAmount);
            this.gbx.Controls.Add(this.tbxUnitprice);
            this.gbx.Controls.Add(this.tbxName);
            this.gbx.Location = new System.Drawing.Point(12, 35);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(492, 229);
            this.gbx.TabIndex = 3;
            this.gbx.TabStop = false;
            this.gbx.Text = "Add a product";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(112, 186);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(103, 140);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(101, 21);
            this.tbxStockAmount.TabIndex = 2;
            // 
            // tbxUnitprice
            // 
            this.tbxUnitprice.Location = new System.Drawing.Point(103, 104);
            this.tbxUnitprice.Name = "tbxUnitprice";
            this.tbxUnitprice.Size = new System.Drawing.Size(101, 21);
            this.tbxUnitprice.TabIndex = 1;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(103, 67);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(101, 21);
            this.tbxName.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbx);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label unitprice;
        private System.Windows.Forms.Label lblstockAmount;
        private System.Windows.Forms.GroupBox gbx;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.TextBox tbxUnitprice;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnAdd;
    }
}

