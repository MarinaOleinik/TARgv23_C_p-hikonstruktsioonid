using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv23_C_põhikonstruktsioonid
{
    public class ClassMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

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
            /*
             nimi: Juku-ga lähame kinno! 
             vanus: Kui vana Juku on. 
             pilet: Tasuta,Laste,Täis,Soodus. Viga! kui <0, >123
            */
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
            Console.WriteLine(paev);
        }
    }
}
