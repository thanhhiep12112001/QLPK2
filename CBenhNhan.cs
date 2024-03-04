using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace đồán
{
    [Serializable]
    class CBenhNhan
    {
        private string h_maBN;
        private string h_hoTen;
        private string h_diaChi;
        private int h_maBHYT;
        private int h_SDT;
        private int h_CCCD;
        private bool h_Phai;
        public string maBN
        {
            get { return h_maBN; }
            set { h_maBN = value; }
        }
        public string hoTen
        {
            get { return h_hoTen; }
            set { h_hoTen = value; }
        }
        public string diaChi
        {
            get { return h_diaChi; }
            set { h_diaChi = value; }

        }
        public int maBHYT
        {
            get { return h_maBHYT; }
            set { h_maBHYT = value; }
        }
        public int CCCD
        {
            get { return h_CCCD; }
            set { h_CCCD = value; }
        }
        public int SDT
        {
            get { return h_SDT; }
            set { h_SDT = value; }
        }
        public bool Phai
        {
            get { return h_Phai; }
            set { h_Phai = value; }
        }
        public CBenhNhan(string maBN,string hoTen,string diaChi, int maBHYT,int CCCD, int SDT,bool Phai)
        {
            h_maBN = maBN;
            h_hoTen = hoTen;
            h_diaChi = diaChi;
            h_CCCD = CCCD;
            h_maBHYT = maBHYT;
            h_SDT = SDT;
            h_Phai = Phai;
        }
        public CBenhNhan()
        {
            h_maBN = "";
            h_hoTen = "";
            h_diaChi = "";
            h_CCCD = 0;
            h_maBHYT = 0;
            h_SDT = 0;
            h_Phai = false;
        }
    }
    [Serializable]
    class CBacSI
    {
        private string h_maBS;
        private string h_TenBS;
        private int h_SDT;
        private string h_PK;
        private string h_CK;
        public string maBS
        {
            get { return h_maBS; }
            set { h_maBS = value; }
        }
        public string TenBS
        {
            get { return h_TenBS; }
            set { h_TenBS = value; }
        }
        public int SDT
        {
            get { return h_SDT; }
            set { h_SDT = value; }
        }
        public string PK

        {
            get { return h_PK; }
            set { h_PK = value; }

        }
        public string CK
        {
            get { return h_CK; }
            set { h_CK = value; }
        }
        public CBacSI(string maBS,string tenBS,int SDT,string PK,string CK)
        {
            h_maBS = maBS;
            h_TenBS = tenBS;
            h_SDT = SDT;
            h_PK = PK;
            h_CK = CK;
        }
        public CBacSI()
        {
            h_maBS = null;
            h_TenBS = null;
            h_SDT = 0;
            h_PK = null;
            h_CK = null;
        }
           
    }
    [Serializable]
    class CThuoc
    {
        private string h_maLThuoc;
        private string h_maThuoc;
        private string h_kho;
        private DateTime h_HSD;
        private string h_Ten;
        private int h_soluong;
        private double h_dongia;
        public string maLThuoc
        {
            get { return h_maLThuoc; }
            set { h_maLThuoc = value; }
        }
        public string maThuoc
        {
            get { return h_maThuoc; }
            set { h_maThuoc = value; }
        }
        public string kho
        {
            get { return h_kho; }
            set { h_kho = value; }
        }
        public DateTime HSD
        {
            get { return h_HSD; }
            set { h_HSD = value; }
        }
        public string Ten
        {
            get { return h_Ten; }
            set { h_Ten = value; }
        }
        public int soluong
        {
            get { return h_soluong; }
            set { h_soluong = value; }
        }
        public double dongia
        {
            get { return h_dongia; }
            set { h_dongia = value; }
        }
        public CThuoc(string maLThuoc, string maThuoc, string kho, DateTime HSD, string Ten,int soluong,double dongia)
        {
            h_maLThuoc = maLThuoc;
            h_maThuoc = maThuoc;
            h_kho = kho;
            h_HSD = HSD;
            h_Ten = Ten;
            h_dongia = dongia;
            h_soluong = soluong;
        }
        public CThuoc()
        {
            h_maLThuoc = null;
            h_maThuoc = null;
            h_kho = null;
            h_HSD = DateTime.Now;
            h_Ten = null;
            h_soluong = 0;
            h_dongia = 0;
        }
    }
}
