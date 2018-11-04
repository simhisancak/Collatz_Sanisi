using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;

namespace Collatz_Sanısı
{
    class sayi
    {
        public static BigInteger ToBigInteger(string value)
        {
            BigInteger result = 0;
            for (int i = 0; i < value.Length; i++)
            {
                result = result * 10 + (value[i] - '0');
            }
            return result;
        }
        public static string collatz()
        {
            don:
            Console.Clear();
            Int64 adim = 0;
            string sayi1 , sayi2 , sayi3 , sayi4 , sayi5 , sayi6 , sayi7 = "";
            Console.WriteLine("Sayıyı 7 parça Girin (Soldan Başlayarak)");
            sayi1 = Console.ReadLine();
            sayi2 = Console.ReadLine();
            sayi3 = Console.ReadLine();
            sayi4 = Console.ReadLine();
            sayi5 = Console.ReadLine();
            sayi6 = Console.ReadLine();
            sayi7 = Console.ReadLine();

            
            BigInteger konsol1 = new BigInteger(1.55);
            BigInteger konsol2 = new BigInteger(1);
            BigInteger konsol3 = new BigInteger(1);
            BigInteger konsol4 = new BigInteger(1);
            BigInteger konsol5 = new BigInteger(1);
            BigInteger konsol6 = new BigInteger(1);
            BigInteger konsol7 = new BigInteger(1);

            BigInteger üs1 = new BigInteger(1);
            BigInteger üs2 = new BigInteger(1);
            BigInteger üs3 = new BigInteger(1);
            BigInteger üs4 = new BigInteger(1);
            BigInteger üs5 = new BigInteger(1);
            BigInteger üs6 = new BigInteger(1);

            try
            {
                konsol1 = ToBigInteger(sayi1);
                konsol2 = ToBigInteger(sayi2);
                konsol3 = ToBigInteger(sayi3);
                konsol4 = ToBigInteger(sayi4);
                konsol5 = ToBigInteger(sayi5);
                konsol6 = ToBigInteger(sayi6);
                konsol7 = ToBigInteger(sayi7);
            }
            catch { goto don; }



            
            for (int i = 0; i <sayi7.Length + sayi6.Length + sayi5.Length + sayi4.Length + sayi3.Length + sayi2.Length; i++)
            {
                üs6 = üs6 * 10;
            }


            for (int i = 0; i < sayi6.Length +sayi5.Length + sayi4.Length + sayi3.Length + sayi2.Length; i++)
            {
                üs5 = üs5 * 10;
            }

            for (int i = 0; i < sayi5.Length + sayi4.Length + sayi3.Length + sayi2.Length; i++)
            {
                üs4 = üs4 * 10;
            }


            for (int i = 0; i < sayi4.Length +sayi3.Length + sayi2.Length; i++)
            {
                üs3 = üs3 * 10;
            }

            for (int i = 0; i < sayi3.Length + sayi2.Length; i++)
            {
                üs2 = üs2 * 10;
            }
            for (int i = 0; i < sayi3.Length; i++)
            {
                üs1 = üs1 * 10;
            }

            string[] log = new string[100000000];
           
            BigInteger sayi = new BigInteger(1);
            BigInteger anasayi = new BigInteger(1);
            Console.Clear();
            sayi = (konsol1*üs6) +(konsol2 * üs5) + (konsol3 * üs4) + (konsol4 * üs3) + (konsol5 * üs2) + (konsol6 * üs1) + konsol7;
            anasayi = (konsol1 * üs6) + (konsol2 * üs5) + (konsol3 * üs4) + (konsol4 * üs3) + (konsol5 * üs2) + (konsol6 * üs1) + konsol7;
            Console.WriteLine("giden sayı " + sayi.ToString() + "    sayilar " + sayi1.ToString() + " " + sayi2.ToString() + " " + sayi3.ToString() + " " + sayi4.ToString() + " " + sayi5.ToString() + " " + sayi6.ToString() + " " + sayi7.ToString());
            Console.WriteLine();
            while (true)

            {
                if (sayi % 2 == 0)
                {
                    sayi = sayi / 2;
                    adim = adim + 1;
                    Console.WriteLine(adim + ". Adım Sayı = " +sayi.ToString());
                    log[adim+1] = adim + ". Adım Sayı = " + Convert.ToString(sayi);
                }
                else
                {
                    sayi = (sayi * 3) + 1;
                    adim = adim + 1;
                    Console.WriteLine(adim + ". Adım Sayı = " + sayi.ToString());
                    log[adim+1] = adim + ". Adım Sayı = " + sayi.ToString();
                }
                if (sayi == 1 || sayi == 0)
                {
                    break;
                }
            }
            Console.WriteLine("-------------bitti-----------");
            Console.WriteLine();
            Console.WriteLine("Adım Sayısı: "+ adim.ToString());
            Console.WriteLine("Ana Sayı : " + anasayi.ToString());

            log[0] = ("Ana Sayı: " + anasayi + "  - " + " Adım Sayısı: " + adim + "  - " + " İşlem Tarihi: " + DateTime.Now.ToString());
            string[] simhi2 = new string[adim+2];
            for (int x = 0; x < adim +3; x++)
            {
                if (log[x] == null && log[x + 1] == null && log[x + 2] == null && log[x + 3] == null)
                {
                    break;
                }
                if (log[x] != null)
                {
                    simhi2[x] = log[x];
                }
            }
            string masaustu_dizin = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "collatz log" + ".txt";
            if (!System.IO.File.Exists(masaustu_dizin))
            {
                FileStream fs = File.Create(masaustu_dizin);
                fs.Close();
                System.IO.File.WriteAllLines(masaustu_dizin, simhi2);
            }
            else
            {
                System.IO.File.WriteAllLines(masaustu_dizin, simhi2);
            }
            Console.WriteLine("-------------bitti-----------");
            Console.WriteLine();
            Console.WriteLine("Adım Sayısı: " + adim.ToString());
            Console.WriteLine("Ana Sayı : " + anasayi.ToString());
            
            return "";
        }

