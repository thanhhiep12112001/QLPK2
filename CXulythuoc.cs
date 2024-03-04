using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace đồán
{
    class CXulythuoc
    {
        private Dictionary<string, CThuoc> dst;
        public CXulythuoc()
        {
            CTruyCapdulieu data = CTruyCapdulieu.khoitao();
            dst = new Dictionary<string, CThuoc>();
        }
        public List<CThuoc>getdsThuoc()
        {
            return dst.Values.ToList();
        }
        public CThuoc tim(string maThuoc)
        {
            try
            {
                return dst[maThuoc];
            }
            catch
            {
                return null;
            }
        }
        public bool them(CThuoc thuoc)
        {
            CThuoc a = tim(thuoc.maThuoc);
            if (a == null)
            {
                dst.Add(thuoc.maThuoc, thuoc);
                return true;
            }
            return false;
        }
        public bool xoa(string maThuoc)
        {
            return dst.Remove(maThuoc);
        }
        public bool sua(CThuoc thuoc )
        {
            CThuoc a = tim(thuoc.maThuoc);
            if (a != null)
            {
                a.maLThuoc = thuoc.maLThuoc;
                a.maThuoc = thuoc.maThuoc;
                a.Ten = thuoc.Ten;
                a.kho = thuoc.kho;
                a.HSD = thuoc.HSD;
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
                bf.Serialize(f, dst);
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
                dst = bs.Deserialize(f) as Dictionary<string, CThuoc>;
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
