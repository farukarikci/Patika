namespace array_sinifi_methodlar {

    class Program{

        static void Main(string [] args){

            int[] sayiDizisi ={23,34,45,56,67,78,12,23,34,45,98,87,76,65};

         /*  Array.Sort(sayiDizisi);

           foreach(var sayi in sayiDizisi){

            Console.WriteLine(sayi);
           }
         */


        /*   Array.Clear(sayiDizisi,2,3);

           foreach(var sayi in sayiDizisi){

            Console.WriteLine(sayi);
           }

         */



         /* 
          Array.Reverse(sayiDizisi);  
         foreach(var sayi in sayiDizisi){

            Console.WriteLine(sayi);
           } 
        */

            Console.WriteLine(Array.IndexOf(sayiDizisi,78));
        }
    }
}
