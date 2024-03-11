﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libak
{
    class Program
    {
        static void kiir(int[] t, string cim)
        {
            Console.WriteLine(cim);
            foreach (int szam in t)
            {
                Console.WriteLine($"{szam}, ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            /*
             LIBÁK

            A róka libát lop a faluból. A libák súlyát – pontosabban tömegét – listában adjuk meg. A farkas a dűlőútnál várja a rókát, és a három kilónál nagyobb libákat elveszi – a piciket nagylel�kűen otthagyja a rókának.
            libak = [1,5,2,3,4]

            a. Hány kiló libát ehet meg a róka?
            b. Átlagosan hány kilósak a rókának maradt libák?
            c1. Előfordult-e olyan, hogy a róka legalább háromkilós libát lopott?
            c2. Előfordult-e olyan, hogy a róka kisebb libát hozott, mint az előző napon?
            d. Hányadik napon sikerült a rókának először legalább háromkilós libát lopnia?
            e. Melyik a róka első legalább háromkilós libája?
            f. Hány libát tarthat meg a róka?
            g. Mekkora a legkisebb liba, amit a farkas elvesz a rókától?
             */

            int[] libak = [1, 5, 2, 3, 4];
            kiir(libak, "libák súlyai");
            Console.WriteLine("nyomj egy billentyűt a kilépéshez");
            Console.ReadKey();
        }
    }
}
