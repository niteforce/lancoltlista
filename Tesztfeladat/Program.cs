using System.IO;
using static System.Console;

namespace Tesztfeladat
{

    class Program
    {
        /*

            A láncolt lista olyan adatszerkezet, amenynek elemei a soron következő elemre hivatkozó referenciát tartalmaznak. 
            A láncolt listát az első fej- vagy gyökérelemen keresztül érjük el.
            Ha az elemek csak a következő tagra mutatnak, akkor egyszeresen, ha a megelőző elemre is, akkor kétszeresen láncolt listáról beszélünk.

            Alább látható egy kétszeresen láncolt lista megvalósítása, egy 20 elemű tömbbel:


        */
        
        static void Main(string[] args)
        {
            string[] szavak = new string[20];

            StreamReader x = new StreamReader("szoveg.txt");
            

            int i = 0;
            while (!x.EndOfStream)
            {
                szavak[i] = x.ReadLine();                
                i++;
            }
            x.Close();

            LinkedList proba = new LinkedList(szavak);
            WriteLine(i + " elemu szovegfile");            


            WriteLine("Elso elem: " + proba.Root.Value);     
            WriteLine("Masodik elem: " + proba.Root.Next.Value);
            WriteLine("Harmadik elem: " + proba.Root.Next.Next.Value);

            WriteLine("Masodik elem: " + proba.Root.Next.Next.Previous.Value);
            WriteLine("Elso elem: " + proba.Root.Next.Next.Previous.Previous.Value);


            /*
            Ez már nem a feladat része volt, alább látható, hogy LinkedList osztályon az IEnumerable interfész megvalósításával
            használhatóvá válik a foreach is.

            */

            foreach (string B in proba)
            {
                WriteLine(B);
            }  

            ReadKey();                      
                     
        }
    }
}
