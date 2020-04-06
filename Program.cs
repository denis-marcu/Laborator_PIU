using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryAdministration
{
    class Program
    {
        static void Main(string[] args)
        {   
            Carte FratiiKaramazov = new Carte("Fratii Karamazov", "F.M. Dostoievski","Polirom",840);
            Persoana p = new Persoana("Popescu","Ion",1);
            Console.WriteLine(FratiiKaramazov.ToString());
            Console.WriteLine(p.ToString());
            Console.ReadKey();
        }
    }
}
