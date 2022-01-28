using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            short s = 1;
            ushort us = 1;
            Int16 int16 = 1;
            Int32 int32 = 1;
            Int64 int64 = 1;
            uint uint1 = 1;
            long l1 = 1;
            float f1 = 1;
            double d1 = 1;
            decimal de1 = 1;
            char ch = 'a';
            string str = "Merhaba";
            DateTime dt = DateTime.Now;


            Console.WriteLine(dt);


            object o1= 5;
            object o2= "Gök";
            object o3= 'a';

            // String ifadeler

            string str1 = string.Empty;
            str1 = "Gökhan";
            string ad = "Gökhan";
            string soyad = "Çam";
            string tamIsim = ad + " " + soyad;

            // integer tanımlama

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer2*integer2;

            // boolean

            bool bool1 = 10<5;
            // değişken dönüşüm
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20+int20.ToString();


            Console.WriteLine(yeniDeger);

            int int21 = int20+Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20+int.Parse(str20);
            Console.WriteLine(int22);

            // DateTime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string datetime3 = DateTime.Now.ToString("HH.mm");
            Console.WriteLine(datetime3);


        }
    }
}