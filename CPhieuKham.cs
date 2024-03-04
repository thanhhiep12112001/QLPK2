using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace đồán
{
    [Serializable]
    class CPhieuKham
    {
        private string m_maPK;
        private string m_maBS;
        private string m_maBN;
        private string m_tenthuoc;
        private string m_tenBN;
        private string m_maThuoc;
        //private List<CChitietphieukham> m_chitietphieukham;
        private DateTime m_ngayCapThuoc;
        public string tenthuoc
        {
            get { return m_tenthuoc; }
            set { m_tenthuoc = value; }
        }
        public string tenBN
        {
            get { return m_tenBN; }
            set { m_tenBN = value; }
        }
        public string maPK
        {
            get { return m_maPK; }
            set { m_maPK = value; }
        }
        public string maBS
        {
            get { return m_maBS; }
            set { m_maBS = value; }
        }
        public string maBN
        {
            get { return m_maBN; }
            set { m_maBN = value; }
        }
        //public List<CChitietphieukham>chitietphieukham
        //{
        //    get { return m_chitietphieukham; }
        //}
        public string maThuoc
        {
            get { return m_maThuoc; }
            set { m_maThuoc = value; }
        }
        public DateTime ngayCapThuoc
        {
            get { return m_ngayCapThuoc; }
            set { m_ngayCapThuoc = value; }
        }
        public CPhieuKham(string maPK, string maBS, string maBN, string maThuoc, DateTime ngayCapThuoc)
        {
            m_maPK = maPK;
            m_maBN = maBN;
            m_maBS = maBS;
            m_maThuoc = maThuoc;
            m_ngayCapThuoc = ngayCapThuoc;
           // m_chitietphieukham = new List<CChitietphieukham>();
        }
        public CPhieuKham()
         {
            m_maPK = "";
            m_maBS = "";
            m_maBN = "";
            m_maThuoc = "";
            m_ngayCapThuoc = DateTime.Now;
            //m_chitietphieukham = new List<CChitietphieukham>();
         }
    }
}
