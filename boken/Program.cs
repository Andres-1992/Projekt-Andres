using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boken
{

    class Program
    {
        static void Main(string[] args)
        {
            Bok programmeringsbok;          //posttyper vi lägger samman ett antal variabler av olika typ till en enhet
            programmeringsbok.titel = "programmeringens grunder";
            programmeringsbok.författare = "abelli, björn";
            programmeringsbok.pris = 299.49F;  //programmeringsboken har nu titel författare och pris
           
            Bok systembok;
            systembok = programmeringsbok;  // systemboken har samma värden som programmeringsboken
            systembok.titel = "sysad"; // vi byter namnet i systemboken till sysad, men den behåller de andra värden som pris och författare
            Console.WriteLine(programmeringsbok.titel);
            Console.WriteLine(systembok.titel); //

           

            /*
            float sträcka=150, tid=2, hastighet=sträcka/tid;  //sträcka=variabel 150=literal float=datatyp

            Console.WriteLine(hastighet);

            hastighet = 60;
            tid = sträcka / hastighet;
            Console.WriteLine(tid);
            */
            /*
            int timlön = 184, timmar = 40;
            int summa = timlön * timmar;
            Console.WriteLine(summa);
            */
            /*
            float a = 5;
            float b = 4;
            Console.WriteLine(a * (b + 2));
            */
            /*
            // Ange sidan i en kvadrat
            int sida = 25;
            //beräkna arean av kvadrat
            int area = sida * sida;
            Console.WriteLine("Area: "+area);
            */
            /*
            const double PI = 3.141593;
            int radie = 25;
            double area = PI * radie * radie;            
            Console.WriteLine(area);
            */
            /*
            int summa, prod, rest;
            int talA=12, talB = 5;
            summa = talA + talB;
            prod = talA * talB;
            rest = talA % talB;
            Console.WriteLine(talA);
            Console.WriteLine(talB);
            Console.WriteLine(summa);
            Console.WriteLine(prod);
            Console.WriteLine(rest);
            */
            /*
            double x = 12345.6789d; //d=suffix
            Console.WriteLine(x);
            float a = (float)x; //typkonvertera (float) innan man anger värdet
            Console.WriteLine(a);
            int b = (int)x;
            Console.WriteLine(b);
            double d = b;// behöver inte typkonvertera för att inga värden tappas
            Console.WriteLine(b);
            double c = a;
            Console.WriteLine(c); // talet blir längre än det ursprungliga talet, hantering av flyttal(utanför denna kursen)
            */
            /*
            int x = 12;
            x *=  2;
            Console.WriteLine(x);

         
       Console.WriteLine("hej \"HEJDÅ\" hej");
       */
            /*
                  float[] belopp;
                  belopp = new float[10];

                  int[] vektor = new int [15]; // [15] plats för 15 värden 0-14
                  vektor[0] = 1;
                  vektor[3] = 76;
                  vektor[7] = 255;
                  vektor[15] = 12; // 15 går inte

                  Console.WriteLine(vektor[7]);
                  */
            /*
      int[] betyg = { 3, 4, 5, 2, 4, 3, 1, 3, 2, 4, 2, 3, 4 };
      int längd = betyg.Length;  // lenght säger hur många element man har i dett fall 13 st
            for (int i = 0; i < 13; i++)
            {
              Console.WriteLine(betyg[i] = i * 10);
            }
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine("Value of element {0} = {1}", i, betyg[i]);
            }

            
            int[,] matris = { { 3, 3 }, { 2, 4 }, { 1, 4 }, { 5, 4 } };
            längd = matris.Length;
            Console.WriteLine(längd);
            int[][] lista = { new int[] {3 }, //initierar inte en matris utan "vektor av vektorer"
                new int[] {2,4,3},
                new int[] {1,4 },            // för var alla matriser symmetriska nu kan man göra de assymetriska men då måste
                new int[] {5,3,2,3,4} };    // man skriva new för varje "rad"
            längd = lista[3].Length; // lista3 för att ta reda på hur många element vi har i den vektorn. övriga är lsita 0,1,2
            Console.WriteLine(längd); 
            */


        }


    }
}
