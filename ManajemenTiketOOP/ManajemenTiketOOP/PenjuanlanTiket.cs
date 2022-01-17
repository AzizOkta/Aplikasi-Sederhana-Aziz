using System;
using System.Collections.Generic;
using System.Text;

namespace ManajemenTiketOOP
{
   public class PenjuanlanTiket : Penumpang
    {
        public string Tujuan { get; set; }
        public int HargaTiket { get; set; }
        public static List<PenjuanlanTiket> penjuanlanTiket { get; set; } = new List<PenjuanlanTiket>();

        private static string[] tujuan = new string[] { "Jakarta", "Surabaya" };
        private static int[] nominal = new int[] { 150000, 100000 };

        public void InputTujuan()
        {

            Console.Clear();
            Console.WriteLine("===Input Tujuan===");
            for (int i = 0; i < tujuan.Length; i++)
            {
                int no = i + 1;
                Console.WriteLine($"{no}. {tujuan[i]}");
            }
            Console.WriteLine("===================================");
            Console.WriteLine("Masukkan Pilihan Kamu : ");

            try
            {
                int option = int.Parse(Console.ReadLine());

                if (option <= tujuan.Length)
                {
                    Tujuan = tujuan[option - 1];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.Message);
            }
        }

        public int InputHarga()
        {
            Console.Clear();
            Console.WriteLine("===Input Harga===");
            Console.WriteLine("KETERANGAN = 1. VVIP 2. EKONOMI");
            Console.WriteLine("======================================");
            for (int i = 0; i < nominal.Length; i++)
            {
                int no = i + 1;
                Console.WriteLine($"{no}. {nominal[i]}");
            }
            Console.WriteLine("===================================");
            Console.WriteLine("Masukkan Pilihan Kamu : ");

            try
            {
                int option = int.Parse(Console.ReadLine());

                if (option <= nominal.Length)
                {
                    HargaTiket = nominal[option - 1];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.Message);
            }
            return HargaTiket;

        }

        public override void NamaPenumpang()
        {
            try
            {
                Console.Clear();
                LihatPenumpang();
                Console.WriteLine("Silakan masukkan urutan Index Penumpang : ");
                int option = int.Parse(Console.ReadLine());
                Nama = DaftarPenumpang[option - 1].Nama;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
        }
      

        public static void TambahTransaksi()
        {
            try
            {
                PenjuanlanTiket transaksi = new PenjuanlanTiket();             
                transaksi.NamaPenumpang();
                transaksi.InputTujuan();
                transaksi.InputHarga();
                penjuanlanTiket.Add(transaksi);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
            Console.Clear();
            LihatTransaksi();
            Console.WriteLine("Tekan Enter untuk kembali ke Menu Utama..");
            Console.ReadKey();
        }

        public static void LihatTransaksi()
        {
            Console.WriteLine("===Daftar Tranksaksi===");
            Console.WriteLine("======================================");
            Console.WriteLine("NO" + ".     " + "Nama Penumpang" + "  " + "Tujuan" + "  " + "Harga");
            for (int i = 0; i < penjuanlanTiket.Count; i++)
            {
                Console.WriteLine((i + 1) + "\t" + (penjuanlanTiket[i].Nama) + "\t" + "\t" + (penjuanlanTiket[i].Tujuan) + "\t" + (penjuanlanTiket[i].HargaTiket));
                Console.WriteLine("---------------------------------------------");
            }
        }


        public static void HapusTransaksi()
        {
            Console.Clear();
            LihatTransaksi();
            Console.WriteLine("Silakan masukan nomor urutan data yang akan dihapus : ");
            try
            {
                int option = int.Parse(Console.ReadLine());
                penjuanlanTiket.RemoveAt(option - 1);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }

            Console.Clear();
            LihatTransaksi();
            Console.WriteLine("Tekan Enter untuk kembali ke Menu Utama..");
            Console.ReadKey();
        }

    }

}
