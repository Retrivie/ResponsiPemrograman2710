using System;

namespace ResponsiPemrograman2710
{
    class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
        public int NaikGaji { get; set; }


        public Karyawan(string getNik, string getNama, int getGajiBulanan)
        {
            Nik             = getNik;
            Nama            = getNama;
            GajiBulanan     = getGajiBulanan;

            if (getGajiBulanan < 0)
            {
                GajiBulanan = 0;
            }
        }

        public void GetNaikGaji()
        {
            int Bonus = GajiBulanan / NaikGaji;
            GajiBulanan = GajiBulanan + Bonus;
            Console.WriteLine("{0} {1}\t\t\t {2}", Nik, Nama, GajiBulanan);
        }

        public void GetKaryawan()
        {
            Console.WriteLine("{0} {1}\t\t\t {2}", Nik, Nama, GajiBulanan);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NIK\tNama\t\t\tGaji Bulanan\n--------------------------------------------");
            Karyawan karyawan = new Karyawan("100151" ,"Bosku", 3000000);
            Karyawan karyawann = new Karyawan("100152", "Bosque", 2000000);

            karyawan.GetKaryawan();
            karyawann.GetKaryawan();

            Console.WriteLine("\n");
            Console.WriteLine("Asyikkkk kenaikan gaji 10%!!\n");
            Console.WriteLine("NIK\tNama\t\t\tGaji Bulanan\n--------------------------------------------");
            
            karyawan.NaikGaji = 10;
            karyawan.GetNaikGaji();

            karyawann.NaikGaji = 10;
            karyawann.GetNaikGaji();

        }
    }
}
