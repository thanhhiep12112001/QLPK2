using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace đồán
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void benhNhan_Click(object sender, EventArgs e)
        {
            BenhNhan frm = new BenhNhan();
            frm.ShowDialog();
        }

        private void bacSi_Click(object sender, EventArgs e)
        {
            bacsi frm = new bacsi();
            frm.ShowDialog();
        }

        private void thuoc_Click(object sender, EventArgs e)
        {
            thuoc frm = new thuoc();
            frm.ShowDialog();
        }
    }
}
