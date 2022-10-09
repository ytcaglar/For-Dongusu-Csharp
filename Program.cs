using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan sayıya kadar olan tek sayıları ekrana yazdırın.
            Console.WriteLine("Bir sayı giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            Console.WriteLine("---------");
            for (int i = 1; i <= sayac; i++)
            {
                if(i%2==1)
                    Console.WriteLine(i);
            }

            // 1 ile 1000 arasındaki çift ve tek sayıların kendi arasında toplamları...
            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if(i%2==1)
                    tekToplam += i;
                
                if(i%2==0)
                    ciftToplam += i;
            }

            Console.WriteLine("Tek Toplam: "+ tekToplam);
            Console.WriteLine("Çift Toplam: "+ ciftToplam);

            // Break: Döngüyü kırmayı olan döngünün devam etmemesini sağlar.
            // Continue: Döngünün o anki kısmını pas geçip bir sonraki değerden devam etmesini sağlar.

            for (int i = 1; i < 10; i++)
            {
                if (i==4) // i = 4 olursa döngüyü bitirir. Döngü devam etmez.
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i==4) // i = 4 olursa döngüyü bitirmez sadece 4 değeri için döngüyü atlar. 
                          // Döngü bir sonraki değerden devam eder.
                    continue;
                Console.WriteLine(i);
            }
            
            // Not : break iç içe döngülerde kullanılırsa en içteki döngüyü kırar.
            // Onun devam etmesine izin vermezken bir üstteki döngüden devam eder.

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (j==4) // j = 4 olursa döngüyü bitirmez sadece 4 değeri için döngüyü atlar. 
                            // Döngü bir sonraki değerden devam eder.
                        continue;

                    if (j==7)  
                        break; // j = 7 olursa döngüyü j döngüsünü bitirir. j döngüsü 6 ya kadar çalışır.
                    Console.WriteLine("i:" + i + " j:" + j);
                
                }
            }
        }
    }
}

