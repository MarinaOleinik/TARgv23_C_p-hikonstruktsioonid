﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv23_C_põhikonstruktsioonid
{
    public class ClassMain
    {
        public static void Main(string[] args)
        {
            //II.Osa Tsüklid, Järjendid,Sõnaslik
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Backspace");
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Backspace);           
            
            int a = 0;
            while(a<10)
            {
                Console.WriteLine(a);
                a++;
            }
            
            /*Inimene naine=new Inimene();
            naine.Nimi = "Kati";
            naine.Vanus = 18;
            Inimene mees = new Inimene("Mati");
            mees.Vanus = 100;
            List<Inimene> inimesed = new List<Inimene> ();
            inimesed.Add(mees);
            inimesed.Add(naine);
            inimesed.Add(mees);
            inimesed.Add(naine);
            inimesed.Add(new Inimene() { Nimi = "Kadri", Vanus = 25 });
            foreach (Inimene inimene in inimesed)
            {
                Console.WriteLine(inimene.Nimi +", ta on " +inimene.Vanus+" aastat vana");
            }
            Dictionary<int,Inimene> õpilased= new Dictionary<int,Inimene>();
            õpilased.Add(501,mees);
            õpilased.Add(601,naine);
            õpilased.Add(602, new Inimene() { Nimi = "Kadri", Vanus = 25 });
            foreach (Inimene item in õpilased.Values)
            {
                Console.WriteLine(item.Nimi);
            }
            foreach (KeyValuePair<int,Inimene> item in õpilased)
            {
                Console.WriteLine(item.Key + ": " + item.Value.Nimi+"("+item.Value.Vanus+")");
            }
            */



            /*ArrayList arrayList = new ArrayList();
            arrayList.Add("Esimene");
            arrayList.Add("Teine");
            arrayList.Add("Kolmas");
            Console.WriteLine("Mida otsime?->");
            string value=Console.ReadLine();
            if (value != null)
            {
                if (arrayList.Contains(value))
                {
                    Console.WriteLine("Kokku: "+arrayList.Count);
                    Console.WriteLine("Otsitav sõne on olemas.\nTa asub " + arrayList.IndexOf(value)+". kohal");
                }
            }
            else
            {
                Console.WriteLine("Oli vaja midagi otsida!");
            }
            arrayList.Insert(3, "Neljas");
            arrayList.RemoveAt(0);
            arrayList.Remove(value);
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            */





            /*List<string> kuude_list = new List<string>();
            try
            {
                foreach (string rida in File.ReadAllLines(@"..\..\..\Kuud.txt"))
                {
                    kuude_list.Add(rida);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }
            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }
            kuude_list.Remove("Juuni");
            kuude_list[0] = "Veeel kuuu";
            Console.WriteLine("--------------Kustutasime juuni-----------");
            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }
            */


            //I.Osa Andmetüübid, If, Case, Alamfunktsioonid, Random
            /*Console.WriteLine("Hello, World!");

            string nimi = "Python";
            Funktisioonid.Tervitus(nimi);


            int a = 0;
            string tekst = "Tere";
            char taht= 'A';
            double arv = 3.55555;
            float arv1 = 2;
            int korrutis = Funktisioonid.Korruta((int)arv, (int)arv1);
            Console.WriteLine(korrutis);

            Console.WriteLine(tekst);
            Console.WriteLine(taht);
            Console.Write("Sisesta uus parameeter a: ");
            a=int.Parse(Console.ReadLine());

            Console.Write("Tehe: ");
            taht=char.Parse(Console.ReadLine());
            if (taht=='+') // && - and, || - or, ! - not
            {
                Console.WriteLine("Arvude {0}, {1} ja {2} summa={3}",a,arv,arv1,arv+arv1+a);
            }
            else if (taht == '*')
            {
                Console.WriteLine("Arvude {0}, {1} ja {2} korrutis={3}", a, arv, arv1, arv * arv1 * a);
            }
            else
            {
                Console.WriteLine("Kirjuta ise!");
            }
            
             nimi: Juku-ga lähame kinno! 
             vanus: Kui vana Juku on. 
             pilet: Tasuta,Laste,Täis,Soodus. Viga! kui <0, >123
            
            Console.WriteLine("Tere!\nMis on sinu nimi?");
            nimi = Console.ReadLine();
            Console.WriteLine("Tere " + nimi);
            if (nimi.ToUpper() == "JUKU")
            {
                Console.WriteLine("Lähme kinno!");
                try
                {
                    Console.WriteLine("{0},\nKui vana sa oled?", nimi);
                    int vanus = int.Parse(Console.ReadLine());
                    if (vanus <= 0 || vanus > 123)
                    {Console.WriteLine("Viga!");}
                    else if (vanus > 0 && vanus <= 6)
                    {Console.WriteLine("Tasuta pilet!");}
                    else if (vanus <= 15)
                    {Console.WriteLine("Lastepilet!");}
                    else if (vanus <= 65)
                    {Console.WriteLine("Täispilet!");}
                    else if (vanus <= 100)
                    {Console.WriteLine("Sooduspilet!");}
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                Console.WriteLine("Mõtle ise reaktsioon välja!");
            }
            Console.WriteLine("Switch'i kasutamine");
            Random random = new Random();
            int paeva_nr = random.Next(1, 7);
            string paev;
            Console.WriteLine(paeva_nr);
            switch (paeva_nr)
            {
                case 1: paev = "Esmaspäev"; break;
                case 2: paev = "Teisipäev"; break;
                case 3: paev = "Kolmapäev"; break;
                case 4: paev = "Neljapäev"; break;
                case 5: paev = "Reede"; break;
                case 6: paev = "Laupäev"; break;
                case 7: paev = "Pühapäev"; break;
                default:
                    paev = "Tundmatu päev";
                    break;
            }
            Console.WriteLine(paev);*/
        }
    }
}
