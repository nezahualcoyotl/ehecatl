namespace Ehecatl
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblExcel = new System.Windows.Forms.Label();
            this.txtExcelLocation = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnInsertStock = new System.Windows.Forms.Button();
            this.txtResponseMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblExcel
            // 
            this.lblExcel.AutoSize = true;
            this.lblExcel.Location = new System.Drawing.Point(11, 15);
            this.lblExcel.Name = "lblExcel";
            this.lblExcel.Size = new System.Drawing.Size(36, 13);
            this.lblExcel.TabIndex = 0;
            this.lblExcel.Text = "Excel:";
            // 
            // txtExcelLocation
            // 
            this.txtExcelLocation.Location = new System.Drawing.Point(53, 12);
            this.txtExcelLocation.Name = "txtExcelLocation";
            this.txtExcelLocation.ReadOnly = true;
            this.txtExcelLocation.Size = new System.Drawing.Size(376, 20);
            this.txtExcelLocation.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(435, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnInsertStock
            // 
            this.btnInsertStock.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInsertStock.Location = new System.Drawing.Point(14, 38);
            this.btnInsertStock.Name = "btnInsertStock";
            this.btnInsertStock.Size = new System.Drawing.Size(89, 30);
            this.btnInsertStock.TabIndex = 3;
            this.btnInsertStock.Text = "Insert Stock";
            this.btnInsertStock.UseVisualStyleBackColor = true;
            this.btnInsertStock.Click += new System.EventHandler(this.btnInsertStock_Click);
            // 
            // txtResponseMessage
            // 
            this.txtResponseMessage.Location = new System.Drawing.Point(14, 74);
            this.txtResponseMessage.Multiline = true;
            this.txtResponseMessage.Name = "txtResponseMessage";
            this.txtResponseMessage.ReadOnly = true;
            this.txtResponseMessage.Size = new System.Drawing.Size(496, 129);
            this.txtResponseMessage.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 218);
            this.Controls.Add(this.txtResponseMessage);
            this.Controls.Add(this.btnInsertStock);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtExcelLocation);
            this.Controls.Add(this.lblExcel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ehecatl 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExcel;
        private System.Windows.Forms.TextBox txtExcelLocation;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnInsertStock;
        private System.Windows.Forms.TextBox txtResponseMessage;
    }
}

