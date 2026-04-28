DeTu[] danhSach = new DeTu[100];
int soLuong = 0;

while (true)
{
    Console.WriteLine("===== MENU =====");
    Console.WriteLine("1. Them de tu moi");
    Console.WriteLine("2. Hien thi danh sach de tu");
    Console.WriteLine("3. Tim de tu xuat sac");
    Console.WriteLine("4. Thoat");
    Console.WriteLine("5. Ma tran Tu Linh");
    Console.Write("Chon chuc nang: ");

    int chon = int.Parse(Console.ReadLine());

    switch (chon)
    {
        case 1:
            DeTu dt = new DeTu();
            dt.NhapThongTin();

            danhSach[soLuong] = dt;
            soLuong++;

            Console.WriteLine("Da them de tu!");
            break;

        case 2:
            for (int i = 0; i < soLuong; i++)
            {
                danhSach[i].HienThi();
            }
            break;

        case 3:
            Console.WriteLine("Danh sach de tu xuat sac:");

            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i].TinhDiemTong() > 25)
                {
                    danhSach[i].HienThi();
                }
            }
            break;

        case 4:
            return;

        case 5:
            int[,] maTranLinhKhi = new int[3, 3];
            Random random = new Random();

            int max = 0;
            int hangMax = 0;
            int cotMax = 0;

            for (int hang = 0; hang < 3; hang++)
            {
                for (int cot = 0; cot < 3; cot++)
                {
                    maTranLinhKhi[hang, cot] = random.Next(1, 101);

                    if (maTranLinhKhi[hang, cot] > max)
                    {
                        max = maTranLinhKhi[hang, cot];
                        hangMax = hang;
                        cotMax = cot;
                    }
                }
            }

            Console.WriteLine("Ma tran linh khi:");

            for (int hang = 0; hang < 3; hang++)
            {
                for (int cot = 0; cot < 3; cot++)
                {
                    Console.Write(maTranLinhKhi[hang, cot] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Linh khi cao nhat: " + max);
            Console.WriteLine("Vi tri: [" + hangMax + ", " + cotMax + "]");
            break;

        default:
            Console.WriteLine("Lua chon khong hop le!");
            break;
    }

    Console.WriteLine();
}