       public static string dongu()
        {
            don:
            Console.Clear();
            BigInteger adim = new BigInteger(1);
            BigInteger öadim = new BigInteger(0);
            string sayi1, sayi2, sayi3, sayi4, sayi5, sayi6, sayi7 = "";
            Console.WriteLine("Sayıyı 7 parça Girin (Soldan Başlayarak)");
            sayi1 = Console.ReadLine();
            sayi2 = Console.ReadLine();
            sayi3 = Console.ReadLine();
            sayi4 = Console.ReadLine();
            sayi5 = Console.ReadLine();
            sayi6 = Console.ReadLine();
            sayi7 = Console.ReadLine();


            BigInteger konsol1 = new BigInteger(1);
            BigInteger konsol2 = new BigInteger(1);
            BigInteger konsol3 = new BigInteger(1);
            BigInteger konsol4 = new BigInteger(1);
            BigInteger konsol5 = new BigInteger(1);
            BigInteger konsol6 = new BigInteger(1);
            BigInteger konsol7 = new BigInteger(1);

            BigInteger üs1 = new BigInteger(1);
            BigInteger üs2 = new BigInteger(1);
            BigInteger üs3 = new BigInteger(1);
            BigInteger üs4 = new BigInteger(1);
            BigInteger üs5 = new BigInteger(1);
            BigInteger üs6 = new BigInteger(1);

            try
            {
                konsol1 = ToBigInteger(sayi1);
                konsol2 = ToBigInteger(sayi2);
                konsol3 = ToBigInteger(sayi3);
                konsol4 = ToBigInteger(sayi4);
                konsol5 = ToBigInteger(sayi5);
                konsol6 = ToBigInteger(sayi6);
                konsol7 = ToBigInteger(sayi7);
            }
            catch { goto don; }



            for (int i = 0; i < sayi7.Length + sayi6.Length + sayi5.Length + sayi4.Length + sayi3.Length + sayi2.Length; i++)
            {
                üs6 = üs6 * 10;
            }


            for (int i = 0; i < sayi6.Length + sayi5.Length + sayi4.Length + sayi3.Length + sayi2.Length; i++)
            {
                üs5 = üs5 * 10;
            }

            for (int i = 0; i < sayi5.Length + sayi4.Length + sayi3.Length + sayi2.Length; i++)
            {
                üs4 = üs4 * 10;
            }


            for (int i = 0; i < sayi4.Length + sayi3.Length + sayi2.Length; i++)
            {
                üs3 = üs3 * 10;
            }

            for (int i = 0; i < sayi3.Length + sayi2.Length; i++)
            {
                üs2 = üs2 * 10;
            }
            for (int i = 0; i < sayi3.Length; i++)
            {
                üs1 = üs1 * 10;
            }

            string[] log = new string[100000000];

            BigInteger sayi = new BigInteger(1);
            BigInteger anasayi = new BigInteger(1);
            Console.Clear();
            sayi = (konsol1 * üs6) + (konsol2 * üs5) + (konsol3 * üs4) + (konsol4 * üs3) + (konsol3 * üs2) + (konsol2 * üs1) + konsol1;
            anasayi = (konsol1 * üs6) + (konsol2 * üs5) + (konsol3 * üs4) + (konsol4 * üs3) + (konsol3 * üs2) + (konsol2 * üs1) + konsol1;
            Console.WriteLine("giden sayı " + sayi.ToString() + "    sayilar " + sayi1.ToString() + " " + sayi2.ToString() + " " + sayi3.ToString());
            try
            {

                while (true)

                   

                    while (true)
                    {

                        if (sayi % 2 == 0)
                        {
                            sayi = sayi / 2;
                            adim = adim + 1;
                         
                        }
                        else
                        {
                            sayi = (sayi * 3) + 1;
                            adim = adim + 1;
                          
                        }
                        if (sayi == 1)
                        {

                            anasayi = anasayi + 1;
                            sayi = anasayi;
                            string masaustu_dizin = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "collatz log döngü" + ".txt";
                            if (adim > öadim)
                            {
                                öadim = adim;
                                Console.Clear();
                                Console.WriteLine("---------------------------------");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("Adım Sayısı: " + adim.ToString());
                                Console.WriteLine();
                                Console.WriteLine("Sayı: " + sayi.ToString());
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("---------------------------------");



                                using (System.IO.StreamWriter file = new System.IO.StreamWriter(masaustu_dizin))
                                {
                                    file.WriteLine("---------------------------------");
                                    file.WriteLine();
                                    file.WriteLine();
                                    file.WriteLine("Adım Sayısı: " + adim.ToString());
                                    file.WriteLine();
                                    file.WriteLine("Sayı: " + sayi.ToString());
                                    file.WriteLine();
                                    file.WriteLine();
                                    file.WriteLine("---------------------------------");
                                }
                            }
                            Console.WriteLine("Ana Sayı: " +anasayi+"  Adım Sayısı: " +adim);
                            adim = 0;
                           
                        }
                    }
            }

            catch
            {

                Console.WriteLine("sayı bitti");
            }
            return "";
        }
    }
}
