using System;

namespace donguler_for_loop{

    class Program {

        static void Main(string [] args){
            /*
            
            for (int i = 1; i <= sayac; i++){

                if(i%2 == 1){
                    Console.WriteLine(i);
                }
            }
           */
           int sayac = int.Parse(Console.ReadLine());
            int ttoplam = 0;
            int ctoplam = 0;

            for(int i = 1; i <= sayac; i++){

                if(i%2 == 1){
                     ttoplam = ttoplam +  i;


                }
                if(i%2 == 0){
                    ctoplam = ctoplam + i;
                }

                
            }
            Console.WriteLine(" Tek Toplam = "+ ttoplam + "Çift Toplam = " + ctoplam );


        }
    }
}
