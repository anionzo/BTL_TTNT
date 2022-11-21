namespace BTL_TTNT
{
    partial class FORM_HIENTHI
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupB_NutThucHien = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txt_SoCum = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_XoaAnh2 = new System.Windows.Forms.Button();
            this.btn_XoaAnh1 = new System.Windows.Forms.Button();
            this.btn_ChuyenDoi = new System.Windows.Forms.Button();
            this.btn_TaiAnh = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSPB_Load = new System.Windows.Forms.ToolStripProgressBar();
            this.tSPB_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar_txt = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gruopAnh = new System.Windows.Forms.GroupBox();
            this.pBox_AnhXuat = new System.Windows.Forms.PictureBox();
            this.pbox_AnhNhap = new System.Windows.Forms.PictureBox();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupB_NutThucHien.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gruopAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_AnhXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_AnhNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(384, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phân Đoạn Hình Ảnh Bằng Thuật Toán K-Means";
            // 
            // groupB_NutThucHien
            // 
            this.groupB_NutThucHien.Controls.Add(this.label2);
            this.groupB_NutThucHien.Controls.Add(this.btn_Luu);
            this.groupB_NutThucHien.Controls.Add(this.txt_SoCum);
            this.groupB_NutThucHien.Controls.Add(this.btn_Thoat);
            this.groupB_NutThucHien.Controls.Add(this.btn_XoaAnh2);
            this.groupB_NutThucHien.Controls.Add(this.btn_XoaAnh1);
            this.groupB_NutThucHien.Controls.Add(this.btn_ChuyenDoi);
            this.groupB_NutThucHien.Controls.Add(this.btn_TaiAnh);
            this.groupB_NutThucHien.Location = new System.Drawing.Point(13, 50);
            this.groupB_NutThucHien.Name = "groupB_NutThucHien";
            this.groupB_NutThucHien.Size = new System.Drawing.Size(169, 554);
            this.groupB_NutThucHien.TabIndex = 1;
            this.groupB_NutThucHien.TabStop = false;
            this.groupB_NutThucHien.Text = "Các Chức Năng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập Vào SỐ Cụm";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(6, 237);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(153, 46);
            this.btn_Luu.TabIndex = 6;
            this.btn_Luu.Text = "Lưu Ảnh";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // txt_SoCum
            // 
            this.txt_SoCum.Location = new System.Drawing.Point(34, 134);
            this.txt_SoCum.Multiline = true;
            this.txt_SoCum.Name = "txt_SoCum";
            this.txt_SoCum.Size = new System.Drawing.Size(93, 22);
            this.txt_SoCum.TabIndex = 5;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(16, 474);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(116, 49);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Thoát ";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_XoaAnh2
            // 
            this.btn_XoaAnh2.Location = new System.Drawing.Point(16, 396);
            this.btn_XoaAnh2.Name = "btn_XoaAnh2";
            this.btn_XoaAnh2.Size = new System.Drawing.Size(124, 46);
            this.btn_XoaAnh2.TabIndex = 4;
            this.btn_XoaAnh2.Text = "Xóa Ảnh 2";
            this.btn_XoaAnh2.UseVisualStyleBackColor = true;
            this.btn_XoaAnh2.Click += new System.EventHandler(this.btn_XoaAnh2_Click);
            // 
            // btn_XoaAnh1
            // 
            this.btn_XoaAnh1.Location = new System.Drawing.Point(16, 332);
            this.btn_XoaAnh1.Name = "btn_XoaAnh1";
            this.btn_XoaAnh1.Size = new System.Drawing.Size(124, 46);
            this.btn_XoaAnh1.TabIndex = 2;
            this.btn_XoaAnh1.Text = "Xóa Ảnh 1";
            this.btn_XoaAnh1.UseVisualStyleBackColor = true;
            this.btn_XoaAnh1.Click += new System.EventHandler(this.btn_XoaAnh1_Click);
            // 
            // btn_ChuyenDoi
            // 
            this.btn_ChuyenDoi.Location = new System.Drawing.Point(6, 162);
            this.btn_ChuyenDoi.Name = "btn_ChuyenDoi";
            this.btn_ChuyenDoi.Size = new System.Drawing.Size(134, 46);
            this.btn_ChuyenDoi.TabIndex = 1;
            this.btn_ChuyenDoi.Text = "Chuyển Đổi Ảnh";
            this.btn_ChuyenDoi.UseVisualStyleBackColor = true;
            this.btn_ChuyenDoi.Click += new System.EventHandler(this.btn_ChuyenDoi_Click);
            // 
            // btn_TaiAnh
            // 
            this.btn_TaiAnh.Location = new System.Drawing.Point(8, 35);
            this.btn_TaiAnh.Name = "btn_TaiAnh";
            this.btn_TaiAnh.Size = new System.Drawing.Size(132, 46);
            this.btn_TaiAnh.TabIndex = 0;
            this.btn_TaiAnh.Text = "Tải Ảnh Lên";
            this.btn_TaiAnh.UseVisualStyleBackColor = true;
            this.btn_TaiAnh.Click += new System.EventHandler(this.btn_TaiAnh_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.tSPB_Load,
            this.toolStripStatusLabel5,
            this.tSPB_Time,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar_txt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 658);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1252, 28);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 22);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(0, 22);
            // 
            // tSPB_Load
            // 
            this.tSPB_Load.Name = "tSPB_Load";
            this.tSPB_Load.Size = new System.Drawing.Size(500, 20);
            // 
            // tSPB_Time
            // 
            this.tSPB_Time.Name = "tSPB_Time";
            this.tSPB_Time.Size = new System.Drawing.Size(63, 22);
            this.tSPB_Time.Text = "00:00:00";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(81, 22);
            this.toolStripStatusLabel2.Text = "                  ";
            // 
            // toolStripProgressBar_txt
            // 
            this.toolStripProgressBar_txt.Name = "toolStripProgressBar_txt";
            this.toolStripProgressBar_txt.Size = new System.Drawing.Size(57, 22);
            this.toolStripProgressBar_txt.Text = "--------";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // gruopAnh
            // 
            this.gruopAnh.Controls.Add(this.pBox_AnhXuat);
            this.gruopAnh.Controls.Add(this.pbox_AnhNhap);
            this.gruopAnh.Location = new System.Drawing.Point(220, 59);
            this.gruopAnh.Name = "gruopAnh";
            this.gruopAnh.Size = new System.Drawing.Size(997, 527);
            this.gruopAnh.TabIndex = 7;
            this.gruopAnh.TabStop = false;
            this.gruopAnh.Text = "ẢNH";
            // 
            // pBox_AnhXuat
            // 
            this.pBox_AnhXuat.Location = new System.Drawing.Point(541, 26);
            this.pBox_AnhXuat.Name = "pBox_AnhXuat";
            this.pBox_AnhXuat.Size = new System.Drawing.Size(428, 467);
            this.pBox_AnhXuat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBox_AnhXuat.TabIndex = 5;
            this.pBox_AnhXuat.TabStop = false;
            // 
            // pbox_AnhNhap
            // 
            this.pbox_AnhNhap.Location = new System.Drawing.Point(36, 26);
            this.pbox_AnhNhap.Name = "pbox_AnhNhap";
            this.pbox_AnhNhap.Size = new System.Drawing.Size(428, 467);
            this.pbox_AnhNhap.TabIndex = 4;
            this.pbox_AnhNhap.TabStop = false;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(81, 22);
            this.toolStripStatusLabel5.Text = "                  ";
            // 
            // FORM_HIENTHI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 686);
            this.Controls.Add(this.gruopAnh);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupB_NutThucHien);
            this.Controls.Add(this.label1);
            this.Name = "FORM_HIENTHI";
            this.Text = "FORM_HIENTHI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FORM_HIENTHI_FormClosing);
            this.groupB_NutThucHien.ResumeLayout(false);
            this.groupB_NutThucHien.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gruopAnh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_AnhXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_AnhNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupB_NutThucHien;
        private System.Windows.Forms.Button btn_TaiAnh;
        private System.Windows.Forms.Button btn_XoaAnh2;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_XoaAnh1;
        private System.Windows.Forms.Button btn_ChuyenDoi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripProgressBar tSPB_Load;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txt_SoCum;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.GroupBox gruopAnh;
        private System.Windows.Forms.PictureBox pBox_AnhXuat;
        private System.Windows.Forms.PictureBox pbox_AnhNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel tSPB_Time;
        private System.Windows.Forms.ToolStripStatusLabel toolStripProgressBar_txt;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
    }
}