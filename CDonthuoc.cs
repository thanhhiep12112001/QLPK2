using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace đồán
{
    [Serializable]
    class CDonthuoc
    {
        private string m_tenthuoc;
        private int m_soluong;
        private double m_dongia;
        private string m_maDT;
        private CThuoc m_thuoc;
        public string tenthuoc
        {
            get { return m_tenthuoc; }
            set { m_tenthuoc = value; }
        }
        public string maDT
        {
            get { return m_maDT; }
            set { m_maDT = value; }
        }
        public int soluong
        {
            get { return m_soluong; }
            set { m_soluong = value; }
        }
        public double dongia
        {
            get { return m_dongia; }
            set { m_dongia = value; }
        }
        public CThuoc Thuoc
        {
            get { return m_thuoc; }
            set { m_thuoc = value; }
        }
        public CDonthuoc()
        {
            m_thuoc = null;
            m_soluong = 0;
            m_dongia = 0;
        }
        public CDonthuoc(CThuoc thuoc, int soluong, double dongia)
        {
            m_thuoc = thuoc;
            m_soluong = soluong;
            m_dongia = dongia;
        }
        public double thanhtien()
        {
            return m_dongia * m_soluong;
        }
    }
}

