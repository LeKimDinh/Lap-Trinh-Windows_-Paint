namespace Bài_Tập_1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDuongThang = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnKhungHCN = new System.Windows.Forms.Button();
            this.btnHCN = new System.Windows.Forms.Button();
            this.btnKhungEllipse = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.btnDuongThang);
            this.flowLayoutPanel1.Controls.Add(this.btnKhungHCN);
            this.flowLayoutPanel1.Controls.Add(this.btnHCN);
            this.flowLayoutPanel1.Controls.Add(this.btnKhungEllipse);
            this.flowLayoutPanel1.Controls.Add(this.btnEllipse);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(158, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnDuongThang
            // 
            this.btnDuongThang.Location = new System.Drawing.Point(3, 3);
            this.btnDuongThang.Name = "btnDuongThang";
            this.btnDuongThang.Size = new System.Drawing.Size(149, 49);
            this.btnDuongThang.TabIndex = 15;
            this.btnDuongThang.Text = "Đường Thẳng";
            this.btnDuongThang.UseVisualStyleBackColor = true;
            this.btnDuongThang.Click += new System.EventHandler(this.btnDuongThang_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(158, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(642, 450);
            this.pnlMain.TabIndex = 1;
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseDown);
            // 
            // btnKhungHCN
            // 
            this.btnKhungHCN.Location = new System.Drawing.Point(3, 58);
            this.btnKhungHCN.Name = "btnKhungHCN";
            this.btnKhungHCN.Size = new System.Drawing.Size(149, 49);
            this.btnKhungHCN.TabIndex = 16;
            this.btnKhungHCN.Text = "Khung Hình Chũ Nhật";
            this.btnKhungHCN.UseVisualStyleBackColor = true;
            this.btnKhungHCN.Click += new System.EventHandler(this.btnKhungHCN_Click);
            // 
            // btnHCN
            // 
            this.btnHCN.Location = new System.Drawing.Point(3, 113);
            this.btnHCN.Name = "btnHCN";
            this.btnHCN.Size = new System.Drawing.Size(149, 49);
            this.btnHCN.TabIndex = 17;
            this.btnHCN.Text = "Hình Chữ Nhật";
            this.btnHCN.UseVisualStyleBackColor = true;
            this.btnHCN.Click += new System.EventHandler(this.btnHCN_Click);
            // 
            // btnKhungEllipse
            // 
            this.btnKhungEllipse.Location = new System.Drawing.Point(3, 168);
            this.btnKhungEllipse.Name = "btnKhungEllipse";
            this.btnKhungEllipse.Size = new System.Drawing.Size(149, 49);
            this.btnKhungEllipse.TabIndex = 18;
            this.btnKhungEllipse.Text = "Khung hình Ellipse";
            this.btnKhungEllipse.UseVisualStyleBackColor = true;
            this.btnKhungEllipse.Click += new System.EventHandler(this.btnKhungEllipse_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(3, 223);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(149, 49);
            this.btnEllipse.TabIndex = 19;
            this.btnEllipse.Text = "Hình Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDuongThang;
        private System.Windows.Forms.Button btnKhungHCN;
        private System.Windows.Forms.Button btnHCN;
        private System.Windows.Forms.Button btnKhungEllipse;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Panel pnlMain;
    }
}

