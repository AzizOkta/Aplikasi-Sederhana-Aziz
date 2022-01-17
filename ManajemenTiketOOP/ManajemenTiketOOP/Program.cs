using System;

namespace ManajemenTiketOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuUtama();
        }
        public static void MenuUtama()
        {
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("Manajemen Tiket");
            Console.WriteLine("==========================================");
            Console.WriteLine("1. Penumpang");
            Console.WriteLine("2. Penjualan Tiket");
            Console.WriteLine("3. Exit");
            Console.WriteLine("==========================================");
            Console.Write("Masukkan Pilihan Anda ");

            int Pilih = Convert.ToInt32(Console.ReadLine());
            switch (Pilih)
            {
                case 1:
                    MenuPenumpang();
                    break;
                case 2:
                    MenuPenjualan();
                    break;
                case 3:
                    break;
                default:
                    MenuUtama();
                    break;
            }
        }

        private static void MenuPenumpang()
        {
            Console.Clear();
            Console.WriteLine("===Penumpang===");
            Console.WriteLine("======================================");
            Console.WriteLine("1. Tambah Penumpang");
            Console.WriteLine("2. Update Penumpang");
            Console.WriteLine("3. Hapus Penumpang");
            Console.WriteLine("4. Daftar Penumpang");
            Console.WriteLine("5. Menu Utama");
            Console.WriteLine("======================================");
            Console.Write("Masukkan Pilihan Anda ");
            int Pilih = Convert.ToInt32(Console.ReadLine());
            switch (Pilih)
            {
                case 1:
                    Console.Clear();
                    Penumpang.InputDataPenumpang();
                    MenuPenumpang();
                    break;
                case 2:
                    Penumpang.EditPenumpang();
                    MenuPenumpang();
                    break;
                case 3:
                    Penumpang.HapusPenumpang();
                    MenuPenumpang();
                    break;
                case 4:
                    Console.Clear();
                    Penumpang.LihatPenumpang();
                    Console.WriteLine("Tekan Enter untuk kembali ke Menu Utama..");
                    Console.ReadKey();
                    MenuPenumpang();
                    break;
                case 5:
                    MenuUtama();
                    break;
                default:
                    MenuUtama();
                    break;
            }

        }

        private static void MenuPenjualan()
        {
            Console.Clear();
            Console.WriteLine("===Penjualan Tiket===");
            Console.WriteLine("======================================");
            Console.WriteLine("1. Penjualan Tiket");
            Console.WriteLine("2. Lihat Daftar Penjualan");
            Console.WriteLine("3. Hapus Data Penjualan");
            Console.WriteLine("4. Menu Utama");
            Console.WriteLine("===================================");
            Console.Write("Masukkan Pilihan Anda ");

            int Pilih = Convert.ToInt32(Console.ReadLine());
            switch (Pilih)
            {
                case 1 :
                    PenjuanlanTiket.TambahTransaksi();
                    MenuPenjualan();
                    break;
                case 2 :
                    Console.Clear();
                    PenjuanlanTiket.LihatTransaksi();
                    Console.WriteLine("Tekan Enter untuk kembali ke Menu Penjualan..");
                    Console.ReadKey();
                    MenuPenjualan();
                    break;
                case 3:
                 PenjuanlanTiket.HapusTransaksi();
                    MenuPenjualan();
                    break;
                case 4:
                    MenuUtama();
                    break;
                default:
                    MenuPenjualan();
                    break;

            }
        }
      
    }
}
