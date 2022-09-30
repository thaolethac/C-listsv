using System;
using System.Collections.Generic;

class QuanLySinhVien
{
    private List<SinhVien> ListSinhVien = null;
    public QuanLySinhVien()
    {
        ListSinhVien = new List<SinhVien>();
    }
    public void AddSinhVien()
    {
        SinhVien sinhvien = new SinhVien();
        Console.Write("Nhap ma sinh vien: ");
        sinhvien.Msv = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhao ten sinh vien: ");
        sinhvien.Namesv = Console.ReadLine();
        Console.Write("Nhap ngay sinh sinh vien: ");
        sinhvien.Ngaysinh = Console.ReadLine();
        Console.Write("Nhap gioi tinh sinh vien: ");
        sinhvien.Gioitinh = Console.ReadLine();
        Console.Write("Nhap khoa cua sinh vien: ");
        sinhvien.Khoa = Console.ReadLine();

        ListSinhVien.Add(sinhvien);
    }
    public int NumberofListsv()
    {
        int Count = 0;
        if (ListSinhVien != null)
        {
            Count = ListSinhVien.Count;
        }
        return Count;
    }
    public SinhVien FindByMsv(int ID)
    {
        SinhVien result = null;
        foreach (SinhVien sinhvien in ListSinhVien)
        {
            if (sinhvien.Msv == ID)
            {
                result = sinhvien;
            }
        }
        return result;
    }
    public List<SinhVien> FindByMasv(int id)
    {
        List<SinhVien> newList = new List<SinhVien>();
        if (ListSinhVien != null && NumberofListsv() > 0)
        {
            foreach (SinhVien sinhvien in ListSinhVien)
            {
                if (Convert.ToString(sinhvien.Msv).Contains(Convert.ToString(id)))
                {
                    newList.Add(sinhvien);
                }
            }
        }
        return newList;
    }
    public void UpdateSv(int id)
    {
        SinhVien sinhvien = FindByMsv(id);
        if (sinhvien != null)
        {
            sinhvien.Msv = id;
            Console.Write("Nhao ten sinh vien: ");
            string Namesv = Console.ReadLine();
            sinhvien.Namesv = Namesv;
            Console.Write("Nhap ngay sinh sinh vien: ");
            string Ngaysinh = Console.ReadLine();
            sinhvien.Ngaysinh = Ngaysinh;
            Console.Write("Nhap gioi tinh sinh vien: ");
            string Gioitinh = Console.ReadLine();
            sinhvien.Gioitinh = Gioitinh;
            Console.Write("Nhap khoa cua sinh vien: ");
            string Khoa = Console.ReadLine();
            sinhvien.Khoa = Khoa;

        }
        else
        {
            Console.WriteLine($"Ma sinh vien {id} khong co trong danh sach");
        }
    }
    public bool DeleteSv(int id)
    {
        bool isDelete = false;
        SinhVien sinhvien = FindByMsv(id);
        if (sinhvien != null)
        {
            isDelete = ListSinhVien.Remove(sinhvien);
        };

        return isDelete;
    }
    public List<SinhVien> getSinhvien()
    {
        return ListSinhVien;
    }
    public void ShowSinhvien(List<SinhVien> list)
    {
        Console.WriteLine("{0, -10} {1, 8} {2, -5} {3, 5} {4, 5}",
      "Ma sinh vien", "Name", "Ngaysinh", "Gioitinh", "Khoa");
        foreach (SinhVien sinhvien in list)
        {
            Console.WriteLine("{0, -5} {4, 12} {2, -5} {3, 5} {4, 5}",
            sinhvien.Msv, sinhvien.Namesv, sinhvien.Ngaysinh, sinhvien.Gioitinh, sinhvien.Khoa);
        }
    }
}
