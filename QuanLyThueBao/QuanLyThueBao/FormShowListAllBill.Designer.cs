namespace QuanLyThueBao
{
    partial class FormShowListAllBill
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
            this.reportAllBill = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportAllBill
            // 
            this.reportAllBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.reportAllBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportAllBill.Location = new System.Drawing.Point(0, 0);
            this.reportAllBill.Name = "reportAllBill";
            this.reportAllBill.Size = new System.Drawing.Size(1227, 583);
            this.reportAllBill.TabIndex = 0;
            // 
            // FormShowListAllBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1227, 583);
            this.Controls.Add(this.reportAllBill);
            this.Name = "FormShowListAllBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DS Tất Cả Hóa Đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormShowListAllBill_FormClosing);
            this.Load += new System.EventHandler(this.FormShowListAllBill_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportAllBill;
    }
}