namespace BacodeSystem.FRMS
{
    partial class Frm_Control
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.lbl_CarNo = new Guna.UI.WinForms.GunaLabel();
            this.btnexitapplication = new Guna.UI.WinForms.GunaImageButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.pnl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnl2
            // 
            this.pnl2.AutoScroll = true;
            this.pnl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl2.Location = new System.Drawing.Point(643, 34);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(154, 413);
            this.pnl2.TabIndex = 7;
            // 
            // pnl
            // 
            this.pnl.AutoScroll = true;
            this.pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(3, 34);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(634, 413);
            this.pnl.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gunaImageButton1);
            this.panel1.Controls.Add(this.lbl_CarNo);
            this.panel1.Controls.Add(this.btnexitapplication);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 25);
            this.panel1.TabIndex = 6;
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaImageButton1.Image = global::BacodeSystem.Properties.Resources.Synchronize_48px;
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaImageButton1.Location = new System.Drawing.Point(27, 0);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(38, 25);
            this.gunaImageButton1.TabIndex = 7;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // lbl_CarNo
            // 
            this.lbl_CarNo.AutoSize = true;
            this.lbl_CarNo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_CarNo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_CarNo.Font = new System.Drawing.Font("JF Flat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CarNo.ForeColor = System.Drawing.Color.White;
            this.lbl_CarNo.Location = new System.Drawing.Point(416, 0);
            this.lbl_CarNo.Name = "lbl_CarNo";
            this.lbl_CarNo.Size = new System.Drawing.Size(218, 28);
            this.lbl_CarNo.TabIndex = 6;
            this.lbl_CarNo.Text = "                   لوحة المراقبة ";
            this.lbl_CarNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnexitapplication
            // 
            this.btnexitapplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnexitapplication.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnexitapplication.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnexitapplication.Image = global::BacodeSystem.Properties.Resources.Delete_32px;
            this.btnexitapplication.ImageSize = new System.Drawing.Size(32, 32);
            this.btnexitapplication.Location = new System.Drawing.Point(0, 0);
            this.btnexitapplication.Name = "btnexitapplication";
            this.btnexitapplication.OnHoverImage = null;
            this.btnexitapplication.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnexitapplication.Size = new System.Drawing.Size(27, 25);
            this.btnexitapplication.TabIndex = 5;
            this.btnexitapplication.Click += new System.EventHandler(this.btnexitapplication_Click_1);
            // 
            // Frm_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Control";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Frm_Control";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Control_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaImageButton btnexitapplication;
        private Guna.UI.WinForms.GunaLabel lbl_CarNo;
        private System.Windows.Forms.Panel pnl2;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
    }
}