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
    public partial class bacsi : Form
    {
        private CXuLyBS xuLy;
        public bacsi()
        {
            InitializeComponent();
        }
        private Dictionary<string, CBacSI> dsBS;
        private void Form2_Load(object sender, EventArgs e)
        {
            ////dsBS = new Dictionary<string, CBacSI>();
            //try
            //{
            //    FileStream f = new FileStream("bacsi23.dat", FileMode.Open);
            //    BinaryFormatter bf = new BinaryFormatter();
            //    dsBS = bf.Deserialize(f) as Dictionary<string, CBacSI>;
            //    f.Close();
            //}
            //catch (Exception)
            //{
            //    dsBS = new Dictionary<string, CBacSI>();
            //}
            //hienthi();
            xuLy = new CXuLyBS();
            if (xuLy.docfile("bacsi23.dat") == true)
            {
                hienthi(xuLy.getdsBS());
            }
            else MessageBox.Show("không đọc được");
        }
        private void hienthi(List<CBacSI> ds)
        {
            {
                BindingSource bs = new BindingSource();
                bs.DataSource =ds;
                dgvBacSI.DataSource = bs;
            }
        }
        private void dgvBacSI_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvBacSI.SelectedRows)
            {
                string maBS = r.Cells[0].Value.ToString();
                CBacSI h = xuLy.tim(maBS);
                h.maBS = txtmaBS.Text;
                h.TenBS = txttenBS.Text;
                h.SDT = int.Parse(txtSDT.Text);
                h.PK = txtPK.Text;
                h.CK = txtCK.Text;
                hienthi(xuLy.getdsBS());
            }

        }
            private void them_Click_1(object sender, EventArgs e)
            {
                try
                {
                    CBacSI h = new CBacSI();
                    h.maBS = txtmaBS.Text;
                    h.TenBS = txttenBS.Text;
                    h.SDT = int.Parse(txtSDT.Text);
                    h.PK = txtPK.Text;
                    h.CK = txtCK.Text;
                    xuLy.them(h);
                    hienthi(xuLy.getdsBS());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        private void xoa_Click_1(object sender, EventArgs e)
        {
                foreach (DataGridViewRow r in dgvBacSI.SelectedRows)
                {
                    string maBS = r.Cells[0].Value.ToString();
                    DialogResult kq = MessageBox.Show("ban muon xoa dong nay ?", "thong bao",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                    xuLy.xoa(maBS);
                    hienthi(xuLy.getdsBS());
                }
        }

        private void sua_Click_1(object sender, EventArgs e)
        {
                CBacSI h = new CBacSI();
                h.maBS = txtmaBS.Text;
                h.TenBS = txttenBS.Text;
                h.SDT = int.Parse(txtSDT.Text);
                h.PK = txtPK.Text;
                h.CK = txtCK.Text;
                xuLy.sua(h);
                hienthi(xuLy.getdsBS());
           
        }

        private void luu_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    FileStream f = new FileStream("bacsi23.dat", FileMode.Create);
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(f, dsBS);
            //    f.Close();
            //    MessageBox.Show("Saved");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);

            //}
            if(xuLy.ghifile("bacsi23.dat")==true)
            {
                MessageBox.Show("lưu file thành công");
                hienthi(xuLy.getdsBS());
            }
            MessageBox.Show("không lưu file được");
        }
    }

}
