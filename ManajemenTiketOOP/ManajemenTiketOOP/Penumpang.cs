using System;
using System.Collections.Generic;
using System.Text;

namespace ManajemenTiketOOP
{
  public class Penumpang
    {
        
        public string IDPenumpang { get; set; }
        public string Nama { get; set; }
        public string NoTelp { get; set; }

        public static List<Penumpang> DaftarPenumpang { get; set; } = new List<Penumpang>();

        public static void InputDataPenumpang()
        {
            
            Penumpang penumpang = new Penumpang();
            penumpang.InputIDPenumapang();
            penumpang.NamaPenumpang();
            penumpang.InputNoTelp();
            DaftarPenumpang.Add(penumpang);
            Console.Clear();
            LihatPenumpang();
           
        }

        public void InputIDPenumapang()
        {
            Console.Write("ID Penumpang : ");
            IDPenumpang = Console.ReadLine();
        }
        public virtual void NamaPenumpang()
        {
            Console.Write("Nama Penumpang :");
            Nama = Console.ReadLine();
        }
        public void InputNoTelp()
        {
            Console.Write("Masukkan NoTelp : ");
            NoTelp = Console.ReadLine();
        }


        public static void LihatPenumpang()
        {
            Console.WriteLine("===Daftar Penumpang===");
            Console.WriteLine("======================================");

            Console.WriteLine("NO" + ".     " + "ID Penumpang" + "  " + "Nama" + "  " + "NoTelp");
            for (int i=0; i<DaftarPenumpang.Count; i++)
            {

                Console.WriteLine((i + 1) +"\t"+(DaftarPenumpang[i].IDPenumpang) + "\t"+"\t" + (DaftarPenumpang[i].Nama)+"\t" +(DaftarPenumpang[i].NoTelp));
                Console.WriteLine("---------------------------------------------");

            }
          }
        public static void EditPenumpang()
        {
                Console.Clear();
                LihatPenumpang();
                Console.WriteLine("Silakan masukkan Index No : ");
                int Pilihan = int.Parse(Console.ReadLine());

                Console.Write("ID Penumpang : ");
                DaftarPenumpang[Pilihan - 1].IDPenumpang = Console.ReadLine();
                Console.Write("Nama : ");
                DaftarPenumpang[Pilihan - 1].Nama = Console.ReadLine();
                Console.Write("NoTelp : ");
                DaftarPenumpang[Pilihan - 1].NoTelp = Console.ReadLine();

            Console.Clear();
            LihatPenumpang();
            Console.WriteLine("Tekan Enter untuk kembali ke Menu Utama..");
            Console.ReadKey();
        }

        public static void HapusPenumpang()
        {
            Console.Clear();
            LihatPenumpang();
            Console.WriteLine("Silakan masukkan Index Yang Akan DI hapus: ");
            try 
            {
                int option = int.Parse(Console.ReadLine());
                DaftarPenumpang.RemoveAt(option - 1);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }

            Console.Clear();
            LihatPenumpang();
            Console.WriteLine("Tekan Enter untuk kembali ke Menu Utama..");
            Console.ReadKey();
        }


    }
}
