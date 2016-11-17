using System;

namespace Vsite.CSharp
{
    public class ZamjenaObjekata
    {
        // TODO: Promijeniti metodu tako da se zamjena odrazi u pozivajućem kodu.
        static void Zamijeni(ref object s1, ref object s2)
        {
            object temp = s2;
            s2 = s1;
            s1 = temp;
        }

        public static void ZamjenaStringova(ref string prvi, ref string drugi)
        {
            Console.WriteLine("Prije metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);
            object prviStr = prvi;
            object drugiStr = drugi;
            Zamijeni(ref prviStr, ref drugiStr);

            prvi = (string)prviStr;
            drugi = (string)drugiStr;


            Console.WriteLine("Nakon metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);
        }

        public static void ZamjenaIntova(int prvi, int drugi)
        {
            Console.WriteLine("Prije metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);

            object o1 = prvi;
            object o2 = drugi;
            // TODO: Promijeniti metodu Zamijeni tako da umjesto tipa string prima tip object i tako podržava zamjenu bilo kojeg tipa objekta. Dodati poziv te metode za 2 argumenta tipa int te provjeriti funkcionalnost.
            Zamijeni(ref o1, ref o2);

            prvi = (int)o1;
            drugi = (int)o2;

            Console.WriteLine("Nakon metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);
        }

        static void Main(string[] args)
        {
            string prvi = "prvi";
            string drugi = "drugi";

            ZamjenaStringova(ref prvi, ref drugi);

            Console.WriteLine();

            ZamjenaIntova(1, 2);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
