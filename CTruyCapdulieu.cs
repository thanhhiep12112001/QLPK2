using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace đồán
{
    class CTruyCapdulieu
    {
        private static CTruyCapdulieu m_data = null;
        private Dictionary<string, CThuoc> m_dst;
        private Dictionary<string, CPhieuKham> m_dsPK;
        private Dictionary<string, CBenhNhan> m_dsBN;
        private Dictionary<string, CBacSI> m_dsBS;
        private CTruyCapdulieu()
        {
            m_dst = new Dictionary<string, CThuoc>();
            m_dsPK = new Dictionary<string, CPhieuKham>();
            m_dsBS = new Dictionary<string, CBacSI>();
            m_dsBN = new Dictionary<string, CBenhNhan>();
        }
        public static CTruyCapdulieu khoitao()
        {
            if (m_data == null) m_data = new CTruyCapdulieu();
            return m_data;
        }
        public Dictionary<string,CThuoc>getdsThuoc()
        {
            return m_dst;
        }
        public Dictionary<string, CPhieuKham> getdsPK()
        {
            return m_dsPK;
        }
        public Dictionary<string,CBenhNhan>getdsBN()
        {
            return m_dsBN;
        }
        public Dictionary<string, CBacSI> getdsBS()
        {
            return m_dsBS;
        }
        public bool ghifile(string tenfile)
        {
            try
            {
                FileStream f = new FileStream(tenfile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, m_data);
                f.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool docfile(string tenfile)
        {
            try
            {
                FileStream f = new FileStream(tenfile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                m_data = bf.Deserialize(f) as CTruyCapdulieu;
                f.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
