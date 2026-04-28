public class DeTu
{
    public string Ten;
    public int CanCung;
    public double[] DiemKhaoHach = new double[3];

    public void NhapThongTin()
    {
        Console.Write("Nhap ten de tu: ");
        Ten = Console.ReadLine();

        do
        {
            Console.Write("Nhap can cung (1-10): ");
            CanCung = int.Parse(Console.ReadLine());
        } while (CanCung < 1 || CanCung > 10);

        Console.Write("Nhap diem The luc: ");
        DiemKhaoHach[0] = double.Parse(Console.ReadLine());

        Console.Write("Nhap diem Linh luc: ");
        DiemKhaoHach[1] = double.Parse(Console.ReadLine());

        Console.Write("Nhap diem Ngo tinh: ");
        DiemKhaoHach[2] = double.Parse(Console.ReadLine());
    }

    public double TinhDiemTong()
    {
        return DiemKhaoHach[0] + DiemKhaoHach[1] + DiemKhaoHach[2];
    }

    public void HienThi()
    {
        Console.WriteLine("Ten: " + Ten);
        Console.WriteLine("Can cung: " + CanCung);
        Console.WriteLine("Diem The luc: " + DiemKhaoHach[0]);
        Console.WriteLine("Diem Linh luc: " + DiemKhaoHach[1]);
        Console.WriteLine("Diem Ngo tinh: " + DiemKhaoHach[2]);
        Console.WriteLine("Diem tong: " + TinhDiemTong());
    }
}