namespace BacodeSystem.CNT
{
    partial class CarState
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_CarState = new Guna.UI.WinForms.GunaLabel();
            this.lbl_CarNo = new Guna.UI.WinForms.GunaLabel();
            this.Car_Image = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Car_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkGreen;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_CarState, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_CarNo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Car_Image, 0, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.11494F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.94253F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.94253F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(115, 153);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_CarState
            // 
            this.lbl_CarState.AutoSize = true;
            this.lbl_CarState.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_CarState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_CarState.Font = new System.Drawing.Font("JF Flat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CarState.ForeColor = System.Drawing.Color.White;
            this.lbl_CarState.Location = new System.Drawing.Point(3, 129);
            this.lbl_CarState.Name = "lbl_CarState";
            this.lbl_CarState.Size = new System.Drawing.Size(109, 24);
            this.lbl_CarState.TabIndex = 7;
            this.lbl_CarState.Text = "خروج";
            this.lbl_CarState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_CarState.Click += new System.EventHandler(this.lbl_CarState_Click);
            // 
            // lbl_CarNo
            // 
            this.lbl_CarNo.AutoSize = true;
            this.lbl_CarNo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_CarNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_CarNo.Font = new System.Drawing.Font("JF Flat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CarNo.ForeColor = System.Drawing.Color.White;
            this.lbl_CarNo.Location = new System.Drawing.Point(3, 107);
            this.lbl_CarNo.Name = "lbl_CarNo";
            this.lbl_CarNo.Size = new System.Drawing.Size(109, 22);
            this.lbl_CarNo.TabIndex = 5;
            this.lbl_CarNo.Text = "خروج";
            this.lbl_CarNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_CarNo.Click += new System.EventHandler(this.lbl_CarNo_Click);
            // 
            // Car_Image
            // 
            this.Car_Image.BackColor = System.Drawing.Color.Transparent;
            this.Car_Image.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Car_Image.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Car_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Car_Image.Location = new System.Drawing.Point(3, 3);
            this.Car_Image.Name = "Car_Image";
            this.Car_Image.Radius = 6;
            this.Car_Image.Size = new System.Drawing.Size(109, 101);
            this.Car_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car_Image.TabIndex = 4;
            this.Car_Image.TabStop = false;
            this.Car_Image.Click += new System.EventHandler(this.Car_Image_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // CarState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "CarState";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(115, 153);
            this.Load += new System.EventHandler(this.CarState_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Car_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaPictureBox Car_Image;
        private Guna.UI.WinForms.GunaLabel lbl_CarState;
        private Guna.UI.WinForms.GunaLabel lbl_CarNo;
        public Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}
