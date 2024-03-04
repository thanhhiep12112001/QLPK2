using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace đồán
{

    class CXulyBN
    {
        private Dictionary<string, CBenhNhan> dsBN;

        public CXulyBN()
        {
            CTruyCapdulieu data = CTruyCapdulieu.khoitao();
            dsBN = new Dictionary<string, CBenhNhan>();
        }
        public List<CBenhNhan> getdsBN()
        {
            return dsBN.Values.ToList();
        }
        public CBenhNhan tim(string maBN)
        {
            try
            {
                return dsBN[maBN];
            }
            catch
            {
                return null;
            }
        }
        public bool them(CBenhNhan bn)
        {
            CBenhNhan a = tim(bn.maBN);
            if (a == null)
            {
                dsBN.Add(bn.maBN, bn);
                return true;
            }
            return false;
        }
        public bool xoa(string maBN)
        {
            return dsBN.Remove(maBN);
        }
        public bool sua(CBenhNhan bn)
        {
            CBenhNhan a = tim(bn.maBN);
            if (a != null)
            {
                a.maBN = bn.maBN;
                a.hoTen = bn.hoTen;
                a.maBHYT = bn.maBHYT;
                a.Phai = bn.Phai;
                a.SDT = bn.SDT;
                a.CCCD = bn.CCCD;
                a.diaChi = bn.diaChi;
                return true;
            }
            return false;
        }
        public bool ghifile(string tenfile)
        {
            try
            {
                FileStream f = new FileStream(tenfile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, dsBN);
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
                BinaryFormatter bs = new BinaryFormatter();
                dsBN = bs.Deserialize(f) as Dictionary<string, CBenhNhan>;
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