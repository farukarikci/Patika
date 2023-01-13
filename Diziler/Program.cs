namespace Diziler{

    class Program{

        static void Main(string [] args){

            string[] renkler = new string[5];

            string[] hayvanlar = {"Öküz","Aslan","Balık","Keçi"};

            int[] dizi;
             dizi = new int[5];

             // Dizilere Değer Atama ve Erişim
             renkler[0]="Mavi";

             dizi[3]= 10234;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi kullanımı

            Console.WriteLine("Lütfen dizinin eleman sayısını giriniz");
            int diziUzunlugu = Convert.ToInt32(Console.ReadLine());

            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i =0;i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz : ", i+1);
                sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
            }

            int toplam = 0;
            foreach(var sayi in sayiDizisi)
                toplam =+ sayi;

            Console.WriteLine("Ortalama : " + toplam/diziUzunlugu);    




           
         

            




        }
    }
}