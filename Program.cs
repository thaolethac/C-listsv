using System;
class Program
{

    public static void Main(string[] args)
    {
        QuanLySinhVien quanlysinhvien = new QuanLySinhVien();
        bool focus = true;
        while (focus)
        {
            Console.WriteLine("\nQuan ly sinh vien: ");
            Console.WriteLine(" 1. Them sinh vien.");
            Console.WriteLine(" 2. Hien thi sinh vien.");
            Console.WriteLine(" 3. Xoa sinh vien theo Msv.");
            Console.WriteLine(" 4. Tim kiem sinh vien theo Msv.");
            Console.WriteLine(" 5. Cap nhat sinh vien theo Msv.");
            Console.WriteLine(" 6. Tong so sinh vien.");
            Console.WriteLine(" 7. Thoat.");
            Console.Write("Nhap tuy chon: ");
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    quanlysinhvien.AddSinhVien();
                    break;
                case 2:
                    quanlysinhvien.ShowSinhvien(quanlysinhvien.getSinhvien());
                    break;

                case 3:
                    int Msv = Convert.ToInt32(Console.ReadLine());
                    quanlysinhvien.DeleteSv(Msv);
                    break;
                case 4:
                    int id = Convert.ToInt32(Console.ReadLine());
                    quanlysinhvien.ShowSinhvien(quanlysinhvien.FindByMasv(id));
                    break;
                case 5:
                    int Id = Convert.ToInt32(Console.ReadLine());
                    quanlysinhvien.UpdateSv(Id);
                    break;
                case 6:
                    Console.WriteLine(quanlysinhvien.NumberofListsv());
                    break;
                case 7:
                    focus = false;
                    break;
                default:
                    Console.WriteLine("Khong co chon thoa man yeu cau !!!!");
                    break;
            }

        };


    }
}