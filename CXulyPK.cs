using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace đồán
{
    class CXulyPK
    {
        private Dictionary<string, CPhieuKham> dsPK;
        public CXulyPK()
        {
            CTruyCapdulieu data = CTruyCapdulieu.khoitao();
            dsPK = data.getdsPK();
        }
        public List<CPhieuKham> getdsPK()
        {
            return dsPK.Values.ToList();
        }
        public CPhieuKham tim(string maPK)
        {
            try
            {
                return dsPK[maPK];
            }
            catch
            {
                return null;
            }
        }
        public void them(CPhieuKham phieu)
        {
            CPhieuKham a = tim(phieu.maPK);
            if (a == null)
            {
                dsPK.Add(phieu.maPK, phieu);
            }
        }
        public void xoa(string maPK)
        {
            CPhieuKham a = tim(maPK);
            if (a != null)
            {
                dsPK.Remove(a.maPK);
            }
        }
        public void sua(CPhieuKham phieu)
        {
            CPhieuKham a = tim(phieu.maPK);
            if (a != null)
            {
                a.maPK = phieu.maPK;
                a.maBS = phieu.maBS;
                a.maBN = phieu.maBN;
                a.maThuoc = phieu.maThuoc;
                a.ngayCapThuoc = phieu.ngayCapThuoc;
            }
        }
        public bool ghifile(string tenfile)
        {
            try
            {
                FileStream f = new FileStream(tenfile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, dsPK);
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
                dsPK = bs.Deserialize(f) as Dictionary<string, CPhieuKham>;
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
