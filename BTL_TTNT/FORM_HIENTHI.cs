using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace BTL_TTNT
{
    public partial class FORM_HIENTHI : Form
    {
        Cum cumPhanDoan = new Cum();
        public int soCum;
        DateTime time = new DateTime();

        public FORM_HIENTHI()
        {
            InitializeComponent();

        }

        private void btn_TaiAnh_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Title = "Mở file Ảnh";
                    dialog.Filter = "Files Ảnh (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        pbox_AnhNhap.SizeMode = PictureBoxSizeMode.Zoom;
                        pbox_AnhNhap.Image = new Bitmap(dialog.FileName);

                    }
                }
                tSPB_Time.Text = "00:00:00";
                toolStripProgressBar_txt.Text = "";
            }
            catch
            {
                MessageBox.Show("Ảnh bị lỗi !.", "LỖI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (pBox_AnhXuat.Image == null)
                    throw new ArgumentNullException();

                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Open image";
                    dialog.Filter = "Image Files (*.jpg;*.bmp;*.jpeg,*.png)|*.JPG;*.BMP;*.JPEG;*.PNG";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        pBox_AnhXuat.Image.Save(dialog.FileName);
                    }
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Không tìm thấy hình ảnh.", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FORM_HIENTHI_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult r;
            r = MessageBox.Show("Đóng chương trình!", "Thoát khỏi phần mềm!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
      
        }

        private void btn_XoaAnh2_Click(object sender, EventArgs e)
        {

            pBox_AnhXuat.Image = null;
            tSPB_Time.Text = "00:00:00";
            tSPB_Load.Text = "";
        }

        private void btn_XoaAnh1_Click(object sender, EventArgs e)
        {
            pbox_AnhNhap.Image = null;
            tSPB_Time.Text = "00:00:00";
            tSPB_Load.Text = "";
        }

        private void btn_ChuyenDoi_Click(object sender, EventArgs e)
        {
            try
            {
                soCum = int.Parse(txt_SoCum.Text);
                if (soCum <= 0 || soCum > 50) throw new OverflowException();
                if (pbox_AnhNhap.Image == null) throw new NullReferenceException();

                tSPB_Load.Value = 0;
                tSPB_Load.Maximum = 100;
                tSPB_Load.Style = ProgressBarStyle.Marquee;
                toolStripProgressBar_txt.Text = string.Format("Phân Cụm Hình Ảnh ---- Load");
                timer1.Start();
                time = new DateTime();


                backgroundWorker1.RunWorkerAsync();
            }
            catch (FormatException)
            {
                MessageBox.Show("Chưa nhập vào số Cụm ?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Nhập trong khoảng từ 1- 30", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException )
            {
                MessageBox.Show("Chưa có hình ảnh!.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không biết " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        { 
            pBox_AnhXuat.Image = cumPhanDoan.PhanDoanHinhAnh(new Bitmap(pbox_AnhNhap.Image), soCum);
            pBox_AnhXuat.SizeMode = PictureBoxSizeMode.Zoom;  // Xa c dinh anh ra
   

     
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            tSPB_Load.Style = ProgressBarStyle.Blocks;
            toolStripProgressBar_txt.Text = "Xong!!!!";
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time.AddSeconds(1);
            tSPB_Time.Text = (time.Hour >= 10 ? time.Hour.ToString() : "0" + time.Hour.ToString()) + ":" + (time.Minute >= 10 ? time.Minute.ToString() : "0" + time.Minute.ToString()) + ":" + (time.Second >= 10 ? time.Second.ToString() : "0" + time.Second.ToString());


        }
    }
}
