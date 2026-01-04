using System;
using System.Diagnostics;
using System.Threading; 

namespace KurtariciAntivirus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "7/24 Koruma Sistemi";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--- ANTİVİRÜS KORUMASI AKTİF ---");
            Console.WriteLine("Her 5 saniyede bir tarama yapılacak...");
            Console.WriteLine("Durdurmak için bu pencereyi kapatabilirsiniz.");
            Console.WriteLine("--------------------------------------------");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}] Tarama yapılıyor...");

                Process[] virusler = Process.GetProcessesByName("PembeEkranVirusu");

                if (virusler.Length > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!!! VİRÜS BULUNDU !!! Temizleniyor...");

                    foreach (Process islem in virusler)
                    {
                        try
                        {
                            islem.Kill();
                            Console.WriteLine(">> Tehdit yok edildi.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(">> Hata: " + ex.Message);
                        }
                    }
                }

                Thread.Sleep(5000);
            }
        }
    }
}