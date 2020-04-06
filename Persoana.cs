using System.Text;
using System.Threading.Tasks;

namespace LibraryAdministration
{
    class Persoana
    {
        private string nume, prenume;
        private int id;
        public Persoana(string nume, string prenume, int id)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.id = id;
        }
        public string Nume { get { return nume; } }
        public string Prenume { get { return prenume; } }
        public int ID { get { return id; } }

        public override string ToString()
        {
            return string.Format("{0} {1}",nume, prenume);
        }

    }
}
