using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace đồán
{
    class CXuLyBS
    {
        private Dictionary<string, CBacSI> dsBS;

        public CXuLyBS()
        {
            CTruyCapdulieu data = CTruyCapdulieu.khoitao();
            dsBS = new Dictionary<string, CBacSI>();
        }
        public List<CBacSI> getdsBS()
        {
            return dsBS.Values.ToList();
        }
        public CBacSI tim(string maBS)
        {
            try
            {
                return dsBS[maBS];
            }
            catch
            {
                return null;
            }
        }
        public bool them(CBacSI bs)
        {
            CBacSI a = tim(bs.maBS);
            if (a == null)
            {
                dsBS.Add(bs.maBS, bs);
                return true;
            }
            return false;
        }
        public bool xoa(string maBS)
        {
            return dsBS.Remove(maBS);
        }
        public bool sua(CBacSI bs)
        {
            CBacSI a = tim(bs.maBS);
            if (a != null)
            {
                a.maBS = bs.maBS;
                a.TenBS = bs.TenBS;
                a.PK = bs.PK;
                a.CK = bs.CK;
                a.SDT = bs.SDT;
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
                bf.Serialize(f, dsBS);
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
                dsBS = bs.Deserialize(f) as Dictionary<string, CBacSI>;
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
