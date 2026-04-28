public class DeTu
{
    public string Ten;
    public int CanCung;
    public double[] DiemKhaoHach = new double[3];

    public void NhapThongTin()
    {
        Console.Write("Nhap ten de tu: ");
        Ten = Console.ReadLine();

        Console.Write("Nhap can cung 1-10: ");
        CanCung = int.Parse(Console.ReadLine());

        Console.Write("Nhap diem the luc: ");
        DiemKhaoHach[0] = double.Parse(Console.ReadLine());

        Console.Write("Nhap diem linh luc: ");
        DiemKhaoHach[1] = double.Parse(Console.ReadLine());

        Console.Write("Nhap diem ngo tinh: ");
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
        Console.WriteLine("Diem tong: " + TinhDiemTong());
        Console.WriteLine("--------------------");
    }
}