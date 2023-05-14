using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001.neveskoszones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem a neved és köszönök neked!");
            string nev = Console.ReadLine();
            Console.WriteLine("Hali, csá, csövi " + nev + "!");

            Console.ReadLine();
        }
    }
}

/*Ez a kód egy egyszerű üdvözlő program. Soronként a következők történnek:
A System névtér importálása.
Egy namespace definiálása _001.neveskoszones névvel.
Egy class definiálása Program névvel.
Az Main függvény definiálása, amely a program belépési pontja.
A "Kérem a neved és köszönök neked!" üzenet kiírása a konzolra.
A felhasználó nevének bekérése a konzolról és a kapott érték eltárolása a nev változóban.
Az üdvözlő üzenet kiírása a konzolra, amely tartalmazza a felhasználó nevét.
Az utolsó sorban egy ReadLine() függvény hívása található, amely megakadályozza a program futásának azonnali befejezését, amíg a felhasználó nem nyom egy billentyűt a konzolon.*/
