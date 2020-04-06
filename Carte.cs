using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAdministration
{
    class Carte
    {
        private string titlu, autor, editura;
        private int nr_pagini;
        public Carte(string titlu, string autor, string editura, int nr_pagini)
        {
            this.titlu = titlu;
            this.autor = autor;
            this.editura = editura;
            this.nr_pagini = nr_pagini;
        }
        public string Title { get { return titlu; } }
        public string Author { get { return autor; } }
        public string PublishingHouse { get { return editura; } }
        public int Nr_Pages { get { return nr_pagini; } }

        public override string ToString()
        {
            return string.Format("{0} de {1}. Editura: {2} - {3} pagini", titlu, autor, editura, nr_pagini);
        }

    }
}
