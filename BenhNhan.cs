using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace đồán
{
    public partial class BenhNhan : Form
    {
        private CXulyBN xuly;
        public BenhNhan()
        {
            InitializeComponent();
        }
        private Dictionary<string, CBenhNhan> x;

        private void Form1_Load(object sender, EventArgs e)
        {
            //dsBN = new Dictionary<string, CBenhNhan>();
            //try
            //{
            //    FileStream f = new FileStream("benhnhan.dat", FileMode.Open);
            //    BinaryFormatter bf = new BinaryFormatter();
            //    dsBN = bf.Deserialize(f) as Dictionary<string, CBenhNhan>;
            //    f.Close();
            //}
            //catch (Exception)
            //{
            //    dsBN = new Dictionary<string, CBenhNhan>();
            //}
            //hienThi();
            xuly = new CXulyBN();
            hienThi(xuly.getdsBN());
        }
       
        private void hienThi(List<CBenhNhan> ds)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = ds;
            // bs.DataSource = BenhnhanView.chuyendoi(dsBN);
            dgvBenhnhan.DataSource = bs;
        }


        private void dgvBenhnhan_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvBenhnhan.SelectedRows)
            {
                string maBN = r.Cells[0].Value.ToString();
                CBenhNhan hs = xuly.tim(maBN); 
                txtmaBN.Text = hs.maBN;
                txtTenBN.Text = hs.hoTen;
                txtBHYT.Text = hs.maBHYT.ToString();
                txtCCCD.Text = hs.CCCD.ToString();
                txtdiaChi.Text = hs.diaChi;
                txtSDT.Text = hs.SDT.ToString();
                
                if (hs.Phai == true)
                {
                    rdbNam.Checked = true;
                }
                else
                {
                    rdbNu.Checked = true;
                }
                break;
                
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            try
            {
                CBenhNhan h = new CBenhNhan();
                h.maBN = txtmaBN.Text;
                h.hoTen = txtTenBN.Text;
                h.SDT = int.Parse(txtSDT.Text);
                h.maBHYT = int.Parse(txtBHYT.Text);
                h.diaChi = txtdiaChi.Text;
                h.CCCD = int.Parse(txtCCCD.Text);
                h.Phai = rdbNam.Checked;
                xuly.them(h);
                hienThi(xuly.getdsBN());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            //foreach (var item in dsBN)
            //{
            //    if (item.Key == txtmaBN.Text)
            //    {
            //        dsBN.Remove(item.Key);
            //        break;
            //    }
            //}
            //hienThi();

            foreach (DataGridViewRow r in dgvBenhnhan.SelectedRows)
            {
                string maBN = r.Cells[0].Value.ToString();
                DialogResult kq = MessageBox.Show("ban muon xoa dong nay ?", "thong bao",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                    xuly.xoa(maBN);
                hienThi(xuly.getdsBN());
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
                CBenhNhan h = new CBenhNhan();
                h.maBN = txtmaBN.Text;
                h.hoTen = txtTenBN.Text;
                h.CCCD = int.Parse(txtCCCD.Text);
                h.SDT = int.Parse(txtSDT.Text);
                h.diaChi = txtdiaChi.Text;
                h.maBHYT = int.Parse(txtBHYT.Text);
                h.Phai = rdbNam.Checked;
                xuly.sua(h);
                hienThi(xuly.getdsBN());
           
        }

        private void ghi_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    FileStream f = new FileStream("benhnhan.dat", FileMode.Create);
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(f, dsBN);
            //    f.Close();
            //    MessageBox.Show("Saved");
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("ko thành công");

            //}

            //if(xuly.ghifile("benhnhan.dat")==true)
            //{
            //    MessageBox.Show("lưu file thành công");
            //    hienThi(xuly.getdsBN());
            //}
            //MessageBox.Show("không lưu file được");
        }
    }
}
