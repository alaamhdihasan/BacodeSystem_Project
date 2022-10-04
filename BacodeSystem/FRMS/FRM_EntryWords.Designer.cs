namespace BacodeSystem.FRMS
{
    partial class FRM_EntryWords
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
            this.btnexitapplication = new Guna.UI.WinForms.GunaImageButton();
            this.pnl = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnexitapplication, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnexitapplication
            // 
            this.btnexitapplication.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnexitapplication.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnexitapplication.Image = global::BacodeSystem.Properties.Resources.Delete_32px;
            this.btnexitapplication.ImageSize = new System.Drawing.Size(32, 32);
            this.btnexitapplication.Location = new System.Drawing.Point(3, 3);
            this.btnexitapplication.Name = "btnexitapplication";
            this.btnexitapplication.OnHoverImage = null;
            this.btnexitapplication.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnexitapplication.Size = new System.Drawing.Size(30, 25);
            this.btnexitapplication.TabIndex = 5;
            this.btnexitapplication.Click += new System.EventHandler(this.btnexitapplication_Click);
            // 
            // pnl
            // 
            this.pnl.AutoScroll = true;
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.Location = new System.Drawing.Point(3, 34);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(794, 413);
            this.pnl.TabIndex = 6;
            // 
            // FRM_EntryWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_EntryWords";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FRM_EntryWords";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_EntryWords_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaImageButton btnexitapplication;
        private System.Windows.Forms.Panel pnl;
    }
}