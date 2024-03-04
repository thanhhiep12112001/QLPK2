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
    public partial class thuoc : Form
    {
        private CXulythuoc xuLy;
        public thuoc()
        {
            InitializeComponent();
        }
        private Dictionary<string, CThuoc> dsThuoc;
        private void Form3_Load(object sender, EventArgs e)
        {
            //dsThuoc = new Dictionary<string, CThuoc>();
            //try
            //{
            //    FileStream f = new FileStream("thuocc.dat", FileMode.Open);
            //    BinaryFormatter bf = new BinaryFormatter();
            //    dsThuoc = bf.Deserialize(f) as Dictionary<string, CThuoc>;
            //    f.Close();
            //}
            //catch (Exception)
            //{
            //    dsThuoc = new Dictionary<string, CThuoc>();
            //}
            //hienthi();
            xuLy = new CXulythuoc();
            if (xuLy.docfile("thuocc.dat") == true)
            {
                hienthi(xuLy.getdsThuoc());
            }
            else MessageBox.Show("không đọc được dữ liệu");
        }
        private void hienthi(List<CThuoc> ds)
        {
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = ds;
                dgvThuoc.DataSource = bs;
            }
        }
        private void dgvThuoc_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvThuoc.SelectedRows)
            {
                string maThuoc = r.Cells[0].Value.ToString();
                CThuoc h = xuLy.tim(maThuoc);
                h.maLThuoc = txtmaLThuoc.Text;
                h.maThuoc = txtmaThuoc.Text;
                h.kho = txtkho.Text;
                h.Ten = txtTenThuoc.Text;
                h.HSD = dtpHSD.Value;
            }
        }

        private void them_Click_1(object sender, EventArgs e)
        {
            try
            {
                CThuoc h = new CThuoc();
                h.maLThuoc = txtmaLThuoc.Text;
                h.maThuoc = txtmaThuoc.Text;
                h.kho = txtkho.Text;
                h.Ten = txtTenThuoc.Text;
                h.HSD = dtpHSD.Value;
                h.soluong = int.Parse(txtsoluong.Text);
                h.dongia = double.Parse(txtdongia.Text);
                xuLy.them(h);
                hienthi(xuLy.getdsThuoc());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void xoa_Click_1(object sender, EventArgs e)
        {
            //foreach (var item in dsThuoc)
            //{
            //    if (item.Key == txtmaThuoc.Text)
            //    {
            //        dsThuoc.Remove(item.Key);
            //        break;
            //    }
            //}
            //hienthi();

            foreach (DataGridViewRow r in dgvThuoc.SelectedRows)
            {
                string maLThuoc = r.Cells[0].Value.ToString();
                DialogResult kq = MessageBox.Show("ban muon xoa dong nay ?", "thong bao",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                    xuLy.xoa(maLThuoc);
                hienthi(xuLy.getdsThuoc());
            }

        }

        private void sua_Click_1(object sender, EventArgs e)
        {
                CThuoc h = new CThuoc();
                h.maLThuoc = txtmaLThuoc.Text;
                h.maThuoc = txtmaThuoc.Text;
                h.kho = txtkho.Text;
                h.Ten = txtTenThuoc.Text;
                h.HSD = dtpHSD.Value;
                h.soluong = int.Parse(txtsoluong.Text);
                h.dongia = double.Parse(txtdongia.Text);
                xuLy.sua(h);
                hienthi(xuLy.getdsThuoc());
           
        }

        private void luu_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    FileStream f = new FileStream("thuocc.dat", FileMode.Create);
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(f, dsThuoc);
            //    f.Close();
            //    MessageBox.Show("Saved");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);

            //}
            if(xuLy.ghifile("thuocc.dat")==true)
            {
                MessageBox.Show("lưu file thành công");
                hienthi(xuLy.getdsThuoc());
            }
            MessageBox.Show("không lưu file được");
        }
    }
}

       
