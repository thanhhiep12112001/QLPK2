using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using đồán  ;

namespace đồán
{
    class BenhnhanView
    {
        
        public string mabn { get; set; }
        public string hoten { get; set; }
        public string diachi { get; set; }
        public string maBHYT { get; set; }
        public string SDT { get; set; }
        public string CCCD { get; set; }
        public string phai { get; set; }

        public static List<BenhnhanView> chuyendoi(List<CBenhNhan> ds)
        {
            List<BenhnhanView> x = new List<BenhnhanView>();
            foreach (CBenhNhan a in ds)
            {
                BenhnhanView bn = new BenhnhanView();
                bn.mabn = a.maBN;
                bn.hoten = a.hoTen;
                bn.diachi = a.diaChi;
                bn.maBHYT = a.maBHYT.ToString();
                bn.SDT = a.SDT.ToString();
                bn.CCCD = a.CCCD.ToString();
                bn.phai = (a.Phai == true) ? "Nam" : "Nữ";
                x.Add(bn);
            }
            return x;
        } 
    }
}
